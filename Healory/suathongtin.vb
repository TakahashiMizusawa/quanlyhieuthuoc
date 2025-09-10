Imports System.Data.SqlClient

Public Class suathongtin

    Private Sub suathongtin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_chinhsua_Click(sender As Object, e As EventArgs) Handles btn_chinhsua.Click
        If txt_username.Text.Trim() = "" Or txt_password.Text.Trim() = "" Or txt_email.Text.Trim() = "" Then
            MessageBox.Show("Tên đăng nhập, mật khẩu và email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As New SqlConnection("Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True")

        Try
            conn.Open()
            ' CHỈ UPDATE Username, Password, FullName => dựa trên Email
            Dim cmd As New SqlCommand("UPDATE Dangky SET Username = @Username, Password = @Password, FullName = @FullName WHERE Email = @Email", conn)
            cmd.Parameters.AddWithValue("@Username", txt_username.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim())
            cmd.Parameters.AddWithValue("@FullName", txt_fullname.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim()) ' dùng để xác định tài khoản cần cập nhật

            Dim rowsAffected = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Cập nhật thành công!", "Thông báo")
                Me.Close()
                main.Show()
            Else
                MessageBox.Show("Không tìm thấy tài khoản với email này.", "Thông báo")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi cập nhật: " & ex.Message, "Lỗi")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_trove_Click(sender As Object, e As EventArgs) Handles btn_trove.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
