Public Class Introduction

    Public Sub ComputeMean()
        ComputeAverage(1, 2, 3, 5)
    End Sub

    Public Sub ComputeAverage(ByVal valueOne As Int32, ByVal valueTwo As Int32, ByVal valueThree As Int32, ByVal valueFour As Integer)
        Dim index = valueOne + valueThree
        Dim niceValue As Int32 = index + valueFour

        Console.Write("{0}", index)

        Dim logOutput As String = String.Format("Value: {0}", index)
    End Sub

End Class