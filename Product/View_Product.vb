Public Class View_Product
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ListView1.View = View.Details
        ListView1.Columns.Add("Product Name ")
        ListView1.Columns.Add("Product id ")
        ListView1.Columns.Add("Cost Price  ")
        ListView1.Columns.Add("Selling Price  ")
        ListView1.Columns.Add(" MRP ")

    End Sub
End Class