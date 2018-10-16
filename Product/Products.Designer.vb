<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.View_Products = New System.Windows.Forms.Button()
        Me.Search_Products = New System.Windows.Forms.Button()
        Me.Update_Products = New System.Windows.Forms.Button()
        Me.Delete_Products = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'View_Products
        '
        Me.View_Products.Location = New System.Drawing.Point(56, 37)
        Me.View_Products.Name = "View_Products"
        Me.View_Products.Size = New System.Drawing.Size(115, 23)
        Me.View_Products.TabIndex = 0
        Me.View_Products.Text = "View_Products"
        Me.View_Products.UseVisualStyleBackColor = True
        '
        'Search_Products
        '
        Me.Search_Products.Location = New System.Drawing.Point(56, 77)
        Me.Search_Products.Name = "Search_Products"
        Me.Search_Products.Size = New System.Drawing.Size(115, 23)
        Me.Search_Products.TabIndex = 1
        Me.Search_Products.Text = "Search_Products"
        Me.Search_Products.UseVisualStyleBackColor = True
        '
        'Update_Products
        '
        Me.Update_Products.Location = New System.Drawing.Point(56, 119)
        Me.Update_Products.Name = "Update_Products"
        Me.Update_Products.Size = New System.Drawing.Size(115, 23)
        Me.Update_Products.TabIndex = 2
        Me.Update_Products.Text = "Update_Products"
        Me.Update_Products.UseVisualStyleBackColor = True
        '
        'Delete_Products
        '
        Me.Delete_Products.Location = New System.Drawing.Point(56, 159)
        Me.Delete_Products.Name = "Delete_Products"
        Me.Delete_Products.Size = New System.Drawing.Size(115, 23)
        Me.Delete_Products.TabIndex = 3
        Me.Delete_Products.Text = "Delete_Products"
        Me.Delete_Products.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Delete_Products)
        Me.Controls.Add(Me.Update_Products)
        Me.Controls.Add(Me.Search_Products)
        Me.Controls.Add(Me.View_Products)
        Me.Name = "Products"
        Me.Text = "Products"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents View_Products As Button
    Friend WithEvents Search_Products As Button
    Friend WithEvents Update_Products As Button
    Friend WithEvents Delete_Products As Button
End Class
