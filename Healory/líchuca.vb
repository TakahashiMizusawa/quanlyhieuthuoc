Imports System.Data.SqlClient

Public Class líchuca

    Dim connectionString As String = "Data Source=NGUYNTHNHNA4447\SA;Initial Catalog=Healory;User ID=sa;Password=Konodioda2006@@;TrustServerCertificate=True"

    ' Load tất cả dữ liệu từ bảng CaLam
    Private Sub LoadData()
        Dim query As String = "SELECT * FROM CaLam"
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Tìm kiếm dữ liệu theo ngày làm
    Private Sub TimKiemTheoNgay(ngay As Date)
        Dim query As String = "SELECT * FROM CaLam WHERE NgayLam = @NgayLam"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NgayLam", ngay)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Form Load: tự động hiển thị tất cả dữ liệu
    Private Sub líchuca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Nút Tìm kiếm
    Private Sub btn_timkiem_Click(sender As Object, e As EventArgs) Handles btn_timkiem.Click
        Dim ngay As Date = dtp_timkiem.Value.Date
        TimKiemTheoNgay(ngay)
    End Sub

    ' Nút Trở lại: tải lại toàn bộ dữ liệu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class
