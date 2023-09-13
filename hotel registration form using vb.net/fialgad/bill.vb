Imports fialgad.Class1
Public Class bill
    Private Sub TextBox1_TextChange(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = usrname
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = gender
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = tdate
    End Sub

    Public Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = samount
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("please pay your bill at the counter")
        Close()

    End Sub
End Class