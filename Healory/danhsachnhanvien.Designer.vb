<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class danhsachnhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(danhsachnhanvien))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_trove = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(798, 355)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_trove
        '
        Me.btn_trove.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trove.Image = CType(resources.GetObject("btn_trove.Image"), System.Drawing.Image)
        Me.btn_trove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trove.Location = New System.Drawing.Point(242, 403)
        Me.btn_trove.Name = "btn_trove"
        Me.btn_trove.Size = New System.Drawing.Size(119, 35)
        Me.btn_trove.TabIndex = 1
        Me.btn_trove.Text = "Trở Về"
        Me.btn_trove.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(447, 403)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(171, 35)
        Me.btn_xoa.TabIndex = 2
        Me.btn_xoa.Text = "Xóa Nhân viên"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Danh sách nhân viên"
        '
        'danhsachnhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_trove)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "danhsachnhanvien"
        Me.Text = "danhsachnhanvien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_trove As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents Label1 As Label
End Class
