Imports System.Data.SqlClient
Public Class dangnhap
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_dangnhap_Click(sender As Object, e As EventArgs) Handles btn_dangnhap.Click
        Dim con As New SqlConnection("Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True")
        Dim cmd As New SqlCommand("SELECT * FROM Dangky WHERE Username = @user AND Password = @pass", con)
        cmd.Parameters.AddWithValue("@user", txt_dangnhap.Text.Trim())
        cmd.Parameters.AddWithValue("@pass", txt_matkhau.Text.Trim())

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            con.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim tenDangNhap As String = dt.Rows(0)("Username").ToString()
                MessageBox.Show("Đăng nhập thành công! Xin chào " & tenDangNhap)

                Dim mainForm As New main()
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_dangky_Click(sender As Object, e As EventArgs) Handles btn_dangky.Click
        Me.Hide()
        dangky.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lbl_dangnhap_Click(sender As Object, e As EventArgs) Handles lbl_dangnhap.Click

    End Sub

    Private Sub lbl_username_Click(sender As Object, e As EventArgs) Handles lbl_username.Click

    End Sub

    Private Sub LBL_pass_Click(sender As Object, e As EventArgs) Handles LBL_pass.Click

    End Sub

    Private Sub txt_dangnhap_TextChanged(sender As Object, e As EventArgs) Handles txt_dangnhap.TextChanged

    End Sub

    Private Sub txt_matkhau_TextChanged(sender As Object, e As EventArgs) Handles txt_matkhau.TextChanged

    End Sub
End Class