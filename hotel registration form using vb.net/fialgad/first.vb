Public Class first

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        client.Show()
        Me.Hide()
    End Sub
End Class
