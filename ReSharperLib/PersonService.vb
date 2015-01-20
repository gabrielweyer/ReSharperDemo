Public Class Person
    Public ReadOnly Property Age() As Integer
        Get
            Return _age
        End Get
    End Property

    Public ReadOnly Property FirstName() As String
        Get
            Return _firstName
        End Get
    End Property

    Public ReadOnly Property LastName() As String
        Get
            Return _lastName
        End Get
    End Property

    Public ReadOnly Property BirthDate() As Date
        Get
            Return _birthDate
        End Get
    End Property

    Public ReadOnly Property FavoriteFood() As String
        Get
            Return _favoriteFood
        End Get
    End Property

    Private _age As Integer
    Private _firstName As String
    Private _lastName As String
    Private _birthDate As Date
    Private _favoriteFood As String

    Public Sub New(ByVal age As Integer, ByVal firstName As String, ByVal lastName As String, ByVal birthDate As Date, ByVal favoriteFood As String)
        _age = age
        _firstName = firstName
        _lastName = lastName
        _birthDate = birthDate
        _favoriteFood = favoriteFood
    End Sub
End Class

Public Class PersonService

    Public Sub CreatePerson()
        StorePerson(New Person(30, "Gabriel", "Weyer", New DateTime(1984, 10, 19), "Hamburger"))
    End Sub

    Private Shared Sub StorePerson(ByVal person As Person)
    End Sub

End Class
