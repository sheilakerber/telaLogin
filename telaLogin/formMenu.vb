Public Class formMenu
    Private Sub formMenu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Dispose()
        Application.Exit()  ' força a saída da aplicação
    End Sub
End Class