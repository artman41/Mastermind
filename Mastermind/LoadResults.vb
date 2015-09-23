Imports System.IO

Public Class LoadResults
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim scores As List(Of String) = loadData()

        Try
            For Each item In scores

                'String.Format("{0}|{1}|{2}", item)

                Dim itemSplit As String()

                itemSplit = item.Split(New Char() {"|"})

                For Each itemx In itemSplit
                    Console.WriteLine(itemx)
                Next

                Me.DataGridView1.Rows.Add(itemSplit(0), itemSplit(1), itemSplit(2))
            Next
        Catch ex As NullReferenceException
            Debug.WriteLine(ex.StackTrace)
        End Try

    End Sub

    Private Function loadData() As List(Of String)
        Dim data As New List(Of String)
        Try
            Dim sr As New StreamReader(References.dirScore)

            Do While sr.Peek() >= 0
                data.Add(sr.ReadLine())
            Loop
            sr.Close()

            Return data
        Catch ex As FileNotFoundException
            MsgBox("No scores detected! Make sure that you've played the game atleast once before!")
            'Dim ls As New List(Of String)
            'ls.Add("NAME|0|DIFFICULTY")
            Return Nothing
        End Try
    End Function
End Class