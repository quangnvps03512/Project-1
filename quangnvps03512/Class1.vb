Imports System.Data.SqlClient
Imports System.Data
Public Class Class1

    Public Class Class1
        Public Function Loadkhachang() As DataSet
            Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)
            Dim db As New DataSet
            conn.Open()
            LoadKH.Fill(db)
            conn.Close()
            Return db
        End Function
        Public Function Loadsanpham() As DataSet
            Dim chuoiketnoi As String = "workstation id=assignment1.mssql.somee.com;packet size=4096;user id=quangnvps03512_SQLLogin_2;pwd=3hmfi6ttco;data source=assignment1.mssql.somee.com;persist security info=False;initial catalog=assignment1"
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim LoadSP As New SqlDataAdapter("select MASP as 'Mã sản phẩm',TENSP as 'Tên sản phẩm', MALSP as 'Mã Loại', MOTA as 'Mô tả' ,SOLUONG as 'Số lượng' from SANPHAM ", conn)
            Dim db As New DataSet
            conn.Open()
            LoadSP.Fill(db)
            conn.Close()
            Return db
        End Function
    End Class
End Class
