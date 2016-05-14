Public Class Form2
    Private Sub Association_1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Association_1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.venta_producto' table. You can move, or remove it, as needed.
        Me.Venta_productoTableAdapter.Fill(Me.DataSet1.venta_producto)
        'TODO: This line of code loads data into the 'DataSet1.usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DataSet1.usuario)
        'TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
        'TODO: This line of code loads data into the 'DataSet1.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.DataSet1.producto)

        'TODO: This line of code loads data into the 'DataSet1.pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.DataSet1.pedido)
        'TODO: This line of code loads data into the 'DataSet1.ingreso_producto' table. You can move, or remove it, as needed.
        Me.Ingreso_productoTableAdapter.Fill(Me.DataSet1.ingreso_producto)
        'TODO: This line of code loads data into the 'DataSet1.contabilidad2' table. You can move, or remove it, as needed.
        Me.Contabilidad2TableAdapter.Fill(Me.DataSet1.contabilidad2)
        'TODO: This line of code loads data into the 'DataSet1.contabilidad' table. You can move, or remove it, as needed.
        Me.ContabilidadTableAdapter.Fill(Me.DataSet1.contabilidad)
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        'TODO: This line of code loads data into the 'DataSet1.association_1' table. You can move, or remove it, as needed.
        Me.Association_1TableAdapter.Fill(Me.DataSet1.association_1)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles EstadisticasDeClienteBoton.Click
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Hide()
        GroupBoxEstadisticasdelCliente.Show()
    End Sub

    Private Sub CrearCliente_Click(sender As Object, e As EventArgs) Handles CrearClienteBoton.Click
        GroupBoxCrearClienteasd.Show()
        GroupBoxModificarClienteasd.Hide()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBoxCrearCliente.Clear()
        ApellidoTextBoxCrearCliente.Clear()
        RucTextBoxCrearCliente.Clear()
        NumeroTextBoxCrearCliente.Clear()
        MailTextBoxCrearCliente.Clear()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24ModificarCliente.Click
        Label1ModificarCliente.Hide()


        If NombreTextBox1ModificarCliente.Text <> "" And ApellidoTextBox1ModificarCliente.Text <> "" And RucTextBox1ModificarCliente.Text <> "" And NumeroTextBox1ModificarCliente.Text <> "" And MailTextBox1ModificarCliente.Text <> "" Then


            Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()

            Dim cantidad_de_clientes As Integer
            cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

            For i As Integer = 0 To (cantidad_de_clientes - 1)
                If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1ModificarCliente.Text Then

                    DataSet1.Tables("cliente").Rows(i).Item("nombre") = NombreTextBox1ModificarCliente.Text
                    DataSet1.Tables("cliente").Rows(i).Item("apellido") = ApellidoTextBox1ModificarCliente.Text
                    DataSet1.Tables("cliente").Rows(i).Item("numero") = NumeroTextBox1ModificarCliente.Text
                    DataSet1.Tables("cliente").Rows(i).Item("mail") = MailTextBox1ModificarCliente.Text
                    If CheckBoxClientePrioritario1ModificarCliente.Checked Then
                        DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True
                    Else
                        DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = False
                    End If

                    i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido
                End If

            Next

            Validate()
            UsuarioBindingSource.EndEdit()
            ClienteTableAdapter.Update(DataSet1.cliente)

            Label1ModificarCliente.Show()
            Label1ModificarCliente.Text = "Cliente Modificado"
            Label1ModificarCliente.ForeColor = Color.Green

        Else
            Label1ModificarCliente.Show()
            Label1ModificarCliente.Text = "Complete los campos vacíos"
            Label1ModificarCliente.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RucTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RucTextBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelClientes.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxEstadisticasdelCliente.Enter

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles ModificarClienteBoton.Click
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Show()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBox1ModificarCliente.Clear()
        ApellidoTextBox1ModificarCliente.Clear()
        RucTextBox1ModificarCliente.Clear()
        NumeroTextBox1ModificarCliente.Clear()
        MailTextBox1ModificarCliente.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9CrearCliente.Click
        GroupBoxCrearClienteasd.Hide()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10ModificarCliente.Click

        GroupBoxModificarClienteasd.Hide()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16Estadisticas.Click
        GroupBoxEstadisticasdelCliente.Hide()

    End Sub

    Private Sub GroupBoxCrearCliente_Enter(sender As Object, e As EventArgs) Handles GroupBoxCrearClienteasd.Enter

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles CrearClienteBotonCrearCliente.Click
        Label72CrearCliente.Hide()


        If NombreTextBoxCrearCliente.Text <> "" And ApellidoTextBoxCrearCliente.Text <> "" And RucTextBoxCrearCliente.Text <> "" And NumeroTextBoxCrearCliente.Text <> "" And MailTextBoxCrearCliente.Text <> "" Then


            Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()

            nuevo_cliente("nombre") = NombreTextBoxCrearCliente.Text
            nuevo_cliente("apellido") = ApellidoTextBoxCrearCliente.Text
            nuevo_cliente("ruc") = RucTextBoxCrearCliente.Text
            nuevo_cliente("numero") = NumeroTextBoxCrearCliente.Text
            nuevo_cliente("mail") = MailTextBoxCrearCliente.Text
            nuevo_cliente("estado_cliente") = True
            If CheckBoxClientePrioritarioCrearCliente.Checked Then
                nuevo_cliente("cliente_prioritario") = True
            Else
                nuevo_cliente("cliente_prioritario") = False
            End If




            DataSet1.Tables("cliente").Rows.Add(nuevo_cliente)

            Validate()
            UsuarioBindingSource.EndEdit()
            ClienteTableAdapter.Update(DataSet1.cliente)

            Label72CrearCliente.Show()
            Label72CrearCliente.Text = "Cliente creado"
            Label72CrearCliente.ForeColor = Color.Green




        Else
            Label72CrearCliente.Show()
            Label72CrearCliente.Text = "Complete los campos vacíos"
            Label72CrearCliente.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RucTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub RucTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles RucTextBoxCrearCliente.TextChanged

    End Sub

    Private Sub RucTextBox_LostFocus(sender As Object, e As EventArgs) Handles RucTextBoxCrearCliente.LostFocus
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado ya esta registrado'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBoxCrearCliente.Text Then

                'Si el cliente está habilitado (no está "borrado)
                If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 1 Then
                    Label72CrearCliente.Show()
                    Label72CrearCliente.Text = "RUC ya registrado"
                    Label72CrearCliente.ForeColor = Color.Red

                    RucTextBoxCrearCliente.Text = ""
                    RucTextBoxCrearCliente.Focus()
                Else
                    MsgBox("El RUC seleccionado pertenece a una cuenta anteriormente eliminada, la misma se ha vuelto a habilitar. Ve a MODIFICAR CLIENTE para cambiar los detalles.")
                    DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 1

                    Validate()
                    UsuarioBindingSource.EndEdit()
                    ClienteTableAdapter.Update(DataSet1.cliente)

                End If




                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido
            Else
                Label72CrearCliente.Hide()
            End If
        Next

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count
        Dim ban_ruc_existe As Integer
        ban_ruc_existe = 0

        Label1ModificarCliente.Text = "entre"
        Label1ModificarCliente.Show()

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado existe'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1ModificarCliente.Text Then
                'Si el cliente está habilitado (no está "borrado)
                If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = True Then
                    Label1ModificarCliente.Hide()

                    RucTextBoxCrearCliente.Text = ""
                    RucTextBoxCrearCliente.Focus()

                    NombreTextBox1ModificarCliente.ReadOnly = False
                    ApellidoTextBox1ModificarCliente.ReadOnly = False
                    NumeroTextBox1ModificarCliente.ReadOnly = False
                    MailTextBox1ModificarCliente.ReadOnly = False

                    NombreTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("nombre")
                    ApellidoTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("apellido")
                    NumeroTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("numero")
                    MailTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("mail")

                    If DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True Then
                        CheckBoxClientePrioritario1ModificarCliente.Checked = True
                    Else
                        CheckBoxClientePrioritario1ModificarCliente.Checked = False
                    End If
                End If
                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                ban_ruc_existe = 1
            End If
        Next

        If ban_ruc_existe = 0 Then
            'Si el ruc ingresado NO existe
            Label1ModificarCliente.Show()
            Label1ModificarCliente.Text = "RUC no registrado"
            Label1ModificarCliente.ForeColor = Color.Red

            RucTextBoxCrearCliente.Text = ""
            RucTextBoxCrearCliente.Focus()

            NombreTextBox1ModificarCliente.Text = ""
            ApellidoTextBox1ModificarCliente.Text = ""
            NumeroTextBox1ModificarCliente.Text = ""
            MailTextBox1ModificarCliente.Text = ""
            CheckBoxClientePrioritario1ModificarCliente.Checked = False

            NombreTextBox1ModificarCliente.ReadOnly = True
            ApellidoTextBox1ModificarCliente.ReadOnly = True
            NumeroTextBox1ModificarCliente.ReadOnly = True
            MailTextBox1ModificarCliente.ReadOnly = True
        End If

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15ModificarCliente.Click
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count
        Dim ban_ruc_existe As Integer
        ban_ruc_existe = 0

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado existe'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1ModificarCliente.Text Then
                'Si el cliente está habilitado (no está "borrado)
                If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 1 Then

                    Label1ModificarCliente.Hide()

                    RucTextBoxCrearCliente.Text = ""
                    RucTextBoxCrearCliente.Focus()

                    NombreTextBox1ModificarCliente.ReadOnly = False
                    ApellidoTextBox1ModificarCliente.ReadOnly = False
                    NumeroTextBox1ModificarCliente.ReadOnly = False
                    MailTextBox1ModificarCliente.ReadOnly = False

                    NombreTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("nombre")
                    ApellidoTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("apellido")
                    NumeroTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("numero")
                    MailTextBox1ModificarCliente.Text = DataSet1.Tables("cliente").Rows(i).Item("mail")

                    If DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True Then
                        CheckBoxClientePrioritario1ModificarCliente.Checked = True
                    Else
                        CheckBoxClientePrioritario1ModificarCliente.Checked = False
                    End If
                Else
                    Label1ModificarCliente.Show()
                    Label1ModificarCliente.Text = "EL CLIENTE NO ESTA HABILITADO"
                    Label1ModificarCliente.ForeColor = Color.Red

                    NombreTextBox1ModificarCliente.Text = ""
                    ApellidoTextBox1ModificarCliente.Text = ""
                    NumeroTextBox1ModificarCliente.Text = ""
                    MailTextBox1ModificarCliente.Text = ""
                    CheckBoxClientePrioritario1ModificarCliente.Checked = False

                    NombreTextBox1ModificarCliente.ReadOnly = True
                    ApellidoTextBox1ModificarCliente.ReadOnly = True
                    NumeroTextBox1ModificarCliente.ReadOnly = True
                    MailTextBox1ModificarCliente.ReadOnly = True
                End If
                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                ban_ruc_existe = 1
            End If
        Next

        If ban_ruc_existe = 0 Then
            'Si el ruc ingresado NO existe
            Label1ModificarCliente.Show()
            Label1ModificarCliente.Text = "RUC no registrado"
            Label1ModificarCliente.ForeColor = Color.Red

            RucTextBoxCrearCliente.Text = ""
            RucTextBoxCrearCliente.Focus()

            NombreTextBox1ModificarCliente.Text = ""
            ApellidoTextBox1ModificarCliente.Text = ""
            NumeroTextBox1ModificarCliente.Text = ""
            MailTextBox1ModificarCliente.Text = ""
            CheckBoxClientePrioritario1ModificarCliente.Checked = False

            NombreTextBox1ModificarCliente.ReadOnly = True
            ApellidoTextBox1ModificarCliente.ReadOnly = True
            NumeroTextBox1ModificarCliente.ReadOnly = True
            MailTextBox1ModificarCliente.ReadOnly = True
        End If

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25ModificarCliente.Click
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado existe'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1ModificarCliente.Text Then
                DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 0
            End If
        Next

        Label1ModificarCliente.Show()
        Label1ModificarCliente.Text = "Cliente Borrado"
        Label1ModificarCliente.ForeColor = Color.Red

        NombreTextBox1ModificarCliente.Text = ""
        ApellidoTextBox1ModificarCliente.Text = ""
        NumeroTextBox1ModificarCliente.Text = ""
        MailTextBox1ModificarCliente.Text = ""
        CheckBoxClientePrioritario1ModificarCliente.Checked = False

        NombreTextBox1ModificarCliente.ReadOnly = True
        ApellidoTextBox1ModificarCliente.ReadOnly = True
        NumeroTextBox1ModificarCliente.ReadOnly = True
        MailTextBox1ModificarCliente.ReadOnly = True

        Validate()
        UsuarioBindingSource.EndEdit()
        ClienteTableAdapter.Update(DataSet1.cliente)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14Estadisticas.Click

    End Sub
End Class