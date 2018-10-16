<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Product
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Product_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Product_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Product_id
        '
        Me.Product_id.Location = New System.Drawing.Point(107, 46)
        Me.Product_id.Name = "Product_id"
        Me.Product_id.Size = New System.Drawing.Size(100, 20)
        Me.Product_id.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product_id"
        '
        'Product_name
        '
        Me.Product_name.Location = New System.Drawing.Point(107, 92)
        Me.Product_name.Name = "Product_name"
        Me.Product_name.Size = New System.Drawing.Size(100, 20)
        Me.Product_name.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product_name"
        '
        'Update_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Product_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Product_id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Update_Product"
        Me.Text = "Update_Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Product_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Product_name As TextBox
    Friend WithEvents Label2 As Label
End Class
