Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmthemkh
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtAdd.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()


                        save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                        save.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                        save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                        save.Parameters.AddWithValue("@SDT", txtSDT.Text)

                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtMaKH.Text = Nothing
                        txtTenkh.Text = Nothing
                        txtAdd.Text = Nothing
                        txtSDT.Text = Nothing

                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()

    End Sub
End Class