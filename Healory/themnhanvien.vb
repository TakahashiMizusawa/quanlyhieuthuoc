Imports System.Data.SqlClient

Public Class themnhanvien
    ' Chuỗi kết nối SQL Server
    Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"
    Dim connection As SqlConnection = New SqlConnection(connectionString)

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        ' Xác nhận mã Admin
        Dim maAdmin As String = InputBox("Vui lòng nhập mã Admin để xác nhận:", "Xác nhận quyền quản trị")
        If maAdmin.Trim().ToLower() <> "healory" Then
            MessageBox.Show("Mã admin không hợp lệ. Không thể thêm nhân viên.", "Xác nhận thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Kiểm tra dữ liệu đầu vào
        If String.IsNullOrWhiteSpace(txt_manhanhvien.Text) OrElse
           String.IsNullOrWhiteSpace(txt_hoten.Text) OrElse
           String.IsNullOrWhiteSpace(txt_gioitinh.Text) OrElse
           String.IsNullOrWhiteSpace(txt_sodienthoai.Text) OrElse
           String.IsNullOrWhiteSpace(txt_email.Text) OrElse
           String.IsNullOrWhiteSpace(txt_chucvu.Text) OrElse
           String.IsNullOrWhiteSpace(txt_diachi.Text) OrElse
           String.IsNullOrWhiteSpace(txt_luongcoban.Text) Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Kiểm tra mã nhân viên đã tồn tại
            Dim checkQuery As String = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV"
            Using checkCmd As New SqlCommand(checkQuery, connection)
                checkCmd.Parameters.AddWithValue("@MaNV", txt_manhanhvien.Text.Trim())
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists > 0 Then
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Thêm nhân viên mới
            Dim insertQuery As String = "INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DienThoai, Email, ChucVu, DiaChi, NgayVaoLam, Luong) 
                            VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @DienThoai, @Email, @ChucVu, @DiaChi, @NgayVaoLam, @Luong)"

            Using cmd As New SqlCommand(insertQuery, connection)
                cmd.Parameters.AddWithValue("@MaNV", txt_manhanhvien.Text.Trim())
                cmd.Parameters.AddWithValue("@HoTen", txt_hoten.Text.Trim())
                cmd.Parameters.AddWithValue("@GioiTinh", txt_gioitinh.Text.Trim())
                cmd.Parameters.AddWithValue("@NgaySinh", dtp_ngaysinh.Value.Date)
                cmd.Parameters.AddWithValue("@DienThoai", txt_sodienthoai.Text.Trim())
                cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim())
                cmd.Parameters.AddWithValue("@ChucVu", txt_chucvu.Text.Trim())
                cmd.Parameters.AddWithValue("@DiaChi", txt_diachi.Text.Trim())
                cmd.Parameters.AddWithValue("@NgayVaoLam", dtp_ngayvaolam.Value.Date)
                cmd.Parameters.AddWithValue("@Luong", Decimal.Parse(txt_luongcoban.Text.Trim()))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using


        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        Me.Close()
    End Sub
End Class
