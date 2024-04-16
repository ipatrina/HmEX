Public Class ProfileManage
    Private Sub ProfileManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfileList()
    End Sub

    Private Sub BtnPRemove_Click(sender As Object, e As EventArgs) Handles BtnPRemove.Click
        'Delete selected profile
        Try
            MainUI.LsvProfile.Items(LstProfile.SelectedIndex).Remove()
            LoadProfileList()
            MainUI.SaveEnabledProfiles()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadProfileList()
        'Refresh the list
        Try
            LstProfile.Items.Clear()

            For i = 0 To MainUI.LsvProfile.Items.Count - 1
                LstProfile.Items.Add(MainUI.LsvProfile.Items(i).SubItems(1).Text)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPAdd_Click(sender As Object, e As EventArgs) Handles BtnPAdd.Click
        'Add a profile
        Try
            MainUI.ListInit(True, TxtProfileName.Text, "1920x1080", "x264", "4096k", "AAC", "192k", True, "")  'Load a series of default properties
            LoadProfileList()
            MainUI.SaveEnabledProfiles()
        Catch ex As Exception

        End Try
    End Sub
End Class