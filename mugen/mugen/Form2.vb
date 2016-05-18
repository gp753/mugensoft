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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        panel_cuentas.Show()
        panel_carga_presupuesto.Hide()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        panel_crear_usuarios.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel_mod_user.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        panel_crear_usuarios.Hide()
    End Sub


    Public Structure estructura_usuario
        Dim posicion As Integer

    End Structure

    Dim user_to_mod As estructura_usuario

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

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

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panel_carga_presupuesto.Show()
        panel_cuentas.Hide()


    End Sub

    Public Structure clien
        Dim name As String
        Dim pos As Integer

    End Structure
    Dim cliente_buscado As clien



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles aceptar_carga_presupuesto.Click

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

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GroupBox3.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Function buscar_en_tablas(tabla As String, columna As String, buscado As String)

        'buscar 
        Dim i As Integer
        Dim cantidad As Integer
        Dim posicion As Integer
        Dim ban As Integer
        ban = 0
        cantidad = DataSet1.Tables(tabla).Rows.Count
        cantidad = cantidad - 1
        For i = 0 To cantidad
            If buscado = DataSet1.Tables(tabla).Rows(i).Item(columna) Then

                posicion = i
                ban = 1
            End If
        Next

        If ban = 0 Then
            posicion = -1 'no se encontro el registro
        End If
        Return posicion


    End Function

    Private Function cargar_venta(code As String, client As String, fecha As String, cantidad As Integer)




        Dim nueva_venta As DataRow = DataSet1.Tables("venta_producto").NewRow
        Dim idproducto As Integer
        idproducto = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "codigo", code)).Item("id_stock_mugen")

        nueva_venta("id_stock_mugen") = idproducto
        nueva_venta("id_cliente") = client
        nueva_venta("fecha_venta") = fecha
        nueva_venta("cantidad") = cantidad


        DataSet1.Tables("venta_producto").Rows.Add(nueva_venta)
        Validate()
        Venta_productoBindingSource.EndEdit()
        Venta_productoTableAdapter.Update(DataSet1.venta_producto)



    End Function

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles venta_guardar.Click

        Dim ban = 0
        'comprobar existencia del cliente

        Dim ruc_cliente As Integer
        ruc_cliente = buscar_en_tablas("cliente", "ruc", text_ruc_venta.Text)
        If ruc_cliente < 0 Then
            ban = 1
            MsgBox("Cliente sin registrar!")
        End If




        'comprobar existencia del producto
        Dim i As Integer

        For i = 0 To DataGridView1.RowCount - 1

            If DataGridView1.Item(0, i).Value IsNot "" Then
                If DataGridView1.Item(3, i).Value = "" Then

                Else
                    If DataGridView1.Item(3, i).Value IsNot "0" Then

                        cargar_venta(DataGridView1.Item(0, i).Value, ruc_cliente, TextBox17.Text, DataGridView1.Item(3, i).Value)


                    End If
                End If
            End If

        Next






        'salida de productos
        'Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()


        'nuevo_cliente("nombre") = TextBox9.Text
        'nuevo_cliente("apellido") = TextBox10.Text

        'nuevo_cliente("ruc") = TextBox12.Text
        'nuevo_cliente("numero") = TextBox13.Text
        'nuevo_cliente("mail") = TextBox14.Text

        'DataSet1.Tables("cliente").Rows.Add(nuevo_cliente)

        'Validate()
        'UsuarioBindingSource.EndEdit()
        'ClienteBindingSource.EndEdit()

        'ClienteTableAdapter.Update(DataSet1.cliente)

        Dim nueva_venta As DataRow = DataSet1.Tables("contabilidad").NewRow





    End Sub

    Private Function cantidad_producto_disponible(idproducto As Integer)
        'funcion que devuelve la cantidad del producto seleccionado disponible
        Dim ingresos As Integer
        Dim salidas As Integer
        Dim i As Integer


        ingresos = 0
        salidas = 0

        For i = 0 To DataSet1.Tables("ingreso_producto").Rows.Count - 1
            If DataSet1.Tables("ingreso_producto").Rows(i).Item("id_stock_mugen") = idproducto Then
                ingresos = ingresos + DataSet1.Tables("ingreso_producto").Rows(i).Item("cantidad_ingreso")
            End If
        Next

        For i = 0 To DataSet1.Tables("venta_producto").Rows.Count - 1

            If DataSet1.Tables("venta_producto").Rows(i).Item("id_stock_mugen") = idproducto Then
                salidas = salidas + DataSet1.Tables("venta_producto").Rows(i).Item("cantidad")
            End If

        Next

        Return ingresos - salidas




    End Function

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim cod As String
        Dim i As Integer
        Dim curen As Integer
        Dim suma As Integer
        Dim iva As Integer
        Dim total As Integer
        Dim idproducto As Integer
        Dim cantidad_product As Integer


        curen = DataGridView1.CurrentRow.Index
        suma = 0

        If (DataGridView1.Item(0, curen).Value = "") Then

        Else
            cod = DataGridView1.Item(0, curen).Value

            For i = 0 To DataSet1.Tables("producto").Rows.Count - 1


                If cod = DataSet1.Tables("producto").Rows(i).Item("codigo") Then

                    DataGridView1.Item(1, curen).Value = DataSet1.Tables("producto").Rows(i).Item("descripcion")
                    DataGridView1.Item(2, curen).Value = DataSet1.Tables("producto").Rows(i).Item("precio_venta")
                    idproducto = DataSet1.Tables("producto").Rows(i).Item("id_stock_mugen")
                Else
                    DataGridView1.Item(0, curen).Value = ""

                    MsgBox("Codigo de producto no existe!")
                End If

            Next
        End If

        If DataGridView1.Item(3, curen).Value = "" Then

        Else
            cantidad_product = cantidad_producto_disponible(idproducto)
            If cantidad_product - DataGridView1.Item(3, curen).Value < 0 Then
                MsgBox("cantidad supera stock")
                DataGridView1.CurrentCell.Value = 0





            End If
            DataGridView1.Item(4, curen).Value = DataGridView1.Item(3, curen).Value * DataGridView1.Item(2, curen).Value
            suma = 0
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(4, i).Value IsNot "" Then
                    suma = suma + DataGridView1.Item(4, i).Value
                    text_sub_total.Text = suma.ToString
                    iva = suma * 0.1
                    text_iva.Text = iva.ToString
                    total = suma + iva

                    text_total.Text = total.ToString
                End If


            Next

        End If

        'ordenar los los grid
        Dim j, k As Integer
        For k = 0 To DataGridView1.RowCount
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(0, i).Value = "" Then
                    If i + 1 < DataGridView1.RowCount Then

                        If DataGridView1.Item(0, i + 1).Value IsNot "" Then
                            For j = 0 To 4
                                DataGridView1.Item(j, i).Value = DataGridView1.Item(j, i + 1).Value
                                DataGridView1.Item(j, i + 1).Value = ""
                            Next
                        End If
                    End If
                End If

            Next
        Next


    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles text_ruc_venta.TextChanged

    End Sub

    Private Function funcion_buscar_cliente(ruc As String)

        Dim cantidad_clientes As Integer
        Dim i As Integer
        Dim salida As Integer
        Dim bandera_salida As Integer

        bandera_salida = 0
        cantidad_clientes = DataSet1.Tables("cliente").Rows.Count
        cantidad_clientes = cantidad_clientes - 1

        For i = 0 To cantidad_clientes
            If ruc = DataSet1.Tables("cliente").Rows(i).Item("ruc") Then
                bandera_salida = 1
                salida = i
            End If
        Next

        If bandera_salida = 0 Then
            salida = -1

        End If

        Return salida

    End Function

    Private Sub TextBox15_LostFocus(sender As Object, e As EventArgs) Handles text_ruc_venta.LostFocus
        Dim ruc As Integer

        ruc = funcion_buscar_cliente(text_ruc_venta.Text)


        If ruc < 0 Then
            label_ruc_venta.Text = "no se econtro cliente"
            label_ruc_venta.ForeColor = Color.Red
            label_ruc_venta.Visible = True



        Else
            label_ruc_venta.Visible = False
            TextBox16.Text = DataSet1.Tables("cliente").Rows(ruc).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(ruc).Item("apellido")
            TextBox17.Text = Date.Now.Date

        End If



    End Sub

    Private Sub boton_vender_Click(sender As Object, e As EventArgs) Handles boton_vender.Click
        panel_vender.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelClientes.Show()
    End Sub

    Private Sub CrearClienteBoton_Click(sender As Object, e As EventArgs) Handles CrearClienteBoton.Click
        GroupBoxCrearClienteasd.Show()
        GroupBoxModificarClienteasd.Hide()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBoxCrearCliente.Clear()
        ApellidoTextBoxCrearCliente.Clear()
        RucTextBoxCrearCliente.Clear()
        NumeroTextBoxCrearCliente.Clear()
        MailTextBoxCrearCliente.Clear()
    End Sub

    Private Sub ModificarClienteBoton_Click(sender As Object, e As EventArgs) Handles ModificarClienteBoton.Click
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Show()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBox1ModificarCliente.Clear()
        ApellidoTextBox1ModificarCliente.Clear()
        RucTextBox1ModificarCliente.Clear()
        NumeroTextBox1ModificarCliente.Clear()
        MailTextBox1ModificarCliente.Clear()
    End Sub

    Private Sub EstadisticasDeClienteBoton_Click(sender As Object, e As EventArgs) Handles EstadisticasDeClienteBoton.Click
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Hide()
        GroupBoxEstadisticasdelCliente.Show()
    End Sub

    Private Sub CrearClienteBotonCrearCliente_Click(sender As Object, e As EventArgs) Handles CrearClienteBotonCrearCliente.Click
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

    Private Sub Button9CrearCliente_Click(sender As Object, e As EventArgs) Handles Button9CrearCliente.Click
        GroupBoxCrearClienteasd.Hide()
    End Sub

    Private Sub Button24ModificarCliente_Click(sender As Object, e As EventArgs) Handles Button24ModificarCliente.Click
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

    Private Sub Button25ModificarCliente_Click(sender As Object, e As EventArgs) Handles Button25ModificarCliente.Click
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

    Private Sub GroupBoxModificarClienteasd_Enter(sender As Object, e As EventArgs) Handles GroupBoxModificarClienteasd.Enter

    End Sub

    Private Sub Button10ModificarCliente_Click(sender As Object, e As EventArgs) Handles Button10ModificarCliente.Click
        GroupBoxModificarClienteasd.Hide()
    End Sub

    Private Sub RucTextBoxCrearCliente_TextChanged(sender As Object, e As EventArgs) Handles RucTextBoxCrearCliente.TextChanged

    End Sub

    Private Sub RucTextBoxCrearCliente_LostFocus(sender As Object, e As EventArgs) Handles RucTextBoxCrearCliente.LostFocus
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

    Private Sub Button15ModificarCliente_Click(sender As Object, e As EventArgs) Handles Button15ModificarCliente.Click
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

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        text_ruc_venta.Clear()
        TextBox16.Clear()
        DataGridView1.Rows.Clear()



    End Sub
End Class