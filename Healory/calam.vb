Imports System.Data.SqlClient
Public Class calam
    Private Sub calam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_hoantat_Click(sender As Object, e As EventArgs) Handles btn_hoantat.Click
        Dim conn As New SqlConnection("Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True")
        Dim query As String = "INSERT INTO CaLam (MaCa, TenCa, GioBatDau, GioKetThuc, MaNV, NgayLam, GhiChu) 
                           VALUES (@MaCa, @TenCa, @GioBatDau, @GioKetThuc, @MaNV, @NgayLam, @GhiChu)"

        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaCa", txt_maca.Text)
            cmd.Parameters.AddWithValue("@TenCa", txt_tenca.Text)
            cmd.Parameters.AddWithValue("@GioBatDau", TimeSpan.Parse(txt_giobatdau.Text))
            cmd.Parameters.AddWithValue("@GioKetThuc", TimeSpan.Parse(txt_gioketthuc.Text))
            cmd.Parameters.AddWithValue("@MaNV", txt_manhanvien.Text)
            cmd.Parameters.AddWithValue("@NgayLam", dtp_ngaylam.Value.Date)
            cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Đã thêm ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thêm ca làm: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class