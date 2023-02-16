Public Class Person

    'atributos de la calse'
    Private _name As String
    Private _birthdate As DateTime?
    Public Property _age As Integer

    'propiedades'
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Birthdate As DateTime?
        Get
            Return _birthdate
        End Get
        Set(ByVal value As DateTime?)
            _birthdate = value
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim _age As Integer
            _age = (DateTime.Now.Year - Birthdate.Value.Year)
            Return _age
        End Get
    End Property

    Public Sub New()
        _name = String.Empty
        _birthdate = Nothing
    End Sub

    Public Sub New(ByVal _name As String, ByVal _birthdate As DateTime?)
        Me._name = _name
        Me._birthdate = _birthdate
    End Sub

    Public Overrides Function ToString() As String
        Return _name.ToUpper() & " " & Age
    End Function
End Class