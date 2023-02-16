Public Class Contac
    Inherits Person

    Private _telephone As String

    Public Property Telephone As String
        Get
            Return _telephone
        End Get
        Set(value As String)
            _telephone = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _telephone = String.Empty
    End Sub

    Public Sub New(ByVal _name As String, ByVal _birthdate As DateTime?, ByVal _telephone As String)
        MyBase.New(_name, _birthdate)
        Me._telephone = _telephone
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & Telephone
    End Function
End Class