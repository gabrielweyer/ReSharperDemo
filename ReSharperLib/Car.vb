Public Class Car
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

    Public Sub GetTicketBySpeedingUp()
    End Sub

End Class