Public Class Login
    Dim usuario1 As String = "User01"
    Dim contra1 As String = "user01"
    Dim usuario2 As String = "Daniell"
    Dim contra2 As String = "nusie"
    Dim usuario3 As String = "adminuser"
    Dim contra3 As String = "asdqweasd"
    Private Sub Entrar_Click(sender As Object, e As EventArgs) Handles Entrar.Click
        If usuario.Text = usuario1 And Contra.Text = contra1 Then
            Me.Hide()
            Sistema.Show()
        ElseIf usuario.Text = usuario2 And Contra.Text = contra2 Then
            Me.Hide()
            Sistema.Show()
        ElseIf usuario.Text = usuario3 And Contra.Text = contra3 Then
            Me.Hide()
            Sistema.Show()
        Else
            MsgBox("Usuario Incorrecto")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
