Public Class Tasks
    Public Handling As Boolean = False  'Is there a processing task
    Public Pausing As Boolean = False   'Did user pause the queue
    Public ProcID As Integer = 0        'Which task (index) is now processing

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        'Pause or countinue the queue
        If BtnPause.Text = "Pause" Then
            Pausing = True
            BtnPause.Text = "Countinue"
            MsgBox("The working process will be suspended after the current task is completed.", vbInformation, "")
        Else
            Pausing = False
            BtnPause.Text = "Pause"
            If Not Handling Then
                DoNext()
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Delete selected task
        Try
            If LsvQueue.FocusedItem.Index = ProcID And LsvQueue.Items(LsvQueue.FocusedItem.Index).SubItems(1).Text = "Processing" Then 'Check if not able to delete
                MsgBox("You cannot delete an ongoing task!", vbExclamation, "")
            Else
                If ProcID > LsvQueue.FocusedItem.Index Then
                    ProcID -= 1
                End If
                LsvQueue.Items.Remove(LsvQueue.FocusedItem)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DoNext()
        Try
            If Not Handling Then
                If Not Pausing Then
                    For i = 0 To LsvQueue.Items.Count - 1
                        If LsvQueue.Items(i).SubItems(1).Text = "Queued" Then
                            'If passed all condition then start to convert the next queued task
                            ProcID = i
                            Conv()
                            Exit Sub
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Conv()
        'Start conversion
        Try
            Handling = True
            LsvQueue.Items(ProcID).SubItems(1).Text = "Processing"
            MainUI.VInputPath = LsvQueue.Items(ProcID).SubItems(0).Text
            MainUI.ProcI = 0
            MainUI.ErrorCount = 0
            MainUI.QsInM3U8 = ""
            MainUI.RessInM3U8 = ""
            MainUI.StepFF()
        Catch ex As Exception
            ReturnFail()
        End Try
    End Sub

    Public Sub ReturnFail()
        Try
            LsvQueue.Items(ProcID).SubItems(1).Text = "Failed"
            Handling = False
            DoNext()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ReturnDone()
        Try
            LsvQueue.Items(ProcID).SubItems(1).Text = "Done"
            Handling = False
            DoNext()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tasks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Hide dialog instead of dispose itself
        e.Cancel = 1
        Hide()
    End Sub
End Class