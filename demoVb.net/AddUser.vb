Public Class AddUser
    Private email As String
    Private ten As String
    Private sdt As String
    Private id As String
    Public Sub New()
    End Sub
    Public Sub New(user As User)
        email = user.Email
        sdt = user.Sdt
        ten = user.Ten
        id = user.Id
    End Sub
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        If id <> Nothing Then
            txtemail.Text = email
            txtsdt.Text = sdt
            txtten.Text = ten
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim user As New User
        Dim addUser As New AddUser
        user.Email = txtemail.Text
        user.Ten = txtten.Text
        user.Sdt = txtsdt.Text
        Dim userController As New UserController
        If id = Nothing Then
            If userController.AddUser(user).Id <> 0 Then
                DialogResult = DialogResult.OK
                addUser.Close()
            End If
        Else
            user.Id = id
            If userController.UpdateUser(user).Id <> 0 Then
                DialogResult = DialogResult.OK
                addUser.Close()
            End If
        End If
    End Sub

    Private Sub cancle_Click(sender As Object, e As EventArgs) Handles cancle.Click
        Me.Close()
    End Sub
End Class