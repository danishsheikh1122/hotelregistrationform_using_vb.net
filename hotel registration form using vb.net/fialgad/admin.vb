Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If (username = "danish" And password = "sheikh") Then
            MessageBox.Show("Login success")
        Else
            MessageBox.Show("invalid username or password")
        End If


    End Sub
End Class