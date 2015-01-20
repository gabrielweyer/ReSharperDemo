Public Class Vehicle
    Private _isRunning As Boolean

    Public Property IsRunning As Boolean
        Get
            Return _isRunning
        End Get
        Private Set(value As Boolean)
            _isRunning = value
        End Set
    End Property

    Public Sub StartEngine()
        IsRunning = True
    End Sub

    Public Sub StopEngine()
        IsRunning = False
    End Sub

End Class

Public Class Car
    Inherits Vehicle

    Public Sub GetTicketBySpeedingUp()
    End Sub
End Class

Public Class Tractor
    Inherits Vehicle

    Public Sub Plow()
    End Sub

End Class