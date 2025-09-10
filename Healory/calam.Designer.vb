<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calam))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_maca = New System.Windows.Forms.TextBox()
        Me.txt_tenca = New System.Windows.Forms.TextBox()
        Me.txt_giobatdau = New System.Windows.Forms.TextBox()
        Me.txt_gioketthuc = New System.Windows.Forms.TextBox()
        Me.txt_manhanvien = New System.Windows.Forms.TextBox()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.dtp_ngaylam = New System.Windows.Forms.DateTimePicker()
        Me.btn_hoantat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sắp xếp ca làm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã ca :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên ca :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giờ bắt đầu :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giờ kết thúc :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mã nhân viên :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ngày làm :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ghi chú :"
        '
        'txt_maca
        '
        Me.txt_maca.Location = New System.Drawing.Point(183, 68)
        Me.txt_maca.Name = "txt_maca"
        Me.txt_maca.Size = New System.Drawing.Size(574, 20)
        Me.txt_maca.TabIndex = 8
        '
        'txt_tenca
        '
        Me.txt_tenca.Location = New System.Drawing.Point(183, 97)
        Me.txt_tenca.Name = "txt_tenca"
        Me.txt_tenca.Size = New System.Drawing.Size(574, 20)
        Me.txt_tenca.TabIndex = 9
        '
        'txt_giobatdau
        '
        Me.txt_giobatdau.Location = New System.Drawing.Point(183, 130)
        Me.txt_giobatdau.Name = "txt_giobatdau"
        Me.txt_giobatdau.Size = New System.Drawing.Size(574, 20)
        Me.txt_giobatdau.TabIndex = 10
        '
        'txt_gioketthuc
        '
        Me.txt_gioketthuc.Location = New System.Drawing.Point(183, 163)
        Me.txt_gioketthuc.Name = "txt_gioketthuc"
        Me.txt_gioketthuc.Size = New System.Drawing.Size(574, 20)
        Me.txt_gioketthuc.TabIndex = 11
        '
        'txt_manhanvien
        '
        Me.txt_manhanvien.Location = New System.Drawing.Point(183, 197)
        Me.txt_manhanvien.Name = "txt_manhanvien"
        Me.txt_manhanvien.Size = New System.Drawing.Size(574, 20)
        Me.txt_manhanvien.TabIndex = 12
        '
        'txt_ghichu
        '
        Me.txt_ghichu.Location = New System.Drawing.Point(183, 263)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Size = New System.Drawing.Size(574, 20)
        Me.txt_ghichu.TabIndex = 13
        '
        'dtp_ngaylam
        '
        Me.dtp_ngaylam.Location = New System.Drawing.Point(183, 230)
        Me.dtp_ngaylam.Name = "dtp_ngaylam"
        Me.dtp_ngaylam.Size = New System.Drawing.Size(573, 20)
        Me.dtp_ngaylam.TabIndex = 14
        '
        'btn_hoantat
        '
        Me.btn_hoantat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hoantat.Image = CType(resources.GetObject("btn_hoantat.Image"), System.Drawing.Image)
        Me.btn_hoantat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hoantat.Location = New System.Drawing.Point(219, 320)
        Me.btn_hoantat.Name = "btn_hoantat"
        Me.btn_hoantat.Size = New System.Drawing.Size(108, 40)
        Me.btn_hoantat.TabIndex = 15
        Me.btn_hoantat.Text = "Hoàn tất"
        Me.btn_hoantat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hoantat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(476, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Trở lại"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'calam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_hoantat)
        Me.Controls.Add(Me.dtp_ngaylam)
        Me.Controls.Add(Me.txt_ghichu)
        Me.Controls.Add(Me.txt_manhanvien)
        Me.Controls.Add(Me.txt_gioketthuc)
        Me.Controls.Add(Me.txt_giobatdau)
        Me.Controls.Add(Me.txt_tenca)
        Me.Controls.Add(Me.txt_maca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "calam"
        Me.Text = "calam"
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
    Friend WithEvents txt_maca As TextBox
    Friend WithEvents txt_tenca As TextBox
    Friend WithEvents txt_giobatdau As TextBox
    Friend WithEvents txt_gioketthuc As TextBox
    Friend WithEvents txt_manhanvien As TextBox
    Friend WithEvents txt_ghichu As TextBox
    Friend WithEvents dtp_ngaylam As DateTimePicker
    Friend WithEvents btn_hoantat As Button
    Friend WithEvents Button1 As Button
End Class
