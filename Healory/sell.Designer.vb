<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sell))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dgv_thuoc = New System.Windows.Forms.DataGridView()
        Me.txt_thuoc = New System.Windows.Forms.TextBox()
        Me.btn_timkiem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.btn_inhoadon = New System.Windows.Forms.Button()
        Me.btn_trolai = New System.Windows.Forms.Button()
        Me.txt_mahoadon = New System.Windows.Forms.TextBox()
        Me.txt_nhanvienban = New System.Windows.Forms.TextBox()
        Me.txt_tenkhachhang = New System.Windows.Forms.TextBox()
        Me.txt_tienkhachdua = New System.Windows.Forms.TextBox()
        Me.dtp_ngayban = New System.Windows.Forms.DateTimePicker()
        Me.lbl_tongtien = New System.Windows.Forms.Label()
        Me.lbl_tralaitien = New System.Windows.Forms.Label()
        CType(Me.Dgv_thuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(197, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thông tin hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Hóa Đơn :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Bán :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nhân Viên Bán :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tên Khách Mua :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(216, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Danh Sách Thuốc :"
        '
        'Dgv_thuoc
        '
        Me.Dgv_thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_thuoc.Location = New System.Drawing.Point(12, 294)
        Me.Dgv_thuoc.Name = "Dgv_thuoc"
        Me.Dgv_thuoc.Size = New System.Drawing.Size(662, 168)
        Me.Dgv_thuoc.TabIndex = 6
        '
        'txt_thuoc
        '
        Me.txt_thuoc.Location = New System.Drawing.Point(32, 268)
        Me.txt_thuoc.Name = "txt_thuoc"
        Me.txt_thuoc.Size = New System.Drawing.Size(479, 20)
        Me.txt_thuoc.TabIndex = 7
        Me.txt_thuoc.Text = "Tìm kiếm thuốc :"
        Me.txt_thuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_timkiem
        '
        Me.btn_timkiem.BackColor = System.Drawing.Color.White
        Me.btn_timkiem.Image = CType(resources.GetObject("btn_timkiem.Image"), System.Drawing.Image)
        Me.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_timkiem.Location = New System.Drawing.Point(536, 262)
        Me.btn_timkiem.Name = "btn_timkiem"
        Me.btn_timkiem.Size = New System.Drawing.Size(107, 30)
        Me.btn_timkiem.TabIndex = 8
        Me.btn_timkiem.Text = "Tìm Kiếm"
        Me.btn_timkiem.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(664, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = " Tổng tiền :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(665, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tiền Khách Đưa :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(665, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tiền Trả Lại :"
        '
        'btn_luu
        '
        Me.btn_luu.BackColor = System.Drawing.Color.White
        Me.btn_luu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(712, 219)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(124, 36)
        Me.btn_luu.TabIndex = 12
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.UseVisualStyleBackColor = False
        '
        'btn_inhoadon
        '
        Me.btn_inhoadon.BackColor = System.Drawing.Color.White
        Me.btn_inhoadon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inhoadon.Image = CType(resources.GetObject("btn_inhoadon.Image"), System.Drawing.Image)
        Me.btn_inhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inhoadon.Location = New System.Drawing.Point(872, 219)
        Me.btn_inhoadon.Name = "btn_inhoadon"
        Me.btn_inhoadon.Size = New System.Drawing.Size(124, 36)
        Me.btn_inhoadon.TabIndex = 13
        Me.btn_inhoadon.Text = "In Hóa Đơn"
        Me.btn_inhoadon.UseVisualStyleBackColor = False
        '
        'btn_trolai
        '
        Me.btn_trolai.BackColor = System.Drawing.Color.White
        Me.btn_trolai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trolai.Image = CType(resources.GetObject("btn_trolai.Image"), System.Drawing.Image)
        Me.btn_trolai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trolai.Location = New System.Drawing.Point(1039, 219)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(124, 36)
        Me.btn_trolai.TabIndex = 14
        Me.btn_trolai.Text = "Trở Lại"
        Me.btn_trolai.UseVisualStyleBackColor = False
        '
        'txt_mahoadon
        '
        Me.txt_mahoadon.Location = New System.Drawing.Point(129, 86)
        Me.txt_mahoadon.Name = "txt_mahoadon"
        Me.txt_mahoadon.Size = New System.Drawing.Size(502, 20)
        Me.txt_mahoadon.TabIndex = 15
        '
        'txt_nhanvienban
        '
        Me.txt_nhanvienban.Location = New System.Drawing.Point(129, 155)
        Me.txt_nhanvienban.Name = "txt_nhanvienban"
        Me.txt_nhanvienban.Size = New System.Drawing.Size(502, 20)
        Me.txt_nhanvienban.TabIndex = 16
        '
        'txt_tenkhachhang
        '
        Me.txt_tenkhachhang.Location = New System.Drawing.Point(129, 187)
        Me.txt_tenkhachhang.Name = "txt_tenkhachhang"
        Me.txt_tenkhachhang.Size = New System.Drawing.Size(502, 20)
        Me.txt_tenkhachhang.TabIndex = 17
        '
        'txt_tienkhachdua
        '
        Me.txt_tienkhachdua.Location = New System.Drawing.Point(781, 118)
        Me.txt_tienkhachdua.Name = "txt_tienkhachdua"
        Me.txt_tienkhachdua.Size = New System.Drawing.Size(145, 20)
        Me.txt_tienkhachdua.TabIndex = 18
        '
        'dtp_ngayban
        '
        Me.dtp_ngayban.Location = New System.Drawing.Point(127, 118)
        Me.dtp_ngayban.Name = "dtp_ngayban"
        Me.dtp_ngayban.Size = New System.Drawing.Size(503, 20)
        Me.dtp_ngayban.TabIndex = 19
        '
        'lbl_tongtien
        '
        Me.lbl_tongtien.AutoSize = True
        Me.lbl_tongtien.ForeColor = System.Drawing.Color.White
        Me.lbl_tongtien.Location = New System.Drawing.Point(746, 91)
        Me.lbl_tongtien.Name = "lbl_tongtien"
        Me.lbl_tongtien.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tongtien.TabIndex = 20
        '
        'lbl_tralaitien
        '
        Me.lbl_tralaitien.AutoSize = True
        Me.lbl_tralaitien.ForeColor = System.Drawing.Color.White
        Me.lbl_tralaitien.Location = New System.Drawing.Point(756, 155)
        Me.lbl_tralaitien.Name = "lbl_tralaitien"
        Me.lbl_tralaitien.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tralaitien.TabIndex = 21
        '
        'sell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1167, 488)
        Me.Controls.Add(Me.lbl_tralaitien)
        Me.Controls.Add(Me.lbl_tongtien)
        Me.Controls.Add(Me.dtp_ngayban)
        Me.Controls.Add(Me.txt_tienkhachdua)
        Me.Controls.Add(Me.txt_tenkhachhang)
        Me.Controls.Add(Me.txt_nhanvienban)
        Me.Controls.Add(Me.txt_mahoadon)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.btn_inhoadon)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_timkiem)
        Me.Controls.Add(Me.txt_thuoc)
        Me.Controls.Add(Me.Dgv_thuoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "sell"
        Me.Text = "banthuoc"
        CType(Me.Dgv_thuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Dgv_thuoc As DataGridView
    Friend WithEvents txt_thuoc As TextBox
    Friend WithEvents btn_timkiem As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_inhoadon As Button
    Friend WithEvents btn_trolai As Button
    Friend WithEvents txt_mahoadon As TextBox
    Friend WithEvents txt_nhanvienban As TextBox
    Friend WithEvents txt_tenkhachhang As TextBox
    Friend WithEvents txt_tienkhachdua As TextBox
    Friend WithEvents dtp_ngayban As DateTimePicker
    Friend WithEvents lbl_tongtien As Label
    Friend WithEvents lbl_tralaitien As Label
End Class
