<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.btnkhachhang = New System.Windows.Forms.Button()
        Me.btnsanpham = New System.Windows.Forms.Button()
        Me.btnlienhe = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnkhachhang
        '
        Me.btnkhachhang.Location = New System.Drawing.Point(8, 12)
        Me.btnkhachhang.Name = "btnkhachhang"
        Me.btnkhachhang.Size = New System.Drawing.Size(75, 23)
        Me.btnkhachhang.TabIndex = 0
        Me.btnkhachhang.Text = "Khách hàng"
        Me.btnkhachhang.UseVisualStyleBackColor = True
        '
        'btnsanpham
        '
        Me.btnsanpham.Location = New System.Drawing.Point(89, 12)
        Me.btnsanpham.Name = "btnsanpham"
        Me.btnsanpham.Size = New System.Drawing.Size(75, 23)
        Me.btnsanpham.TabIndex = 0
        Me.btnsanpham.Text = "Sản phẩm"
        Me.btnsanpham.UseVisualStyleBackColor = True
        '
        'btnlienhe
        '
        Me.btnlienhe.Location = New System.Drawing.Point(170, 12)
        Me.btnlienhe.Name = "btnlienhe"
        Me.btnlienhe.Size = New System.Drawing.Size(75, 23)
        Me.btnlienhe.TabIndex = 0
        Me.btnlienhe.Text = "Liên hệ"
        Me.btnlienhe.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(251, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Giới thiệu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(332, 242)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnlienhe)
        Me.Controls.Add(Me.btnsanpham)
        Me.Controls.Add(Me.btnkhachhang)
        Me.Name = "frmmain"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkhachhang As System.Windows.Forms.Button
    Friend WithEvents btnsanpham As System.Windows.Forms.Button
    Friend WithEvents btnlienhe As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
