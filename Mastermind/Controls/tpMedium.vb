Public Class tpMedium
    Dim Checked As Integer = 0
    Dim Codes As New List(Of Integer)
    Dim score As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        updateTimesChecked(TimesChecked, 0)
        CreateCode()
    End Sub

    Private Sub updateTimesChecked(obj As Label, add As Integer)
        Checked += add
        obj.Text = Checked.ToString() + " Times Checked"
    End Sub

    Private Sub CreateCode()
        Dim rand As New Random()

        Dim tempCode As Integer = 100
        Dim oldCode As Integer = tempCode

        Static Generator As System.Random = New System.Random()

        For i = 1 To 5

            While tempCode.Equals(oldCode)
                tempCode = Generator.Next(0, 10)
            End While

            Codes.Add(tempCode)
            Debug.WriteLine(i.ToString() + " temp " + tempCode.ToString())
            oldCode = tempCode
            'debug.WriteLine(i.ToString() + " old " + oldCode.ToString())
        Next
    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        updateTimesChecked(TimesChecked, 1)

        score -= 4

        If Cracker1.Value = Codes(0) Then
            Cracker1.Enabled = 0
        End If

        If Cracker2.Value = Codes(1) Then
            Cracker2.Enabled = 0
        End If

        If Cracker3.Value = Codes(2) Then
            Cracker3.Enabled = 0
        End If

        If Cracker4.Value = Codes(3) Then
            Cracker4.Enabled = 0
        End If

        If Cracker5.Value = Codes(4) Then
            Cracker5.Enabled = 0
        End If
    End Sub

    Private Sub ButtonCrack_Click(sender As Object, e As EventArgs) Handles ButtonCrack.Click
        If Cracker1.Value = Codes(0) Then
            CrackerProgress.Value += 20
            Cracker1.Enabled = 0
            score += 1
        End If

        If Cracker2.Value = Codes(1) Then
            CrackerProgress.Value += 20
            Cracker2.Enabled = 0
            score += 1
        End If

        If Cracker3.Value = Codes(2) Then
            CrackerProgress.Value += 20
            Cracker3.Enabled = 0
            score += 1
        End If

        If Cracker4.Value = Codes(3) Then
            CrackerProgress.Value += 20
            Cracker4.Enabled = 0
            score += 1
        End If

        If Cracker5.Value = Codes(4) Then
            CrackerProgress.Value += 20
            Cracker5.Enabled = 0
            score += 1
        End If

        If CrackerProgress.Value.Equals(100) Then
            MsgBox("You won!" + Environment.NewLine + "You Checked the locks " + Checked.ToString() + " Times!")
            endGame(score, "Medium")
            DirectCast(Me.Parent, TabControl).TabPages.RemoveAt(DirectCast(Me.Parent, TabControl).SelectedIndex())
        Else
            MsgBox("You Lost!" + Environment.NewLine + "You didn't crack all the locks!")
            endGame(score, "Medium")
            DirectCast(Me.Parent, TabControl).TabPages.RemoveAt(DirectCast(Me.Parent, TabControl).SelectedIndex())
        End If
    End Sub

    Private Sub endGame(ByVal score As Integer, ByVal difficulty As String)
        Dim resultsBox = New SaveResults(score, difficulty)
        resultsBox.ShowDialog()
    End Sub
End Class
