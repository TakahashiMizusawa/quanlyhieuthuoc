<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dangnhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dangnhap))
        Me.lbl_dangnhap = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.LBL_pass = New System.Windows.Forms.Label()
        Me.txt_dangnhap = New System.Windows.Forms.TextBox()
        Me.txt_matkhau = New System.Windows.Forms.TextBox()
        Me.btn_dangnhap = New System.Windows.Forms.Button()
        Me.btn_dangky = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_dangnhap
        '
        Me.lbl_dangnhap.AutoSize = True
        Me.lbl_dangnhap.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_dangnhap.Location = New System.Drawing.Point(628, 60)
        Me.lbl_dangnhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_dangnhap.Name = "lbl_dangnhap"
        Me.lbl_dangnhap.Size = New System.Drawing.Size(314, 55)
        Me.lbl_dangnhap.TabIndex = 0
        Me.lbl_dangnhap.Text = "ĐĂNG NHẬP"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(40, 194)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(206, 36)
        Me.lbl_username.TabIndex = 1
        Me.lbl_username.Text = "USER NAME"
        '
        'LBL_pass
        '
        Me.LBL_pass.AutoSize = True
        Me.LBL_pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LBL_pass.Location = New System.Drawing.Point(40, 315)
        Me.LBL_pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_pass.Name = "LBL_pass"
        Me.LBL_pass.Size = New System.Drawing.Size(194, 36)
        Me.LBL_pass.TabIndex = 2
        Me.LBL_pass.Text = "MẬT KHẨU"
        '
        'txt_dangnhap
        '
        Me.txt_dangnhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_dangnhap.Location = New System.Drawing.Point(340, 194)
        Me.txt_dangnhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dangnhap.Multiline = True
        Me.txt_dangnhap.Name = "txt_dangnhap"
        Me.txt_dangnhap.Size = New System.Drawing.Size(902, 46)
        Me.txt_dangnhap.TabIndex = 3
        '
        'txt_matkhau
        '
        Me.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_matkhau.Location = New System.Drawing.Point(340, 306)
        Me.txt_matkhau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_matkhau.Multiline = True
        Me.txt_matkhau.Name = "txt_matkhau"
        Me.txt_matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_matkhau.Size = New System.Drawing.Size(902, 46)
        Me.txt_matkhau.TabIndex = 4
        '
        'btn_dangnhap
        '
        Me.btn_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_dangnhap.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_dangnhap.ImageKey = "(none)"
        Me.btn_dangnhap.Location = New System.Drawing.Point(636, 462)
        Me.btn_dangnhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_dangnhap.Name = "btn_dangnhap"
        Me.btn_dangnhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_dangnhap.Size = New System.Drawing.Size(272, 69)
        Me.btn_dangnhap.TabIndex = 5
        Me.btn_dangnhap.Text = "Đăng Nhập"
        Me.btn_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_dangnhap.UseVisualStyleBackColor = False
        '
        'btn_dangky
        '
        Me.btn_dangky.BackColor = System.Drawing.Color.LightCoral
        Me.btn_dangky.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_dangky.Image = CType(resources.GetObject("btn_dangky.Image"), System.Drawing.Image)
        Me.btn_dangky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dangky.Location = New System.Drawing.Point(636, 571)
        Me.btn_dangky.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_dangky.Name = "btn_dangky"
        Me.btn_dangky.Size = New System.Drawing.Size(272, 69)
        Me.btn_dangky.TabIndex = 6
        Me.btn_dangky.Text = "ĐĂNG KÝ"
        Me.btn_dangky.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1466, 750)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1468, 752)
        Me.Controls.Add(Me.btn_dangky)
        Me.Controls.Add(Me.btn_dangnhap)
        Me.Controls.Add(Me.txt_matkhau)
        Me.Controls.Add(Me.txt_dangnhap)
        Me.Controls.Add(Me.LBL_pass)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_dangnhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dangnhap"
        Me.Text = "A"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_dangnhap As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents LBL_pass As Label
    Friend WithEvents txt_dangnhap As TextBox
    Friend WithEvents txt_matkhau As TextBox
    Friend WithEvents btn_dangnhap As Button
    Friend WithEvents btn_dangky As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
