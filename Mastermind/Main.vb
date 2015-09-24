Imports System.ComponentModel

Public Class Main

    Private _currentPage As Int32 = 1

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown

        If e.Button = MouseButtons.Right Then

            Dim tabPageIndex As Integer = 0

            For i As Integer = 0 To TabControl1.TabPages.Count - 1

                If TabControl1.GetTabRect(i).Contains(e.X, e.Y) Then
                    tabPageIndex = i
                    TabMenu.Tag = i
                    Exit For
                End If

            Next
        End If


    End Sub

    Private Sub TabMenu_Opening(sender As Object, e As CancelEventArgs) Handles TabMenu.Opening
        Dim tp As TabPage

        Try
            tp = TabControl1.TabPages(Me.TabMenu.Tag)
            If tp.Text = "Difficulty" Then e.Cancel = True
        Catch exc As Exception
            'Debug.Fail(exc.StackTrace)
            Debug.WriteLine(exc.StackTrace)
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If Me.TabControl1.TabPages.Count >= Convert.ToInt16(Me.TabMenu.Tag) AndAlso Convert.ToInt16(Me.TabMenu.Tag) <> 0 Then
                Me.TabControl1.TabPages.RemoveAt(Convert.ToInt16(Me.TabMenu.Tag))
            End If
        Catch exc As Exception
            'Debug.Fail(exc.StackTrace)
            Debug.WriteLine(exc.StackTrace)
        End Try

    End Sub

    Private Sub ButtonEasy_Click(sender As Object, e As EventArgs) Handles ButtonEasy.Click


        Dim tp As New tpEasy
        TabControl1.TabPages.Add(tp)
        TabControl1.SelectedTab = tp
    End Sub

    Private Sub ButtonMedium_Click(sender As Object, e As EventArgs) Handles ButtonMedium.Click
        Dim tp As New tpMedium
        TabControl1.TabPages.Add(tp)
        TabControl1.SelectedTab = tp
    End Sub

    Private Sub ButtonHard_Click(sender As Object, e As EventArgs) Handles ButtonHard.Click
        Dim tp As New tpHard
        TabControl1.TabPages.Add(tp)
        TabControl1.SelectedTab = tp
    End Sub

    Private Sub ButtonResults_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        Dim lr As New LoadResults()
        lr.ShowDialog()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        If System.IO.File.Exists(References.dirScore) Then
            System.IO.File.Delete(References.dirScore)
            MsgBox("Highscores Deleted")
        Else
            MsgBox("No Highscores to Delete")
        End If
    End Sub
End Class
