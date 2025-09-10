<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class themthuoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(themthuoc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tenthuoc = New System.Windows.Forms.TextBox()
        Me.txt_donvitinh = New System.Windows.Forms.TextBox()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_gianhap = New System.Windows.Forms.TextBox()
        Me.txt_giaban = New System.Windows.Forms.TextBox()
        Me.txt_nhasanxuat = New System.Windows.Forms.TextBox()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.dtp_hansudung = New System.Windows.Forms.DateTimePicker()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_trolai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập thuốc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "tên thuốc :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đơn vị tính :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số lượng :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giá Nhập :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giá bán :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hạn sử dụng :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nhà sản xuất :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Ghi chú :"
        '
        'txt_tenthuoc
        '
        Me.txt_tenthuoc.Location = New System.Drawing.Point(202, 90)
        Me.txt_tenthuoc.Name = "txt_tenthuoc"
        Me.txt_tenthuoc.Size = New System.Drawing.Size(769, 20)
        Me.txt_tenthuoc.TabIndex = 9
        '
        'txt_donvitinh
        '
        Me.txt_donvitinh.Location = New System.Drawing.Point(202, 131)
        Me.txt_donvitinh.Name = "txt_donvitinh"
        Me.txt_donvitinh.Size = New System.Drawing.Size(769, 20)
        Me.txt_donvitinh.TabIndex = 10
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(202, 169)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(769, 20)
        Me.txt_soluong.TabIndex = 11
        '
        'txt_gianhap
        '
        Me.txt_gianhap.Location = New System.Drawing.Point(202, 215)
        Me.txt_gianhap.Name = "txt_gianhap"
        Me.txt_gianhap.Size = New System.Drawing.Size(769, 20)
        Me.txt_gianhap.TabIndex = 12
        '
        'txt_giaban
        '
        Me.txt_giaban.Location = New System.Drawing.Point(202, 247)
        Me.txt_giaban.Name = "txt_giaban"
        Me.txt_giaban.Size = New System.Drawing.Size(769, 20)
        Me.txt_giaban.TabIndex = 13
        '
        'txt_nhasanxuat
        '
        Me.txt_nhasanxuat.Location = New System.Drawing.Point(202, 329)
        Me.txt_nhasanxuat.Name = "txt_nhasanxuat"
        Me.txt_nhasanxuat.Size = New System.Drawing.Size(769, 20)
        Me.txt_nhasanxuat.TabIndex = 14
        '
        'txt_ghichu
        '
        Me.txt_ghichu.Location = New System.Drawing.Point(202, 367)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Size = New System.Drawing.Size(769, 20)
        Me.txt_ghichu.TabIndex = 15
        '
        'dtp_hansudung
        '
        Me.dtp_hansudung.Location = New System.Drawing.Point(203, 289)
        Me.dtp_hansudung.Name = "dtp_hansudung"
        Me.dtp_hansudung.Size = New System.Drawing.Size(767, 20)
        Me.dtp_hansudung.TabIndex = 16
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(207, 429)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(134, 39)
        Me.btn_them.TabIndex = 17
        Me.btn_them.Text = "Thêm thuốc"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_trolai
        '
        Me.btn_trolai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trolai.Image = CType(resources.GetObject("btn_trolai.Image"), System.Drawing.Image)
        Me.btn_trolai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trolai.Location = New System.Drawing.Point(719, 429)
        Me.btn_trolai.Name = "btn_trolai"
        Me.btn_trolai.Size = New System.Drawing.Size(134, 39)
        Me.btn_trolai.TabIndex = 18
        Me.btn_trolai.Text = "Trở lại"
        Me.btn_trolai.UseVisualStyleBackColor = True
        '
        'themthuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 504)
        Me.Controls.Add(Me.btn_trolai)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.dtp_hansudung)
        Me.Controls.Add(Me.txt_ghichu)
        Me.Controls.Add(Me.txt_nhasanxuat)
        Me.Controls.Add(Me.txt_giaban)
        Me.Controls.Add(Me.txt_gianhap)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.txt_donvitinh)
        Me.Controls.Add(Me.txt_tenthuoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "themthuoc"
        Me.Text = "themthuoc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_tenthuoc As TextBox
    Friend WithEvents txt_donvitinh As TextBox
    Friend WithEvents txt_soluong As TextBox
    Friend WithEvents txt_gianhap As TextBox
    Friend WithEvents txt_giaban As TextBox
    Friend WithEvents txt_nhasanxuat As TextBox
    Friend WithEvents txt_ghichu As TextBox
    Friend WithEvents dtp_hansudung As DateTimePicker
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_trolai As Button
End Class
