Public Class ClsClientes
    Private nombre As String
    Private numIdentificacion As String
    Private direccion As String
    Private telefono As String

    'CONSTRUCTOR DE LA CLASE CLIENTES
    Public Sub New(nom As String, numId As String, dir As String, tel As String)
        nombre = nom
        numIdentificacion = numId
        direccion = dir
        telefono = tel
    End Sub

    Public Property nombreCliente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
End Class
