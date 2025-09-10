<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suathongtin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(suathongtin))
        Me.lbl_chs_tendangnhap = New System.Windows.Forms.Label()
        Me.lbl_chinhsua = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.btn_trove = New System.Windows.Forms.Button()
        Me.btn_chinhsua = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_mk = New System.Windows.Forms.Label()
        Me.lbl_tendangnhap = New System.Windows.Forms.Label()
        Me.lbl_hovaten = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_chs_tendangnhap
        '
        Me.lbl_chs_tendangnhap.AutoSize = True
        Me.lbl_chs_tendangnhap.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_chs_tendangnhap.Location = New System.Drawing.Point(19, 107)
        Me.lbl_chs_tendangnhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_chs_tendangnhap.Name = "lbl_chs_tendangnhap"
        Me.lbl_chs_tendangnhap.Size = New System.Drawing.Size(0, 15)
        Me.lbl_chs_tendangnhap.TabIndex = 1
        '
        'lbl_chinhsua
        '
        Me.lbl_chinhsua.AutoSize = True
        Me.lbl_chinhsua.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_chinhsua.Location = New System.Drawing.Point(269, 34)
        Me.lbl_chinhsua.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_chinhsua.Name = "lbl_chinhsua"
        Me.lbl_chinhsua.Size = New System.Drawing.Size(330, 31)
        Me.lbl_chinhsua.TabIndex = 0
        Me.lbl_chinhsua.Text = "CHỈNH SỬA THÔNG TIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "EMAIL*"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(191, 203)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(498, 22)
        Me.txt_email.TabIndex = 20
        '
        'btn_trove
        '
        Me.btn_trove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_trove.Font = New System.Drawing.Font("Times New Roman", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_trove.Image = CType(resources.GetObject("btn_trove.Image"), System.Drawing.Image)
        Me.btn_trove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trove.Location = New System.Drawing.Point(401, 333)
        Me.btn_trove.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_trove.Name = "btn_trove"
        Me.btn_trove.Size = New System.Drawing.Size(135, 38)
        Me.btn_trove.TabIndex = 19
        Me.btn_trove.Text = "TRỞ VỀ"
        Me.btn_trove.UseVisualStyleBackColor = False
        '
        'btn_chinhsua
        '
        Me.btn_chinhsua.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_chinhsua.Font = New System.Drawing.Font("Times New Roman", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_chinhsua.Image = CType(resources.GetObject("btn_chinhsua.Image"), System.Drawing.Image)
        Me.btn_chinhsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_chinhsua.Location = New System.Drawing.Point(218, 333)
        Me.btn_chinhsua.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_chinhsua.Name = "btn_chinhsua"
        Me.btn_chinhsua.Size = New System.Drawing.Size(143, 38)
        Me.btn_chinhsua.TabIndex = 18
        Me.btn_chinhsua.Text = "CHỈNH SỬA"
        Me.btn_chinhsua.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(191, 249)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(498, 22)
        Me.txt_password.TabIndex = 17
        '
        'txt_fullname
        '
        Me.txt_fullname.Location = New System.Drawing.Point(191, 153)
        Me.txt_fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fullname.Multiline = True
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(498, 22)
        Me.txt_fullname.TabIndex = 16
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(191, 106)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(498, 22)
        Me.txt_username.TabIndex = 15
        '
        'lbl_mk
        '
        Me.lbl_mk.AutoSize = True
        Me.lbl_mk.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_mk.Location = New System.Drawing.Point(16, 243)
        Me.lbl_mk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mk.Name = "lbl_mk"
        Me.lbl_mk.Size = New System.Drawing.Size(118, 22)
        Me.lbl_mk.TabIndex = 14
        Me.lbl_mk.Text = "PASSWORD"
        '
        'lbl_tendangnhap
        '
        Me.lbl_tendangnhap.AutoSize = True
        Me.lbl_tendangnhap.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_tendangnhap.Location = New System.Drawing.Point(16, 103)
        Me.lbl_tendangnhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tendangnhap.Name = "lbl_tendangnhap"
        Me.lbl_tendangnhap.Size = New System.Drawing.Size(119, 22)
        Me.lbl_tendangnhap.TabIndex = 13
        Me.lbl_tendangnhap.Text = "USERNAME"
        '
        'lbl_hovaten
        '
        Me.lbl_hovaten.AutoSize = True
        Me.lbl_hovaten.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_hovaten.Location = New System.Drawing.Point(16, 150)
        Me.lbl_hovaten.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hovaten.Name = "lbl_hovaten"
        Me.lbl_hovaten.Size = New System.Drawing.Size(121, 22)
        Me.lbl_hovaten.TabIndex = 12
        Me.lbl_hovaten.Text = "FULL NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(751, 445)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'suathongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 444)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.btn_trove)
        Me.Controls.Add(Me.btn_chinhsua)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_fullname)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_mk)
        Me.Controls.Add(Me.lbl_tendangnhap)
        Me.Controls.Add(Me.lbl_hovaten)
        Me.Controls.Add(Me.lbl_chs_tendangnhap)
        Me.Controls.Add(Me.lbl_chinhsua)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "suathongtin"
        Me.Text = "suathongtin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_chs_tendangnhap As Label
    Friend WithEvents lbl_chinhsua As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents btn_trove As Button
    Friend WithEvents btn_chinhsua As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_mk As Label
    Friend WithEvents lbl_tendangnhap As Label
    Friend WithEvents lbl_hovaten As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
