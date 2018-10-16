Public Class Search_Product
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.Compare(TextBox1.Text = TextBox1.Text, "") = 0 Then
            '  IDbConnection 
            Dim updatequery As String = "  Update Product Set Product_id = " + Product_id.Text + " , Where product_name = " + Product_name.Text & ""
            ExecuteQuery(updateQuerty)
            MessageBox.Show(" Product found ")
        Else
            MessageBox.Show(" Product  not found ")
    
        End If





    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click

    End Sub
End Class