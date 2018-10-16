Public Class Delete_Product
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.Compare(TextBox1.Text, "") = 0 Then
            Label2.Text = " Product Not available"
        Else
            Label2.Text = TextBox1.Text
            TextBox1.Text = ""

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class