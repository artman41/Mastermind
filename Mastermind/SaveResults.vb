Imports System.IO

Public Class SaveResults
    Dim _name As String
    Dim _difficulty As String
    Dim _score As Integer

    Dim _localresults As String

    Public Sub New(ByVal score As Integer, ByVal difficulty As String)

        InitializeComponent()

        Me._score = score
        Me._difficulty = difficulty

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        'DataGridView1.Rows.Add(NameBox.Text, score, difficulty)

        _name = NameBox.Text

        _localresults = String.Format("{0}|{1}|{2}", _name, _score, _difficulty)

        Dim sw As New StreamWriter(References.dirScore, True)

        sw.WriteLineAsync(_localresults)

        sw.Close()

        MsgBox("Score Saved!")
        Me.Close()

    End Sub

    '  For Each rw As DataGridViewRow In Me.DataGridView1.Rows
    '  Dim a As String = String.Format("|{0}|{1}|{2}", rw.Cells("ColName").Value, rw.Cells("ColScore").Value, rw.Cells("coldifficulty").Value)
    '  Next
End Class