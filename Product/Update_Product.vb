Public Class Update_Product
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
    'IDbConnection 
    Dim updatequery As = "  Update Product Set Product_id = " & Product_id.Text & " , Where product_name = "& Product_name.Text & "
          ExecuteQuery(updateQuerty)
         MessageBox.Show("Data Updated ")

 & Product_id.Text &

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Product_id.TextChanged

    End Sub
End Classs