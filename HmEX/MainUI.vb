Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions

Public Class MainUI
    Public ProgramName As String = "HmEX"

    Public BEArg As String = ""      'Bento4 commands
    Public ErrorCount As Integer = 0
    Public FFArg As String = ""      'FFmpeg commands
    Public Key As String = ""        'Randomly generated video encryption key
    Public LFilePath As String = ""  'Logo browser path
    Public n As String = ""          'Currently processing task name
    Dim NowEdit As Integer = 0       'Stores the selected profile index
    Public OFilePath As String = ""  'Currently processing output path
    Public OHeight As Integer = 0    'Set output video height
    Public OWidth As Integer = 0     'Set output video width
    Public p As New Process()        'Background video processor
    Public ProcI As Integer = 0      'Currently processing profile index
    Public Prog As String = ""       'Indicates which program should be called
    Public QsInM3U8 As String = ""   'Array to store all profiles that match the input source
    Public RessInM3U8 As String = "" 'Array to store all output video resolutions
    Public VersionStrings As String() = Application.ProductVersion.ToString.Split(".")
    Public VInputPath As String = "" 'Currently processing input path

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Text = ProgramName
            LoadEnabledProfiles()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DefaultValueInit()
        'Load default profiles if required
        Try
            ListInit(False, "LD", "480x270", "x264", "192k", "AAC", "96k", False, "")
            ListInit(True, "SD", "720x404", "x264", "512k", "AAC", "128k", False, "")
            ListInit(True, "HD", "1280x720", "x264", "1536k", "AAC", "128k", True, "")
            ListInit(True, "FHD", "1920x1080", "x264", "4096k", "AAC", "192k", True, "")
            ListInit(True, "UHD", "3840x2160", "x264", "20480k", "AAC", "256k", True, "")
            SaveEnabledProfiles()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SaveEnabledProfiles()
        'Store all profiles into registry
        Try
            Dim loc1 As String = ""
            For i = 0 To LsvProfile.Items.Count - 1
                loc1 += LsvProfile.Items(i).SubItems(1).Text & "|"
                SaveConfig(LsvProfile.Items(i).SubItems(1).Text)
            Next
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Config\EnabledProfiles", loc1, "REG_SZ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadEnabledProfiles()
        'Read and load all profiles into the list
        Try
            Dim loc1() As String = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Config\EnabledProfiles").split("|")
            For Each loc2 In loc1
                If loc2.Trim = "" Then

                Else
                    'If there is no detailed properties stored in registry, load the default properties for current profile
                    Dim i As Integer = LsvProfile.Items.Count
                    ListInit(True, loc2.Trim, "1920x1080", "x264", "4096k", "AAC", "192k", True, "")
                    LoadConfig(i, loc2.Trim)
                End If
            Next
            If LsvProfile.Items.Count = 0 Then
                DefaultValueInit()
            End If
        Catch ex As Exception
            LsvProfile.Items.Clear()
            DefaultValueInit()
        End Try
    End Sub

    Public Sub ListInit(Enable As Boolean, Q As String, Res As String, VCoding As String, VBitrate As String, ACoding As String, ABitrate As String, Enc As Boolean, Opt As String)
        'Build profile list structure
        Try
            Dim i As Integer = LsvProfile.Items.Count
            Dim loc1 As String = ""
            If Enable Then
                loc1 = "√"
            End If
            Dim loc2 As String = ""
            If Enc Then
                loc2 = "√"
            End If
            LsvProfile.Items.Add(loc1)
            LsvProfile.Items(i).SubItems.Add(Q)
            LsvProfile.Items(i).SubItems.Add(Res)
            LsvProfile.Items(i).SubItems.Add(VCoding)
            LsvProfile.Items(i).SubItems.Add(VBitrate)
            LsvProfile.Items(i).SubItems.Add(ACoding)
            LsvProfile.Items(i).SubItems.Add(ABitrate)
            LsvProfile.Items(i).SubItems.Add(loc2)
            LsvProfile.Items(i).SubItems.Add(Opt)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvProfile.SelectedIndexChanged
        'Load selected profile to edit area
        Try
            NowEdit = LsvProfile.FocusedItem.Index
            If LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(0).Text = "√" Then
                ChkEnabled.Checked = True
            Else
                ChkEnabled.Checked = False
            End If
            LblProfileName.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(1).Text
            TxtVResolution.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(2).Text
            CboVCoding.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(3).Text
            TxtVBitrate.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(4).Text
            CboACoding.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(5).Text
            TxtABitrate.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(6).Text
            If LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(7).Text = "√" Then
                ChkEncryption.Checked = True
            Else
                ChkEncryption.Checked = False
            End If
            TxtOptionsInput.Text = LsvProfile.Items(LsvProfile.FocusedItem.Index).SubItems(8).Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdateList_Click(sender As Object, e As EventArgs) Handles BtnUpdateList.Click
        'Update selected profile by using edit area's new configuration
        Try
            Dim ID As Integer = NowEdit
            Dim loc1 As String = ""
            If ChkEnabled.Checked = True Then
                loc1 = "√"
            End If
            Dim loc2 As String = ""
            If ChkEncryption.Checked = True Then
                loc2 = "√"
            End If
            LsvProfile.Items(ID).SubItems(0).Text = loc1
            LsvProfile.Items(ID).SubItems(2).Text = TxtVResolution.Text
            LsvProfile.Items(ID).SubItems(3).Text = CboVCoding.Text
            LsvProfile.Items(ID).SubItems(4).Text = TxtVBitrate.Text
            LsvProfile.Items(ID).SubItems(5).Text = CboACoding.Text
            LsvProfile.Items(ID).SubItems(6).Text = TxtABitrate.Text
            LsvProfile.Items(ID).SubItems(7).Text = loc2
            LsvProfile.Items(ID).SubItems(8).Text = TxtOptionsInput.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOutputBrowse_Click(sender As Object, e As EventArgs) Handles BtnOutputBrowse.Click
        Try
            If FbdOutput.ShowDialog = DialogResult.OK Then
                TxtOutputPath.Text = FbdOutput.SelectedPath
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnInputBrowse_Click(sender As Object, e As EventArgs) Handles BtnInputBrowse.Click
        Try
            If OfdInput.ShowDialog = DialogResult.OK Then
                TxtInputPath.Text = OfdInput.FileName
            End If
            BtnQueue.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnQueue_Click(sender As Object, e As EventArgs) Handles BtnQueue.Click
        Try
            If IsFFmpegExist() = False Then
                If MsgBox("FFmpeg software is not detected on this computer. " & ProgramName & " requires FFmpeg software to be present to perform video transcoding process." & vbCrLf & "Would you like to download FFmpeg now?", vbQuestion + vbYesNo, Text) = vbYes Then
                    Process.Start("https://ffmpeg.zeranoe.com/builds/")
                    MsgBox("Your browser will display an official download page of FFmpeg software. Please download a FFmpeg build that matches your Windows architecture. Then extract ""bin\ffmpeg.exe"" file from the compressed package to the current directory. Please note that by using such a third-party software, you must agree to and comply with its relevant license terms and conditions.", vbInformation, Text)
                End If
                Exit Sub
            End If

            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\mp42hls.exe") Then
                My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\mp42hls.exe", ReadResource("HmEX.mp42hls.exe"), False)
            End If

            If My.Computer.FileSystem.FileExists(TxtInputPath.Text) Then
                Tasks.Show()
                Dim idx As Integer = Tasks.LsvQueue.Items.Count
                Tasks.LsvQueue.Items.Add(TxtInputPath.Text)
                Tasks.LsvQueue.Items(idx).SubItems.Add("Queued")
                TxtInputPath.Text = ""
                Tasks.DoNext()
            Else
                Tasks.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ReadResource(resname As String) As Byte()
        Dim Stream As Stream = Assembly.GetExecutingAssembly.GetManifestResourceStream(resname)
        Dim FileByte(Stream.Length - 1) As Byte
        With Stream
            .Read(FileByte, 0, FileByte.Length)
            .Close()
            .Dispose()
        End With
        Return FileByte
    End Function

    Public Function IsFFmpegExist() As Boolean
        Try
            Dim loc1 As New Process()
            loc1.StartInfo.FileName = "ffmpeg.exe"
            loc1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            loc1.Start()
            loc1.WaitForExit()
            loc1.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ParseQ(Q As Integer)
        'Analysis of Video Resolution
        Try
            Dim loc1() As String = GetVideoRes(VInputPath).Split(",")
            Dim loc3 As Integer = loc1(0)    'Source video width
            Dim loc4 As Integer = loc1(1)    'Source video height
            Dim loc2() As String = LsvProfile.Items(Q).SubItems(2).Text.Split("x")
            Dim loc5 As Integer = loc2(0)    'Profile width
            Dim loc6 As Integer = loc2(1)    'Profile height

            If loc3 >= loc5 Then
                OWidth = loc5
                OHeight = CloseToInt(loc5 / (loc3 / loc4))
            ElseIf loc4 >= loc6 Then
                OHeight = loc6
                OWidth = CloseToInt(loc6 * (loc3 / loc4))
            Else
                Return "-1"
            End If
            Return "OK"
        Catch ex As Exception
            Return "-1"
        End Try
    End Function

    Private Function CloseToInt([to] As Integer)
        'The closest side length that can be divided by two
        Return If(([to] Mod 2 = 0), [to], ([to] - 1))
    End Function

    Public Sub StepFF()
        'FFmpeg encoding process
        Try
            n = System.IO.Path.GetFileNameWithoutExtension(VInputPath)
            If ProcI < LsvProfile.Items.Count Then
                Dim i As Integer = ProcI
                'Prerequisite check
                If LsvProfile.Items(i).SubItems(0).Text = "√" And ParseQ(i) = "OK" Then
                    Dim CV As String = "libx264"
                    If LsvProfile.Items(i).SubItems(3).Text = "x264" Then
                        CV = "libx264"        'H.264 Software encoder
                    ElseIf LsvProfile.Items(i).SubItems(3).Text = "h264_qsv" Then
                        CV = "h264_qsv"    'Intel Quick Sync Video
                    ElseIf LsvProfile.Items(i).SubItems(3).Text = "h264_nvenc" Then
                        CV = "h264_nvenc"  'Nvidia NVENC
                    ElseIf LsvProfile.Items(i).SubItems(3).Text = "x265" Then
                        CV = "libx265"        'H.265 Software encoder
                    ElseIf LsvProfile.Items(i).SubItems(3).Text = "h264_qsv" Then
                        CV = "h265_qsv"    'Intel Quick Sync Video
                    ElseIf LsvProfile.Items(i).SubItems(3).Text = "h264_nvenc" Then
                        CV = "h265_nvenc"  'Nvidia NVENC
                    End If

                    Dim CA As String = ""
                    If LsvProfile.Items(i).SubItems(5).Text = "AAC" Then
                        CA = "aac"
                    ElseIf LsvProfile.Items(i).SubItems(5).Text = "AAC HE" Then
                        CA = "aac -profile:a aac_he"
                    End If

                    'Build MP4 output path
                    OFilePath = TxtOutputPath.Text & "\" & n & "_" & LsvProfile.Items(i).SubItems(1).Text & ".mp4"
                    FFArg = "-i " & Chr(34) & VInputPath & Chr(34) & " " & LsvProfile.Items(i).SubItems(8).Text & " -c:v " & CV & " -b:v " & LsvProfile.Items(i).SubItems(4).Text & " -c:a " & CA & " -b:a " & LsvProfile.Items(i).SubItems(6).Text & " -s " & OWidth & "x" & OHeight & " -y " & Chr(34) & OFilePath & Chr(34)

                    'Begin encode
                    VideoWorker.RunWorkerAsync()
                Else
                    ProcI += 1
                    StepFF()
                End If
            Else
                WriteM3U8()
                Tasks.ReturnDone()
            End If
        Catch ex As Exception
            Tasks.ReturnFail()
        End Try
    End Sub

    Private Sub StepBE()
        'Bento4 slicing process
        Try
            Dim i As Integer = ProcI
            If LsvProfile.Items(i).SubItems(0).Text = "√" Then
                Dim q As String = LsvProfile.Items(i).SubItems(1).Text

                Try
                    My.Computer.FileSystem.CreateDirectory(TxtOutputPath.Text & "\" & n)
                Catch ex As Exception

                End Try

                'Build command
                Dim loc1 As String = ""
                If LsvProfile.Items(i).SubItems(7).Text = "√" Then
                    Dim k As String = GenKey()
                    loc1 = " --encryption-key-uri " & Chr(34) & q & "-K.dat" & Chr(34) & " --encryption-key " & k
                    My.Computer.FileSystem.WriteAllBytes(TxtOutputPath.Text & "\" & n & "\" & q & "-K.dat", StringToByteArray(k), False)
                End If

                BEArg = "--segment-duration 30 --index-filename " & Chr(34) & TxtOutputPath.Text & "\" & n & "\" & q & ".m3u8" & Chr(34) & " --segment-filename-template " & Chr(34) & TxtOutputPath.Text & "\" & n & "\" & q & "-%d.ts" & Chr(34) & " --segment-url-template " & q & "-%d.ts " & loc1 & " " & Chr(34) & OFilePath & Chr(34)

                'Start slicing
                SegWorker.RunWorkerAsync()
            Else
                ProcI += 1
                ErrorCount = 0
                StepFF()
            End If
        Catch ex As Exception
            Tasks.ReturnFail()
        End Try
    End Sub

    Private Sub VideoWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles VideoWorker.DoWork
        'Start FFmpeg
        Try
            p.StartInfo.FileName = "ffmpeg.exe"
            p.StartInfo.Arguments = FFArg
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            p.Start()
            p.WaitForExit()
            p.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VideoWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles VideoWorker.RunWorkerCompleted
        Try
            'Check if FFmpeg output file exists
            If My.Computer.FileSystem.FileExists(OFilePath) Then
                'Check if FFmpeg output contains video
                If My.Computer.FileSystem.GetFileInfo(OFilePath).Length <= 1048576 Then
                    StepFFFail()
                Else
                    'If FFmpeg output is okay, go to Bento4 slicing
                    StepBE()
                End If
            Else
                StepFFFail()
            End If
        Catch ex As Exception
            StepFFFail()
        End Try
    End Sub

    Private Sub StepFFFail()
        Try
            ErrorCount += 1
            If ErrorCount >= 5 Then
                Tasks.ReturnFail()
            Else
                StepFF()
            End If
        Catch ex As Exception
            Tasks.ReturnFail()
        End Try
    End Sub

    Private Sub SegWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles SegWorker.DoWork
        'Start Bento4
        Try
            p.StartInfo.FileName = "mp42hls.exe"
            p.StartInfo.Arguments = BEArg
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            p.Start()
            p.WaitForExit()
            p.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SegWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SegWorker.RunWorkerCompleted
        Try
            Try
                My.Computer.FileSystem.DeleteFile(OFilePath)
            Catch ex As Exception

            End Try
            'Store resolutions for master playlist output
            QsInM3U8 += ProcI & ","
            RessInM3U8 += OWidth & "x" & OHeight & ","
            ProcI += 1
            StepFF()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WriteM3U8()
        'Generate master playlist
        Try
            Dim UTF8NoBOM As New System.Text.UTF8Encoding(False)
            Dim FWrite As System.IO.StreamWriter = New System.IO.StreamWriter(TxtOutputPath.Text & "\" & n & ".m3u8", False, UTF8NoBOM)
            FWrite.WriteLine("#EXTM3U")    'HLS standard header
            Dim loc1() As String = QsInM3U8.Split(",")
            Dim loc2() As String = RessInM3U8.Split(",")
            Dim loc3 As Integer = 0
            For Each i In loc1
                If Not i = "" Then
                    Dim bandwidthadd As Integer = 100000
                    If i < 2 Then
                        bandwidthadd = 200000
                    End If

                    Dim bandwidth As Integer
                    bandwidth = LetterToInt(LsvProfile.Items(Convert.ToInt32(i)).SubItems(4).Text) + LetterToInt(LsvProfile.Items(Convert.ToInt32(i)).SubItems(6).Text) + bandwidthadd

                    FWrite.WriteLine("#EXT-X-STREAM-INF:PROGRAM-ID=1,BANDWIDTH=" & bandwidth & ",RESOLUTION=" & loc2(loc3) & ",NAME=" & Chr(34) & LsvProfile.Items(Convert.ToInt32(i)).SubItems(1).Text & Chr(34))
                    FWrite.WriteLine(n & "/" & LsvProfile.Items(Convert.ToInt32(i)).SubItems(1).Text & ".m3u8")

                    loc3 += 1
                End If
            Next

            FWrite.Close()
            FWrite.Dispose()
        Catch ex As Exception
            Tasks.ReturnFail()
        End Try
    End Sub

    Public Function LetterToInt(input As String)
        'Bitrate calculation
        Try
            Dim i As Integer = 0
            If input.ToLower.Contains("k") Then
                i = input.Replace("k", "") * 1000
            ElseIf input.ToLower.Contains("m") Then
                i = input.Replace("m", "") * 1000000
            Else
                i = input
            End If

            Return i
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GenKey() As String
        'Randomly generate an AES-128 encryption key
        Dim loc1 As String = ""
        Dim i As Long
        Dim intLength As Integer
        Const STRINGSOURCE = "0123456789ABCDEF"
        intLength = Len(STRINGSOURCE) - 1

        Randomize()
        For i = 1 To 32
            loc1 &= Mid(STRINGSOURCE, Int(Rnd() * intLength + 1), 1)
        Next

        Return loc1
    End Function

    Public Shared Function StringToByteArray(hex As String) As Byte()
        Return Enumerable.Range(0, hex.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(hex.Substring(x, 2), 16)).ToArray()
    End Function

    Private Function GetVideoRes(FilePath)
        'Parsing source video input resolution
        Dim p As New Process()
        Try
            p.StartInfo.FileName = "ffmpeg.exe"
            p.StartInfo.Arguments = "-i " & Chr(34) & FilePath & Chr(34)
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.RedirectStandardError = True
            p.Start()
            p.WaitForExit()
            Dim Errorstr As String = p.StandardError.ReadToEnd()
            p.Close()
            Dim regex As New Regex("(\d{2,4})x(\d{2,4})", RegexOptions.Compiled)  'Use Regular Expression to extract resolution from FFmpeg output
            Dim m As Match = regex.Match(Errorstr)
            If m.Success Then
                Dim VWidth As Integer = Integer.Parse(m.Groups(1).Value)
                Dim VHeight As Integer = Integer.Parse(m.Groups(2).Value)
                Return VWidth & "," & VHeight
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub BtnWatermarkAdd_Click(sender As Object, e As EventArgs) Handles BtnWatermarkAdd.Click
        If ChkWatermarkReverse.Checked = True Then
            TxtOptionsInput.Text += "-vf delogo=" & TxtWatermarkC.Text
        Else
            TxtOptionsInput.Text += "-i " & Chr(34) & LFilePath & Chr(34) & " -filter_complex " & Chr(34) & "overlay=" & TxtWatermarkC.Text & Chr(34)
        End If
    End Sub

    Private Sub BtnWatermarkChoose_Click(sender As Object, e As EventArgs) Handles BtnWatermarkChoose.Click
        Try
            If OfdInput.ShowDialog = DialogResult.OK Then
                LFilePath = OfdInput.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveConfig(ProfileName As String)
        'Store profile settings into registry
        Try
            Dim loc1 As Integer = -1
            For i = 0 To LsvProfile.Items.Count - 1
                If LsvProfile.Items(i).SubItems(1).Text = ProfileName Then
                    loc1 = i
                End If
            Next

            Dim loc2 As String = "False"
            If LsvProfile.Items(loc1).SubItems(0).Text = "√" Then
                loc2 = "-1"
            End If
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\Enabled", loc2, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\Resolution", LsvProfile.Items(loc1).SubItems(2).Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\VCoding", LsvProfile.Items(loc1).SubItems(3).Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\VBitrate", LsvProfile.Items(loc1).SubItems(4).Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\ACoding", LsvProfile.Items(loc1).SubItems(5).Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\ABitrate", LsvProfile.Items(loc1).SubItems(6).Text, "REG_SZ")
            Dim loc3 As String = "False"
            If LsvProfile.Items(loc1).SubItems(7).Text = "√" Then
                loc3 = "-1"
            End If
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\Encryption", loc3, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Profiles\" & ProfileName & "\Options", LsvProfile.Items(loc1).SubItems(8).Text, "REG_SZ")
            CreateObject("WScript.Shell").RegWrite("HKCU\Software\" & ProgramName & "\Config\WorkPath", TxtOutputPath.Text, "REG_SZ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadConfig(id As Integer, profile As String)
        'Load profile settings from registry into the profile list
        Try
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\Enabled") = "-1" Then
                LsvProfile.Items(id).SubItems(0).Text = "√"
            Else
                LsvProfile.Items(id).SubItems(0).Text = ""
            End If
            LsvProfile.Items(id).SubItems(2).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\Resolution")
            LsvProfile.Items(id).SubItems(3).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\VCoding")
            LsvProfile.Items(id).SubItems(4).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\VBitrate")
            LsvProfile.Items(id).SubItems(5).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\ACoding")
            LsvProfile.Items(id).SubItems(6).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\ABitrate")
            If CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\Encryption") = "-1" Then
                LsvProfile.Items(id).SubItems(7).Text = "√"
            Else
                LsvProfile.Items(id).SubItems(7).Text = ""
            End If
            LsvProfile.Items(id).SubItems(8).Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Profiles\" & profile & "\Options")
            TxtOutputPath.Text = CreateObject("WScript.Shell").RegRead("HKCU\Software\" & ProgramName & "\Config\WorkPath")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSaveList_Click(sender As Object, e As EventArgs) Handles BtnSaveList.Click
        SaveConfig(LblProfileName.Text)
    End Sub

    Private Sub BtnManageProfile_Click(sender As Object, e As EventArgs) Handles BtnManageProfile.Click
        MsgBox("Please note: This is an advanced feature of the program, which allows you edit preset profile names and numbers. Normally, you do NOT need this feature. However, you do have complete rights of the usage. If you have problems when using this feature, please delete all items in the list, then restart the program to allow preset profiles to be restored.", vbInformation, "")
        ProfileManage.Show()
    End Sub

    Private Sub MainUI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            e.Cancel = 1
            Dispose()
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Try
            MsgBox("HLS/m3u8 Encoder X" & vbCrLf & "A M3U8 Generation Utility with Video Encode GUI." & vbCrLf & vbCrLf & "Version: " & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2) & vbCrLf & "Date: 20" & VersionStrings(3).Substring(0, 2) & "/" & VersionStrings(3).Substring(2, 2) & vbCrLf & vbCrLf & "Copyright © 2018-2019. All rights reserved.", vbInformation, "About HmEX")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Try
            Dim DragFilePath As String() = e.Data.GetData(DataFormats.FileDrop)
            If My.Computer.FileSystem.FileExists(DragFilePath(0)) Then
                TxtInputPath.Text = DragFilePath(0)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
