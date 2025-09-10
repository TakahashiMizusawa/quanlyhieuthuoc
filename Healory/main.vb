Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChỉnhSửaThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉnhSửaThôngTinToolStripMenuItem.Click
        Me.Hide()
        suathongtin.Show()
    End Sub

    Private Sub THoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THoátToolStripMenuItem.Click
        Dim thoat As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If thoat = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
        dangnhap.Show()
    End Sub

    Private Sub QuảnLýThuốcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLýThuốcToolStripMenuItem1.Click
        thuoc.Show()
    End Sub

    Private Sub NhậpThuốcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpThuốcToolStripMenuItem.Click
        themthuoc.Show()
    End Sub

    Private Sub BánThuốcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BánThuốcToolStripMenuItem.Click
        sell.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        hoadon.Show()
    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        danhsachnhanvien.Show()
    End Sub

    Private Sub ThêmNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmNhânViênToolStripMenuItem.Click
        themnhanvien.Show()
    End Sub

    Private Sub SắpXếpCaLàmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SắpXếpCaLàmToolStripMenuItem.Click
        calam.Show()
    End Sub

    Private Sub LịchSửCaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LịchSửCaToolStripMenuItem.Click
        líchuca.Show()
    End Sub
End Class