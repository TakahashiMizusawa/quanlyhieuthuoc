Imports System.Data.SqlClient

Public Class danhsachnhanvien

    Private connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"

    Private Sub btn_trove_Click(sender As Object, e As EventArgs) Handles btn_trove.Click
        Me.Close()
    End Sub

    Private Sub danhsachnhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connection As New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM NhanVien"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        ' Yêu cầu nhập mật khẩu
        Dim password As String = InputBox("Nhập mật khẩu để xác nhận xóa:", "Xác thực")
        If password <> "healory" Then
            MessageBox.Show("Sai mật khẩu. Không thể xóa nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Kiểm tra xem có dòng nào được chọn không
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Xác nhận trước khi xóa
        If MessageBox.Show("Bạn có chắc chắn muốn xóa những nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Try
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    If Not row.IsNewRow Then
                        Dim maNV As String = row.Cells("MaNV").Value.ToString()
                        Dim deleteQuery As String = "DELETE FROM NhanVien WHERE MaNV = @MaNV"

                        Using command As New SqlCommand(deleteQuery, connection)
                            command.Parameters.AddWithValue("@MaNV", maNV)
                            command.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData() ' Load lại dữ liệu sau khi xóa

            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
