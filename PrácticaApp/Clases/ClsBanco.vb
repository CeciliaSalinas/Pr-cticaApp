Public Class ClsBanco

    'ATRIBUTOS DE LA CLASE BANCO
    Private numSucursal As Integer
    Private nombreBanco As String
    Private cuentaAhorro As List(Of ClsCuentaAhorro)

    'CONSTRUCTOR DE LA CLASE BANCO
    Public Sub New(numSuc As Integer, nomBan As String)
        numSucursal = numSuc
        nombreBanco = nomBan
        cuentaAhorro = New List(Of ClsCuentaAhorro)
    End Sub

    ''METODO PARA CREAR UNA CUENTA AHORRO, PERO ANTES VERIFICA QUE EL CLIENTE NO TENGA CUENTA YA CREADA
    'Public Sub crearCuentaAhorro(cuenta As ClsClientes, saldoInicial As Double)
    '    Dim existe As Boolean = False

    ''verificamos que el cliente no tenga cuenta creada
    'For i = 0 To cuentaAhorro.Count - 1 Step 1

    '    Dim clienteLista As ClsClientes = cuentaAhorro.Item(i).clienteCuentaAhorro
    '    If
    '            clienteLista.Equals()
    '        End Sub

End Class
