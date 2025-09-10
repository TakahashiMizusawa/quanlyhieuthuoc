<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thuoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thuoc))
        Me.lbl_tukhoa = New System.Windows.Forms.Label()
        Me.txt_timkiem = New System.Windows.Forms.TextBox()
        Me.btn_tim = New System.Windows.Forms.Button()
        Me.dgv_thuoc = New System.Windows.Forms.DataGridView()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_trolai = New System.Windows.Forms.Button()
        Me.lbl_timsach = New System.Windows.Forms.Label()
        CType(Me.dgv_thuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tukhoa
        '
        Me.lbl_tukhoa.AutoSize = True
        Me.lbl_tukhoa.Font = New System.Drawing.Font("Times New Roman", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_tukhoa.Location = New System.Drawing.Point(48, 71)
        Me.lbl_tukhoa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tukhoa.Name = "lbl_tukhoa"
        Me.lbl_tukhoa.Size = New System.Drawing.Size(91, 16)
        Me.lbl_tukhoa.TabIndex = 1
        Me.lbl_tukhoa.Text = "Nhập Từ Khóa"
        '
        'txt_timkiem
        '
        Me.txt_timkiem.Location = New System.Drawing.Point(168, 72)
        Me.txt_timkiem.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_timkiem.Multiline = True
        Me.txt_timkiem.Name = "txt_timkiem"
        Me.txt_timkiem.Size = New System.Drawing.Size(735, 21)
        Me.txt_timkiem.TabIndex = 2
        Me.txt_timkiem.Text = "Nhập tên thuốc"
        Me.txt_timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_tim
        '
        Me.btn_tim.Image = CType(resources.GetObject("btn_tim.Image"), System.Drawing.Image)
        Me.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tim.Location = New System.Drawing.Point(413, 367)
        Me.btn_tim.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tim.Name = "btn_tim"
        Me.btn_tim.Size = New System.Drawing.Size(119, 39)
        Me.btn_tim.TabIndex = 3
        Me.btn_tim.Text = "Tìm Kiếm"
        Me.btn_tim.UseVisualStyleBackColor = True
        '
        'dgv_thuoc
        '
        Me.dgv_thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_thuoc.Location = New System.Drawing.Point(2, 103)
        Me.dgv_thuoc.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_thuoc.Name = "dgv_thuoc"
        Me.dgv_thuoc.RowHeadersWidth = 82
        Me.dgv_thuoc.RowTemplate.Height = 33
        Me.dgv_thuoc.Size = New System.Drawing.Size(971, 248)
        Me.dgv_thuoc.TabIndex = 4
        '
        'btn_xoa
        '
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(271, 367)
        Me.btn_xoa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(119, 39)
        Me.btn_xoa.TabIndex = 6
        Me.btn_xoa.Text = "Xóa thuốc"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_trolai
        '
        Me.btn_trolai.Image = CType(resources.GetObject("btn_trolai.Image"), System.Drawing.Image)
        Me.btn_trolai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trolai.Location = New System.Drawing.Point(541, 367)
        Me.btn_trolai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(119, 39)
        Me.btn_trolai.TabIndex = 7
        Me.btn_trolai.Text = "Trở Lại"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'lbl_timsach
        '
        Me.lbl_timsach.AutoSize = True
        Me.lbl_timsach.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_timsach.Location = New System.Drawing.Point(428, 24)
        Me.lbl_timsach.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_timsach.Name = "lbl_timsach"
        Me.lbl_timsach.Size = New System.Drawing.Size(138, 22)
        Me.lbl_timsach.TabIndex = 0
        Me.lbl_timsach.Text = "Quản Lý Thuốc"
        '
        'thuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 455)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.dgv_thuoc)
        Me.Controls.Add(Me.btn_tim)
        Me.Controls.Add(Me.txt_timkiem)
        Me.Controls.Add(Me.lbl_tukhoa)
        Me.Controls.Add(Me.lbl_timsach)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "thuoc"
        Me.Text = "sach"
        CType(Me.dgv_thuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tukhoa As Label
    Friend WithEvents txt_timkiem As TextBox
    Friend WithEvents btn_tim As Button
    Friend WithEvents dgv_thuoc As DataGridView
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_trolai As Button
    Friend WithEvents lbl_timsach As Label
End Class
