Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmthemsp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@SOLUONG,@MOTA,@MALSP)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtsoluong.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtsoluong.Focus()
                        If txtmota.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mô tả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtmota.Focus()
                            If txtMALOAI.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)



                            Else
                                save.Parameters.AddWithValue("@MASP", txtMASP.Text)
                                save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                                save.Parameters.AddWithValue("@SOLUONG", txtsoluong.Text)
                                save.Parameters.AddWithValue("@MOTA", txtmota.Text)
                                save.Parameters.AddWithValue("@MALSP", txtMALOAI.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMASP.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtsoluong.Text = Nothing
                                txtmota.Text = Nothing
                                txtMALOAI.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()

    End Sub
End Class