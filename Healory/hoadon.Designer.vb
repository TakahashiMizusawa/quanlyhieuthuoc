<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hoadon))
        Me.Dgv_haodon = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_timkiem = New System.Windows.Forms.Button()
        CType(Me.Dgv_haodon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_haodon
        '
        Me.Dgv_haodon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_haodon.Location = New System.Drawing.Point(3, 61)
        Me.Dgv_haodon.Name = "Dgv_haodon"
        Me.Dgv_haodon.Size = New System.Drawing.Size(799, 338)
        Me.Dgv_haodon.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(552, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Trở lại"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hóa đơn"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(483, 20)
        Me.TextBox1.TabIndex = 3
        '
        'btn_timkiem
        '
        Me.btn_timkiem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_timkiem.Image = CType(resources.GetObject("btn_timkiem.Image"), System.Drawing.Image)
        Me.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_timkiem.Location = New System.Drawing.Point(206, 414)
        Me.btn_timkiem.Name = "btn_timkiem"
        Me.btn_timkiem.Size = New System.Drawing.Size(138, 30)
        Me.btn_timkiem.TabIndex = 4
        Me.btn_timkiem.Text = "Tìm kiếm"
        Me.btn_timkiem.UseVisualStyleBackColor = True
        '
        'hoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_timkiem)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dgv_haodon)
        Me.Name = "hoadon"
        Me.Text = "hoadon"
        CType(Me.Dgv_haodon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_haodon As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_timkiem As Button
End Class
