Public Class PersonService

    Public Sub CreatePerson()
        StorePerson(30, "Gabriel", "Weyer", New DateTime(1984, 10, 19), "Hamburger")
    End Sub

    Private Shared Sub StorePerson(ByVal age As Int32, ByVal firstName As String, ByVal lastName As String, ByVal birthDate As DateTime, ByVal favoriteFood As String)
    End Sub

End Class
