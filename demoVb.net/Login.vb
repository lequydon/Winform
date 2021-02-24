Public Class Login
    Dim usercontroller As New UserController()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user = usercontroller.Login(txtEmail.Text, txtPass.Text)
        If user IsNot Nothing Then
            Dim list As New Form1()
            list.ShowDialog()
        End If
    End Sub
End Class