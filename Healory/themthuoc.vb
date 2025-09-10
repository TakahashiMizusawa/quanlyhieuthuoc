Imports System.Data.SqlClient

Public Class themthuoc
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        ' Chuỗi kết nối đến cơ sở dữ liệu
        Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Tạo mã thuốc tự động (ví dụ: THUOC001, THUOC002,...)
                Dim maThuoc As String = TaoMaThuoc(conn)

                ' Tạo câu lệnh SQL thêm thuốc
                Dim sql As String = "INSERT INTO Thuoc (MaThuoc, TenThuoc, DonViTinh, SoLuong, GiaNhap, GiaBan, HanSuDung, NhaSanXuat, GhiChu)
                                     VALUES (@MaThuoc, @TenThuoc, @DonViTinh, @SoLuong, @GiaNhap, @GiaBan, @HanSuDung, @NhaSanXuat, @GhiChu)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaThuoc", maThuoc)
                    cmd.Parameters.AddWithValue("@TenThuoc", txt_tenthuoc.Text)
                    cmd.Parameters.AddWithValue("@DonViTinh", txt_donvitinh.Text)
                    cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(txt_soluong.Text))
                    cmd.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(txt_gianhap.Text))
                    cmd.Parameters.AddWithValue("@GiaBan", Decimal.Parse(txt_giaban.Text))
                    cmd.Parameters.AddWithValue("@HanSuDung", dtp_hansudung.Value)
                    cmd.Parameters.AddWithValue("@NhaSanXuat", txt_nhasanxuat.Text)
                    cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thêm thuốc: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Hàm tạo mã thuốc tự động (ví dụ: THUOC001)
    Private Function TaoMaThuoc(conn As SqlConnection) As String
        Dim sql As String = "SELECT COUNT(*) FROM Thuoc"
        Using cmd As New SqlCommand(sql, conn)
            Dim count As Integer = CInt(cmd.ExecuteScalar()) + 1
            Return "TH" & count.ToString("D3")
        End Using
    End Function

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        Me.Close()
    End Sub

    Private Sub themthuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
