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



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

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

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles venta_guardar.Click
        DataGridView1.Item(0, 0).Value = "hola"
    End Sub


    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim cod As String
        Dim i As Integer
        Dim curen As Integer
        Dim suma As Integer
        Dim iva As Integer
        Dim total As Integer

        curen = DataGridView1.CurrentRow.Index
        suma = 0

        If (DataGridView1.Item(0, curen).Value = "") Then

        Else
            cod = DataGridView1.Item(0, curen).Value

            For i = 0 To DataSet1.Tables("producto").Rows.Count - 1


                If cod = DataSet1.Tables("producto").Rows(i).Item("codigo") Then

                    DataGridView1.Item(1, curen).Value = DataSet1.Tables("producto").Rows(i).Item("descripcion")
                    DataGridView1.Item(2, curen).Value = DataSet1.Tables("producto").Rows(i).Item("precio_venta")

                End If

            Next
        End If

        If DataGridView1.Item(3, curen).Value = "" Then

        Else
            DataGridView1.Item(4, curen).Value = DataGridView1.Item(3, curen).Value * DataGridView1.Item(2, curen).Value
            suma = 0
            For i = 0 To DataGridView1.RowCount - 1
                suma = suma + DataGridView1.Item(4, i).Value
                text_sub_total.Text = suma.ToString
                iva = suma * 0.1
                text_iva.Text = iva.ToString
                total = suma + iva

                text_total.Text = total.ToString

            Next

        End If
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

        Return i

    End Function

    Private Sub TextBox15_LostFocus(sender As Object, e As EventArgs) Handles text_ruc_venta.LostFocus
        Dim ruc As String
        ruc = funcion_buscar_cliente(text_ruc_venta.Text)

        If ruc < 0 Then
            label_ruc_venta.Text = "no se econtro cliente"

        End If


        label_ruc_venta.Text = funcion_buscar_cliente("hola")
    End Sub
End Class