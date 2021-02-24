Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New Login
        login.Hide()
        Dim usercontroller As New UserController
        Dim listUser As New List(Of User)
        DataGridView1.AutoGenerateColumns = False
        BindingSource1.DataSource = usercontroller.GetListUser()
        DataGridView1.DataSource = BindingSource1
        'listUser = usercontroller.GetListUser()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim usercontroller As New UserController
        Dim userSelected As User = BindingSource1.Current
        Dim checkUserDeleted = usercontroller.DeleteUser(userSelected.Id)
        If checkUserDeleted = True Then
            BindingSource1.RemoveCurrent()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim addUser As New AddUser()
        If addUser.ShowDialog() = DialogResult.OK Then
            Dim usercontroller As New UserController
            Dim listUser As New List(Of User)
            DataGridView1.AutoGenerateColumns = False
            BindingSource1.DataSource = usercontroller.GetListUser()
            DataGridView1.DataSource = BindingSource1
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim userSelected As User = BindingSource1.Current
        Dim addUser As New AddUser(userSelected)
        If addUser.ShowDialog() = DialogResult.OK Then
            Dim usercontroller As New UserController
            Dim listUser As New List(Of User)
            DataGridView1.AutoGenerateColumns = False
            BindingSource1.DataSource = usercontroller.GetListUser()
            DataGridView1.DataSource = BindingSource1
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim usercontroller As New UserController
        'Dim listUser As New List(Of User)
        DataGridView1.AutoGenerateColumns = False
        BindingSource1.DataSource = usercontroller.FinUser(txtFind.Text)
        DataGridView1.DataSource = BindingSource1
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
