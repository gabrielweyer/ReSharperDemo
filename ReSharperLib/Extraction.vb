Public Class Extraction

    Public Sub RepeatCode()

        Dim sumOne As Int32
        Dim listOne = New List(Of Int32) From {1, 2, 3}

        For i As Integer = 0 To listOne.Count
            sumOne += listOne.Item(i)
        Next

        If (sumOne > 6) Then
            Throw New ArgumentOutOfRangeException("The sum is too big")
        End If

        Dim sumTwo As Int32
        Dim listTwo = New List(Of Int32) From {1, 2, 3}

        For i As Integer = 0 To listTwo.Count
            sumTwo += listTwo.Item(i)
        Next

        If (sumTwo > 6) Then
            Throw New ArgumentOutOfRangeException("The sum is too big")
        End If

        Dim sumThree As Int32
        Dim listThree = New List(Of Int32) From {1, 2, 3}

        For i As Integer = 0 To listThree.Count
            sumThree += listThree.Item(i)
        Next

        If (sumThree > 6) Then
            Throw New ArgumentOutOfRangeException("The sum is too big")
        End If

    End Sub

End Class