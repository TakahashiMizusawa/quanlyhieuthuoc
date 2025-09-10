<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class líchuca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(líchuca))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp_timkiem = New System.Windows.Forms.DateTimePicker()
        Me.btn_timkiem = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(378, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lịch sử ca"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(907, 298)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(331, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "trở lại"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtp_timkiem
        '
        Me.dtp_timkiem.Location = New System.Drawing.Point(394, 95)
        Me.dtp_timkiem.Name = "dtp_timkiem"
        Me.dtp_timkiem.Size = New System.Drawing.Size(405, 20)
        Me.dtp_timkiem.TabIndex = 3
        '
        'btn_timkiem
        '
        Me.btn_timkiem.BackColor = System.Drawing.Color.White
        Me.btn_timkiem.Location = New System.Drawing.Point(808, 94)
        Me.btn_timkiem.Name = "btn_timkiem"
        Me.btn_timkiem.Size = New System.Drawing.Size(97, 20)
        Me.btn_timkiem.TabIndex = 4
        Me.btn_timkiem.Text = "Tìm kiếm"
        Me.btn_timkiem.UseVisualStyleBackColor = False
        '
        'líchuca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 493)
        Me.Controls.Add(Me.btn_timkiem)
        Me.Controls.Add(Me.dtp_timkiem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "líchuca"
        Me.Text = "líchuca"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtp_timkiem As DateTimePicker
    Friend WithEvents btn_timkiem As Button
End Class
