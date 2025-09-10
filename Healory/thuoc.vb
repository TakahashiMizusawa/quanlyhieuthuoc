Imports System.Data.SqlClient

Public Class thuoc
    ' Kết nối đến SQL Server
    Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub thuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllThuoc()
    End Sub

    Private Sub LoadAllThuoc()
        Dim query As String = "SELECT * FROM Thuoc"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            dgv_thuoc.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu thuốc: " & ex.Message, "Lỗi")
        End Try
    End Sub

    Private Sub btn_tim_Click(sender As Object, e As EventArgs) Handles btn_tim.Click
        Dim tuKhoa As String = txt_timkiem.Text.Trim()

        If tuKhoa = "" Then
            MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo")
            Return
        End If

        Dim query As String = "SELECT * FROM Thuoc WHERE TenThuoc LIKE @TuKhoa OR NhaSanXuat LIKE @TuKhoa"
        Dim adapter As New SqlDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" & tuKhoa & "%")

        Dim table As New DataTable()
        Try
            adapter.Fill(table)
            dgv_thuoc.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message, "Lỗi")
        End Try
    End Sub

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        Me.Close()
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        ' Kiểm tra có dòng nào được chọn không
        If dgv_thuoc.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn thuốc cần xóa.", "Thông báo")
            Return
        End If

        ' Kiểm tra cột TenThuoc có tồn tại
        If Not dgv_thuoc.Columns.Contains("TenThuoc") Then
            MessageBox.Show("Không tìm thấy cột TenThuoc trong dữ liệu!", "Lỗi")
            Return
        End If

        ' Xác thực mã ADMIN 1 lần
        Dim maAdmin As String = InputBox("Vui lòng nhập mã ADMIN để xác nhận xóa:", "Xác nhận ADMIN")
        If maAdmin.Trim() <> "healory" Then
            MessageBox.Show("Mã ADMIN không đúng. Không thể xóa thuốc.", "Cảnh báo")
            Return
        End If

        ' Xác nhận xóa
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa " & dgv_thuoc.SelectedRows.Count & " thuốc đã chọn theo Tên Thuốc?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Dim rowsDeleted As Integer = 0

        Try
            connection.Open()

            For Each row As DataGridViewRow In dgv_thuoc.SelectedRows
                Dim tenThuoc As Object = row.Cells("TenThuoc").Value
                If tenThuoc IsNot Nothing Then
                    Dim query As String = "DELETE FROM Thuoc WHERE TenThuoc = @TenThuoc"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@TenThuoc", tenThuoc.ToString())
                        rowsDeleted += command.ExecuteNonQuery()
                    End Using
                End If
            Next

            connection.Close()

            If rowsDeleted > 0 Then
                MessageBox.Show("Đã xóa " & rowsDeleted & " thuốc thành công!", "Thành công")
                LoadAllThuoc()
            Else
                MessageBox.Show("Không có thuốc nào được xóa.", "Thông báo")
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa thuốc: " & ex.Message, "Lỗi")
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub
End Class
