Imports System.Data.SqlClient

Public Class sell

    Dim tongTien As Decimal = 0


    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        Me.Close()
    End Sub

    ' Nút tìm kiếm thuốc
    Private Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        Dim tuKhoa As String = txt_thuoc.Text.Trim()

        If tuKhoa = "" Then
            MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.")
            Return
        End If

        Dim query As String = "SELECT MaThuoc, TenThuoc, DonViTinh, SoLuong, GiaBan, HanSuDung, NhaSanXuat FROM Thuoc " &
                              "WHERE MaThuoc LIKE @TuKhoa OR TenThuoc LIKE @TuKhoa"

        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TuKhoa", "%" & tuKhoa & "%")
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                Dgv_thuoc.DataSource = table
            End Using
        End Using
    End Sub

    ' Sự kiện chọn thuốc trong DataGridView
    Private Sub Dgv_thuoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_thuoc.CellClick
        If e.RowIndex >= 0 Then
            Dim giaBan As Decimal = 0

            ' Lấy giá bán từ dòng được chọn (cột GiaBan)
            Decimal.TryParse(Dgv_thuoc.Rows(e.RowIndex).Cells("GiaBan").Value.ToString(), giaBan)

            ' Cộng dồn tổng tiền
            tongTien += giaBan
            lbl_tongtien.Text = tongTien.ToString("N0") & " VNĐ"

            ' Tính lại tiền trả nếu có tiền khách đưa
            TinhTienTraLai()
        End If
    End Sub

    ' Tính tiền trả lại
    Private Sub TinhTienTraLai()
        Dim tienKhachDua As Decimal = 0

        If Decimal.TryParse(txt_tienkhachdua.Text.Trim(), tienKhachDua) Then
            Dim tienTraLai As Decimal = tienKhachDua - tongTien
            lbl_tralaitien.Text = tienTraLai.ToString("N0") & " VNĐ"
        Else
            lbl_tralaitien.Text = "0 VNĐ"
        End If
    End Sub

    ' Khi thay đổi số tiền khách đưa
    Private Sub txt_tienkhachdua_TextChanged(sender As Object, e As EventArgs) Handles txt_tienkhachdua.TextChanged
        TinhTienTraLai()
    End Sub

    Private Sub sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Có thể thêm lệnh khởi tạo dữ liệu ở đây
    End Sub

    ' Sự kiện nút Lưu: Lưu dữ liệu hóa đơn vào CSDL
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        LuuHoaDon()
    End Sub

    ' Hàm lưu thông tin hóa đơn vào bảng HoaDonBanThuoc
    Private Sub LuuHoaDon()
        ' Kiểm tra dữ liệu đầu vào cơ bản
        If String.IsNullOrWhiteSpace(txt_mahoadon.Text) OrElse
           String.IsNullOrWhiteSpace(txt_nhanvienban.Text) OrElse
           Dgv_thuoc.Rows.Count = 0 Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn thuốc trước khi lưu.")
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                ' Dùng transaction để đảm bảo atomicity khi lưu nhiều dòng thuốc
                Using tran As SqlTransaction = conn.BeginTransaction()

                    For Each row As DataGridViewRow In Dgv_thuoc.Rows
                        If Not row.IsNewRow Then
                            Dim maHD As String = txt_mahoadon.Text.Trim()
                            Dim ngayBan As Date = dtp_ngayban.Value.Date
                            Dim tenNV As String = txt_nhanvienban.Text.Trim()
                            Dim tenKH As String = txt_tenkhachhang.Text.Trim()
                            Dim maThuoc As String = row.Cells("MaThuoc").Value.ToString()
                            Dim tenThuoc As String = row.Cells("TenThuoc").Value.ToString()
                            Dim soLuong As Integer = 1
                            Dim donGia As Decimal = Decimal.Parse(row.Cells("GiaBan").Value.ToString())

                            ' Câu lệnh INSERT
                            Dim insertQuery As String = "INSERT INTO HoaDonBanThuoc (MaHD, NgayBan, Tennhanvien, TenKhachHang, MaThuoc, TenThuoc, SoLuong, DonGia) " &
                                                       "VALUES (@MaHD, @NgayBan, @Tennhanvien, @TenKhachHang, @MaThuoc, @TenThuoc, @SoLuong, @DonGia)"

                            Using cmd As New SqlCommand(insertQuery, conn, tran)
                                cmd.Parameters.AddWithValue("@MaHD", maHD)
                                cmd.Parameters.AddWithValue("@NgayBan", ngayBan)
                                cmd.Parameters.AddWithValue("@Tennhanvien", tenNV)
                                cmd.Parameters.AddWithValue("@TenKhachHang", tenKH)
                                cmd.Parameters.AddWithValue("@MaThuoc", maThuoc)
                                cmd.Parameters.AddWithValue("@TenThuoc", tenThuoc)
                                cmd.Parameters.AddWithValue("@SoLuong", soLuong)
                                cmd.Parameters.AddWithValue("@DonGia", donGia)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    tran.Commit()
                End Using
            End Using

            MessageBox.Show("Lưu hóa đơn thành công.")
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu hóa đơn: " & ex.Message)
        End Try
    End Sub

    ' Hàm tạo kết nối tới CSDL, bạn thay đổi chuỗi kết nối phù hợp
    Private Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"
        Return New SqlConnection(connectionString)
    End Function

    ' Nút in hóa đơn
    Private Sub btn_inhoadon_Click(sender As Object, e As EventArgs) Handles btn_inhoadon.Click
        ' Kiểm tra có thuốc được chọn chưa (Dgv_thuoc có dữ liệu)
        If Dgv_thuoc.Rows.Count = 0 Then
            MessageBox.Show("Chưa có thuốc nào để in hóa đơn!")
            Return
        End If

        ' Thông tin hóa đơn
        Dim thongTin As New System.Text.StringBuilder()

        thongTin.AppendLine("---- HÓA ĐƠN BÁN THUỐC ----")
        thongTin.AppendLine($"Mã hóa đơn: {txt_mahoadon.Text.Trim()}")
        thongTin.AppendLine($"Ngày bán: {dtp_ngayban.Value.ToShortDateString()}")
        thongTin.AppendLine($"Nhân viên bán: {txt_nhanvienban.Text.Trim()}")
        thongTin.AppendLine($"Khách hàng: {txt_tenkhachhang.Text.Trim()}")
        thongTin.AppendLine()
        thongTin.AppendLine("Danh sách thuốc:")

        ' Lấy từng dòng thuốc trong DataGridView để liệt kê
        If Dgv_thuoc.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn ít nhất một thuốc để in hóa đơn.")
            Return
        End If

        For Each row As DataGridViewRow In Dgv_thuoc.SelectedRows
            Dim maThuoc As String = row.Cells("MaThuoc").Value.ToString()
            Dim tenThuoc As String = row.Cells("TenThuoc").Value.ToString()
            Dim soLuong As String = If(row.Cells("SoLuong").Value IsNot Nothing, row.Cells("SoLuong").Value.ToString(), "1")
            Dim giaBan As String = If(row.Cells("GiaBan").Value IsNot Nothing, row.Cells("GiaBan").Value.ToString(), "0")

            thongTin.AppendLine($"- {tenThuoc} (Mã: {maThuoc}), Số lượng: {soLuong}, Giá: {Decimal.Parse(giaBan).ToString("N0")} VNĐ")
        Next


        thongTin.AppendLine()
        thongTin.AppendLine($"Tổng tiền: {tongTien.ToString("N0")} VNĐ")
        thongTin.AppendLine($"Tiền khách đưa: {txt_tienkhachdua.Text} VNĐ")
        thongTin.AppendLine($"Tiền trả lại: {lbl_tralaitien.Text}")

        ' Hiển thị message box
        MessageBox.Show(thongTin.ToString(), "Hóa đơn bán thuốc")
    End Sub
End Class
