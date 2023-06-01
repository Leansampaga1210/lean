Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Appstat = "Trial Version" Then

            If My.Settings.Loadcount < 0 Then
                Form2.ShowDialog()
            End If

            Me.Text = My.Settings.Appstat & " : Counter =>
                " & My.Settings.Loadcount
            My.Settings.Loadcount -= 1
            My.Settings.Save()

        Else
            Me.Text = My.Settings.Appstat

        End If
    End Sub
End Class
