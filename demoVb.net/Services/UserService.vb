

Imports System.Configuration
Imports System.Data.SqlClient

Class UserService
    Implements IUser
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
    Public Function GetUser(id As Integer) As User Implements IUser.GetUser
        Throw New NotImplementedException()
    End Function

    Public Function GetListUser() As List(Of User) Implements IUser.GetListUser
        Dim data As New List(Of User)
        'Dim connectionString As String = "Server=DON-PC;Database=demoVB;User Id=sa;Password=123456"
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "SELECT *
                            FROM [user]"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        Dim dbReader As SqlDataReader
        dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do While dbReader.Read()
            Dim userObj As New User
            'MessageBox.Show(dbReader.GetString(0))
            'userObj.Ten = dbReader.GetString(0)
            'userObj.Email = dbReader.GetString(1)
            'userObj.Sdt = dbReader.GetString(2)
            userObj.Id = Int(dbReader("id"))
            userObj.Ten = dbReader("ten").ToString
            userObj.Email = dbReader("email").ToString
            userObj.Sdt = dbReader("sdt").ToString
            data.Add(userObj)
        Loop
        con.Close() 'đóng kết nối sau khi sử dụng
        Return data
    End Function

    Public Function DeleteUser(id As Integer) As Boolean Implements IUser.DeleteUser
        Dim rowsAffected As Integer = 0
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "delete [user] where [user].id=@id"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        cmd.Parameters.Add(New SqlParameter("@id", id))
        rowsAffected = Int(cmd.ExecuteNonQuery())
        con.Close() 'đóng kết nối sau khi sử dụng
        Return rowsAffected
    End Function

    Public Function AddUser(user As User) As User Implements IUser.AddUser
        Dim userId As Integer = 0
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "insert into  [user] values(@ten,@email,@sdt)SELECT @@IDENTITY"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        cmd.Parameters.Add(New SqlParameter("@ten", user.Ten))
        cmd.Parameters.Add(New SqlParameter("@email", user.Email))
        cmd.Parameters.Add(New SqlParameter("@sdt", user.Sdt))
        userId = Int(cmd.ExecuteScalar())
        user.Id = userId
        con.Close() 'đóng kết nối sau khi sử dụng
        Return user
    End Function

    Public Function UpdateUser(user As User) As User Implements IUser.UpdateUser
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "update [user] set ten=@ten,email=@email,sdt=@sdt where id=@id select @@IDENTITY"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        cmd.Parameters.Add(New SqlParameter("@id", user.Id))
        cmd.Parameters.Add(New SqlParameter("@ten", user.Ten))
        cmd.Parameters.Add(New SqlParameter("@email", user.Email))
        cmd.Parameters.Add(New SqlParameter("@sdt", user.Sdt))
        cmd.ExecuteScalar()
        con.Close() 'đóng kết nối sau khi sử dụng
        Return user
    End Function

    Public Function FindUser(keyWord As String) As List(Of User) Implements IUser.FindUser
        Dim data As New List(Of User)
        keyWord = "%" + keyWord + "%"
        'Dim connectionString As String = "Server=DON-PC;Database=demoVB;User Id=sa;Password=123456"
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "select * from [user] where ten like @keyWord or email like @keyWord or sdt like @keyWord or @keyWord=N''"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@keyWord", keyWord)
        Dim dbReader As SqlDataReader
        dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Do While dbReader.Read()
            Dim userObj As New User
            'MessageBox.Show(dbReader.GetString(0))
            'userObj.Ten = dbReader.GetString(0)
            'userObj.Email = dbReader.GetString(1)
            'userObj.Sdt = dbReader.GetString(2)
            userObj.Id = Int(dbReader("id"))
            userObj.Ten = dbReader("ten").ToString
            userObj.Email = dbReader("email").ToString
            userObj.Sdt = dbReader("sdt").ToString
            data.Add(userObj)
        Loop
        con.Close() 'đóng kết nối sau khi sử dụng
        Return data
    End Function

    Public Function Login(email As String, password As String) As User Implements IUser.Login
        Dim con As New SqlConnection(connectionString)
        con.Open()   'Mở kết nối
        'Code truy vấn, cập nhật dữ dữ liệu ở đây
        Dim cmd = New SqlCommand()
        cmd.CommandText = "login @email,@password"
        cmd.CommandType = System.Data.CommandType.Text
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@password", password)
        Dim dbReader As SqlDataReader
        dbReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dbReader.Read()
        Dim objUser As New User
        Try
            objUser.Id = dbReader("id").ToString
            objUser.Ten = dbReader("ten").ToString
            objUser.Email = dbReader("email").ToString
            objUser.Sdt = dbReader("sdt").ToString
        Catch ex As Exception
            objUser = Nothing
        End Try
        con.Close() 'đóng kết nối sau khi sử dụng
        Return objUser
    End Function
End Class
