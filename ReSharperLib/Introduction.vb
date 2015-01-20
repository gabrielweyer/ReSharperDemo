Public Class Introduction

    Public Sub ComputeMean()
        ComputeAverage(1, 2, 3)
    End Sub

    Public Sub ComputeAverage(ByVal valueOne As Int32, ByVal valueTwo As Int32, ByVal valueThree As Int32)
        Dim niceValue As Int32 = valueOne + valueThree + 5

        Console.Write("{0}", valueOne + valueThree)

        Dim logOutput As String = String.Format("Value: {0}", valueOne + valueThree)
    End Sub

End Class