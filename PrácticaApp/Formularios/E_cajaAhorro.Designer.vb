<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class e_cajaAhorro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDetalleTransaccion = New System.Windows.Forms.Button()
        Me.btnSaldoDisponible = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnIngresarDinero = New System.Windows.Forms.Button()
        Me.liIngresos = New System.Windows.Forms.ListBox()
        Me.liRetiros = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnCrearCuenta)
        Me.GroupBox1.Controls.Add(Me.txtSaldoInicial)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNumIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear cuenta"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(179, 95)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(139, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Location = New System.Drawing.Point(28, 95)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(129, 23)
        Me.btnCrearCuenta.TabIndex = 10
        Me.btnCrearCuenta.Text = "Crear Cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(635, 55)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(110, 20)
        Me.txtSaldoInicial.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(494, 56)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(118, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(332, 57)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(141, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'txtNumIdentificacion
        '
        Me.txtNumIdentificacion.Location = New System.Drawing.Point(178, 57)
        Me.txtNumIdentificacion.Name = "txtNumIdentificacion"
        Me.txtNumIdentificacion.Size = New System.Drawing.Size(141, 20)
        Me.txtNumIdentificacion.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(28, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(129, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(660, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Saldo inicial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(523, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Número de identificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDetalleTransaccion)
        Me.GroupBox2.Controls.Add(Me.btnSaldoDisponible)
        Me.GroupBox2.Controls.Add(Me.btnRetirarDinero)
        Me.GroupBox2.Controls.Add(Me.btnIngresarDinero)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(773, 129)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'btnDetalleTransaccion
        '
        Me.btnDetalleTransaccion.Location = New System.Drawing.Point(602, 52)
        Me.btnDetalleTransaccion.Name = "btnDetalleTransaccion"
        Me.btnDetalleTransaccion.Size = New System.Drawing.Size(143, 50)
        Me.btnDetalleTransaccion.TabIndex = 3
        Me.btnDetalleTransaccion.Text = "Detalle transacción"
        Me.btnDetalleTransaccion.UseVisualStyleBackColor = True
        '
        'btnSaldoDisponible
        '
        Me.btnSaldoDisponible.Location = New System.Drawing.Point(420, 52)
        Me.btnSaldoDisponible.Name = "btnSaldoDisponible"
        Me.btnSaldoDisponible.Size = New System.Drawing.Size(143, 50)
        Me.btnSaldoDisponible.TabIndex = 2
        Me.btnSaldoDisponible.Text = "Saldo Disponible"
        Me.btnSaldoDisponible.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Location = New System.Drawing.Point(210, 52)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(143, 50)
        Me.btnRetirarDinero.TabIndex = 1
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnIngresarDinero
        '
        Me.btnIngresarDinero.Location = New System.Drawing.Point(35, 52)
        Me.btnIngresarDinero.Name = "btnIngresarDinero"
        Me.btnIngresarDinero.Size = New System.Drawing.Size(143, 50)
        Me.btnIngresarDinero.TabIndex = 0
        Me.btnIngresarDinero.Text = "Ingresar Dinero"
        Me.btnIngresarDinero.UseVisualStyleBackColor = True
        '
        'liIngresos
        '
        Me.liIngresos.FormattingEnabled = True
        Me.liIngresos.Location = New System.Drawing.Point(12, 356)
        Me.liIngresos.Name = "liIngresos"
        Me.liIngresos.Size = New System.Drawing.Size(363, 134)
        Me.liIngresos.TabIndex = 2
        '
        'liRetiros
        '
        Me.liRetiros.FormattingEnabled = True
        Me.liRetiros.Location = New System.Drawing.Point(418, 356)
        Me.liRetiros.Name = "liRetiros"
        Me.liRetiros.Size = New System.Drawing.Size(365, 134)
        Me.liRetiros.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Historial de transacciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingresos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Retiros"
        '
        'e_cajaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 518)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.liRetiros)
        Me.Controls.Add(Me.liIngresos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "e_cajaAhorro"
        Me.Text = "Caja de ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNumIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDetalleTransaccion As Button
    Friend WithEvents btnSaldoDisponible As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents btnIngresarDinero As Button
    Friend WithEvents liIngresos As ListBox
    Friend WithEvents liRetiros As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
