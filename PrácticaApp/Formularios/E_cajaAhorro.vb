Public Class e_cajaAhorro

    Private banco As New ClsBanco(1, "xy")
    Private ingresoDinero As Integer
    Private retiroDinero As Integer
    Private saldoDisponible As Integer
    Private saldoIncial As Double

    Private Sub e_cajaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub limpiaTextBox()
        txtNombre.Clear()
        txtNumIdentificacion.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtSaldoInicial.Clear()

    End Sub
    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click


        If txtNombre.Text <> "" And txtNumIdentificacion.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtSaldoInicial.Text <> "" Then

            Dim cte As New ClsClientes(txtNombre.Text, txtNumIdentificacion.Text, txtDireccion.Text, txtTelefono.Text)

            Dim saldoInicial As Double = Double.Parse(txtSaldoInicial.Text)


            'banco.cuentaAhorro(cte, saldoInicial)

            limpiaTextBox()
        Else
            MsgBox("Debe completar todos los datos para crear la cuenta")
        End If
        MsgBox("La cuenta fue creada con éxito : ")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiaTextBox()
    End Sub

    Private Sub btnIngresarDinero_Click(sender As Object, e As EventArgs) Handles btnIngresarDinero.Click
        ingresoDinero = InputBox("Ingrese el monto a depositar")
        liIngresos.Items.Add(ingresoDinero)
    End Sub

    Private Sub btnRetirarDinero_Click(sender As Object, e As EventArgs) Handles btnRetirarDinero.Click
        retiroDinero = InputBox("Ingrese el monto a depositar")
        liRetiros.Items.Add(retiroDinero)
    End Sub

    Private Sub btnSaldoDisponible_Click(sender As Object, e As EventArgs) Handles btnSaldoDisponible.Click
        saldoDisponible = saldoIncia

    End Sub

    'saldoDisponible = saldoInicial + ingresoDinero - retiroDinero


End Class