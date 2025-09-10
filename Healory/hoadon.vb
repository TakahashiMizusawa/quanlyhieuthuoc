Imports System.Data.SqlClient

Public Class hoadon
    Private Sub hoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHoaDonBanThuoc()
    End Sub

    ' Hàm tải toàn bộ hóa đơn thuốc
    Private Sub LoadHoaDonBanThuoc()
        Dim query As String = "SELECT MaHD, NgayBan, Tennhanvien, TenKhachHang, MaThuoc, TenThuoc, SoLuong, DonGia, ThanhTien FROM HoaDonBanThuoc"

        Try
            Using conn As SqlConnection = GetConnection()
                Using cmd As New SqlCommand(query, conn)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    Dgv_haodon.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    ' Hàm tạo kết nối SQL Server
    Private Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"
        Return New SqlConnection(connectionString)
    End Function

    ' Nút đóng form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' Nút tìm kiếm hóa đơn theo mã
    Private Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        Dim maHD As String = TextBox1.Text.Trim()

        If String.IsNullOrEmpty(maHD) Then
            MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm kiếm.")
            Return
        End If

        Dim query As String = "SELECT MaHD, NgayBan, Tennhanvien, TenKhachHang, MaThuoc, TenThuoc, SoLuong, DonGia, ThanhTien " &
                              "FROM HoaDonBanThuoc WHERE MaHD = @MaHD"

        Try
            Using conn As SqlConnection = GetConnection()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaHD", maHD)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy hóa đơn với mã: " & maHD)
                    End If

                    Dgv_haodon.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
        End Try
    End Sub
End Class
