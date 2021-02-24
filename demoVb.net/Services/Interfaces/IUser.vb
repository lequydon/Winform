Public Interface IUser
    Function GetUser(ByVal id As Integer) As User
    Function GetListUser() As List(Of User)
    Function DeleteUser(ByVal id As Integer) As Boolean
    Function AddUser(ByVal user As User) As User
    Function UpdateUser(ByVal user As User) As User
    Function FindUser(ByVal keyWord As String) As List(Of User)
    Function Login(ByVal email As String, ByVal password As String) As User
End Interface
