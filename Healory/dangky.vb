Imports System.Data.SqlClient

Public Class dangky
    Private Sub btn_dangky_Click(sender As Object, e As EventArgs) Handles btn_dangky.Click
        Dim conn As New SqlConnection("Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True")

        Try
            conn.Open()
            Dim query As String = "INSERT INTO dangky (Username, FullName, Email, Password) VALUES (@username, @fullname, @email, @password)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@fullname", txt_fullname.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Đăng ký thành công!", "Thông báo")
                Me.Close()
                dangnhap.Show()
            Else
                MessageBox.Show("Đăng ký thất bại!", "Lỗi")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dangky_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_trove_Click(sender As Object, e As EventArgs) Handles btn_trove.Click
        Me.Close()
        dangnhap.Show()
    End Sub
End Class
