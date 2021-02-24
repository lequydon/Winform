Public Class UserController
    Public Function GetUser(id As Integer) As User
        Dim obj As New UserService()
        Return obj.GetUser(id)
    End Function
    Public Function GetListUser() As List(Of User)
        Dim obj As New UserService()
        Return obj.GetListUser()
    End Function
    Public Function DeleteUser(id As Integer) As Boolean
        Dim obj As New UserService()
        Return obj.DeleteUser(id)
    End Function
    Public Function AddUser(user As User) As User
        Dim obj As New UserService()
        Return obj.AddUser(user)
    End Function

    Public Function UpdateUser(user As User) As User
        Dim obj As New UserService()
        Return obj.UpdateUser(user)
    End Function
    Public Function FinUser(keyword As String) As List(Of User)
        Dim obj As New UserService()
        Return obj.FindUser(keyword)
    End Function
    Public Function Login(email As String, pass As String) As User
        Dim obj As New UserService()
        Return obj.Login(email, pass)
    End Function
End Class
