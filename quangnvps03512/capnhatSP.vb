Imports System.Data.SqlClient
Imports System.Data
Public Class frmcapnhatSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub sanpham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)

        conn.Open()
        load.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub
    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsanpham.CellContentClick
        Dim click As Integer = dgvsanpham.CurrentCell.RowIndex
        txtMasp.Text = dgvsanpham.Item(0, click).Value
        txtTensp.Text = dgvsanpham.Item(1, click).Value
        txtmalsp.Text = dgvsanpham.Item(2, click).Value
        txtmota.Text = dgvsanpham.Item(3, click).Value
        txtsoluong.Text = dgvsanpham.Item(4, click).Value
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM set MASP=@MASP, TENSP=@TENSP, MALSP=@MALSP, MOTA=@MOTA, SOLUONG=@SOLUONG where MASP=@MASP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMasp.Focus()
            If txtMasp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMasp.Focus()
                If txtTensp.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTensp.Focus()
                    If txtmalsp.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtmalsp.Focus()
                        If txtmota.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mô tả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtmota.Focus()
                            If txtsoluong.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MAsp", txtMasp.Text)
                                addupdate.Parameters.AddWithValue("@TENsp", txtTensp.Text)
                                addupdate.Parameters.AddWithValue("@malsp", txtmalsp.Text)
                                addupdate.Parameters.AddWithValue("@mota", txtmota.Text)
                                addupdate.Parameters.AddWithValue("@soluong", txtsoluong.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMasp.Text = Nothing
                                txtTensp.Text = Nothing
                                txtmalsp.Text = Nothing
                                txtmota.Text = Nothing
                                txtsoluong.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()

    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MASP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMasp.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMasp.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMasp.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMasp.Text = Nothing
                    txtTensp.Text = Nothing
                    txtmalsp.Text = Nothing
                    txtmota.Text = Nothing
                    txtsoluong.Text = Nothing

                    'txtMasp.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()
    End Sub

End Class