Imports System.Data.SqlClient
Imports System.Data
Public Class frmsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub sanpham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        frmthemsp.Show()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        frmcapnhatSP.Show()
    End Sub
End Class