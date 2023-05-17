Public MustInherit Class Person
    Public Overrides Function ToString() As String
        Return "No todas las personas son empleados :o"
    End Function

    Private name_ As String

    Public Property Name() As String
        Get
            Return name_
        End Get
        Set(ByVal value As String)
            name_ = value
        End Set
    End Property

    Private imagePath_ As String

    Public Property ImagePath() As String
        Get
            Return imagePath_
        End Get
        Set(ByVal value As String)
            imagePath_ = value
        End Set
    End Property
End Class
