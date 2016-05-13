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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GroupBoxCrearCliente.Hide()
        GroupBoxModificarCliente.Hide()
        GroupBoxEstadisticasdelCliente.Show()
    End Sub

    Private Sub CrearCliente_Click(sender As Object, e As EventArgs) Handles CrearCliente.Click
        GroupBoxCrearCliente.Show()
        GroupBoxModificarCliente.Hide()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        RucTextBox.Clear()
        NumeroTextBox.Clear()
        MailTextBox.Clear()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Label71.Hide()


        If NombreTextBox1.Text <> "" And ApellidoTextBox1.Text <> "" And RucTextBox1.Text <> "" And NumeroTextBox1.Text <> "" And MailTextBox1.Text <> "" Then


            Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()

            'nuevo_cliente("nombre") = NombreTextBox1.Text
            'nuevo_cliente("apellido") = ApellidoTextBox1.Text
            'nuevo_cliente("ruc") = RucTextBox1.Text
            'nuevo_cliente("numero") = NumeroTextBox1.Text
            'nuevo_cliente("mail") = MailTextBox.Text
            'nuevo_cliente("estado_cliente") = True
            'If CheckBoxClientePrioritario1.Checked Then
            '    nuevo_cliente("cliente_prioritario") = True
            'Else
            '    nuevo_cliente("cliente_prioritario") = False
            'End If




            Dim cantidad_de_clientes As Integer
            cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

            For i As Integer = 0 To (cantidad_de_clientes - 1)
                If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1.Text Then

                    DataSet1.Tables("cliente").Rows(i).Item("nombre") = NombreTextBox1.Text
                    DataSet1.Tables("cliente").Rows(i).Item("apellido") = ApellidoTextBox1.Text
                    DataSet1.Tables("cliente").Rows(i).Item("numero") = NumeroTextBox1.Text
                    DataSet1.Tables("cliente").Rows(i).Item("mail") = MailTextBox.Text
                    If CheckBoxClientePrioritario1.Checked Then
                        DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True
                    Else
                        DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = False
                    End If

                    i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido
                End If

            Next



            'DataSet1.Tables("cliente").Rows.Add(nuevo_cliente)


            Validate()
            UsuarioBindingSource.EndEdit()
            ClienteTableAdapter.Update(DataSet1.cliente)





        Else
            Label71.Show()
            Label71.Text = "Complete los campos vacíos"
            Label71.ForeColor = Color.Red
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

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        GroupBoxCrearCliente.Hide()
        GroupBoxModificarCliente.Show()
        GroupBoxEstadisticasdelCliente.Hide()

        NombreTextBox1.Clear()
        ApellidoTextBox1.Clear()
        RucTextBox1.Clear()
        NumeroTextBox1.Clear()
        MailTextBox1.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GroupBoxCrearCliente.Hide()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        GroupBoxModificarCliente.Hide()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        GroupBoxEstadisticasdelCliente.Hide()

    End Sub

    Private Sub GroupBoxCrearCliente_Enter(sender As Object, e As EventArgs) Handles GroupBoxCrearCliente.Enter

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Label72.Hide()


        If NombreTextBox.Text <> "" And ApellidoTextBox.Text <> "" And RucTextBox.Text <> "" And NumeroTextBox.Text <> "" And MailTextBox.Text <> "" Then


            Dim nuevo_cliente As DataRow = DataSet1.Tables("cliente").NewRow()

            nuevo_cliente("nombre") = NombreTextBox.Text
            nuevo_cliente("apellido") = ApellidoTextBox.Text
            nuevo_cliente("ruc") = RucTextBox.Text
            nuevo_cliente("numero") = NumeroTextBox.Text
            nuevo_cliente("mail") = MailTextBox.Text
            nuevo_cliente("estado_cliente") = True
            If CheckBoxClientePrioritario.Checked Then
                nuevo_cliente("cliente_prioritario") = True
            Else
                nuevo_cliente("cliente_prioritario") = False
            End If




            DataSet1.Tables("cliente").Rows.Add(nuevo_cliente)

            Validate()
            UsuarioBindingSource.EndEdit()
            ClienteTableAdapter.Update(DataSet1.cliente)





        Else
            Label72.Show()
            Label72.Text = "Complete los campos vacíos"
            Label72.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RucTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub RucTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles RucTextBox.TextChanged

    End Sub

    Private Sub RucTextBox_LostFocus(sender As Object, e As EventArgs) Handles RucTextBox.LostFocus
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox.Text Then

                'Si el RUC ingresado ya esta registrado'
                Label72.Show()
                Label72.Text = "RUC ya registrado"
                Label72.ForeColor = Color.Red

                RucTextBox.Text = ""
                RucTextBox.Focus()


                'si_ruc_no_es_repetido = 0
                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido
            Else
                Label72.Hide()
            End If
        Next

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count
        Dim ban_ruc_existe As Integer
        ban_ruc_existe = 0

        Label1.Text = "entre"
        Label1.Show()

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado existe'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1.Text Then
                'Si el cliente está habilitado (no está "borrado)
                If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = True Then
                    Label71.Hide()

                    RucTextBox.Text = ""
                    RucTextBox.Focus()

                    NombreTextBox1.ReadOnly = False
                    ApellidoTextBox1.ReadOnly = False
                    NumeroTextBox1.ReadOnly = False
                    MailTextBox1.ReadOnly = False

                    NombreTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("nombre")
                    ApellidoTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("apellido")
                    NumeroTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("numero")
                    MailTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("mail")

                    If DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True Then
                        CheckBoxClientePrioritario1.Checked = True
                    Else
                        CheckBoxClientePrioritario1.Checked = False
                    End If
                End If
                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                ban_ruc_existe = 1
            End If
        Next

        If ban_ruc_existe = 0 Then
            'Si el ruc ingresado NO existe
            Label1.Show()
            Label1.Text = "RUC no registrado"
            Label1.ForeColor = Color.Red

            RucTextBox.Text = ""
            RucTextBox.Focus()

            NombreTextBox1.Text = ""
            ApellidoTextBox1.Text = ""
            NumeroTextBox1.Text = ""
            MailTextBox1.Text = ""
            CheckBoxClientePrioritario1.Checked = False

            NombreTextBox1.ReadOnly = True
            ApellidoTextBox1.ReadOnly = True
            NumeroTextBox1.ReadOnly = True
            MailTextBox1.ReadOnly = True
        End If

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Dim cantidad_de_clientes As Integer
        cantidad_de_clientes = DataSet1.Tables("cliente").Rows.Count
        Dim ban_ruc_existe As Integer
        ban_ruc_existe = 0

        Label1.Text = "entre"
        Label1.Show()

        For i As Integer = 0 To (cantidad_de_clientes - 1)
            'Si el RUC ingresado existe'
            If DataSet1.Tables("cliente").Rows(i).Item("ruc") = RucTextBox1.Text Then
                'Si el cliente está habilitado (no está "borrado)
                If DataSet1.Tables("cliente").Rows(i).Item("estado_cliente") = True Then
                    Label71.Hide()

                    RucTextBox.Text = ""
                    RucTextBox.Focus()

                    NombreTextBox1.ReadOnly = False
                    ApellidoTextBox1.ReadOnly = False
                    NumeroTextBox1.ReadOnly = False
                    MailTextBox1.ReadOnly = False

                    NombreTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("nombre")
                    ApellidoTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("apellido")
                    NumeroTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("numero")
                    MailTextBox1.Text = DataSet1.Tables("cliente").Rows(i).Item("mail")

                    If DataSet1.Tables("cliente").Rows(i).Item("cliente_prioritario") = True Then
                        CheckBoxClientePrioritario1.Checked = True
                    Else
                        CheckBoxClientePrioritario1.Checked = False
                    End If
                End If
                i = cantidad_de_clientes - 1 'Para cortar el FOR, ya que se encontró RUC repetido

                ban_ruc_existe = 1
            End If
        Next

        If ban_ruc_existe = 0 Then
            'Si el ruc ingresado NO existe
            Label1.Show()
            Label1.Text = "RUC no registrado"
            Label1.ForeColor = Color.Red

            RucTextBox.Text = ""
            RucTextBox.Focus()

            NombreTextBox1.Text = ""
            ApellidoTextBox1.Text = ""
            NumeroTextBox1.Text = ""
            MailTextBox1.Text = ""
            CheckBoxClientePrioritario1.Checked = False

            NombreTextBox1.ReadOnly = True
            ApellidoTextBox1.ReadOnly = True
            NumeroTextBox1.ReadOnly = True
            MailTextBox1.ReadOnly = True
        End If

    End Sub
End Class