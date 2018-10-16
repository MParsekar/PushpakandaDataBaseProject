Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub View_Products_Click(sender As Object, e As EventArgs) Handles View_Products.Click
        View_Product.Show()

    End Sub

    Private Sub Update_Products_Click(sender As Object, e As EventArgs) Handles Update_Products.Click
        Update_Product.Show()


    End Sub

    Private Sub Search_Products_Click(sender As Object, e As EventArgs) Handles Search_Products.Click
        Search_Product.Show()

    End Sub

    Private Sub Delete_Products_Click(sender As Object, e As EventArgs) Handles Delete_Products.Click
        Delete_Product.Show()

    End Sub
End Class
