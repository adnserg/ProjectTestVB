Public Class WinAppTest
    Private Sub AccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessToolStripMenuItem.Click
        Access.Show()
        Hide()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MsSqlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsSqlToolStripMenuItem.Click
        MsSql.Show()
        Hide()
    End Sub
End Class
