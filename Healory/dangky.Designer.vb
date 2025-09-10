<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dangky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dangky))
        Me.lbl_dangky = New System.Windows.Forms.Label()
        Me.lbl_hovaten = New System.Windows.Forms.Label()
        Me.lbl_tendangnhap = New System.Windows.Forms.Label()
        Me.lbl_mk = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_dangky = New System.Windows.Forms.Button()
        Me.btn_trove = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_dangky
        '
        Me.lbl_dangky.AutoSize = True
        Me.lbl_dangky.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_dangky.Location = New System.Drawing.Point(304, 19)
        Me.lbl_dangky.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_dangky.Name = "lbl_dangky"
        Me.lbl_dangky.Size = New System.Drawing.Size(123, 26)
        Me.lbl_dangky.TabIndex = 0
        Me.lbl_dangky.Text = "ĐĂNG KÝ"
        '
        'lbl_hovaten
        '
        Me.lbl_hovaten.AutoSize = True
        Me.lbl_hovaten.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_hovaten.Location = New System.Drawing.Point(32, 108)
        Me.lbl_hovaten.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hovaten.Name = "lbl_hovaten"
        Me.lbl_hovaten.Size = New System.Drawing.Size(121, 22)
        Me.lbl_hovaten.TabIndex = 1
        Me.lbl_hovaten.Text = "FULL NAME"
        '
        'lbl_tendangnhap
        '
        Me.lbl_tendangnhap.AutoSize = True
        Me.lbl_tendangnhap.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_tendangnhap.Location = New System.Drawing.Point(32, 61)
        Me.lbl_tendangnhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tendangnhap.Name = "lbl_tendangnhap"
        Me.lbl_tendangnhap.Size = New System.Drawing.Size(119, 22)
        Me.lbl_tendangnhap.TabIndex = 2
        Me.lbl_tendangnhap.Text = "USERNAME"
        '
        'lbl_mk
        '
        Me.lbl_mk.AutoSize = True
        Me.lbl_mk.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbl_mk.Location = New System.Drawing.Point(32, 201)
        Me.lbl_mk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mk.Name = "lbl_mk"
        Me.lbl_mk.Size = New System.Drawing.Size(118, 22)
        Me.lbl_mk.TabIndex = 3
        Me.lbl_mk.Text = "PASSWORD"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(182, 61)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(381, 22)
        Me.txt_username.TabIndex = 4
        '
        'txt_fullname
        '
        Me.txt_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_fullname.Location = New System.Drawing.Point(182, 108)
        Me.txt_fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fullname.Multiline = True
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(381, 22)
        Me.txt_fullname.TabIndex = 5
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(182, 204)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(381, 22)
        Me.txt_password.TabIndex = 6
        '
        'btn_dangky
        '
        Me.btn_dangky.BackColor = System.Drawing.Color.LightCoral
        Me.btn_dangky.Font = New System.Drawing.Font("Times New Roman", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_dangky.Image = CType(resources.GetObject("btn_dangky.Image"), System.Drawing.Image)
        Me.btn_dangky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dangky.Location = New System.Drawing.Point(182, 265)
        Me.btn_dangky.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_dangky.Name = "btn_dangky"
        Me.btn_dangky.Size = New System.Drawing.Size(134, 41)
        Me.btn_dangky.TabIndex = 7
        Me.btn_dangky.Text = "ĐĂNG KÝ"
        Me.btn_dangky.UseVisualStyleBackColor = False
        '
        'btn_trove
        '
        Me.btn_trove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_trove.Font = New System.Drawing.Font("Times New Roman", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_trove.Image = CType(resources.GetObject("btn_trove.Image"), System.Drawing.Image)
        Me.btn_trove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trove.Location = New System.Drawing.Point(420, 265)
        Me.btn_trove.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_trove.Name = "btn_trove"
        Me.btn_trove.Size = New System.Drawing.Size(134, 41)
        Me.btn_trove.TabIndex = 8
        Me.btn_trove.Text = "TRỞ VỀ"
        Me.btn_trove.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(182, 158)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(381, 22)
        Me.txt_email.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "EMAIL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(724, 405)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'dangky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 408)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.btn_trove)
        Me.Controls.Add(Me.btn_dangky)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_fullname)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_mk)
        Me.Controls.Add(Me.lbl_tendangnhap)
        Me.Controls.Add(Me.lbl_hovaten)
        Me.Controls.Add(Me.lbl_dangky)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dangky"
        Me.Text = "dangky"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_dangky As Label
    Friend WithEvents lbl_hovaten As Label
    Friend WithEvents lbl_tendangnhap As Label
    Friend WithEvents lbl_mk As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_dangky As Button
    Friend WithEvents btn_trove As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
