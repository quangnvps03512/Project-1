Imports System.Data.SqlClient
Imports System.Data
Public Class frmkhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

   

    Private Sub khachhang_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvXemkh.DataSource = db.DefaultView
    End Sub




    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        frmthemkh.Show()

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvXemkh.DataSource = db.DefaultView
    End Sub

   

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        frmcapnhatKH.Show()
    End Sub
End Class