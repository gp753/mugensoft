Imports System.Drawing
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System

Public Class Form2
    Private Sub Association_1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Association_1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        panel_cuentas.Show()
        panel_carga_presupuesto.Hide()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        panel_crear_usuarios.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Panel_mod_user.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim user As String
        Dim ban_login As Integer
        Dim cantidad_usuarios As Integer


        cantidad_usuarios = DataSet1.Tables("usuario").Rows.Count


        ban_login = 0
        If textbox_pass.Text = textbox_rep_pass.Text Then
            For i As Integer = 0 To (cantidad_usuarios - 1)
                user = DataSet1.Tables("usuario").Rows(i).Item("cuenta")

                If textbox_cuenta.Text = user Then
                    ban_login = 2
                End If

            Next
        Else
            ban_login = 1
        End If

        If ComboBox1.Text = "" Then
            ban_login = 4
        End If

        If ban_login = 0 Then
            Dim nuevo_usuario As DataRow = DataSet1.Tables("usuario").NewRow()




            nuevo_usuario("cuenta") = textbox_cuenta.Text
            nuevo_usuario("pass") = textbox_pass.Text
            nuevo_usuario("nombre_usuario") = textbox_nombre.Text
            nuevo_usuario("apellido_usuario") = textbox_apellido.Text
            nuevo_usuario("numero_usuario") = textbox_numero.Text
            nuevo_usuario("mail_usuario") = textbox_mail.Text
            nuevo_usuario("estado_usuario") = True





            If ComboBox1.Text = "Administrador" Then
                nuevo_usuario("nivel") = 1
            ElseIf ComboBox1.Text = "Usuario Normal" Then
                nuevo_usuario("nivel") = 2

            End If
            label_error_crear.Text = "Usuario creado con exito"
            label_error_crear.ForeColor = Color.Green


            DataSet1.Tables("usuario").Rows.Add(nuevo_usuario)
            Me.Validate()
            Me.UsuarioBindingSource.EndEdit()
            UsuarioTableAdapter.Update(DataSet1.usuario)
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        ElseIf ban_login = 1 Then
            label_error_crear.Text = "contraseñas no coinciden"
            label_error_crear.ForeColor = Color.Red

        ElseIf ban_login = 2 Then
            label_error_crear.Text = "usuario ya existe"
            label_error_crear.ForeColor = Color.Red
        ElseIf ban_login = 4 Then
            label_error_crear.Text = "nivel no seleccionado"
            label_error_crear.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        panel_crear_usuarios.Hide()
    End Sub


    Public Structure estructura_usuario
        Dim posicion As Integer

    End Structure

    Dim user_to_mod As estructura_usuario

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim user As String
        Dim pas As String
        Dim ban_login As Integer
        Dim cantidad_usuarios As Integer

        Label23.Text = ""
        Label22.Text = ""

        cantidad_usuarios = DataSet1.Tables("usuario").Rows.Count


        ban_login = 0
        For i As Integer = 0 To (cantidad_usuarios - 1)
            user = DataSet1.Tables("usuario").Rows(i).Item("cuenta")
            pas = DataSet1.Tables("usuario").Rows(i).Item("pass")

            If textbox_mod_cuenta.Text = user And textbox_mod_pass.Text = pas Then
                ban_login = 1
                user_to_mod.posicion = i
            End If

        Next

        If ban_login = 1 Then
            Label21.Text = "Ingreso"
            Label21.ForeColor = Color.Green
            panel_mod_cuenta.Show()
        Else
            Label21.Text = "Usuario o Contraseña incorrecto"
            Label21.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

        If textbox_nueva_pass.Text = texbox_nueva_pass_rep.Text Then
            DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("pass") = textbox_nueva_pass.Text
            Label22.Text = "Contraseña modificada con exito"
            Label22.ForeColor = Color.Green
        Else
            Label22.Text = "Contraseñas no coinciden"
            Label22.ForeColor = Color.Red

        End If

        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        UsuarioTableAdapter.Update(DataSet1.usuario)
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        If TextBox4.Text <> "" Then
            DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("nombre_usuario") = TextBox4.Text
            Label23.Text = "Datos modificados con exito"
            Label23.ForeColor = Color.Green

        End If

        If TextBox3.Text <> "" Then
            DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("apellido_usuario") = TextBox3.Text
            Label23.Text = "Datos modificados con exito"
            Label23.ForeColor = Color.Green

        End If

        If TextBox2.Text <> "" Then
            DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("numero_usuario") = TextBox2.Text
            Label23.Text = "Datos modificados con exito"
            Label23.ForeColor = Color.Green

        End If

        If TextBox1.Text <> "" Then
            DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("mail_usuario") = TextBox1.Text
            Label23.Text = "Datos modificados con exito"
            Label23.ForeColor = Color.Green

        End If

        If ComboBox2.Text <> "" Then

            If ComboBox2.Text = "Adminstrador" Then
                DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("nivel") = 1
                Label23.Text = "Datos modificados con exito"
                Label23.ForeColor = Color.Green
            ElseIf ComboBox2.Text = "Usuario Normal" Then
                DataSet1.Tables("usuario").Rows(user_to_mod.posicion).Item("nivel") = 2
                Label23.Text = "Datos modificados con exito"
                Label23.ForeColor = Color.Green
            End If

        End If

        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        UsuarioTableAdapter.Update(DataSet1.usuario)
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        panel_carga_presupuesto.Show()
        panel_cuentas.Hide()


    End Sub

    Public Structure clien
        Dim name As String
        Dim pos As Integer

    End Structure
    Dim cliente_buscado As clien



    Private Sub Button14_Click(sender As Object, e As EventArgs)

        Dim ban_cliente As Integer
        Dim cantidad_clientes As Integer

        cantidad_clientes = DataSet1.Tables("cliente").Rows.Count
        ban_cliente = 0
        cliente_buscado.name = TextBox5.Text

        If cliente_buscado.name <> "" Then

            For i As Integer = 0 To (cantidad_clientes - 1)
                If DataSet1.Tables("cliente").Rows(i).Item("nombre") = cliente_buscado.name Then
                    Label30.Hide()
                    ban_cliente = 1
                    cliente_buscado.pos = i
                End If
            Next
        Else
            ban_cliente = 2
            Label30.Show()
            Label30.Text = "Campo cliente vacio"
            Label30.ForeColor = Color.Red
        End If

        If ban_cliente = 0 Then
            Label30.Show()
            Label30.Text = "Cliente no encontrado, favor agregue cliente"
            Label30.ForeColor = Color.Red
        ElseIf ban_cliente = 1 Then
            Dim nuevo_presupuesto As DataRow = DataSet1.Tables("pedido").NewRow

            nuevo_presupuesto("id_cliente") = DataSet1.Tables("cliente").Rows(cliente_buscado.pos).Item("id_cliente")
            nuevo_presupuesto("id_usuario") = 1
            nuevo_presupuesto("plazo_entrega") = TextBox6.Text
            nuevo_presupuesto("plazo_cobro") = TextBox7.Text
            nuevo_presupuesto("oferta") = RichTextBox2.Text
            nuevo_presupuesto("precio") = TextBox8.Text
            nuevo_presupuesto("estado") = "pendiente"
            nuevo_presupuesto("nombre_pedido") = TextBox22.Text

            DataSet1.Tables("pedido").Rows.Add(nuevo_presupuesto)

            Label70.Text = "Pedido cargado con exito!"
            Label70.ForeColor = Color.Green
            Label70.Show()


            Me.Validate()
            Me.UsuarioBindingSource.EndEdit()
            PedidoBindingSource.EndEdit()

            PedidoTableAdapter.Update(DataSet1.pedido)
            TableAdapterManager.UpdateAll(Me.DataSet1)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        GroupBox3.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

        Dim ban_error As Integer
        ban_error = 0
        Label39.Hide()
        Label40.Hide()
        Label37.Hide()
        Label38.Hide()

        If TextBox9.Text = "" Then
            ban_error = 1
            Label39.Show()

            Label39.Text = "Favor ingresar nombre del cliente"
            Label39.ForeColor = Color.Red
        End If

        If TextBox12.Text = "" Then
            ban_error = 1
            Label37.Show()

            Label37.Text = "Favor ingresar RUC"
            Label37.ForeColor = Color.Red
        End If

        If TextBox10.Text = "" Then
            ban_error = 1
            Label40.Show()

            Label40.Text = "Favor ingresar apellido del cliente"
            Label40.ForeColor = Color.Red
        End If


        Dim cantidad_clientes As Integer

        cantidad_clientes = DataSet1.Tables("cliente").Rows.Count

        cliente_buscado.name = TextBox9.Text
        Console.WriteLine("estoy aca")

        If cliente_buscado.name <> "" Then

            For i As Integer = 0 To (cantidad_clientes - 1)
                If DataSet1.Tables("cliente").Rows(i).Item("nombre") = cliente_buscado.name Then
                    Label39.Show()
                    ban_error = 1
                    Label39.Text = "El cliente ya existe"
                    Label39.ForeColor = Color.Red
                End If
            Next
        End If

        If ban_error = 0 Then
            Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()


            nuevo_cliente("nombre") = TextBox9.Text
            nuevo_cliente("apellido") = TextBox10.Text

            nuevo_cliente("ruc") = TextBox12.Text
            nuevo_cliente("numero") = TextBox13.Text
            nuevo_cliente("mail") = TextBox14.Text

            DataSet1.Tables("cliente").Rows.Add(nuevo_cliente)

            Validate()
            UsuarioBindingSource.EndEdit()
            ClienteBindingSource.EndEdit()

            ClienteTableAdapter.Update(DataSet1.cliente)


            Label38.Show()
            Label38.Text = "Cliente creado con exito!"
            Label38.ForeColor = Color.Green






        End If
    End Sub



    Private Sub actualizarCalendarios()
        Dim canPedidos As Integer
        Dim entregas, cobros, estado As String
        canPedidos = DataSet1.Tables("pedido").Rows.Count
        calendarioCobro.RemoveAllBoldedDates()
        calendarioEntregas.RemoveAllBoldedDates()
        For i As Integer = 0 To (canPedidos - 1)

            entregas = pedidoGridView.Item(3, i).Value().ToString
            cobros = pedidoGridView.Item(4, i).Value().ToString
            estado = pedidoGridView.Item(7, i).Value().ToString
            If estado = "pendiente" Or estado = "terminado" Then
                calendarioEntregas.AddBoldedDate(entregas)
            End If
            If estado = "entregado" Or estado = "pendiente" Or estado = "terminado" Then
                calendarioCobro.AddBoldedDate(cobros)
            End If
        Next
        calendarioEntregas.UpdateBoldedDates()
        calendarioCobro.UpdateBoldedDates()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub pedidoDataSet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PanelTrabajosPendientes_Paint_1(sender As Object, e As PaintEventArgs) Handles PanelTrabajosPendientes.Paint

    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarioEntregas.DateChanged
        ' MsgBox("la fecha es" + calendarioPedidos.SelectionStart.ToShortDateString)


    End Sub

    Private Sub calendarioEntregas_DateSelected_1(sender As Object, e As DateRangeEventArgs) Handles calendarioEntregas.DateSelected 'el pae

        ' TextEntrega.Text = calendarioEntregas.SelectionStart.Date aca al hacer click buscar clientes
        Dim i As Integer
        Dim pDate As Date
        Dim canPedidos As Integer
        Dim cadena As String = "Proyectos pendientes:" + vbCrLf
        Dim ban As Boolean = False

        canPedidos = DataSet1.Tables("pedido").Rows.Count

        If canPedidos > 0 Then
            For i = 0 To (canPedidos - 1)
                pDate = pedidoGridView.Item(3, i).Value.ToString
                If pDate = calendarioEntregas.SelectionStart Then
                    cadena = cadena + pedidoGridView.Item(8, i).Value.ToString + vbCrLf
                    ban = True
                End If
            Next
            If ban = True Then
                MsgBox(cadena)
            Else
                MsgBox("Sin pedidos")
            End If
        End If

    End Sub

    Private Sub calendarioCobro_DateSelected_1(sender As Object, e As DateRangeEventArgs) Handles calendarioCobro.DateSelected 'el pae
        'TextCobro.Text = calendarioCobro.SelectionStart.Date aca al hacer click buscar cliente
        Dim i As Integer
        Dim pDate As Date
        Dim canPedidos As Integer
        Dim cadena As String = "Proyectos a cobrar:" + vbCrLf
        Dim ban As Boolean = False

        canPedidos = DataSet1.Tables("pedido").Rows.Count

        If canPedidos > 0 Then
            For i = 0 To (canPedidos - 1)
                pDate = pedidoGridView.Item(4, i).Value.ToString
                If pDate = calendarioCobro.SelectionStart Then
                    cadena = cadena + pedidoGridView.Item(8, i).Value.ToString + vbCrLf
                    ban = True
                End If
            Next
            If ban = True Then
                MsgBox(cadena)
            Else
                MsgBox("Sin pedidos")
            End If
        End If
    End Sub

    Private Sub botonBuscar_Click_1(sender As Object, e As EventArgs) Handles botonBuscar.Click 'el pae

        Dim nombreCliente As String
        Dim apellidoCliente As String
        Dim identiCliente As String
        Dim canPedidos As Integer
        Dim canClientes As Integer
        Dim idCliente() As Integer
        Dim nombres() As String
        Dim apellidos() As String
        Dim ban, ban2 As Boolean
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer = 0
        Dim s As Integer
        ban = False
        ban2 = False
        canClientes = DataSet1.Tables("cliente").Rows.Count
        canPedidos = DataSet1.Tables("pedido").Rows.Count

        apellidoCliente = TextApellido.Text
        identiCliente = TextIden.Text
        nombreCliente = TextCliente.Text
        resultadosPedidos.Items.Clear()

        noExiste.Hide()
        sinDatos.Hide()
        noHayPendientes.Hide()
        idClientesAux.Items.Clear()
        'ReDim idCliente(canClientes)
        ReDim idCliente(k + 1)
        idCliente(0) = 0
        MsgBox(canPedidos)
        If canPedidos > 0 And canClientes > 0 Then

            ReDim nombres(canClientes)
            ReDim apellidos(canClientes)
            If nombreCliente <> "" Then
                If apellidoCliente <> "" Then
                    If identiCliente <> "" Then
                        'realizar busqueda en base a los 3
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteGridView.Item(1, i).Value().ToString And apellidoCliente = ClienteGridView.Item(2, i).Value().ToString And identiCliente = ClienteGridView.Item(3, i).Value().ToString Then
                                idCliente(k) = ClienteGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)
                            End If
                        Next
                    Else
                        'realizar busqueda en base a nombre y apellido
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteGridView.Item(1, i).Value().ToString And apellidoCliente = ClienteGridView.Item(2, i).Value().ToString Then
                                idCliente(k) = ClienteGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)

                            End If
                        Next
                    End If
                Else
                    If identiCliente <> "" Then
                        'realizar busqueda en base a nombre e identificacion
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteGridView.Item(1, i).Value().ToString And identiCliente = ClienteGridView.Item(3, i).Value().ToString Then
                                idCliente(k) = ClienteGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)
                            End If
                        Next
                    Else
                        'realizar busqueda en base a nombre 
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteGridView.Item(1, i).Value().ToString Then
                                idCliente(k) = ClienteGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)
                            End If
                        Next
                    End If

                End If
            ElseIf apellidoCliente <> "" Then

                If identiCliente <> "" Then
                    'realizar busqueda en base a apellido e identificacion
                    For i = 0 To (canClientes - 1)
                        If apellidoCliente = ClienteGridView.Item(2, i).Value().ToString And identiCliente = ClienteGridView.Item(3, i).Value().ToString Then
                            idCliente(k) = ClienteGridView.Item(0, i).Value()
                            k = k + 1
                            ReDim Preserve idCliente(k)
                        End If
                    Next
                Else
                    'realizar busqueda en base al apellido
                    For i = 0 To (canClientes - 1)
                        If apellidoCliente = ClienteGridView.Item(2, i).Value().ToString Then
                            idCliente(k) = ClienteGridView.Item(0, i).Value()
                            k = k + 1
                            ReDim Preserve idCliente(k)
                        End If
                    Next
                End If
            Else
                'realizar busqueda en base a la identidad o ruc
                For i = 0 To (canClientes - 1)
                    If identiCliente = ClienteGridView.Item(3, i).Value().ToString Then
                        idCliente(k) = ClienteGridView.Item(0, i).Value()
                        k = k + 1
                        ReDim Preserve idCliente(k)
                    End If
                Next
            End If

            If idCliente(s) = 0 And Not (identiCliente = "" And apellidoCliente = "" And nombreCliente = "") Then
                noExiste.Show()
            End If
            'controla  si hay trabajos pendientes para en cliente buscado
            For s = 0 To (k - 1)
                ban = False
                For j = 0 To (canPedidos - 1)
                    If idCliente(s) = pedidoGridView.Item(1, j).Value() Then
                        For i = 0 To (canClientes - 1)
                            If idCliente(s).ToString = ClienteGridView.Item(0, i).Value().ToString And ban = False Then
                                resultadosPedidos.Items.Add(ClienteGridView.Item(1, i).Value().ToString + " " + ClienteGridView.Item(2, i).Value().ToString + " " + ClienteGridView.Item(3, i).Value().ToString)
                                ban = True
                                idClientesAux.Items.Add(idCliente(s))
                                idCliente(s) = 0
                                i = canClientes
                            End If
                        Next
                    End If
                Next
            Next
            If identiCliente = "" And apellidoCliente = "" And nombreCliente = "" Then
                sinDatos.Show()
                ban = True
            End If
            If ban = False And ban2 = True Then
                noHayPendientes.Show()
            End If

        Else
            MsgBox("No hay clientes que mostrar")

        End If



    End Sub

    Private Sub resultadosPedidos_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles resultadosPedidos.SelectedIndexChanged 'el pae
        Dim i, j As Integer
        Dim idCliente As String
        Dim canClientes As Integer
        Dim canPedidos As Integer
        Dim canElem As Integer
        canElem = pcProyecto.Items.Count - 1
        For j = 0 To canElem
            pcProyecto.Items(j) = ""
        Next
        pcProyecto.Items.Clear()
        ptEntrega.Text = ""
        ptCobro.Text = ""
        ptDescrip.Text = ""
        ptPrecio.Text = ""

        canClientes = DataSet1.Tables("cliente").Rows.Count
        canPedidos = DataSet1.Tables("pedido").Rows.Count
        i = resultadosPedidos.SelectedIndex

        If i > -1 Then
            idCliente = idClientesAux.Items(i).ToString
            If canClientes > 0 Then
                For j = 0 To (canClientes - 1)
                    If idCliente = ClienteGridView.Item(0, j).Value.ToString Then
                        ptNombre.Text = ClienteGridView.Item(1, j).Value.ToString
                        ptApellido.Text = ClienteGridView.Item(2, j).Value.ToString
                        ptRuc.Text = ClienteGridView.Item(3, i).Value.ToString
                    End If
                Next
            End If
            'tiene que poner el nombre del proyecto y no su id esperar a base de datos
            If canPedidos > 0 Then
                For j = 0 To (canPedidos - 1)
                    If idCliente = pedidoGridView.Item(1, j).Value.ToString Then
                        pcProyecto.Items.Add(pedidoGridView.Item(8, j).Value.ToString)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub pcProyecto_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles pcProyecto.SelectedIndexChanged 'el pae
        Dim i, j As Integer
        Dim nProyecto As String
        Dim canClientes As Integer
        Dim canPedidos As Integer

        canClientes = DataSet1.Tables("cliente").Rows.Count
        canPedidos = DataSet1.Tables("pedido").Rows.Count

        i = pcProyecto.SelectedIndex
        nProyecto = pcProyecto.Items(i).ToString
        If canPedidos > 0 Then
            For j = 0 To (canPedidos - 1)
                If nProyecto = pedidoGridView.Item(8, j).Value.ToString Then
                    ptEntrega.Text = pedidoGridView.Item(3, j).Value.ToString
                    ptCobro.Text = pedidoGridView.Item(4, j).Value.ToString
                    ptDescrip.Text = pedidoGridView.Item(5, j).Value.ToString
                    ptPrecio.Text = pedidoGridView.Item(6, j).Value.ToString
                    lbEstado.Text = pedidoGridView.Item(7, j).Value.ToString
                    cambioColorLabelEstado()
                    'falta agregar el estado
                End If
            Next
        End If
    End Sub

    Private Sub pbCambiar_Click_1(sender As Object, e As EventArgs) Handles pbCambiar.Click 'por el pae
        Dim i, j, canPedidos As Integer
        Dim ban As Boolean = False
        Dim estado As String
        Dim proyecto As String

        proyecto = ""
        If pcProyecto.SelectedIndex <> -1 Then
            i = pcEstado.SelectedIndex
            estado = pcEstado.Items(i).ToString
            proyecto = pcProyecto.Items(pcProyecto.SelectedIndex).ToString
            canPedidos = DataSet1.Tables("pedido").Rows.Count

            If canPedidos > 0 Then 'a tener en cuenta que verifique si la base de datos esta vacia
                For j = 0 To (canPedidos - 1)
                    If proyecto = pedidoGridView.Item(8, j).Value.ToString Then
                        'DataSet1.Tables("pendido").Rows(j).Item("estado") = estado
                        DataSet1.Tables("pedido").Rows(j).Item(7) = estado
                        lbEstado.Text = estado
                        cambioColorLabelEstado()
                        ban = True
                    End If
                Next
                If ban = True Then
                    Validate()
                    PedidoTableAdapter.Update(DataSet1.pedido) 'se utiliza para actualizar la base datos a lo tru
                    'revisar problema
                    actualizarCalendarios()
                    MsgBox(" Se cambio el estado del " + proyecto + " a " + estado)
                Else
                    MsgBox("No existe pedido para cambiar el estado")

                End If
            End If
        End If
    End Sub

    Private Sub cambioColorLabelEstado() 'por el pae
        If lbEstado.Text = "pendiente" Then
            lbEstado.ForeColor = Color.Red
        ElseIf lbEstado.Text = "terminado" Then
            lbEstado.ForeColor = Color.Yellow
        ElseIf lbEstado.Text = "entregado" Then
            lbEstado.ForeColor = Color.GreenYellow
        Else
            lbEstado.ForeColor = Color.Green
        End If
    End Sub

    Private Sub pbBorrar_Click(sender As Object, e As EventArgs) Handles pbBorrar.Click 'por el pae
        TextCliente.Text = ""
        TextApellido.Text = ""
        TextIden.Text = ""
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelTrabajosPendientes.Hide()
        panel_carga_presupuesto.Hide()
        PanelTrabajosPendientes.Hide()


        panel_gastos.Show()

    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click

        If TextBox15.Text = "" Or TextBox16.Text = "" Or TextBox17.Text = "" Or TextBox18.Text = "" Then
            Label63.Text = "Favor completar todos los campos requeridos"
            Label63.ForeColor = Color.Red
            Label63.Show()
        Else
            Dim nueva_contabilidad As DataRow = DataSet1.Tables("contabilidad").NewRow()

            Dim nueva_salida As DataRow = DataSet1.Tables("salida").NewRow()


            nueva_contabilidad("descripcion") = TextBox15.Text
            nueva_contabilidad("monto") = TextBox16.Text
            nueva_contabilidad("columna") = "entrada"
            nueva_contabilidad("fecha") = TextBox17.Text

            DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad)
            Dim nueva_contabilidad2 As DataRow = DataSet1.Tables("contabilidad").NewRow()
            nueva_contabilidad2("descripcion") = "caja"
            nueva_contabilidad2("monto") = TextBox16.Text
            nueva_contabilidad2("columna") = "salida"
            nueva_contabilidad2("fecha") = TextBox17.Text
            DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad2)

            Validate()

            ContabilidadBindingSource.EndEdit()
            ContabilidadTableAdapter.Update(DataSet1.contabilidad)
            TableAdapterManager.UpdateAll(Me.DataSet1)

            Label63.Text = "Cuenta agregada con exito!"
            Label63.ForeColor = Color.Green
            Label63.Show()




        End If
    End Sub

    Private Sub panel_carga_presupuesto_Paint(sender As Object, e As PaintEventArgs) Handles panel_carga_presupuesto.Paint

    End Sub

    Private Sub panel_cuentas_Paint(sender As Object, e As PaintEventArgs) Handles panel_cuentas.Paint

    End Sub



    Private Sub btpGenerar_Click_1(sender As Object, e As EventArgs) Handles btpGenerar.Click
        Dim user() As String
        Dim i, k, canUsuario, userId() As Integer
        canUsuario = DataSet1.Tables("usuario").Rows.Count

        graficoPagados.Series.Clear()
        graficoTrabajos.Series.Clear()
        graficoTrabajos.Series.Add("Pendientes")
        graficoTrabajos.Series.Add("Terminados")
        graficoTrabajos.Series.Add("Entregados")
        graficoPagados.Series.Add("Cobrados")
        graficoPagados.Series("Cobrados").ChartType = DataVisualization.Charting.SeriesChartType.Area
        ReDim user(1)
        ReDim userId(1)
        k = 0
        user(0) = ""
        If canUsuario > 0 Then
            For i = 1 To canUsuario - 1
                If controlarRepetidos(user, UsuarioDataGridView.Item(1, i).Value.ToString) Then
                    user(k) = UsuarioDataGridView.Item(1, i).Value.ToString
                    userId(k) = UsuarioDataGridView.Item(0, i).Value
                    'MsgBox(user(k) + userId(k).ToString)
                    k = k + 1
                    ReDim Preserve user(k + 1)
                    ReDim Preserve userId(k + 1)
                End If
            Next
        End If
        ReDim Preserve user(k)
        ReDim Preserve userId(k)
        Dim j, p(k), t(k), en(k), canPedidos As Integer
        Dim entrega, cobrado As Date
        Dim monto As Double
        Dim bandera As Boolean
        bandera = False
        canPedidos = DataSet1.Tables("pedido").Rows.Count
        If canPedidos > 0 Then
            For i = 0 To k - 1
                p(i) = 0
                t(i) = 0
                en(i) = 0

            Next

            'MsgBox(k)
            If user(0) <> "" Then

                For i = 0 To k - 1
                    For j = 0 To canPedidos - 1
                        entrega = pedidoGridView.Item(3, j).Value
                        If userId(i) = pedidoGridView.Item(2, j).Value And entrega.Month = Now.Month Then ' se puede mejorar
                            bandera = True
                            If pedidoGridView.Item(7, j).Value.ToString = "pendiente" Then
                                p(i) = p(i) + 1
                                'MsgBox("entra")
                            ElseIf pedidoGridView.Item(7, j).Value.ToString = "terminado" Then
                                t(i) = t(i) + 1
                            ElseIf pedidoGridView.Item(7, j).Value.ToString = "entregado" Then
                                en(i) = en(i) + 1

                            End If


                        End If
                    Next
                Next
                If bandera Then
                    For i = 0 To k - 1
                        'MsgBox(p(i))

                        If p(i) > 0 Then
                            graficoTrabajos.Series("Pendientes").Points.AddXY(user(i), p(i))

                        End If
                        If t(i) > 0 Then
                            graficoTrabajos.Series("Terminados").Points.AddXY(user(i), t(i))
                        End If
                        If en(i) > 0 Then
                            graficoTrabajos.Series("Entregados").Points.AddXY(user(i), en(i))
                        End If
                        'If c(i) > 0 Then
                        'graficoTrabajos.Series("Cobrados").Points.AddXY(user(i), c(i))
                        'End If
                        graficoTrabajos.AlignDataPointsByAxisLabel()
                    Next

                End If
            Else
                MsgBox("No hay trabajos este mes")
            End If
            bandera = False
            For i = 0 To canPedidos - 1
                cobrado = pedidoGridView.Item(4, i).Value
                monto = pedidoGridView.Item(6, i).Value
                If cobrado.Month = Now.Month Then
                    graficoPagados.Series("Cobrados").Points.AddXY(cobrado, monto)
                    bandera = True
                End If
            Next
            If Not bandera Then
                MsgBox("No hay trabajos cobrados en el mes")
            End If

            Dim imagen1, imagen2 As New Bitmap(400, 230)
            Dim table As New PdfPTable(7)
            Dim table2 As New PdfPTable(7)
            Dim cell As New PdfPCell(New Phrase("                                   Trabajos realizados por los Usuarios"))
            Dim cell2 As New PdfPCell(New Phrase("                                   Trabajos cobrados por los Usuarios"))

            ' Dim base As iTextSharp.text.pdf.BaseFont
            '  Dim fuente As iTextSharp.text.Font
            ' base = FontFactory.GetFont(FontFactory.TIMES_ROMAN, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
            'fuente.Style(base, 12, Font.Italic, Color.Red)
            'MsgBox(Environment.UserName.ToString)
            graficoTrabajos.DrawToBitmap(imagen1, graficoTrabajos.DisplayRectangle)
            imagen1.Save("C:\Users\" + Environment.UserName.ToString + "\AppData\Local\Temp\grafico1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            graficoPagados.DrawToBitmap(imagen2, graficoPagados.DisplayRectangle)
            imagen2.Save("C:\Users\" + Environment.UserName.ToString + "\AppData\Local\Temp\grafico2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            SaveFileDialog1.DefaultExt = "pdf"
            SaveFileDialog1.FileName = "informe"

            cell.Colspan = 7
            cell.HorizontalAlignment = 0
            table.SpacingBefore = 20.0F
            table.SpacingAfter = 30.0F
            table.AddCell(cell)
            table.SetWidths({0.55F, 0.7F, 0.7F, 0.9F, 0.7F, 0.7F, 0.8F})
            If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Try
                    Dim salida1 As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\Users\" + Environment.UserName.ToString + "\AppData\Local\Temp\grafico1.jpg")
                    Dim salida2 As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\Users\" + Environment.UserName.ToString + "\AppData\Local\Temp\grafico2.jpg")
                    Dim DOCUMENTO As New Document
                    Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                    DOCUMENTO.Open()
                    DOCUMENTO.Add(New Paragraph("                                                                 Resumen del mes"))
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    DOCUMENTO.Add(New Paragraph("Estadisticas de trabajos correspondiente a el mes actual"))
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    DOCUMENTO.Add(salida1)
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    table.AddCell("Usuario")
                    table.AddCell("Fecha de Entrega")
                    table.AddCell("Fecha de Cobro")
                    table.AddCell("Descripcion")
                    table.AddCell("Precio")
                    table.AddCell("Nombre del Pedido")
                    table.AddCell("Estado")

                    For i = 0 To canPedidos - 1
                        If pedidoGridView.Item(7, i).Value <> "cobrado" Then
                            For j = 0 To k - 1
                                If pedidoGridView.Item(2, i).Value = userId(j) Then
                                    table.AddCell(user(j).ToString)
                                End If
                            Next
                            table.AddCell(pedidoGridView.Item(3, i).Value.ToString)
                            table.AddCell(pedidoGridView.Item(4, i).Value.ToString)
                            table.AddCell(pedidoGridView.Item(5, i).Value.ToString)
                            table.AddCell(pedidoGridView.Item(6, i).Value.ToString)
                            table.AddCell(pedidoGridView.Item(8, i).Value.ToString)
                            table.AddCell(pedidoGridView.Item(7, i).Value.ToString)
                        End If
                    Next
                    DOCUMENTO.Add(table)
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    DOCUMENTO.Add(salida2)
                    DOCUMENTO.Add(New Paragraph(vbCrLf))
                    cell2.Colspan = 7
                    cell2.HorizontalAlignment = 0
                    table2.SpacingBefore = 20.0F
                    table2.SpacingAfter = 30.0F
                    table2.AddCell(cell2)
                    table2.SetWidths({0.55F, 0.7F, 0.7F, 0.9F, 0.7F, 0.7F, 0.8F})

                    table2.AddCell("Usuario")
                    table2.AddCell("Fecha de Entrega")
                    table2.AddCell("Fecha de Cobro")
                    table2.AddCell("Descripcion")
                    table2.AddCell("Precio")
                    table2.AddCell("Nombre del Pedido")
                    table2.AddCell("Estado")

                    For i = 0 To canPedidos - 1
                        If pedidoGridView.Item(7, i).Value = "cobrado" Then
                            For j = 0 To k - 1
                                If pedidoGridView.Item(2, i).Value = userId(j) Then
                                    table2.AddCell(user(j).ToString)
                                End If
                            Next
                            table2.AddCell(pedidoGridView.Item(3, i).Value.ToString)
                            table2.AddCell(pedidoGridView.Item(4, i).Value.ToString)
                            table2.AddCell(pedidoGridView.Item(5, i).Value.ToString)
                            table2.AddCell(pedidoGridView.Item(6, i).Value.ToString)
                            table2.AddCell(pedidoGridView.Item(8, i).Value.ToString)
                            table2.AddCell(pedidoGridView.Item(7, i).Value.ToString)
                        End If
                    Next
                    DOCUMENTO.Add(table2)
                    DOCUMENTO.Close()
                    MsgBox("Resumen generado con exito")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If





    End Sub

    Private Function controlarRepetidos(ByVal array(), ByVal valor)

        Dim i, n As Integer
        n = array.Length
        For i = 0 To n - 1
            If array(i) = valor Then
                Return False
            End If
        Next
        Return True

    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        panel_cuentas.Hide()
        panel_carga_presupuesto.Hide()
        panel_gastos.Hide()
        PanelTrabajosPendientes.Show()
        actualizarCalendarios()

    End Sub

    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        pcEstado.Items.Add("pendiente") 'no se termino aun 0
        pcEstado.Items.Add("terminado") 'terminado pero no cobrado 1
        pcEstado.Items.Add("entregado") 'entregado pero no cobrado 2
        pcEstado.Items.Add("cobrado")   'cobrado 3
    End Sub
End Class

