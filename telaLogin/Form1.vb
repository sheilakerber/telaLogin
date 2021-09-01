Public Class Form1

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If (txtUsuario.Text = Nothing Or txtSenha.Text = Nothing) Then
            MsgBox("O campo Usuário e Senha devem estar preenchidos.", MsgBoxStyle.Exclamation, "Atenção!")
            Exit Sub
        End If

        If txtUsuario.Text = "ADMIN" And txtSenha.Text = "ABC123" Then
            ' MsgBox("Login efetuado com sucesso!", MsgBoxStyle.OkOnly, "Logado!")
            formMenu.Show()   ' abrir nova tela
            Me.Dispose()      ' fechar tela atual (Me = Form1)
        Else
            MsgBox("Usuário ou senha incorreto. Por favor, verifique seus dados!", MsgBoxStyle.Critical, "Erro ao logar!")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtUsuario.Text = Nothing
        txtSenha.Text = Nothing
    End Sub
End Class
