Imports System.Drawing
'Imports iTextSharp
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports System.IO
Imports System

Public Class Form2
    Private Sub Association_1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Association_1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.gasto_recurrente' Puede moverla o quitarla según sea necesario.
        Me.Gasto_recurrenteTableAdapter.Fill(Me.DataSet1.gasto_recurrente)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.gasto' Puede moverla o quitarla según sea necesario.
        Me.GastoTableAdapter.Fill(Me.DataSet1.gasto)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.venta_servicio' Puede moverla o quitarla según sea necesario.
        Me.Venta_servicioTableAdapter.Fill(Me.DataSet1.venta_servicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.DataSet1.servicio)
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

        pcEstado.Items.Add("pendiente") 'no se termino aun 0
        pcEstado.Items.Add("terminado") 'terminado pero no cobrado 1
        pcEstado.Items.Add("entregado") 'entregado pero no cobrado 2
        pcEstado.Items.Add("cobrado")   'cobrado 3


    End Sub


    Private Function update_cache()
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.gasto' Puede moverla o quitarla según sea necesario.
        Me.GastoTableAdapter.Fill(Me.DataSet1.gasto)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.venta_servicio' Puede moverla o quitarla según sea necesario.
        Me.Venta_servicioTableAdapter.Fill(Me.DataSet1.venta_servicio)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.DataSet1.servicio)
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

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If datos_loguin.nivel_usuario = 1 Then
            GroupBox4Stock.Hide()
            panel_carga_presupuesto.Hide()
            panel_vender.Hide()
            panel_cuentas.Hide()
            Panel1.Hide()
            PanelClientes.Hide()
            PanelTrabajosPendientes.Hide()
            panelServicios.Hide()
            panel_contabilidad.Hide()
            panel_cuentas.Show()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        panel_crear_usuarios.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel_mod_user.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        update_cache()


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
        update_cache()


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

        update_cache()

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
        If datos_loguin.nivel_usuario <> 2 Then
            Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente) 'despues mejorar esto
            panel_carga_presupuesto.Show()
            GroupBox4Stock.Hide()
            panel_vender.Hide()
            panel_cuentas.Hide()
            Panel1.Hide()
            PanelClientes.Hide()
            PanelTrabajosPendientes.Hide()
            panelServicios.Hide()
            panel_contabilidad.Hide()
        End If
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
                ' If DataSet1.Tables("cliente").Rows(i).Item("nombre") = cliente_buscado.name Then
                'Label30.Hide()
                'ban_cliente = 1
                cliente_buscado.pos = TextBox5.Text
                ban_cliente = 1
                'End If
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




        nueva_venta("n_factura_venta_producto") = n_factura_textbox.Text

        MsgBox("Guardado exitosamente")
        DataSet1.Tables("venta_producto").Rows.Add(nueva_venta)
        Validate()
        Venta_productoBindingSource.EndEdit()
        Venta_productoTableAdapter.Update(DataSet1.venta_producto)






    End Function

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles venta_guardar.Click
        update_cache()
        Dim ban = 0
        'comprobar existencia del cliente
        Dim id_cliente
        Dim ruc_cliente As Integer
        Dim ban_operacion_realizada = 0
        ruc_cliente = buscar_en_tablas("cliente", "ruc", text_ruc_venta.Text)

        Dim caja_seleccionada = seleccion_caja.SelectedIndex
        'empresa 1 es Studio
        'empresa 2 es Libreria
        'empresa 3 es Eliptica

        If caja_seleccionada = -1 Then
            ban = 1
            MsgBox("Favor Seleccione caja")
        End If

        If ruc_cliente < 0 Then
            ban = 1
            MsgBox("Cliente sin registrar!")
        End If

        If buscar_en_tablas("venta_producto", "n_factura_venta_producto", n_factura_textbox.Text) >= 0 Then
            MsgBox("ya existe un registro con esa factura, cree una nueva factura si desea realizar una venta")
        ElseIf ban = 0 Then

            'comprobar existencia del producto
            Dim i As Integer

            For i = 0 To DataGridView1.RowCount - 1

                If DataGridView1.Item(0, i).Value IsNot "" Then
                    If DataGridView1.Item(3, i).Value IsNot Nothing Then

                        If DataGridView1.Item(3, i).Value.ToString = "" Then

                        Else
                            If DataGridView1.Item(3, i).Value IsNot "0" Then
                                id_cliente = DataSet1.Tables("cliente").Rows(ruc_cliente).Item("id_cliente")
                                cargar_venta(DataGridView1.Item(0, i).Value, id_cliente, TextBox17.Text, DataGridView1.Item(3, i).Value)


                                Dim nueva_contabilidad As DataRow = DataSet1.Tables("contabilidad").NewRow
                                nueva_contabilidad("descripcion") = "Venta de " + DataGridView1.Item(3, i).Value.ToString + " " + DataGridView1.Item(1, i).Value.ToString
                                nueva_contabilidad("haber") = DataGridView1.Item(4, i).Value
                                nueva_contabilidad("fecha") = TextBox17.Text
                                nueva_contabilidad("numero_factura") = n_factura_textbox.Text
                                nueva_contabilidad("empresa") = caja_seleccionada
                                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad)
                                Validate()
                                ContabilidadBindingSource.EndEdit()
                                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                                Dim nueva_contabilidad6 As DataRow = DataSet1.Tables("contabilidad2").NewRow
                                nueva_contabilidad6("descripcion_modificacion") = "Venta realizada"
                                nueva_contabilidad6("fecha_modificacion") = TextBox17.Text
                                nueva_contabilidad6("haber2") = DataGridView1.Item(4, i).Value
                                nueva_contabilidad6("fecha2") = TextBox17.Text
                                nueva_contabilidad6("numero_factura2") = n_factura_textbox.Text
                                nueva_contabilidad6("id_usuario") = datos_loguin.id_usuario
                                nueva_contabilidad6("empresa") = caja_seleccionada
                                nueva_contabilidad6("descripcion2") = "Venta de " + DataGridView1.Item(3, i).Value.ToString + " " + DataGridView1.Item(1, i).Value.ToString
                                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad6)
                                Validate()
                                Contabilidad2BindingSource.EndEdit()
                                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)
                                ban_operacion_realizada = 1




                            End If
                        End If
                    End If
                End If


            Next

            If ban_operacion_realizada = 1 Then
                Dim nueva_contabilidad2 As DataRow = DataSet1.Tables("contabilidad").NewRow
                nueva_contabilidad2("descripcion") = "IVA"
                nueva_contabilidad2("haber") = text_iva.Text
                nueva_contabilidad2("fecha") = TextBox17.Text
                nueva_contabilidad2("numero_factura") = n_factura_textbox.Text
                nueva_contabilidad2("empresa") = caja_seleccionada
                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad2)
                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                Dim nueva_contabilidad3 As DataRow = DataSet1.Tables("contabilidad").NewRow
                nueva_contabilidad3("descripcion") = "Caja"
                nueva_contabilidad3("deber") = text_sub_total.Text
                nueva_contabilidad3("fecha") = TextBox17.Text
                nueva_contabilidad3("numero_factura") = n_factura_textbox.Text
                nueva_contabilidad3("empresa") = caja_seleccionada
                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad3)
                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                Dim nueva_contabilidad4 As DataRow = DataSet1.Tables("contabilidad2").NewRow
                nueva_contabilidad4("descripcion_modificacion") = "Venta realizada"
                nueva_contabilidad4("fecha_modificacion") = TextBox17.Text
                nueva_contabilidad4("haber2") = text_iva.Text
                nueva_contabilidad4("fecha2") = TextBox17.Text
                nueva_contabilidad4("numero_factura2") = n_factura_textbox.Text
                nueva_contabilidad4("descripcion2") = "IVA"
                nueva_contabilidad4("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad4("empresa") = caja_seleccionada
                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad4)
                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                Dim nueva_contabilidad5 As DataRow = DataSet1.Tables("contabilidad2").NewRow
                nueva_contabilidad5("descripcion_modificacion") = "Venta realizada"
                nueva_contabilidad5("fecha_modificacion") = TextBox17.Text
                nueva_contabilidad5("deber2") = text_sub_total.Text
                nueva_contabilidad5("fecha2") = TextBox17.Text
                nueva_contabilidad5("numero_factura2") = n_factura_textbox.Text
                nueva_contabilidad5("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad5("descripcion2") = "Caja"
                nueva_contabilidad5("empresa") = caja_seleccionada
                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad5)
                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)
            End If







        End If





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
        Dim ban As Integer
        Dim ban_exist_product As Integer
        ban_exist_product = 0


        curen = DataGridView1.CurrentRow.Index

        suma = 0

        If DataGridView1.CurrentCellAddress.X = 2 Then
            If IsNumeric(DataGridView1.Item(2, curen).Value) Then

            Else
                MsgBox("Ingrese un precio unitario numerico")
                DataGridView1.Item(2, curen).Value = ""
            End If
        End If


        If (DataGridView1.Item(0, curen).Value = "") Then

        ElseIf seleccion_caja.SelectedIndex = 1 Then
            cod = DataGridView1.Item(0, curen).Value

            For i = 0 To DataSet1.Tables("producto").Rows.Count - 1


                If cod = DataSet1.Tables("producto").Rows(i).Item("codigo") Then

                    DataGridView1.Item(1, curen).Value = DataSet1.Tables("producto").Rows(i).Item("descripcion")
                    DataGridView1.Item(2, curen).Value = DataSet1.Tables("producto").Rows(i).Item("precio_venta")
                    idproducto = DataSet1.Tables("producto").Rows(i).Item("id_stock_mugen")
                    ban_exist_product = 1
                End If

            Next
            If ban_exist_product = 0 Then
                DataGridView1.Item(0, curen).Value = ""
                MsgBox("Codigo de producto no existe!")
            End If
        Else
            DataGridView1.Item(1, curen).ReadOnly = False
            DataGridView1.Item(2, curen).ReadOnly = False
        End If

        If DataGridView1.Item(3, curen).Value = "" Then

        Else
            cantidad_product = cantidad_producto_disponible(idproducto)
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(0, i).Value IsNot "" Then
                    If DataGridView1.Item(0, i).Value = 0 Then
                        suma = suma + DataGridView1.Item(4, i).Value
                        text_sub_total.Text = suma.ToString
                        iva = suma * 0.1
                        text_iva.Text = iva.ToString
                        total = suma + iva

                        text_total.Text = total.ToString
                    End If
                End If



            Next

            If IsNumeric(DataGridView1.Item(3, curen).Value) = False Then
                MsgBox("Ingrese numero")
                DataGridView1.Item(3, curen).Value = ""
            Else

                If cantidad_product - DataGridView1.Item(3, curen).Value < 0 And seleccion_caja.SelectedIndex = 1 Then
                    MsgBox("cantidad de " + DataGridView1.Item(1, curen).Value.ToString + " supera stock:  " + cantidad_product.ToString)
                    DataGridView1.CurrentCell.Value = 0
                End If
                If IsNumeric(DataGridView1.Item(2, curen).Value) Then
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
                Else
                    MsgBox("Ingrese un precio unitario numerico")
                    DataGridView1.Item(2, curen).Value = ""
                End If
            End If
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
        Dim venta_producto_tam As Integer
        Dim mayor As Integer
        Dim aux As String


        venta_producto_tam = DataSet1.Tables("venta_producto").Rows.Count - 1

        ruc = funcion_buscar_cliente(text_ruc_venta.Text)
        mayor = 0

        If ruc < 0 Then
            label_ruc_venta.Text = "no se econtro cliente"
            label_ruc_venta.ForeColor = Color.Red
            label_ruc_venta.Visible = True



        Else
            label_ruc_venta.Visible = False
            TextBox16.Text = DataSet1.Tables("cliente").Rows(ruc).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(ruc).Item("apellido")
            TextBox17.Text = Date.Now.Date
            If datos_loguin.nivel_usuario < 3 Then

                If venta_producto_tam >= 0 Then
                    For i = 0 To venta_producto_tam
                        aux = DataSet1.Tables("venta_producto").Rows(i).Item("n_factura_venta_producto")
                        aux = aux.Substring(7)
                        If aux > mayor Then
                            mayor = aux
                        End If
                    Next
                End If
                mayor = mayor + 1

                n_factura_textbox.Text = "00-000-" + mayor.ToString
            ElseIf datos_loguin.nivel_usuario = 3 Then
                n_factura_textbox.Text = "00-000-0000"
            End If
        End If



    End Sub

    Private Sub boton_vender_Click(sender As Object, e As EventArgs) Handles boton_vender.Click
        If datos_loguin.nivel_usuario <> 3 Then
            GroupBox4Stock.Hide()
            panel_carga_presupuesto.Hide()

            panel_cuentas.Hide()
            Panel1.Hide()
            PanelClientes.Hide()
            PanelTrabajosPendientes.Hide()
            panelServicios.Hide()
            panel_contabilidad.Hide()

            panel_vender.Show()
            If seleccion_caja.Items.Count < 1 Then
                If datos_loguin.nivel_usuario = 1 Then
                    seleccion_caja.Items.Add("Studio")
                    seleccion_caja.Items.Add("Libreria")
                    seleccion_caja.Items.Add("Eliptica")
                ElseIf datos_loguin.nivel_usuario = 2 Then
                    seleccion_caja.Items.Add("Studio")
                    seleccion_caja.Items.Add("Libreria")
                End If
            End If
            seleccion_caja.SelectedIndex = 1
        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox4Stock.Hide()
        panel_carga_presupuesto.Hide()
        panel_vender.Hide()

        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Show()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
    End Sub

    Private Sub CrearClienteBoton_Click(sender As Object, e As EventArgs)
        GroupBoxCrearClienteasd.Show()
        GroupBoxModificarClienteasd.Hide()


        NombreTextBoxCrearCliente.Clear()
        ApellidoTextBoxCrearCliente.Clear()
        RucTextBoxCrearCliente.Clear()
        NumeroTextBoxCrearCliente.Clear()
        MailTextBoxCrearCliente.Clear()
    End Sub

    Private Sub ModificarClienteBoton_Click(sender As Object, e As EventArgs)
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Show()


        NombreTextBox1ModificarCliente.Clear()
        ApellidoTextBox1ModificarCliente.Clear()
        RucTextBox1ModificarCliente.Clear()
        NumeroTextBox1ModificarCliente.Clear()
        MailTextBox1ModificarCliente.Clear()
    End Sub

    Private Sub EstadisticasDeClienteBoton_Click(sender As Object, e As EventArgs)
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Hide()

    End Sub

    Private Sub CrearClienteBotonCrearCliente_Click(sender As Object, e As EventArgs)
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

    Private Sub Button9CrearCliente_Click(sender As Object, e As EventArgs)
        GroupBoxCrearClienteasd.Hide()
    End Sub

    Private Sub Button24ModificarCliente_Click(sender As Object, e As EventArgs)
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

    Private Sub Button25ModificarCliente_Click(sender As Object, e As EventArgs)
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

    Private Sub GroupBoxModificarClienteasd_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10ModificarCliente_Click(sender As Object, e As EventArgs)
        GroupBoxModificarClienteasd.Hide()
    End Sub

    Private Sub RucTextBoxCrearCliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub RucTextBoxCrearCliente_LostFocus(sender As Object, e As EventArgs)
    '    Dim cantidad_de_clientes As Integer
    '    cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

    '    For i As Integer = 0 To (cantidad_de_clientes - 1)
    '        'Si el RUC ingresado ya esta registrado'
    '        If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBoxCrearCliente.Text Then

    '            'Si el cliente está habilitado (no está "borrado)
    '            If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 1 Then
    '                Label72CrearCliente.Show()
    '                Label72CrearCliente.Text = "RUC ya registrado"
    '                Label72CrearCliente.ForeColor = Color.Red

    '                RucTextBoxCrearCliente.Text = ""
    '                RucTextBoxCrearCliente.Focus()
    '            Else
    '                MsgBox("El RUC seleccionado pertenece a una cuenta anteriormente eliminada, la misma se ha vuelto a habilitar. Ve a MODIFICAR CLIENTE para cambiar los detalles.")
    '                DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = 1

    '                Validate()
    '                UsuarioBindingSource.EndEdit()
    '                ClienteTableAdapter.Update(DataSet1.cliente)

    '            End If




    '            i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido
    '        Else
    '            Label72CrearCliente.Hide()
    '        End If
    '    Next

    'End Sub

    Private Sub Button15ModificarCliente_Click(sender As Object, e As EventArgs)
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

    Private Sub pbBorrar_Click(sender As Object, e As EventArgs) Handles pbBorrar.Click
        TextCliente.Text = ""
        TextApellido.Text = ""
        TextIden.Text = ""
    End Sub

    Private Sub botonBuscar_Click(sender As Object, e As EventArgs) Handles buscarSerBtn.Click
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
        If canPedidos > 0 And canClientes > 0 Then
            ReDim nombres(canClientes)
            ReDim apellidos(canClientes)
            If nombreCliente <> "" Then
                If apellidoCliente <> "" Then
                    If identiCliente <> "" Then
                        'realizar busqueda en base a los 3
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteDataGridView.Item(1, i).Value().ToString And apellidoCliente = ClienteDataGridView.Item(2, i).Value().ToString And identiCliente = ClienteDataGridView.Item(3, i).Value().ToString Then
                                idCliente(k) = ClienteDataGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)
                            End If
                        Next
                    Else
                        'realizar busqueda en base a nombre y apellido
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteDataGridView.Item(1, i).Value().ToString And apellidoCliente = ClienteDataGridView.Item(2, i).Value().ToString Then
                                idCliente(k) = ClienteDataGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)

                            End If
                        Next
                    End If
                Else
                    If identiCliente <> "" Then
                        'realizar busqueda en base a nombre e identificacion
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteDataGridView.Item(1, i).Value().ToString And identiCliente = ClienteDataGridView.Item(3, i).Value().ToString Then
                                idCliente(k) = ClienteDataGridView.Item(0, i).Value()
                                k = k + 1
                                ReDim Preserve idCliente(k)
                            End If
                        Next
                    Else
                        'realizar busqueda en base a nombre 
                        For i = 0 To (canClientes - 1)
                            If nombreCliente = ClienteDataGridView.Item(1, i).Value().ToString Then
                                idCliente(k) = ClienteDataGridView.Item(0, i).Value()
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
                        If apellidoCliente = ClienteDataGridView.Item(2, i).Value().ToString And identiCliente = ClienteDataGridView.Item(3, i).Value().ToString Then
                            idCliente(k) = ClienteDataGridView.Item(0, i).Value()
                            k = k + 1
                            ReDim Preserve idCliente(k)
                        End If
                    Next
                Else
                    'realizar busqueda en base al apellido
                    For i = 0 To (canClientes - 1)
                        If apellidoCliente = ClienteDataGridView.Item(2, i).Value().ToString Then
                            idCliente(k) = ClienteDataGridView.Item(0, i).Value()
                            k = k + 1
                            ReDim Preserve idCliente(k)
                        End If
                    Next
                End If
            Else
                'realizar busqueda en base a la identidad o ruc
                For i = 0 To (canClientes - 1)
                    If identiCliente = ClienteDataGridView.Item(3, i).Value().ToString Then
                        idCliente(k) = ClienteDataGridView.Item(0, i).Value()
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
                    If idCliente(s) = PedidoDataGridView.Item(1, j).Value() Then
                        For i = 0 To (canClientes - 1)
                            If idCliente(s).ToString = ClienteDataGridView.Item(0, i).Value().ToString And ban = False Then
                                resultadosPedidos.Items.Add(ClienteDataGridView.Item(1, i).Value().ToString + " " + ClienteDataGridView.Item(2, i).Value().ToString + " " + ClienteDataGridView.Item(3, i).Value().ToString)
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

    Private Sub resultadosPedidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles resultadosPedidos.SelectedIndexChanged
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
                    If idCliente = ClienteDataGridView.Item(0, j).Value.ToString Then
                        ptNombre.Text = ClienteDataGridView.Item(1, j).Value.ToString
                        ptApellido.Text = ClienteDataGridView.Item(2, j).Value.ToString
                        ptRuc.Text = ClienteDataGridView.Item(3, i).Value.ToString
                    End If
                Next
            End If
            'tiene que poner el nombre del proyecto y no su id esperar a base de datos
            If canPedidos > 0 Then
                For j = 0 To (canPedidos - 1)
                    If idCliente = PedidoDataGridView.Item(1, j).Value.ToString Then
                        pcProyecto.Items.Add(PedidoDataGridView.Item(8, j).Value.ToString)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub pcProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pcProyecto.SelectedIndexChanged
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
                If nProyecto = PedidoDataGridView.Item(8, j).Value.ToString Then
                    ptEntrega.Text = PedidoDataGridView.Item(3, j).Value.ToString
                    ptCobro.Text = PedidoDataGridView.Item(4, j).Value.ToString
                    ptDescrip.Text = PedidoDataGridView.Item(5, j).Value.ToString
                    ptPrecio.Text = PedidoDataGridView.Item(6, j).Value.ToString
                    lbEstado.Text = PedidoDataGridView.Item(7, j).Value.ToString
                    cambioColorLabelEstado()
                    'falta agregar el estado
                End If
            Next
        End If
    End Sub

    Private Sub pbCambiar_Click(sender As Object, e As EventArgs) Handles pbCambiar.Click
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
                    If proyecto = PedidoDataGridView.Item(8, j).Value.ToString Then
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

    Private Sub btpGenerar_Click(sender As Object, e As EventArgs) Handles btpGenerar.Click
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
        Dim bandera, bandera2 As Boolean
        bandera = bandera2 = False
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
                        entrega = PedidoDataGridView.Item(3, j).Value
                        If userId(i) = PedidoDataGridView.Item(2, j).Value And entrega.Month = Now.Month Then ' se puede mejorar
                            bandera = True
                            If PedidoDataGridView.Item(7, j).Value.ToString = "pendiente" Then
                                p(i) = p(i) + 1
                                'MsgBox("entra")
                            ElseIf PedidoDataGridView.Item(7, j).Value.ToString = "terminado" Then
                                t(i) = t(i) + 1
                            ElseIf PedidoDataGridView.Item(7, j).Value.ToString = "entregado" Then
                                en(i) = en(i) + 1

                            End If
                        End If
                    Next
                Next
                If bandera Then
                    For i = 0 To k - 1
                        'MsgBox(p(i))
                        bandera2 = True
                        If p(i) > 0 Then
                            graficoTrabajos.Series("Pendientes").Points.AddXY(user(i), p(i))

                        End If
                        If t(i) > 0 Then
                            graficoTrabajos.Series("Terminados").Points.AddXY(user(i), t(i))
                        End If
                        If en(i) > 0 Then
                            graficoTrabajos.Series("Entregados").Points.AddXY(user(i), en(i))
                        End If

                        graficoTrabajos.AlignDataPointsByAxisLabel()
                    Next

                End If
            Else
                MsgBox("No hay trabajos este mes")
            End If
            bandera = False
            For i = 0 To canPedidos - 1
                cobrado = PedidoDataGridView.Item(4, i).Value
                monto = PedidoDataGridView.Item(6, i).Value
                If cobrado.Month = Now.Month Then
                    graficoPagados.Series("Cobrados").Points.AddXY(cobrado, monto)
                    bandera = True
                End If
            Next
            If Not bandera Then
                MsgBox("No hay trabajos cobrados en el mes")
            End If

            Dim y As Integer
            y = 0
            If bandera2 Then
                For i = 0 To canPedidos - 1
                    If PedidoDataGridView.Item(7, i).Value <> "cobrado" Then
                        For j = 0 To k - 1
                            If PedidoDataGridView.Item(2, i).Value = userId(j) Then
                                DataGridViewTrabajos.Item(0, y).Value = user(j).ToString
                            End If
                        Next
                        DataGridViewTrabajos.Item(1, y).Value = PedidoDataGridView.Item(8, i).Value.ToString()
                        DataGridViewTrabajos.Item(2, y).Value = PedidoDataGridView.Item(3, i).Value.ToString()
                        DataGridViewTrabajos.Item(3, y).Value = PedidoDataGridView.Item(4, i).Value.ToString()
                        DataGridViewTrabajos.Item(4, y).Value = PedidoDataGridView.Item(5, i).Value.ToString()
                        DataGridViewTrabajos.Item(5, y).Value = PedidoDataGridView.Item(6, i).Value.ToString()
                        DataGridViewTrabajos.Item(6, y).Value = PedidoDataGridView.Item(7, i).Value.ToString()
                        DataGridViewTrabajos.Rows.Add()
                        y = y + 1
                        resulTrabajos.Show()
                        PanelTrabajosPendientes.Hide()
                    End If
                Next
            End If
            If bandera Then
                y = 0
                For i = 0 To canPedidos - 1
                    If PedidoDataGridView.Item(7, i).Value = "cobrado" Then
                        For j = 0 To k - 1
                            If PedidoDataGridView.Item(2, i).Value = userId(j) Then
                                DataGridViewTrabajos.Item(0, y).Value = user(j).ToString
                            End If
                        Next
                        DataGridViewCobrados.Item(1, y).Value = PedidoDataGridView.Item(8, i).Value.ToString()
                        DataGridViewCobrados.Item(2, y).Value = PedidoDataGridView.Item(3, i).Value.ToString()
                        DataGridViewCobrados.Item(3, y).Value = PedidoDataGridView.Item(4, i).Value.ToString()
                        DataGridViewCobrados.Item(4, y).Value = PedidoDataGridView.Item(5, i).Value.ToString()
                        DataGridViewCobrados.Rows.Add()
                        y = y + 1
                    End If
                Next

            End If
            'las cosas terminan aca
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



    Private Sub calendarioEntregas_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarioEntregas.DateSelected
        ' TextEntrega.Text = calendarioEntregas.SelectionStart.Date aca al hacer click buscar clientes
        Dim i As Integer
        Dim pDate As Date
        Dim canPedidos As Integer
        Dim cadena As String = "Proyectos pendientes:" + vbCrLf
        Dim ban As Boolean = False

        canPedidos = DataSet1.Tables("pedido").Rows.Count

        If canPedidos > 0 Then
            For i = 0 To (canPedidos - 1)
                pDate = PedidoDataGridView.Item(3, i).Value.ToString
                If pDate = calendarioEntregas.SelectionStart Then
                    cadena = cadena + PedidoDataGridView.Item(8, i).Value.ToString + vbCrLf
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



    Private Sub calendarioCobro_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarioCobro.DateSelected
        'TextCobro.Text = calendarioCobro.SelectionStart.Date aca al hacer click buscar cliente
        Dim i As Integer
        Dim pDate As Date
        Dim canPedidos As Integer
        Dim cadena As String = "Proyectos a cobrar:" + vbCrLf
        Dim ban As Boolean = False

        canPedidos = DataSet1.Tables("pedido").Rows.Count

        If canPedidos > 0 Then
            For i = 0 To (canPedidos - 1)
                pDate = PedidoDataGridView.Item(4, i).Value.ToString
                If pDate = calendarioCobro.SelectionStart Then
                    cadena = cadena + PedidoDataGridView.Item(8, i).Value.ToString + vbCrLf
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

    Private Sub actualizarCalendarios()
        Dim canPedidos As Integer
        Dim entregas, cobros, estado As String
        canPedidos = DataSet1.Tables("pedido").Rows.Count
        calendarioCobro.RemoveAllBoldedDates()
        calendarioEntregas.RemoveAllBoldedDates()
        For i As Integer = 0 To (canPedidos - 1)

            entregas = PedidoDataGridView.Item(3, i).Value().ToString
            cobros = PedidoDataGridView.Item(4, i).Value().ToString
            estado = PedidoDataGridView.Item(7, i).Value().ToString
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        update_cache()


        GroupBox4Stock.Hide()
        panel_carga_presupuesto.Hide()
        panel_vender.Hide()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
        PanelTrabajosPendientes.Show()
        actualizarCalendarios()

    End Sub

    Private Sub boton_stock_Click(sender As Object, e As EventArgs) Handles boton_stock.Click
        panel_carga_presupuesto.Hide()
        panel_vender.Hide()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
        GroupBox4Stock.Show()
    End Sub

    Private Sub Button24NuevoProducto_Click(sender As Object, e As EventArgs)

        panel_carga_presupuesto.Hide()
        panel_vender.Hide()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()

        GroupBoxNuevoProducto.Show()


        GroupBoxIngresodeProducto.Text = ""
        GroupBoxModificarProducto.Text = ""


        TextBoxCodigo.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecio.Clear()
    End Sub



    Private Sub GroupBox4Stock_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Show()
    End Sub

    Private Sub ButtonCrearProducto_Click(sender As Object, e As EventArgs)
        LabelNuevoProducto.Hide()

        If TextBoxCodigo.Text <> "" And TextBoxDescripcion.Text <> "" And TextBoxPrecio.Text <> "" Then
            Dim nuevo_producto As DataRow = DataSet1.Tables("producto").NewRow()

            nuevo_producto("codigo") = TextBoxCodigo.Text
            nuevo_producto("descripcion") = TextBoxDescripcion.Text
            nuevo_producto("precio_venta") = TextBoxPrecio.Text

            DataSet1.Tables("producto").Rows.Add(nuevo_producto)

            Validate()
            UsuarioBindingSource.EndEdit()
            ProductoTableAdapter.Update(DataSet1.producto)

            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Producto creado"
            LabelNuevoProducto.ForeColor = Color.Green


        Else
            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Complete los campos vacíos"
            LabelNuevoProducto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonCerrar1_Click(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Hide()
    End Sub



    Private Sub ButtonCerrar2_Click(sender As Object, e As EventArgs)
        GroupBoxIngresodeProducto.Hide()
    End Sub

    Private Sub ButtonCerrar3_Click(sender As Object, e As EventArgs)

        GroupBoxModificarProducto.Hide()
    End Sub

    Private Sub TextBoxProveedor_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBoxCodigo_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Mostrar_contabilidad_Click(sender As Object, e As EventArgs) Handles Mostrar_contabilidad.Click


        Dim empresa_seleccionada As Integer

        empresa_seleccionada = seleccionar_empresa.SelectedIndex



        Dim i As Integer
        Dim cant_cont As Integer


        If view_contable.Rows.Count > 0 Then
            view_contable.Rows.Clear()
        End If
        view_contable.Rows.Add()




        cant_cont = DataSet1.Tables("contabilidad").Rows.Count - 1

        If empresa_seleccionada > -1 Then
            For i = 0 To cant_cont

                If empresa_seleccionada = 3 Then
                    If DataSet1.Tables("contabilidad").Rows(i).Item("empresa") < 2 Then
                        view_contable.Item(0, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("fecha")
                        view_contable.Item(1, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("descripcion")

                        If IsNumeric(DataSet1.Tables("contabilidad").Rows(i).Item("haber")) Then
                            view_contable.Item(3, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("haber")
                        End If

                        If IsNumeric(DataSet1.Tables("contabilidad").Rows(i).Item("deber")) Then
                            view_contable.Item(2, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("deber")
                        End If

                        view_contable.Item(4, i).Value = 0
                        view_contable.Rows.Add()
                    End If
                ElseIf DataSet1.Tables("contabilidad").Rows(i).Item("empresa") = empresa_seleccionada Then
                    view_contable.Item(0, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("fecha")
                    view_contable.Item(1, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("descripcion")

                    If IsNumeric(DataSet1.Tables("contabilidad").Rows(i).Item("haber")) Then
                        view_contable.Item(3, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("haber")
                    End If

                    If IsNumeric(DataSet1.Tables("contabilidad").Rows(i).Item("deber")) Then
                        view_contable.Item(2, i).Value = DataSet1.Tables("contabilidad").Rows(i).Item("deber")
                    End If

                    view_contable.Item(4, i).Value = 0
                    view_contable.Rows.Add()
                End If
            Next
        End If

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim desde As String
        Dim hasta As String

        desde = fecha_desde.Value
        desde = desde.Substring(0, 10)

        hasta = fecha_hasta.Value
        hasta = hasta.Substring(0, 10)

        MsgBox("desde " + desde + " hasta " + hasta)
    End Sub

    Private Sub Button24NuevoProducto_Click_1(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Show()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Hide()

        GroupBoxIngresodeProducto.Text = ""
        GroupBoxModificarProducto.Text = ""


        TextBoxCodigo.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecio.Clear()
    End Sub

    Private Sub Button25_Click_1(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Show()
        GroupBoxModificarProducto.Hide()
        LabelIngresoProducto.Hide()

        TextBoxProveedor.Text = ""
        TextBoxDeshabilitado2.Text = ""
        TextBoxIDStockMugen.Text = ""
        TextBoxDeshabilitado3.Text = ""
        TextBoxNroFactura.Text = ""
        TextBoxCantidad.Text = ""
        TextBoxPreciodeCompra.Text = ""
        TextBoxPrecioUnitario.Text = ""

        TextBoxFecha.Text = Date.Today

    End Sub

    Private Sub Button26_Click_1(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Show()
    End Sub

    Private Sub TextBoxCodigo_TextChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub ButtonCrearProducto_Click_1(sender As Object, e As EventArgs)
        LabelNuevoProducto.Hide()

        If TextBoxCodigo.Text <> "" And TextBoxDescripcion.Text <> "" And TextBoxPrecio.Text <> "" Then
            Dim nuevo_producto As DataRow = DataSet1.Tables("producto").NewRow()

            nuevo_producto("codigo") = TextBoxCodigo.Text
            nuevo_producto("descripcion") = TextBoxDescripcion.Text
            nuevo_producto("precio_venta") = TextBoxPrecio.Text

            DataSet1.Tables("producto").Rows.Add(nuevo_producto)

            Validate()
            UsuarioBindingSource.EndEdit()
            ProductoTableAdapter.Update(DataSet1.producto)

            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Producto creado"
            LabelNuevoProducto.ForeColor = Color.Green


        Else
            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Complete los campos vacíos"
            LabelNuevoProducto.ForeColor = Color.Red
        End If

    End Sub

    Private Sub ButtonCerrar1_Click_1(sender As Object, e As EventArgs)
        GroupBoxNuevoProducto.Hide()

    End Sub

    Private Sub TextBoxProveedor_TextChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBoxIDStockMugen_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBoxFecha_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBoxCantidad_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBoxPreciodeCompra_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxPreciodeCompra_MouseWheel(sender As Object, e As MouseEventArgs)
        LabelIngresoProducto.Hide()
        If IsNumeric(TextBoxPreciodeCompra.Text) = False Then
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Ingrese un número"
            LabelIngresoProducto.ForeColor = Color.Red

            TextBoxPreciodeCompra.Text = ""
            TextBoxPreciodeCompra.Focus()
        End If

    End Sub

    Private Sub TextBoxPrecioUnitario_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ButtonInsertarProducto_Click_1(sender As Object, e As EventArgs)
        LabelIngresoProducto.Hide()

        If TextBoxProveedor.Text <> "" And TextBoxDeshabilitado2.Text <> "" And TextBoxIDStockMugen.Text <> "" And TextBoxDeshabilitado3.Text <> "" And TextBoxFecha.Text <> "" And TextBoxNroFactura.Text <> "" And TextBoxCantidad.Text <> "" And TextBoxPreciodeCompra.Text <> "" And TextBoxPrecioUnitario.Text <> "" Then
            Dim nuevo_ingreso_producto As DataRow = DataSet1.Tables("ingreso_producto").NewRow()


            nuevo_ingreso_producto("id_proveedor") = DataSet1.Tables("proveedor").Rows(buscar_en_tablas("proveedor", "ruc_proveedor", TextBoxProveedor.Text)).Item("id_proveedor")
            nuevo_ingreso_producto("id_stock_mugen") = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "codigo", TextBoxIDStockMugen.Text)).Item("id_stock_mugen")
            nuevo_ingreso_producto("fecha_ingreso") = TextBoxFecha.Text
            nuevo_ingreso_producto("numero_factura_ingreso") = TextBoxNroFactura.Text
            nuevo_ingreso_producto("cantidad_ingreso") = TextBoxCantidad.Text
            nuevo_ingreso_producto("precio_compra") = TextBoxPreciodeCompra.Text
            nuevo_ingreso_producto("precio_compra_unitario") = TextBoxPrecioUnitario.Text

            DataSet1.Tables("ingreso_producto").Rows.Add(nuevo_ingreso_producto)

            Validate()
            Ingreso_productoBindingSource.EndEdit()
            Ingreso_productoTableAdapter.Update(DataSet1.ingreso_producto)

            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Producto creado"
            LabelIngresoProducto.ForeColor = Color.Green


        Else
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Complete los campos vacíos"
            LabelIngresoProducto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonCerrar2_Click_1(sender As Object, e As EventArgs)
        GroupBoxIngresodeProducto.Hide()

    End Sub

    Private Sub ButtonBuscara_Click(sender As Object, e As EventArgs)
        Dim cantidad_de_productos As Integer
        cantidad_de_productos = DataSet1.Tables("producto").Rows.Count
        Dim ban_productos_existe As Integer
        ban_productos_existe = 0

        For i As Integer = 0 To (cantidad_de_productos - 1)
            'Si el PRODUCTO ingresado existe'
            If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxCodigo2.Text Then

                LabelModificarProducto.Hide()

                'RucTextBoxCrearCliente.Text = ""
                'RucTextBoxCrearCliente.Focus()

                TextBoxDescripcion2.ReadOnly = False
                TextBoxPrecio2.ReadOnly = False


                TextBoxDescripcion2.Text = DataSet1.Tables("producto").Rows(i).Item("descripcion")
                TextBoxPrecio2.Text = DataSet1.Tables("producto").Rows(i).Item("precio_venta")

                i = cantidad_de_productos - 1 'Para cortar el FOR

                ban_productos_existe = 1
            End If
        Next

        If ban_productos_existe = 0 Then
            'Si el producto ingresado NO existe
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Producto no registrado"
            LabelModificarProducto.ForeColor = Color.Red

            TextBoxCodigo2.Text = ""
            TextBoxCodigo2.Focus()

            TextBoxDescripcion2.Text = ""
            TextBoxPrecio2.Text = ""

            TextBoxDescripcion2.ReadOnly = True
            TextBoxPrecio2.ReadOnly = True
        End If

    End Sub

    Private Sub ButtonModificarProducto_Click(sender As Object, e As EventArgs)
        LabelModificarProducto.Hide()

        If TextBoxCodigo2.Text <> "" And TextBoxDescripcion2.Text <> "" And TextBoxPrecio2.Text <> "" Then

            Dim nuevo_producto As DataRow = DataSet1.Tables("producto").NewRow()

            Dim cantidad_de_productos As Integer
            cantidad_de_productos = DataSet1.Tables("producto").Rows.Count

            For i As Integer = 0 To (cantidad_de_productos - 1)
                If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxCodigo2.Text Then

                    DataSet1.Tables("producto").Rows(i).Item("descripcion") = TextBoxDescripcion2.Text
                    DataSet1.Tables("producto").Rows(i).Item("precio_venta") = TextBoxPrecio2.Text

                    i = cantidad_de_productos - 1 'Para cortar el FOR, ya que se encontró RUC repetido
                End If

            Next

            Validate()
            ProductoBindingSource.EndEdit()
            ProductoTableAdapter.Update(DataSet1.producto)

            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Producto Modificado"
            LabelModificarProducto.ForeColor = Color.Green

        Else
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Complete los campos vacíos"
            LabelModificarProducto.ForeColor = Color.Red
        End If

    End Sub

    Private Sub ButtonCerrar3_Click_1(sender As Object, e As EventArgs)

        GroupBoxModificarProducto.Hide()
    End Sub
    Private Sub mostrarErrores(ByRef label As Object, ByVal mensaje As String, ByVal codigoError As Boolean) ' para mostrar los labels que sirven para indicar errores

        ' 0 no hay error ocultar labels 1 hay error pintar de rojo y cargar mensaje
        If codigoError Then
            label.Text = mensaje
            label.BackColor = Color.Red
            label.Show()
        Else
            label.Hide()
        End If

    End Sub
    Private Sub serBusBtn_Click(sender As Object, e As EventArgs) Handles serBusBtn.Click

        'nueva puerquesa
        Dim i, j, k, s As Integer
        Dim resul As String
        Dim bandera As Boolean = False

        mostrarErrores(errorBuscar, "", False)
        i = DataSet1.Tables("servicio").Rows.Count
        s = serBusBtn.Text.ToString.Length
        If i > 0 Then
            For j = 0 To i - 1

                resul = ServicioDataGridView.Item(1, j).Value().ToString()
                k = resul.Length
                If k >= s And serBusBtn.Text <> "" Then
                    If resul.Substring(0, s).Equals(serBusBtn.Text) Then
                        lisBusSer.Items.Add(resul + " " + ServicioDataGridView.Item(2, j).Value().ToString() + " " + ServicioDataGridView.Item(3, j).Value().ToString())
                        bandera = True
                    End If
                ElseIf serBusBtn.Text = "" Then
                    lisBusSer.Items.Add(resul + " " + ServicioDataGridView.Item(2, j).Value().ToString() + " " + ServicioDataGridView.Item(3, j).Value().ToString())
                    bandera = -True
                End If
            Next
        Else
            mostrarErrores(errorBuscar, "No existe registros en la base de datos", True)
            verServicios.Hide()
        End If

        If bandera Then
            mostrarErrores(errorBuscar, "No existen coincidencias", True)
        End If
    End Sub

    Private Sub carSerBtn_Click(sender As Object, e As EventArgs) Handles carSerBtn.Click
        Dim resul As Integer

        If nomSerTxt.Text = "" Then
            mostrarErrores(error1Ser, "Complete este campo", True)
        ElseIf desSerTxt.Text = "" Then
            mostrarErrores(error2Ser, "Complete este campo", True)
        ElseIf Not (CheckBoxDias.Checked <> False Or CheckBoxMano.Checked <> False Or CheckBoxCom.Checked <> False) Then
            mostrarErrores(error3Ser, "Marque al menos un campo", True)
        Else
            mostrarErrores(error1Ser, "", False)
            mostrarErrores(error2Ser, "", False)
            mostrarErrores(error3Ser, "", False)
            resul = buscar_en_tablas("servicio", "nombre_servicio", nomSerTxt.Text)

            If resul = -1 Then
                Dim nuevo_servicio As DataRow = DataSet1.Tables("servicio").NewRow()

                nuevo_servicio("nombre_servicio") = nomSerTxt.Text
                nuevo_servicio("descripcion_servicio") = desSerTxt.Text
                If CheckBoxDias.Checked And Not CheckBoxMano.Checked And Not CheckBoxCom.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxDias.Text
                ElseIf CheckBoxMano.Checked And Not CheckBoxCom.Checked And Not CheckBoxDias.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxMano.Text
                ElseIf CheckBoxCom.Checked And Not CheckBoxMano.Checked And Not CheckBoxDias.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxCom.Text
                ElseIf CheckBoxMano.Checked And CheckBoxCom.Checked And Not CheckBoxDias.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxMano.Text + " " + CheckBoxCom.Text
                ElseIf CheckBoxDias.Checked And CheckBoxMano.Checked And Not CheckBoxCom.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxDias.Text + " " + CheckBoxMano.Text
                ElseIf CheckBoxDias.Checked And Not CheckBoxMano.Checked And CheckBoxCom.Checked Then
                    nuevo_servicio("forma_calculo") = CheckBoxDias.Text + " " + CheckBoxCom.Text
                Else
                    nuevo_servicio("forma_calculo") = CheckBoxDias.Text + " " + CheckBoxMano.Text + " " + CheckBoxCom.Text
                End If
                MsgBox("Servicio cargado exitosamente")
                DataSet1.Tables("servicio").Rows.Add(nuevo_servicio)
                Validate()
                ServicioTableAdapter.Update(DataSet1.servicio)

            Else
                mostrarErrores(error1Ser, "Ya existe!", True)
            End If
        End If
    End Sub


    Private Sub editSerBtn_Click(sender As Object, e As EventArgs) Handles editSerBtn.Click
        Dim resul As Integer
        Dim cadena As String
        If nomSerTxt.Text <> "" Then
            editarServicios.Show()
            mostrarErrores(error1Ser, "", False)
            mostrarErrores(error2Ser, "", False)
            mostrarErrores(error3Ser, "", False)
            CheckBoxDias2.Checked = False
            CheckBoxMano2.Checked = False
            CheckBoxCom2.Checked = False
            resul = buscar_en_tablas("servicio", "nombre_servicio", nomSerTxt.Text)
            MsgBox(resul)
            If resul > -1 Then
                nomSerTxt2.Text = ServicioDataGridView.Item(1, resul).Value.ToString
                desSerTxt2.Text = ServicioDataGridView.Item(2, resul).Value.ToString
                cadena = ServicioDataGridView.Item(3, resul).Value.ToString
                cadena = String.Concat(cadena, "                                                                                                             ")
                ' MsgBox(cadena.Substring(6, 18).ToString)

                If cadena.Substring(0, 5).Equals("xDias") And cadena.Substring(6, 13).Equals("             ") And cadena.Substring(14, 12).Equals("            ") Then
                    CheckBoxDias2.Checked = True
                ElseIf cadena.Substring(0, 13).Equals("xMano de obra") And cadena.Substring(14, 12).Equals("            ") Then
                    CheckBoxMano2.Checked = True
                ElseIf cadena.Substring(0, 12).Equals("xComplejidad") Then
                    CheckBoxCom2.Checked = True

                ElseIf cadena.Substring(0, 5).Equals("xDias") And cadena.Substring(6, 13).Equals("xMano de obra") And cadena.Substring(20, 12).Equals("            ") Then
                    CheckBoxDias2.Checked = True
                    CheckBoxMano2.Checked = True
                ElseIf cadena.Substring(0, 5).Equals("xDias") And cadena.Substring(6, 12).Equals("xComplejidad") Then
                    CheckBoxDias2.Checked = True
                    CheckBoxCom2.Checked = True

                ElseIf cadena.Substring(0, 13).Equals("xMano de obra") And cadena.Substring(14, 12).Equals("xComplejidad") Then
                    CheckBoxCom2.Checked = True
                    CheckBoxMano2.Checked = True
                Else
                    CheckBoxDias2.Checked = True
                    CheckBoxMano2.Checked = True
                    CheckBoxCom2.Checked = True
                End If
            Else
                nomSerTxt2.Text = nomSerTxt.Text
                mostrarErrores(error1Ser2, "No existe es servicio,No se puede editar", True)
            End If

        Else
            mostrarErrores(error1Ser, "¿Cual es el nombre del servicio a editar?", True)
        End If
    End Sub

    Private Sub modSerBtn_Click(sender As Object, e As EventArgs) Handles modSerBtn.Click
        Dim resul As Integer
        Dim cadena As String

        cadena = ""
        resul = buscar_en_tablas("servicio", "nombre_servicio", nomSerTxt.Text)
        MsgBox(resul)
        If resul > -1 Then
            DataSet1.Tables("servicio").Rows(resul).Item(1) = nomSerTxt2.Text
            DataSet1.Tables("servicio").Rows(resul).Item(2) = desSerTxt2.Text
            If CheckBoxDias2.Checked Then
                cadena = String.Concat(cadena, CheckBoxDias2.Text)
                cadena = String.Concat(cadena, " ")
            End If
            If CheckBoxMano2.Checked Then
                cadena = String.Concat(cadena, CheckBoxMano2.Text)
                cadena = String.Concat(cadena, " ")
            End If
            If CheckBoxCom2.Checked Then
                cadena = String.Concat(cadena, CheckBoxCom2.Text)
                cadena = String.Concat(cadena, " ")
            End If
            cadena = cadena.Remove(cadena.Length - 1)
            DataSet1.Tables("servicio").Rows(resul).Item(3) = cadena
            Validate()
            ServicioTableAdapter.Update(DataSet1)
        End If
    End Sub

    Private Sub borSerBtn2_Click(sender As Object, e As EventArgs) Handles borSerBtn2.Click
        nomSerTxt2.Clear()
        desSerTxt2.Clear()
        CheckBoxCom2.Checked = False
        CheckBoxDias2.Checked = False
        CheckBoxMano2.Checked = False
        ingresarServicios.Hide()
    End Sub

    Private Sub borSerBtn_Click(sender As Object, e As EventArgs) Handles borSerBtn.Click
        nomSerTxt.Clear()
        desSerTxt.Clear()
        CheckBoxCom.Checked = False
        CheckBoxDias.Checked = False
        CheckBoxMano.Checked = False
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        verSerPanel.Show()
    End Sub

    Private Sub boton_servicios_Click(sender As Object, e As EventArgs) Handles boton_servicios.Click
        GroupBox4Stock.Hide()
        panel_carga_presupuesto.Hide()
        panel_vender.Hide()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
        panelServicios.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim factura_buscada As String
        Dim pos As Integer
        Dim i As Integer
        Dim ruc As String

        Dim fecha As String
        Dim pos_cliente As Integer
        Dim nom_cliente As String
        Dim cantidad_grid As Integer
        Dim cont As Integer
        cont = 0

        factura_buscada = n_factura_textbox.Text
        pos = buscar_en_tablas("venta_producto", "n_factura_venta_producto", factura_buscada)

        If pos >= 0 Then
            ruc = DataSet1.Tables("venta_producto").Rows(pos).Item("id_cliente")
            pos_cliente = buscar_en_tablas("cliente", "id_cliente", ruc)
            ruc = DataSet1.Tables("cliente").Rows(pos_cliente).Item("ruc")
            nom_cliente = DataSet1.Tables("cliente").Rows(pos_cliente).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(pos_cliente).Item("apellido")
            fecha = DataSet1.Tables("venta_producto").Rows(pos).Item("fecha_venta")

            text_ruc_venta.Text = ruc
            TextBox16.Text = nom_cliente
            TextBox17.Text = fecha

            For i = 0 To DataSet1.Tables("venta_producto").Rows.Count - 1

                If factura_buscada = DataSet1.Tables("venta_producto").Rows(i).Item("n_factura_venta_producto") Then

                    DataGridView1.Rows.Add()

                    DataGridView1.Item(0, cont).Value = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "id_stock_mugen", DataSet1.Tables("venta_producto").Rows(i).Item("id_stock_mugen"))).Item("codigo")
                    DataGridView1.Item(1, cont).Value = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "id_stock_mugen", DataSet1.Tables("venta_producto").Rows(i).Item("id_stock_mugen"))).Item("descripcion")
                    DataGridView1.Item(2, cont).Value = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "id_stock_mugen", DataSet1.Tables("venta_producto").Rows(i).Item("id_stock_mugen"))).Item("precio_venta")
                    DataGridView1.Item(3, cont).Value = DataSet1.Tables("venta_producto").Rows(i).Item("cantidad")

                    cont = cont + 1
                End If


            Next


        Else
            MsgBox("Factura no existe")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox4Stock.Hide()
        panel_carga_presupuesto.Hide()
        panel_vender.Show()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        panel_carga_presupuesto.Hide()
        panel_vender.Hide()
        panel_cuentas.Hide()
        Panel1.Hide()
        PanelClientes.Hide()
        PanelTrabajosPendientes.Hide()
        panelServicios.Hide()
        panel_contabilidad.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If datos_loguin.nivel_usuario = 1 Then
            GroupBox4Stock.Hide()
            panel_carga_presupuesto.Hide()
            panel_vender.Hide()
            panel_cuentas.Hide()
            Panel1.Hide()
            PanelClientes.Hide()
            PanelTrabajosPendientes.Hide()
            panelServicios.Hide()
            panel_contabilidad.Show()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        list_clientes.Items.Clear()



        Dim i As Integer
        Dim cantidad As Integer
        Dim posicion As Integer
        Dim ban As Integer
        list_clientes.Show()

        ban = 0
        cantidad = DataSet1.Tables("cliente").Rows.Count
        cantidad = cantidad - 1

        For i = 0 To cantidad
            If TextBox5.TextLength <= DataSet1.Tables("cliente").Rows(i).Item("nombre").ToString.Length Then
                If TextBox5.Text.Substring(0, TextBox5.TextLength) = DataSet1.Tables("cliente").Rows(i).Item("nombre").Substring(0, TextBox5.TextLength) Then
                    list_clientes.Items.Add(i.ToString + "   " + DataSet1.Tables("cliente").Rows(i).Item("ruc") + ", " + DataSet1.Tables("cliente").Rows(i).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(i).Item("apellido"))
                End If
            End If
        Next

    End Sub

    Private Sub TextBox5_DragOver(sender As Object, e As DragEventArgs) Handles TextBox5.DragOver


    End Sub

    Private Sub list_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_clientes.SelectedIndexChanged

        TextBox5.Text = list_clientes.SelectedItem.ToString.Substring(0, 4)
        list_clientes.Hide()


    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        If list_clientes.Visible = True Then
            list_clientes.Focus()
        Else
            list_clientes.Hide()

        End If
    End Sub

    Private Function pos_ultimo_guion(n_factura As String)
        Dim i As Integer

        Dim aux As Integer
        aux = -1

        For i = 0 To n_factura.Length - 1
            If n_factura.Chars(i) = "-" Then
                aux = i + 1
            End If

        Next
        Return aux

    End Function

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

        Dim pos As Integer
        Dim num As Integer
        pos = pos_ultimo_guion(n_factura_textbox.Text)
        num = n_factura_textbox.Text.Substring(pos)
        MsgBox("posicion " + pos.ToString + "como queda " + num)





    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CrearClienteBoton_Click_1(sender As Object, e As EventArgs) Handles CrearClienteBoton.Click
        update_cache()

        DataGridMugen.Hide()
        GroupBoxCrearClienteasd.Show()
        GroupBoxModificarClienteasd.Hide()
        DataGridEstadisticasCliente.Hide()

        NombreTextBoxCrearCliente.Clear()
        ApellidoTextBoxCrearCliente.Clear()
        RucTextBoxCrearCliente.Clear()
        NumeroTextBoxCrearCliente.Clear()
        MailTextBoxCrearCliente.Clear()
    End Sub

    Private Sub ModificarClienteBoton_Click_1(sender As Object, e As EventArgs) Handles ModificarClienteBoton.Click
        update_cache()

        DataGridMugen.Hide()
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Show()
        DataGridEstadisticasCliente.Hide()

        NombreTextBox1ModificarCliente.Clear()
        ApellidoTextBox1ModificarCliente.Clear()
        RucTextBox1ModificarCliente.Clear()
        NumeroTextBox1ModificarCliente.Clear()
        MailTextBox1ModificarCliente.Clear()
    End Sub

    Private Sub EstadisticasDeClienteBoton_Click_1(sender As Object, e As EventArgs) Handles EstadisticasDeClienteBoton.Click
        DataGridMugen.Hide()
        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Hide()
        DataGridEstadisticasCliente.Show()

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer

        Dim cant_cliente As Integer
        cant_cliente = DataSet1.Tables("cliente").Rows.Count - 1

        Dim cant_venta_servicio As Integer
        cant_venta_servicio = DataSet1.Tables("venta_servicio").Rows.Count - 1

        Dim cant_pedido As Integer
        cant_pedido = DataSet1.Tables("pedido").Rows.Count - 1

        Dim cantidad_final_venta_servicio As Integer
        Dim cantidad_final_pedidos_entregados As Integer

        Dim cant_pendiente As Integer
        Dim cant_terminado As Integer
        Dim cant_entregado As Integer
        Dim cant_cobrado As Integer

        Dim cantidad_pendiente As Integer
        Dim cantidad_terminado As Integer
        Dim cantidad_entregado As Integer
        Dim cantidad_cobrado As Integer

        Dim costo_pendiente As Integer
        Dim costo_entregado As Integer


        For i = 0 To cant_cliente

            cantidad_final_venta_servicio = 0
            cantidad_final_pedidos_entregados = 0

            cant_pendiente = 0
            cant_terminado = 0
            cant_entregado = 0
            cant_cobrado = 0

            cantidad_pendiente = 0
            cantidad_terminado = 0
            cantidad_entregado = 0
            cantidad_cobrado = 0

            costo_pendiente = 0
            costo_entregado = 0


            DataGridEstadisticasCliente.Rows.Add()

            DataGridEstadisticasCliente.Item(0, i).Value = DataSet1.Tables("cliente").Rows(i).Item("ruc")
            DataGridEstadisticasCliente.Item(1, i).Value = DataSet1.Tables("cliente").Rows(i).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(i).Item("apellido")

            For j = 0 To cant_venta_servicio
                If DataSet1.Tables("venta_servicio").Rows(j).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    cantidad_final_venta_servicio = cantidad_final_venta_servicio + DataSet1.Tables("venta_servicio").Rows(j).Item("precio_venta_servicio")
                End If
            Next

            For k = 0 To cant_pedido
                If DataSet1.Tables("pedido").Rows(k).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    If DataSet1.Tables("pedido").Rows(k).Item("estado") = "entregado" Then
                        cantidad_final_pedidos_entregados = cantidad_final_pedidos_entregados + DataSet1.Tables("pedido").Rows(k).Item("precio")
                    End If
                End If
            Next

            'Deuda
            DataGridEstadisticasCliente.Item(2, i).Value = cantidad_final_venta_servicio - cantidad_final_pedidos_entregados


            For l = 0 To cant_pendiente
                If DataSet1.Tables("pedido").Rows(l).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    If DataSet1.Tables("pedido").Rows(l).Item("estado") = "pendiente" Then
                        cantidad_pendiente = cantidad_pendiente + 1
                        costo_pendiente = costo_pendiente + DataSet1.Tables("pedido").Rows(l).Item("precio")
                    End If
                End If
            Next

            'Trabajos Pendientes
            DataGridEstadisticasCliente.Item(3, i).Value = cantidad_pendiente


            For l = 0 To cant_terminado
                If DataSet1.Tables("pedido").Rows(l).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    If DataSet1.Tables("pedido").Rows(l).Item("estado") = "pendiente" Then
                        cantidad_terminado = cantidad_terminado + 1
                    End If
                End If
            Next

            'Trabajos Terminados
            DataGridEstadisticasCliente.Item(4, i).Value = cantidad_terminado


            For l = 0 To cant_terminado
                If DataSet1.Tables("pedido").Rows(l).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    If DataSet1.Tables("pedido").Rows(l).Item("estado") = "pendiente" Then
                        cantidad_entregado = cantidad_entregado + 1
                        costo_entregado = costo_entregado + 1
                    End If
                End If
            Next

            'Trabajos Entregados
            DataGridEstadisticasCliente.Item(5, i).Value = cantidad_entregado


            For l = 0 To cant_cobrado
                If DataSet1.Tables("pedido").Rows(l).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    If DataSet1.Tables("pedido").Rows(l).Item("estado") = "pendiente" Then
                        cantidad_cobrado = cantidad_cobrado + 1
                    End If
                End If
            Next

            'Trabajos Cobrados
            DataGridEstadisticasCliente.Item(6, i).Value = cantidad_cobrado

            'Costo (trabajos entregados)
            DataGridEstadisticasCliente.Item(7, i).Value = costo_entregado

            'Costo (trabajos pendientes)
            DataGridEstadisticasCliente.Item(8, i).Value = costo_pendiente

            'Prioritario
            If DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True Then
                DataGridEstadisticasCliente.Item(9, i).Value = "Si"
            Else
                DataGridEstadisticasCliente.Item(9, i).Value = "No"
            End If

        Next
    End Sub

    Private Sub ButtonClientesMugen_Click(sender As Object, e As EventArgs) Handles ButtonClientesMugen.Click
        update_cache()

        GroupBoxCrearClienteasd.Hide()
        GroupBoxModificarClienteasd.Hide()
        DataGridEstadisticasCliente.Hide()
        DataGridMugen.Show()


        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim cant_cliente As Integer
        cant_cliente = DataSet1.Tables("cliente").Rows.Count - 1

        Dim cant_venta_producto As Integer
        cant_venta_producto = DataSet1.Tables("venta_producto").Rows.Count - 1


        Dim cant_producto As Integer
        cant_producto = DataSet1.Tables("producto").Rows.Count - 1

        Dim cantidad_final_venta_producto As Integer

        Dim precio_del_producto As Integer
        precio_del_producto = 0

        For i = 0 To cant_cliente

            cantidad_final_venta_producto = 0

            DataGridMugen.Rows.Add()

            DataGridMugen.Item(0, i).Value = DataSet1.Tables("cliente").Rows(i).Item("ruc")
            DataGridMugen.Item(1, i).Value = DataSet1.Tables("cliente").Rows(i).Item("nombre") + " " + DataSet1.Tables("cliente").Rows(i).Item("apellido")

            For j = 0 To cant_venta_producto
                If DataSet1.Tables("venta_producto").Rows(j).Item("id_cliente") = DataSet1.Tables("cliente").Rows(i).Item("id_cliente") Then
                    For k = 0 To cant_producto
                        If DataSet1.Tables("producto").Rows(k).Item("id_stock_mugen") = DataSet1.Tables("venta_producto").Rows(j).Item("id_stock_mugen") Then
                            precio_del_producto = DataSet1.Tables("producto").Rows(k).Item("precio_venta")
                        End If
                    Next

                    cantidad_final_venta_producto = cantidad_final_venta_producto + (DataSet1.Tables("venta_producto").Rows(j).Item("cantidad") * precio_del_producto)
                End If
            Next

            DataGridMugen.Item(2, i).Value = cantidad_final_venta_producto


        Next

    End Sub

    Private Sub RucTextBoxCrearCliente_TextChanged_1(sender As Object, e As EventArgs) Handles RucTextBoxCrearCliente.TextChanged

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

    Private Sub CrearClienteBotonCrearCliente_Click_1(sender As Object, e As EventArgs) Handles CrearClienteBotonCrearCliente.Click
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

    Private Sub Button9CrearCliente_Click_1(sender As Object, e As EventArgs) Handles Button9CrearCliente.Click
        GroupBoxCrearClienteasd.Hide()
    End Sub

    Private Sub Button15ModificarCliente_Click_1(sender As Object, e As EventArgs) Handles Button15ModificarCliente.Click
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count
        Dim ban_ruc_existe As Integer
        ban_ruc_existe = 0

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

    Private Sub Button24ModificarCliente_Click_1(sender As Object, e As EventArgs) Handles Button24ModificarCliente.Click
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

    Private Sub Button25ModificarCliente_Click_1(sender As Object, e As EventArgs) Handles Button25ModificarCliente.Click
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

    Private Sub Button10ModificarCliente_Click_1(sender As Object, e As EventArgs) Handles Button10ModificarCliente.Click
        GroupBoxModificarClienteasd.Hide()
    End Sub

    Private Sub Button24NuevoProducto_Click_2(sender As Object, e As EventArgs) Handles Button24NuevoProducto.Click
        update_cache()


        GroupBoxNuevoProducto.Show()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Hide()
        GroupBoxProveedor.Hide()
        DataGridEstadoStock.Hide()

        GroupBoxIngresodeProducto.Text = ""
        GroupBoxModificarProducto.Text = ""


        TextBoxCodigo.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecio.Clear()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        update_cache()
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Show()
        GroupBoxModificarProducto.Hide()
        LabelIngresoProducto.Hide()
        GroupBoxProveedor.Hide()
        DataGridEstadoStock.Hide()

        TextBoxProveedor.Text = ""
        TextBoxDeshabilitado2.Text = ""
        TextBoxIDStockMugen.Text = ""
        TextBoxDeshabilitado3.Text = ""
        TextBoxNroFactura.Text = ""
        TextBoxCantidad.Text = ""
        TextBoxPreciodeCompra.Text = ""
        TextBoxPrecioUnitario.Text = ""

        TextBoxFecha.Text = Date.Today
    End Sub

    Private Sub Button26_Click_2(sender As Object, e As EventArgs) Handles Button26.Click
        update_cache()
        GroupBoxNuevoProducto.Hide()
        GroupBoxProveedor.Hide()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Show()
        DataGridEstadoStock.Hide()
    End Sub

    Private Sub ButtonEstadodeStock_Click(sender As Object, e As EventArgs) Handles ButtonEstadodeStock.Click
        update_cache()
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Hide()
        LabelIngresoProducto.Hide()
        GroupBoxProveedor.Hide()
        DataGridEstadoStock.Show()

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim cant_producto As Integer
        cant_producto = DataSet1.Tables("producto").Rows.Count - 1

        Dim cant_ingreso_producto As Integer
        cant_ingreso_producto = DataSet1.Tables("ingreso_producto").Rows.Count - 1

        Dim cant_egreso_producto As Integer
        cant_egreso_producto = DataSet1.Tables("venta_producto").Rows.Count - 1

        Dim cantidad_final_de_ingreso As Integer
        Dim cantidad_final_de_egreso As Integer

        For i = 0 To cant_producto
            cantidad_final_de_ingreso = 0
            cantidad_final_de_egreso = 0

            DataGridEstadoStock.Rows.Add()

            DataGridEstadoStock.Item(0, i).Value = DataSet1.Tables("producto").Rows(i).Item("codigo")
            DataGridEstadoStock.Item(1, i).Value = DataSet1.Tables("producto").Rows(i).Item("descripcion")

            For j = 0 To cant_ingreso_producto
                If DataSet1.Tables("ingreso_producto").Rows(j).Item("id_stock_mugen") = DataSet1.Tables("producto").Rows(i).Item("id_stock_mugen") Then
                    cantidad_final_de_ingreso = cantidad_final_de_ingreso + DataSet1.Tables("ingreso_producto").Rows(j).Item("cantidad_ingreso")
                End If
            Next

            For k = 0 To cant_egreso_producto
                If DataSet1.Tables("venta_producto").Rows(k).Item("id_stock_mugen") = DataSet1.Tables("producto").Rows(i).Item("id_stock_mugen") Then
                    cantidad_final_de_egreso = cantidad_final_de_egreso + DataSet1.Tables("venta_producto").Rows(k).Item("cantidad")
                End If
            Next

            DataGridEstadoStock.Item(2, i).Value = cantidad_final_de_ingreso - cantidad_final_de_egreso
        Next
    End Sub

    Private Sub BotonNuevoProveedor_Click(sender As Object, e As EventArgs) Handles BotonNuevoProveedor.Click
        update_cache()
        GroupBoxNuevoProducto.Hide()
        GroupBoxIngresodeProducto.Hide()
        GroupBoxModificarProducto.Hide()
        LabelIngresoProducto.Hide()
        GroupBoxProveedor.Show()
        DataGridEstadoStock.Hide()
    End Sub

    Private Sub TextBoxCodigo_TextChanged_2(sender As Object, e As EventArgs) Handles TextBoxCodigo.TextChanged

    End Sub

    Private Sub TextBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCodigo.LostFocus
        Dim cantidad_de_productos As Integer
        cantidad_de_productos = DataSet1.Tables("producto").Rows.Count
        If cantidad_de_productos > 0 Then
            For i As Integer = 0 To (cantidad_de_productos - 1)
                'Si el (CÓDIGO DE) PRODUCTO ya esta registrado'
                If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxCodigo.Text Then

                    LabelNuevoProducto.Show()
                    LabelNuevoProducto.Text = "El código de producto ya está registrado"
                    LabelNuevoProducto.ForeColor = Color.Red

                    TextBoxCodigo.Text = ""
                    TextBoxCodigo.Focus()

                    i = cantidad_de_productos - 1 'Para cortar el FOR, ya que se encontró RUC repetido
                Else
                    LabelNuevoProducto.Hide()
                End If
            Next
        End If
    End Sub

    Private Sub ButtonCrearProducto_Click_2(sender As Object, e As EventArgs) Handles ButtonCrearProducto.Click
        LabelNuevoProducto.Hide()

        If TextBoxCodigo.Text <> "" And TextBoxDescripcion.Text <> "" And TextBoxPrecio.Text <> "" Then
            Dim nuevo_producto As DataRow = DataSet1.Tables("producto").NewRow()

            nuevo_producto("codigo") = TextBoxCodigo.Text
            nuevo_producto("descripcion") = TextBoxDescripcion.Text
            nuevo_producto("precio_venta") = TextBoxPrecio.Text

            DataSet1.Tables("producto").Rows.Add(nuevo_producto)

            Validate()
            UsuarioBindingSource.EndEdit()
            ProductoTableAdapter.Update(DataSet1.producto)

            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Producto creado"
            LabelNuevoProducto.ForeColor = Color.Green


        Else
            LabelNuevoProducto.Show()
            LabelNuevoProducto.Text = "Complete los campos vacíos"
            LabelNuevoProducto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonCerrar1_Click_2(sender As Object, e As EventArgs) Handles ButtonCerrar1.Click
        GroupBoxNuevoProducto.Hide()
    End Sub

    Private Sub ButtonInsertarProveedor_Click(sender As Object, e As EventArgs) Handles ButtonInsertarProveedor.Click
        LabelNuevoProveedor.Hide()

        If TextBoxNombreProveedor.Text <> "" And TextBoxRUCproveedor.Text <> "" Then
            Dim nuevo_proveedor As DataRow = DataSet1.Tables("proveedor").NewRow()


            nuevo_proveedor("nombre_proveedor") = TextBoxNombreProveedor.Text
            nuevo_proveedor("ruc_proveedor") = TextBoxRUCproveedor.Text

            DataSet1.Tables("proveedor").Rows.Add(nuevo_proveedor)

            Validate()
            ProveedorBindingSource.EndEdit()
            ProveedorTableAdapter.Update(DataSet1.proveedor)

            LabelNuevoProveedor.Show()
            LabelNuevoProveedor.Text = "Proveedor creado"
            LabelNuevoProveedor.ForeColor = Color.Green


        Else
            LabelNuevoProveedor.Show()
            LabelNuevoProveedor.Text = "Complete los campos vacíos"
            LabelNuevoProveedor.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        GroupBoxProveedor.Hide()
    End Sub

    Private Sub TextBoxProveedor_TextChanged_2(sender As Object, e As EventArgs) Handles TextBoxProveedor.TextChanged

    End Sub

    Private Sub TextBoxProveedor_LostFocus(sender As Object, e As EventArgs) Handles TextBoxProveedor.LostFocus
        LabelIngresoProducto.Hide()
        Dim cantidad_de_proveedores As Integer
        cantidad_de_proveedores = DataSet1.Tables("proveedor").Rows.Count
        Dim ban As Integer
        ban = 0

        If cantidad_de_proveedores > 0 Then
            For i As Integer = 0 To (cantidad_de_proveedores - 1)
                'Si el PROVEEDOR existe'
                If DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = TextBoxProveedor.Text Then
                    LabelNuevoProducto.Hide()
                    TextBoxDeshabilitado2.Text = DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor")

                    'i = cantidad_de_productos - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                    ban = 1

                End If
            Next

            If ban = 0 Then
                LabelIngresoProducto.Show()
                LabelIngresoProducto.Text = "El proveedor ingresado no existe"
                LabelIngresoProducto.ForeColor = Color.Red

                TextBoxDeshabilitado2.Text = ""

                TextBoxProveedor.Text = ""
                TextBoxProveedor.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxIDStockMugen_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxIDStockMugen.TextChanged

    End Sub

    Private Sub TextBoxIDStockMugen_LostFocus(sender As Object, e As EventArgs) Handles TextBoxIDStockMugen.LostFocus
        LabelIngresoProducto.Hide()
        Dim cantidad_de_productos As Integer
        cantidad_de_productos = DataSet1.Tables("producto").Rows.Count
        Dim ban As Integer
        ban = 0

        If cantidad_de_productos > 0 Then
            For i As Integer = 0 To (cantidad_de_productos - 1)
                'Si el (CÓDIGO DE) PRODUCTO existe'
                If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxIDStockMugen.Text Then
                    LabelNuevoProducto.Hide()
                    TextBoxDeshabilitado3.Text = DataSet1.Tables("producto").Rows(i).Item("descripcion")

                    'i = cantidad_de_productos - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                    ban = 1

                End If
            Next

            If ban = 0 Then
                LabelIngresoProducto.Show()
                LabelIngresoProducto.Text = "El código de producto no existe"
                LabelIngresoProducto.ForeColor = Color.Red

                TextBoxDeshabilitado3.Text = ""

                TextBoxIDStockMugen.Text = ""
                TextBoxIDStockMugen.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxFecha_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxFecha.TextChanged

    End Sub

    Private Sub TextBoxFecha_LostFocus(sender As Object, e As EventArgs) Handles TextBoxFecha.LostFocus
        LabelIngresoProducto.Hide()
        If IsDate(TextBoxFecha.Text) = False Then
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Ingrese fecha válida"
            LabelIngresoProducto.ForeColor = Color.Red

            TextBoxFecha.Focus()
        End If
    End Sub

    Private Sub TextBoxCantidad_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxCantidad.TextChanged

    End Sub

    Private Sub TextBoxCantidad_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCantidad.LostFocus
        LabelIngresoProducto.Hide()
        If IsNumeric(TextBoxCantidad.Text) = False Then
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Ingrese un número"
            LabelIngresoProducto.ForeColor = Color.Red

            TextBoxCantidad.Text = ""
            TextBoxCantidad.Focus()
        End If
    End Sub

    Private Sub TextBoxPreciodeCompra_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPreciodeCompra.TextChanged

    End Sub

    Private Sub TextBoxPreciodeCompra_LostFocus(sender As Object, e As EventArgs) Handles TextBoxPreciodeCompra.LostFocus
        LabelIngresoProducto.Hide()
        If IsNumeric(TextBoxPreciodeCompra.Text) = False Then
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Ingrese un número"
            LabelIngresoProducto.ForeColor = Color.Red

            TextBoxPreciodeCompra.Text = ""
            TextBoxPreciodeCompra.Focus()
        End If
    End Sub

    Private Sub TextBoxPrecioUnitario_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPrecioUnitario.TextChanged

    End Sub

    Private Sub TextBoxPrecioUnitario_LostFocus(sender As Object, e As EventArgs) Handles TextBoxPrecioUnitario.LostFocus
        LabelIngresoProducto.Hide()
        If IsNumeric(TextBoxPreciodeCompra.Text) = False Then
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Ingrese un número"
            LabelIngresoProducto.ForeColor = Color.Red

            TextBoxPreciodeCompra.Text = ""
            TextBoxPreciodeCompra.Focus()
        End If
    End Sub

    Private Sub ButtonInsertarProducto_Click(sender As Object, e As EventArgs) Handles ButtonInsertarProducto.Click
        LabelIngresoProducto.Hide()

        If TextBoxProveedor.Text <> "" And TextBoxDeshabilitado2.Text <> "" And TextBoxIDStockMugen.Text <> "" And TextBoxDeshabilitado3.Text <> "" And TextBoxFecha.Text <> "" And TextBoxNroFactura.Text <> "" And TextBoxCantidad.Text <> "" And TextBoxPreciodeCompra.Text <> "" And TextBoxPrecioUnitario.Text <> "" Then
            Dim nuevo_ingreso_producto As DataRow = DataSet1.Tables("ingreso_producto").NewRow()


            nuevo_ingreso_producto("id_proveedor") = DataSet1.Tables("proveedor").Rows(buscar_en_tablas("proveedor", "ruc_proveedor", TextBoxProveedor.Text)).Item("id_proveedor")
            nuevo_ingreso_producto("id_stock_mugen") = DataSet1.Tables("producto").Rows(buscar_en_tablas("producto", "codigo", TextBoxIDStockMugen.Text)).Item("id_stock_mugen")
            nuevo_ingreso_producto("fecha_ingreso") = TextBoxFecha.Text
            nuevo_ingreso_producto("numero_factura_ingreso") = TextBoxNroFactura.Text
            nuevo_ingreso_producto("cantidad_ingreso") = TextBoxCantidad.Text
            nuevo_ingreso_producto("precio_compra") = TextBoxPreciodeCompra.Text
            nuevo_ingreso_producto("precio_compra_unitario") = TextBoxPrecioUnitario.Text

            DataSet1.Tables("ingreso_producto").Rows.Add(nuevo_ingreso_producto)

            Validate()
            Ingreso_productoBindingSource.EndEdit()
            Ingreso_productoTableAdapter.Update(DataSet1.ingreso_producto)

            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Producto creado"
            LabelIngresoProducto.ForeColor = Color.Green

            ''''CONTABILIDAD''''

            'SI EL IVA ESTÁ INCLUÍDO
            If CheckBoxIVAincluido.Checked Then
                ' ===ACTUALIZAR TABLA CONTABILIDAD I===

                ' 1) ITEM
                Dim nueva_contabilidad4 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad4("descripcion") = "Ingresa(n) " + TextBoxCantidad.Text + " " + TextBoxDeshabilitado3.Text
                nueva_contabilidad4("deber") = (TextBoxPreciodeCompra.Text / 110) * 100
                'nueva_contabilidad4("haber") = TextBoxNroFactura.Text
                nueva_contabilidad4("fecha") = TextBoxFecha.Text
                'nueva_contabilidad4("saldo") = TextBoxNroFactura.Text
                nueva_contabilidad4("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad4)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                ' 2) IVA
                Dim nueva_contabilidad5 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad5("descripcion") = "IVA"
                nueva_contabilidad5("deber") = TextBoxPreciodeCompra.Text - ((TextBoxPreciodeCompra.Text / 110) * 100)
                'nueva_contabilidad5("haber") = TextBoxNroFactura.Text
                nueva_contabilidad5("fecha") = TextBoxFecha.Text
                'nueva_contabilidad5("saldo") = TextBoxNroFactura.Text
                nueva_contabilidad5("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad5)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                ' 3) CAJA
                Dim nueva_contabilidad6 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad6("descripcion") = "Caja"
                'nueva_contabilidad6("deber") = 
                nueva_contabilidad6("haber") = ((TextBoxPreciodeCompra.Text / 110) * 100) + (TextBoxPreciodeCompra.Text - ((TextBoxPreciodeCompra.Text / 110) * 100))
                nueva_contabilidad6("fecha") = TextBoxFecha.Text
                'nueva_contabilidad6("saldo") = TextBoxNroFactura.Text
                'nueva_contabilidad6("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad6)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                ' 1) ITEM
                Dim nueva_contabilidad7 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad7("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad7("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad7("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad7("descripcion2") = "Ingresa(n) " + TextBoxCantidad.Text + " " + TextBoxDeshabilitado3.Text
                nueva_contabilidad7("deber2") = (TextBoxPreciodeCompra.Text / 110) * 100
                'nueva_contabilidad7("haber2") = TextBoxNroFactura.Text
                nueva_contabilidad7("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad7("saldo2") = TextBoxNroFactura.Text
                nueva_contabilidad7("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad7)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                ' 2) IVA
                Dim nueva_contabilidad8 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad8("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad8("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad8("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad8("descripcion2") = "IVA"
                nueva_contabilidad8("deber2") = TextBoxPreciodeCompra.Text - ((TextBoxPreciodeCompra.Text / 110) * 100)
                'nueva_contabilidad8("haber2") = TextBoxNroFactura.Text
                nueva_contabilidad8("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad8("saldo2") = TextBoxNroFactura.Text
                nueva_contabilidad8("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad8)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                ' 3) CAJA
                Dim nueva_contabilidad9 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad9("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad9("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad9("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad9("descripcion2") = "Caja"
                'nueva_contabilidad9("deber2") = 
                nueva_contabilidad9("haber2") = ((TextBoxPreciodeCompra.Text / 110) * 100) + (TextBoxPreciodeCompra.Text - ((TextBoxPreciodeCompra.Text / 110) * 100))
                nueva_contabilidad9("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad9("saldo2") = TextBoxNroFactura.Text
                'nueva_contabilidad9("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad9)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

            Else 'SI EL IVA NO ESTÁ INCLUIDO
                ' ===ACTUALIZAR TABLA CONTABILIDAD I===

                ' 1) ITEM
                Dim nueva_contabilidad1 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad1("descripcion") = "Ingresa(n) " + TextBoxCantidad.Text + " " + TextBoxDeshabilitado3.Text
                nueva_contabilidad1("deber") = TextBoxPreciodeCompra.Text
                'nueva_contabilidad1("haber") = TextBoxNroFactura.Text
                nueva_contabilidad1("fecha") = TextBoxFecha.Text
                'nueva_contabilidad1("saldo") = TextBoxNroFactura.Text
                nueva_contabilidad1("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad1)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                ' 2) IVA
                Dim nueva_contabilidad2 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad2("descripcion") = "IVA"
                nueva_contabilidad2("deber") = TextBoxPreciodeCompra.Text / 10
                'nueva_contabilidad2("haber") = TextBoxNroFactura.Text
                nueva_contabilidad2("fecha") = TextBoxFecha.Text
                'nueva_contabilidad2("saldo") = TextBoxNroFactura.Text
                nueva_contabilidad2("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad2)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                ' 3) CAJA
                Dim nueva_contabilidad3 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                nueva_contabilidad3("descripcion") = "Caja"
                'nueva_contabilidad3("deber") = 
                nueva_contabilidad3("haber") = TextBoxPreciodeCompra.Text + (TextBoxPreciodeCompra.Text / 10)
                nueva_contabilidad3("fecha") = TextBoxFecha.Text
                'nueva_contabilidad3("saldo") = TextBoxNroFactura.Text
                'nueva_contabilidad3("numero_factura") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad3)

                Validate()
                ContabilidadBindingSource.EndEdit()
                ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                ' 1) ITEM
                Dim nueva_contabilidad10 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad10("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad10("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad10("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad10("descripcion2") = "Ingresa(n) " + TextBoxCantidad.Text + " " + TextBoxDeshabilitado3.Text
                nueva_contabilidad10("deber2") = TextBoxPreciodeCompra.Text
                'nueva_contabilidad10("haber2") = TextBoxNroFactura.Text
                nueva_contabilidad10("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad10("saldo2") = TextBoxNroFactura.Text
                nueva_contabilidad10("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad10)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                ' 2) IVA
                Dim nueva_contabilidad11 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad11("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad11("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad11("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad11("descripcion2") = "IVA"
                nueva_contabilidad11("deber2") = TextBoxPreciodeCompra.Text / 10
                'nueva_contabilidad11("haber2") = TextBoxNroFactura.Text
                nueva_contabilidad11("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad11("saldo2") = TextBoxNroFactura.Text
                nueva_contabilidad11("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad11)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                ' 3) CAJA
                Dim nueva_contabilidad12 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                nueva_contabilidad12("id_usuario") = datos_loguin.id_usuario
                nueva_contabilidad12("descripcion_modificacion") = "Ingreso de Producto"
                nueva_contabilidad12("fecha_modificacion") = TextBoxFecha.Text
                nueva_contabilidad12("descripcion2") = "Caja"
                'nueva_contabilidad12("deber2") = 
                nueva_contabilidad12("haber2") = TextBoxPreciodeCompra.Text + (TextBoxPreciodeCompra.Text / 10)
                nueva_contabilidad12("fecha2") = TextBoxFecha.Text
                'nueva_contabilidad12("saldo2") = TextBoxNroFactura.Text
                'nueva_contabilidad12("numero_factura2") = TextBoxNroFactura.Text

                DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad12)

                Validate()
                Contabilidad2BindingSource.EndEdit()
                Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)
            End If
        Else
            LabelIngresoProducto.Show()
            LabelIngresoProducto.Text = "Complete los campos vacíos"
            LabelIngresoProducto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonCerrar2_Click_2(sender As Object, e As EventArgs) Handles ButtonCerrar2.Click
        GroupBoxIngresodeProducto.Hide()
    End Sub

    Private Sub ButtonBuscara_Click_1(sender As Object, e As EventArgs) Handles ButtonBuscara.Click
        Dim cantidad_de_productos As Integer
        cantidad_de_productos = DataSet1.Tables("producto").Rows.Count
        Dim ban_productos_existe As Integer
        ban_productos_existe = 0

        For i As Integer = 0 To (cantidad_de_productos - 1)
            'Si el PRODUCTO ingresado existe'
            If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxCodigo2.Text Then

                LabelModificarProducto.Hide()

                'RucTextBoxCrearCliente.Text = ""
                'RucTextBoxCrearCliente.Focus()

                TextBoxDescripcion2.ReadOnly = False
                TextBoxPrecio2.ReadOnly = False


                TextBoxDescripcion2.Text = DataSet1.Tables("producto").Rows(i).Item("descripcion")
                TextBoxPrecio2.Text = DataSet1.Tables("producto").Rows(i).Item("precio_venta")

                i = cantidad_de_productos - 1 'Para cortar el FOR

                ban_productos_existe = 1
            End If
        Next

        If ban_productos_existe = 0 Then
            'Si el producto ingresado NO existe
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Producto no registrado"
            LabelModificarProducto.ForeColor = Color.Red

            TextBoxCodigo2.Text = ""
            TextBoxCodigo2.Focus()

            TextBoxDescripcion2.Text = ""
            TextBoxPrecio2.Text = ""

            TextBoxDescripcion2.ReadOnly = True
            TextBoxPrecio2.ReadOnly = True
        End If
    End Sub

    Private Sub ButtonModificarProducto_Click_1(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        LabelModificarProducto.Hide()

        If TextBoxCodigo2.Text <> "" And TextBoxDescripcion2.Text <> "" And TextBoxPrecio2.Text <> "" Then

            Dim nuevo_producto As DataRow = DataSet1.Tables("producto").NewRow()

            Dim cantidad_de_productos As Integer
            cantidad_de_productos = DataSet1.Tables("producto").Rows.Count

            For i As Integer = 0 To (cantidad_de_productos - 1)
                If DataSet1.Tables("producto").Rows(i).Item("codigo") = TextBoxCodigo2.Text Then

                    DataSet1.Tables("producto").Rows(i).Item("descripcion") = TextBoxDescripcion2.Text
                    DataSet1.Tables("producto").Rows(i).Item("precio_venta") = TextBoxPrecio2.Text

                    i = cantidad_de_productos - 1 'Para cortar el FOR, ya que se encontró RUC repetido
                End If

            Next

            Validate()
            ProductoBindingSource.EndEdit()
            ProductoTableAdapter.Update(DataSet1.producto)

            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Producto Modificado"
            LabelModificarProducto.ForeColor = Color.Green

        Else
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Complete los campos vacíos"
            LabelModificarProducto.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonCerrar3_Click_2(sender As Object, e As EventArgs) Handles ButtonCerrar3.Click

        GroupBoxModificarProducto.Hide()
    End Sub

    Private Sub cancelarSerBtn_Click(sender As Object, e As EventArgs) Handles cancelarSerBtn.Click
        verSerPanel.Hide()
    End Sub

    Private Sub cargarGastoBtn_Click(sender As Object, e As EventArgs) Handles cargarGastoBtn.Click
        mostrarErrores(errorGasto, "", False)
        If nFacturaGastoTxt.Text = "" And montoGastoTxt.Text And fechaGastoTxt.Text = "" And detalleGastoTxt.Text = "" Then
            If IsDate(fechaGastoTxt.Text) Then
                Dim nuevo_gasto As DataRow = DataSet1.Tables("gasto").NewRow()
                Dim nueva_contabilidad As DataRow = DataSet1.Tables("contabilidad").NewRow()
                Dim nueva_contabilidad2 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                'se carga la tabla de gastos
                nuevo_gasto("n_factura_gasto") = nFacturaGastoTxt.Text
                nuevo_gasto("detalle_gasto") = detalleGastoTxt.Text
                nuevo_gasto("monto_factura") = montoGastoTxt.Text
                nuevo_gasto("fecha_gasto") = fechaGastoTxt.Text
                DataSet1.Tables("gasto").Rows.Add(nuevo_gasto)
                Validate()
                GastoBindingSource.EndEdit()
                GastoTableAdapter.Update(DataSet1.gasto)
                ''con iva?
                If ivaCbGasto.Checked Then
                    'cargando contabiidad 1
                    Dim nueva_contabilidad4 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad4("descripcion") = "Ingresa Gasto"
                    nueva_contabilidad4("deber") = (montoGastoTxt.Text / 110) * 100
                    nueva_contabilidad4("fecha") = fechaGastoTxt.Text
                    nueva_contabilidad4("numero_factura") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad4)
                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 2) IVA
                    Dim nueva_contabilidad5 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad5("descripcion") = "IVA"
                    nueva_contabilidad5("deber") = montoGastoTxt.Text - ((montoGastoTxt.Text / 110) * 100)
                    nueva_contabilidad5("fecha") = fechaGastoTxt.Text
                    nueva_contabilidad5("numero_factura") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad5)
                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 3) CAJA
                    Dim nueva_contabilidad6 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad6("descripcion") = "Caja"
                    nueva_contabilidad6("haber") = ((montoGastoTxt.Text / 110) * 100) + (montoGastoTxt.Text - ((montoGastoTxt.Text / 110) * 100))
                    nueva_contabilidad6("fecha") = fechaGastoTxt.Text


                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad6)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                    ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                    ' 1) ITEM
                    Dim nueva_contabilidad7 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad7("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad7("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad7("fecha_modificacion") = fechaGastoTxt.Text
                    nueva_contabilidad7("descripcion2") = detalleGastoTxt.Text
                    nueva_contabilidad7("deber2") = (montoGastoTxt.Text / 110) * 100
                    nueva_contabilidad7("fecha2") = fechaGastoTxt.Text
                    nueva_contabilidad7("numero_factura2") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad7)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 2) IVA
                    Dim nueva_contabilidad8 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad8("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad8("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad8("fecha_modificacion") = fechaGastoTxt.Text
                    nueva_contabilidad8("descripcion2") = "IVA"
                    nueva_contabilidad8("deber2") = montoGastoTxt.Text - ((montoGastoTxt.Text / 110) * 100)
                    nueva_contabilidad8("fecha2") = fechaGastoTxt.Text
                    nueva_contabilidad8("numero_factura2") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad8)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                Else 'SI EL IVA NO ESTÁ INCLUIDO
                    ' ===ACTUALIZAR TABLA CONTABILIDAD I===

                    ' 1) ITEM
                    Dim nueva_contabilidad1 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad1("descripcion") = "Ingreso de Gasto"
                    nueva_contabilidad1("deber") = montoGastoTxt.Text
                    nueva_contabilidad1("fecha") = fechaGastoTxt.Text
                    nueva_contabilidad1("numero_factura") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad1)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 2) IVA
                    Dim nueva_contabilidad22 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad2("descripcion") = "IVA"
                    nueva_contabilidad2("deber") = montoGastoTxt.Text / 10
                    nueva_contabilidad2("fecha") = fechaGastoTxt.Text
                    nueva_contabilidad2("numero_factura") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad22)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 3) CAJA
                    Dim nueva_contabilidad3 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad3("descripcion") = "Caja"
                    nueva_contabilidad3("haber") = montoGastoTxt.Text + (montoGastoTxt.Text / 10)
                    nueva_contabilidad3("fecha") = fechaGastoTxt.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad3)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                    ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                    ' 1) ITEM
                    Dim nueva_contabilidad10 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad10("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad10("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad10("fecha_modificacion") = fechaGastoTxt.Text
                    nueva_contabilidad10("descripcion2") = detalleGastoTxt.Text
                    nueva_contabilidad10("deber2") = montoGastoTxt.Text
                    nueva_contabilidad10("fecha2") = fechaGastoTxt.Text
                    nueva_contabilidad10("numero_factura2") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad10)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 2) IVA
                    Dim nueva_contabilidad11 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad11("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad11("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad11("fecha_modificacion") = fechaGastoTxt.Text
                    nueva_contabilidad11("descripcion2") = "IVA"
                    nueva_contabilidad11("deber2") = montoGastoTxt.Text / 10
                    nueva_contabilidad11("fecha2") = fechaGastoTxt.Text
                    nueva_contabilidad11("numero_factura2") = nFacturaGastoTxt.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad11)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 3) CAJA
                    Dim nueva_contabilidad12 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad12("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad12("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad12("fecha_modificacion") = fechaGastoTxt.Text
                    nueva_contabilidad12("descripcion2") = "Caja"
                    nueva_contabilidad12("haber2") = montoGastoTxt.Text + (montoGastoTxt.Text / 10)
                    nueva_contabilidad12("fecha2") = fechaGastoTxt.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad12)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)
                End If
            Else
                mostrarErrores(errorGasto, "La fecha no es valida", True)
            End If
        Else
            mostrarErrores(errorGasto, "Porfavor, complete todos los campos", True)
        End If
    End Sub

    Private Sub aceptarGastoBtn_Click(sender As Object, e As EventArgs) Handles aceptarGastoBtn.Click
        mostrarErrores(errorGasto2, "", False)
        If nFacturaGastoTxt2.Text = "" And montoGastoTxt2.Text And fechaGastoTxt2.Text = "" And detalleGastoTxt2.Text = "" Then
            If IsDate(fechaGastoTxt2.Text) Then
                Dim nuevo_gasto As DataRow = DataSet1.Tables("gasto").NewRow()
                Dim nueva_contabilidad As DataRow = DataSet1.Tables("contabilidad").NewRow()
                Dim nueva_contabilidad2 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                'se carga la tabla de gastos
                nuevo_gasto("n_factura_gasto") = nFacturaGastoTxt2.Text
                nuevo_gasto("detalle_gasto") = detalleGastoTxt2.Text
                nuevo_gasto("monto_factura") = montoGastoTxt2.Text
                nuevo_gasto("fecha_gasto") = fechaGastoTxt2.Text
                DataSet1.Tables("gasto").Rows.Add(nuevo_gasto)
                Validate()
                GastoBindingSource.EndEdit()
                GastoTableAdapter.Update(DataSet1.gasto)
                'con iva?
                If ivaCbGasto2.Checked Then
                    'cargando contabiidad 1
                    Dim nueva_contabilidad4 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad4("descripcion") = "Ingresa Gasto"
                    nueva_contabilidad4("deber") = (montoGastoTxt2.Text / 110) * 100
                    nueva_contabilidad4("fecha") = fechaGastoTxt2.Text
                    nueva_contabilidad4("numero_factura") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad4)
                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 2) IVA
                    Dim nueva_contabilidad5 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad5("descripcion") = "IVA"
                    nueva_contabilidad5("deber") = montoGastoTxt2.Text - ((montoGastoTxt2.Text / 110) * 100)
                    nueva_contabilidad5("fecha") = fechaGastoTxt2.Text
                    nueva_contabilidad5("numero_factura") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad5)
                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 3) CAJA
                    Dim nueva_contabilidad6 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad6("descripcion") = "Caja"
                    nueva_contabilidad6("haber") = ((montoGastoTxt2.Text / 110) * 100) + (montoGastoTxt2.Text - ((montoGastoTxt2.Text / 110) * 100))
                    nueva_contabilidad6("fecha") = fechaGastoTxt2.Text


                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad6)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                    ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                    ' 1) ITEM
                    Dim nueva_contabilidad7 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad7("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad7("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad7("fecha_modificacion") = fechaGastoTxt2.Text
                    nueva_contabilidad7("descripcion2") = detalleGastoTxt2.Text
                    nueva_contabilidad7("deber2") = (montoGastoTxt2.Text / 110) * 100
                    nueva_contabilidad7("fecha2") = fechaGastoTxt2.Text
                    nueva_contabilidad7("numero_factura2") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad7)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 2) IVA
                    Dim nueva_contabilidad8 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad8("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad8("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad8("fecha_modificacion") = fechaGastoTxt2.Text
                    nueva_contabilidad8("descripcion2") = "IVA"
                    nueva_contabilidad8("deber2") = montoGastoTxt2.Text - ((montoGastoTxt2.Text / 110) * 100)
                    nueva_contabilidad8("fecha2") = fechaGastoTxt2.Text
                    nueva_contabilidad8("numero_factura2") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad8)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                Else 'SI EL IVA NO ESTÁ INCLUIDO
                    ' ===ACTUALIZAR TABLA CONTABILIDAD I===

                    ' 1) ITEM
                    Dim nueva_contabilidad1 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad1("descripcion") = "Ingreso de Gasto"
                    nueva_contabilidad1("deber") = montoGastoTxt2.Text
                    nueva_contabilidad1("fecha") = fechaGastoTxt2.Text
                    nueva_contabilidad1("numero_factura") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad1)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 2) IVA
                    Dim nueva_contabilidad22 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad2("descripcion") = "IVA"
                    nueva_contabilidad2("deber") = montoGastoTxt2.Text / 10
                    nueva_contabilidad2("fecha") = fechaGastoTxt2.Text
                    nueva_contabilidad2("numero_factura") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad22)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)

                    ' 3) CAJA
                    Dim nueva_contabilidad3 As DataRow = DataSet1.Tables("contabilidad").NewRow()

                    nueva_contabilidad3("descripcion") = "Caja"
                    nueva_contabilidad3("haber") = montoGastoTxt2.Text + (montoGastoTxt2.Text / 10)
                    nueva_contabilidad3("fecha") = fechaGastoTxt2.Text

                    DataSet1.Tables("contabilidad").Rows.Add(nueva_contabilidad3)

                    Validate()
                    ContabilidadBindingSource.EndEdit()
                    ContabilidadTableAdapter.Update(DataSet1.contabilidad)


                    ' ===ACTUALIZAR TABLA CONTABILIDAD II===

                    ' 1) ITEM
                    Dim nueva_contabilidad10 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad10("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad10("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad10("fecha_modificacion") = fechaGastoTxt2.Text
                    nueva_contabilidad10("descripcion2") = detalleGastoTxt2.Text
                    nueva_contabilidad10("deber2") = montoGastoTxt2.Text
                    nueva_contabilidad10("fecha2") = fechaGastoTxt2.Text
                    nueva_contabilidad10("numero_factura2") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad10)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 2) IVA
                    Dim nueva_contabilidad11 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad11("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad11("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad11("fecha_modificacion") = fechaGastoTxt2.Text
                    nueva_contabilidad11("descripcion2") = "IVA"
                    nueva_contabilidad11("deber2") = montoGastoTxt2.Text / 10
                    nueva_contabilidad11("fecha2") = fechaGastoTxt2.Text
                    nueva_contabilidad11("numero_factura2") = nFacturaGastoTxt2.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad11)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)

                    ' 3) CAJA
                    Dim nueva_contabilidad12 As DataRow = DataSet1.Tables("contabilidad2").NewRow()

                    nueva_contabilidad12("id_usuario") = datos_loguin.id_usuario
                    nueva_contabilidad12("descripcion_modificacion") = "Ingreso de Gasto"
                    nueva_contabilidad12("fecha_modificacion") = fechaGastoTxt2.Text
                    nueva_contabilidad12("descripcion2") = "Caja"
                    nueva_contabilidad12("haber2") = montoGastoTxt2.Text + (montoGastoTxt2.Text / 10)
                    nueva_contabilidad12("fecha2") = fechaGastoTxt2.Text

                    DataSet1.Tables("contabilidad2").Rows.Add(nueva_contabilidad12)

                    Validate()
                    Contabilidad2BindingSource.EndEdit()
                    Contabilidad2TableAdapter.Update(DataSet1.contabilidad2)
                End If
            Else
                mostrarErrores(errorGasto2, "La fecha no es valida", True)
            End If
        Else
            mostrarErrores(errorGasto2, "Porfavor, complete todos los campos", True)
        End If
    End Sub

    Private Sub cancelarGastoBtn_Click(sender As Object, e As EventArgs) Handles cancelarGastoBtn.Click
        modificarGasto.Hide()
    End Sub

    Private Sub modificarGastoBtn_Click(sender As Object, e As EventArgs) Handles modificarGastoBtn.Click
        modificarGasto.Show()
        nFacturaGastoTxt2.Text = nFacturaGastoTxt.Text
        If montoGastoTxt2.Text <> "" Then
            mostrarErrores(errorGasto2, "Ingrese el gasto a modificar,numero de factura", True)
        Else
            Dim i As Integer = buscar_en_tablas("gasto", "n_factura_gasto", nFacturaGastoTxt2.Text)
            If i > -1 Then
                fechaGastoTxt2.Text = DataSet1.Tables("gasto").Rows(i).Item("fecha_gasto")
                montoGastoTxt2.Text = DataSet1.Tables("gasto").Rows(i).Item("monto_gasto")
                detalleGastoTxt2.Text = DataSet1.Tables("gasto").Rows(i).Item("detalle_gasto")
            End If
        End If
    End Sub

    Private Sub borrarGastoBtn_Click(sender As Object, e As EventArgs) Handles borrarGastoBtn.Click
        nFacturaGastoTxt.Text = ""
        fechaGastoTxt.Text = ""
        montoGastoTxt.Text = ""
        detalleGastoTxt.Text = ""
    End Sub

    Private Sub borrarGastoBtn2_Click(sender As Object, e As EventArgs) Handles borrarGastoBtn2.Click
        nFacturaGastoTxt2.Text = ""
        fechaGastoTxt2.Text = ""
        montoGastoTxt2.Text = ""
        detalleGastoTxt2.Text = ""
    End Sub



    Private Sub calendarioGasto2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarioGasto2.DateSelected
        fechaGastoTxt2.Text = calendarioGasto2.SelectionStart
    End Sub


    Private Sub calendarioGasto_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarioGasto.DateSelected
        fechaGastoTxt.Text = calendarioGasto.SelectionStart
    End Sub
    Private Sub fechaGastoTxt_GotFocus(sender As Object, e As EventArgs) Handles fechaGastoTxt.GotFocus
        calendarioGasto.Show()
    End Sub

    Private Sub fechaGastoTxt_LostFocus(sender As Object, e As EventArgs) Handles fechaGastoTxt.LostFocus
        calendarioGasto.Hide()
    End Sub


    Private Sub fechaGastoTxt2_GotFocus(sender As Object, e As EventArgs) Handles fechaGastoTxt2.GotFocus
        calendarioGasto2.Show()
    End Sub

    Private Sub fechaGastoTxt2_LostFocus(sender As Object, e As EventArgs) Handles fechaGastoTxt2.LostFocus
        calendarioGasto2.Hide()
    End Sub

    Private Sub seleccion_caja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seleccion_caja.SelectedIndexChanged
        If seleccion_caja.SelectedIndex = 0 Then
            DataGridView1.Rows.Clear()

            DataGridView1.Rows.Add()

            DataGridView1.Item(0, 0).Value = "1"
            DataGridView1.Item(1, 0).ReadOnly = False
            DataGridView1.Item(2, 0).ReadOnly = False


        End If
    End Sub
End Class