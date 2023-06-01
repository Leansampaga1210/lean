Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Appstart = "Trial Version" Then

            If My.Settings.LoadCount < 0 Then
                Form2.ShowDialog()
            End If

            Me.Text = My.Settings.Appstart & ":Counter=>
                " & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()
        Else
            Me.Text = My.Settings.Appstart

        End If
    End Sub
End Class
