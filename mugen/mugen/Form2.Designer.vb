<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MailLabelM As System.Windows.Forms.Label
        Dim NumeroLabelN As System.Windows.Forms.Label
        Dim RucLabelR As System.Windows.Forms.Label
        Dim ApellidoLabelA As System.Windows.Forms.Label
        Dim NombreLabelN As System.Windows.Forms.Label
        Dim MailLabel1M As System.Windows.Forms.Label
        Dim NumeroLabel1N As System.Windows.Forms.Label
        Dim ApellidoLabel1A As System.Windows.Forms.Label
        Dim NombreLabel1N As System.Windows.Forms.Label
        Dim RucLabel1R As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Ingreso_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New mugen.DataSet1()
        Me.Contabilidad2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContabilidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Association_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Association_1TableAdapter = New mugen.DataSet1TableAdapters.association_1TableAdapter()
        Me.TableAdapterManager = New mugen.DataSet1TableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New mugen.DataSet1TableAdapters.clienteTableAdapter()
        Me.Contabilidad2TableAdapter = New mugen.DataSet1TableAdapters.contabilidad2TableAdapter()
        Me.ContabilidadTableAdapter = New mugen.DataSet1TableAdapters.contabilidadTableAdapter()
        Me.Ingreso_productoTableAdapter = New mugen.DataSet1TableAdapters.ingreso_productoTableAdapter()
        Me.PedidoTableAdapter = New mugen.DataSet1TableAdapters.pedidoTableAdapter()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Venta_servicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn107 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn108 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn109 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn111 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn112 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta_servicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venta_productoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn101 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn106 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn97 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn98 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn99 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingreso_productoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contabilidad2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContabilidadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Association_1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTableAdapter = New mugen.DataSet1TableAdapters.productoTableAdapter()
        Me.ProveedorTableAdapter = New mugen.DataSet1TableAdapters.proveedorTableAdapter()
        Me.UsuarioTableAdapter = New mugen.DataSet1TableAdapters.usuarioTableAdapter()
        Me.Venta_productoTableAdapter = New mugen.DataSet1TableAdapters.venta_productoTableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel_cuentas = New System.Windows.Forms.Panel()
        Me.panel_crear_usuarios = New System.Windows.Forms.Panel()
        Me.label_error_crear = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.textbox_mail = New System.Windows.Forms.TextBox()
        Me.textbox_numero = New System.Windows.Forms.TextBox()
        Me.textbox_apellido = New System.Windows.Forms.TextBox()
        Me.textbox_nombre = New System.Windows.Forms.TextBox()
        Me.textbox_rep_pass = New System.Windows.Forms.TextBox()
        Me.textbox_pass = New System.Windows.Forms.TextBox()
        Me.textbox_cuenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_mod_user = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.panel_mod_cuenta = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.texbox_nueva_pass_rep = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textbox_nueva_pass = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.textbox_mod_pass = New System.Windows.Forms.TextBox()
        Me.textbox_mod_cuenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panel_carga_presupuesto = New System.Windows.Forms.Panel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.aceptar_carga_presupuesto = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.panel_botones_mugen = New System.Windows.Forms.Panel()
        Me.boton_stock = New System.Windows.Forms.Button()
        Me.boton_vender = New System.Windows.Forms.Button()
        Me.boton_servicios = New System.Windows.Forms.Button()
        Me.panel_vender = New System.Windows.Forms.Panel()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.label_ruc_venta = New System.Windows.Forms.Label()
        Me.text_total = New System.Windows.Forms.TextBox()
        Me.label_total = New System.Windows.Forms.Label()
        Me.text_iva = New System.Windows.Forms.TextBox()
        Me.label_iva = New System.Windows.Forms.Label()
        Me.text_sub_total = New System.Windows.Forms.TextBox()
        Me.label_subtotal = New System.Windows.Forms.Label()
        Me.venta_guardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.label_venta_cliente = New System.Windows.Forms.Label()
        Me.text_ruc_venta = New System.Windows.Forms.TextBox()
        Me.label_ruc = New System.Windows.Forms.Label()
        Me.PanelClientes = New System.Windows.Forms.Panel()
        Me.ClienteDataGridView1ModificarCliente = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxCrearClienteasd = New System.Windows.Forms.GroupBox()
        Me.Label72CrearCliente = New System.Windows.Forms.Label()
        Me.MailTextBoxCrearCliente = New System.Windows.Forms.TextBox()
        Me.NumeroTextBoxCrearCliente = New System.Windows.Forms.TextBox()
        Me.RucTextBoxCrearCliente = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBoxCrearCliente = New System.Windows.Forms.TextBox()
        Me.NombreTextBoxCrearCliente = New System.Windows.Forms.TextBox()
        Me.CheckBoxClientePrioritarioCrearCliente = New System.Windows.Forms.CheckBox()
        Me.Button9CrearCliente = New System.Windows.Forms.Button()
        Me.CrearClienteBotonCrearCliente = New System.Windows.Forms.Button()
        Me.GroupBoxEstadisticasdelCliente = New System.Windows.Forms.GroupBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.EstadisticasDeClienteBoton = New System.Windows.Forms.Button()
        Me.GroupBoxModificarClienteasd = New System.Windows.Forms.GroupBox()
        Me.Label1ModificarCliente = New System.Windows.Forms.Label()
        Me.Button15ModificarCliente = New System.Windows.Forms.Button()
        Me.MailTextBox1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.RucTextBox1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.CheckBoxClientePrioritario1ModificarCliente = New System.Windows.Forms.CheckBox()
        Me.Button10ModificarCliente = New System.Windows.Forms.Button()
        Me.Button25ModificarCliente = New System.Windows.Forms.Button()
        Me.Button24ModificarCliente = New System.Windows.Forms.Button()
        Me.ModificarClienteBoton = New System.Windows.Forms.Button()
        Me.CrearClienteBoton = New System.Windows.Forms.Button()
        Me.PanelTrabajosPendientes = New System.Windows.Forms.Panel()
        Me.pedidoGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn95 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn96 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.graficoTrabajos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.graficoPagados = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btpGenerar = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.idClientesAux = New System.Windows.Forms.ListBox()
        Me.pbBorrar = New System.Windows.Forms.Button()
        Me.pbCambiar = New System.Windows.Forms.Button()
        Me.label47 = New System.Windows.Forms.Label()
        Me.pcEstado = New System.Windows.Forms.ComboBox()
        Me.idClienteActual = New System.Windows.Forms.Label()
        Me.noHayPendientes = New System.Windows.Forms.Label()
        Me.noExiste = New System.Windows.Forms.Label()
        Me.sinDatos = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextIden = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.calendarioCobro = New System.Windows.Forms.MonthCalendar()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.labelRuc = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.pcProyecto = New System.Windows.Forms.ComboBox()
        Me.ptNombre = New System.Windows.Forms.TextBox()
        Me.ptApellido = New System.Windows.Forms.TextBox()
        Me.ptRuc = New System.Windows.Forms.TextBox()
        Me.ptDescrip = New System.Windows.Forms.TextBox()
        Me.ptEntrega = New System.Windows.Forms.TextBox()
        Me.ptCobro = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.ptPrecio = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.botonBuscar = New System.Windows.Forms.Button()
        Me.calendarioEntregas = New System.Windows.Forms.MonthCalendar()
        Me.resultadosPedidos = New System.Windows.Forms.ListBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextCliente = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox4Stock = New System.Windows.Forms.GroupBox()
        Me.GroupBoxModificarProducto = New System.Windows.Forms.GroupBox()
        Me.LabelModificarProducto = New System.Windows.Forms.Label()
        Me.ButtonCerrar3 = New System.Windows.Forms.Button()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.TextBoxPrecio2 = New System.Windows.Forms.TextBox()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion2 = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxCodigo2 = New System.Windows.Forms.TextBox()
        Me.LabelCodigo = New System.Windows.Forms.Label()
        Me.GroupBoxIngresodeProducto = New System.Windows.Forms.GroupBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TextBoxDeshabilitado2 = New System.Windows.Forms.TextBox()
        Me.TextBoxDeshabilitado = New System.Windows.Forms.TextBox()
        Me.LabelIngresoProducto = New System.Windows.Forms.Label()
        Me.ButtonCerrar2 = New System.Windows.Forms.Button()
        Me.ButtonInsertarProducto = New System.Windows.Forms.Button()
        Me.TextBoxIVA = New System.Windows.Forms.TextBox()
        Me.TextBoxPreciodeCompra = New System.Windows.Forms.TextBox()
        Me.TextBoxProveedor = New System.Windows.Forms.TextBox()
        Me.TextBoxFacturaNro = New System.Windows.Forms.TextBox()
        Me.TextBoxSeleccionarCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxSeleccionarProducto = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.GroupBoxNuevoProducto = New System.Windows.Forms.GroupBox()
        Me.LabelNuevoProducto = New System.Windows.Forms.Label()
        Me.ButtonCerrar1 = New System.Windows.Forms.Button()
        Me.ButtonCrearProducto = New System.Windows.Forms.Button()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label43d = New System.Windows.Forms.Label()
        Me.Label42s = New System.Windows.Forms.Label()
        Me.Label41a = New System.Windows.Forms.Label()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button24NuevoProducto = New System.Windows.Forms.Button()
        Me.ServicioTableAdapter = New mugen.DataSet1TableAdapters.servicioTableAdapter()
        Me.Venta_servicioTableAdapter = New mugen.DataSet1TableAdapters.venta_servicioTableAdapter()
        Me.label_n_factura = New System.Windows.Forms.Label()
        Me.n_factura_textbox = New System.Windows.Forms.TextBox()
        MailLabelM = New System.Windows.Forms.Label()
        NumeroLabelN = New System.Windows.Forms.Label()
        RucLabelR = New System.Windows.Forms.Label()
        ApellidoLabelA = New System.Windows.Forms.Label()
        NombreLabelN = New System.Windows.Forms.Label()
        MailLabel1M = New System.Windows.Forms.Label()
        NumeroLabel1N = New System.Windows.Forms.Label()
        ApellidoLabel1A = New System.Windows.Forms.Label()
        NombreLabel1N = New System.Windows.Forms.Label()
        RucLabel1R = New System.Windows.Forms.Label()
        CType(Me.Ingreso_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contabilidad2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContabilidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Association_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Venta_servicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_servicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_productoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venta_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingreso_productoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contabilidad2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContabilidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Association_1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_cuentas.SuspendLayout()
        Me.panel_crear_usuarios.SuspendLayout()
        Me.Panel_mod_user.SuspendLayout()
        Me.panel_mod_cuenta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panel_carga_presupuesto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panel_botones_mugen.SuspendLayout()
        Me.panel_vender.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelClientes.SuspendLayout()
        CType(Me.ClienteDataGridView1ModificarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCrearClienteasd.SuspendLayout()
        Me.GroupBoxEstadisticasdelCliente.SuspendLayout()
        Me.GroupBoxModificarClienteasd.SuspendLayout()
        Me.PanelTrabajosPendientes.SuspendLayout()
        CType(Me.pedidoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graficoTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graficoPagados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4Stock.SuspendLayout()
        Me.GroupBoxModificarProducto.SuspendLayout()
        Me.GroupBoxIngresodeProducto.SuspendLayout()
        Me.GroupBoxNuevoProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'MailLabelM
        '
        MailLabelM.AutoSize = True
        MailLabelM.Location = New System.Drawing.Point(63, 168)
        MailLabelM.Name = "MailLabelM"
        MailLabelM.Size = New System.Drawing.Size(29, 13)
        MailLabelM.TabIndex = 8
        MailLabelM.Text = "Mail:"
        '
        'NumeroLabelN
        '
        NumeroLabelN.AutoSize = True
        NumeroLabelN.Location = New System.Drawing.Point(45, 140)
        NumeroLabelN.Name = "NumeroLabelN"
        NumeroLabelN.Size = New System.Drawing.Size(47, 13)
        NumeroLabelN.TabIndex = 6
        NumeroLabelN.Text = "Número:"
        '
        'RucLabelR
        '
        RucLabelR.AutoSize = True
        RucLabelR.Location = New System.Drawing.Point(59, 112)
        RucLabelR.Name = "RucLabelR"
        RucLabelR.Size = New System.Drawing.Size(33, 13)
        RucLabelR.TabIndex = 4
        RucLabelR.Text = "RUC:"
        '
        'ApellidoLabelA
        '
        ApellidoLabelA.AutoSize = True
        ApellidoLabelA.Location = New System.Drawing.Point(45, 84)
        ApellidoLabelA.Name = "ApellidoLabelA"
        ApellidoLabelA.Size = New System.Drawing.Size(47, 13)
        ApellidoLabelA.TabIndex = 2
        ApellidoLabelA.Text = "Apellido:"
        '
        'NombreLabelN
        '
        NombreLabelN.AutoSize = True
        NombreLabelN.Location = New System.Drawing.Point(45, 56)
        NombreLabelN.Name = "NombreLabelN"
        NombreLabelN.Size = New System.Drawing.Size(47, 13)
        NombreLabelN.TabIndex = 0
        NombreLabelN.Text = "Nombre:"
        '
        'MailLabel1M
        '
        MailLabel1M.AutoSize = True
        MailLabel1M.Location = New System.Drawing.Point(39, 170)
        MailLabel1M.Name = "MailLabel1M"
        MailLabel1M.Size = New System.Drawing.Size(29, 13)
        MailLabel1M.TabIndex = 8
        MailLabel1M.Text = "Mail:"
        '
        'NumeroLabel1N
        '
        NumeroLabel1N.AutoSize = True
        NumeroLabel1N.Location = New System.Drawing.Point(22, 139)
        NumeroLabel1N.Name = "NumeroLabel1N"
        NumeroLabel1N.Size = New System.Drawing.Size(47, 13)
        NumeroLabel1N.TabIndex = 6
        NumeroLabel1N.Text = "Número:"
        '
        'ApellidoLabel1A
        '
        ApellidoLabel1A.AutoSize = True
        ApellidoLabel1A.Location = New System.Drawing.Point(21, 108)
        ApellidoLabel1A.Name = "ApellidoLabel1A"
        ApellidoLabel1A.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel1A.TabIndex = 4
        ApellidoLabel1A.Text = "Apellido:"
        '
        'NombreLabel1N
        '
        NombreLabel1N.AutoSize = True
        NombreLabel1N.Location = New System.Drawing.Point(22, 77)
        NombreLabel1N.Name = "NombreLabel1N"
        NombreLabel1N.Size = New System.Drawing.Size(47, 13)
        NombreLabel1N.TabIndex = 2
        NombreLabel1N.Text = "Nombre:"
        '
        'RucLabel1R
        '
        RucLabel1R.AutoSize = True
        RucLabel1R.Location = New System.Drawing.Point(42, 46)
        RucLabel1R.Name = "RucLabel1R"
        RucLabel1R.Size = New System.Drawing.Size(33, 13)
        RucLabel1R.TabIndex = 0
        RucLabel1R.Text = "RUC:"
        '
        'Ingreso_productoBindingSource
        '
        Me.Ingreso_productoBindingSource.DataMember = "ingreso_producto"
        Me.Ingreso_productoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Contabilidad2BindingSource
        '
        Me.Contabilidad2BindingSource.DataMember = "contabilidad2"
        Me.Contabilidad2BindingSource.DataSource = Me.DataSet1
        '
        'ContabilidadBindingSource
        '
        Me.ContabilidadBindingSource.DataMember = "contabilidad"
        Me.ContabilidadBindingSource.DataSource = Me.DataSet1
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'Association_1BindingSource
        '
        Me.Association_1BindingSource.DataMember = "association_1"
        Me.Association_1BindingSource.DataSource = Me.DataSet1
        '
        'Association_1TableAdapter
        '
        Me.Association_1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.association_1TableAdapter = Me.Association_1TableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.contabilidad2TableAdapter = Me.Contabilidad2TableAdapter
        Me.TableAdapterManager.contabilidadTableAdapter = Me.ContabilidadTableAdapter
        Me.TableAdapterManager.ingreso_productoTableAdapter = Me.Ingreso_productoTableAdapter
        Me.TableAdapterManager.pedidoTableAdapter = Me.PedidoTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.servicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = mugen.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.venta_productoTableAdapter = Nothing
        Me.TableAdapterManager.venta_servicioTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Contabilidad2TableAdapter
        '
        Me.Contabilidad2TableAdapter.ClearBeforeFill = True
        '
        'ContabilidadTableAdapter
        '
        Me.ContabilidadTableAdapter.ClearBeforeFill = True
        '
        'Ingreso_productoTableAdapter
        '
        Me.Ingreso_productoTableAdapter.ClearBeforeFill = True
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "pedido"
        Me.PedidoBindingSource.DataSource = Me.DataSet1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Venta_servicioDataGridView)
        Me.Panel1.Controls.Add(Me.Venta_productoDataGridView)
        Me.Panel1.Controls.Add(Me.UsuarioDataGridView)
        Me.Panel1.Controls.Add(Me.ServicioDataGridView)
        Me.Panel1.Controls.Add(Me.ProveedorDataGridView)
        Me.Panel1.Controls.Add(Me.ProductoDataGridView)
        Me.Panel1.Controls.Add(Me.PedidoDataGridView)
        Me.Panel1.Controls.Add(Me.Ingreso_productoDataGridView)
        Me.Panel1.Controls.Add(Me.Contabilidad2DataGridView)
        Me.Panel1.Controls.Add(Me.ContabilidadDataGridView)
        Me.Panel1.Controls.Add(Me.ClienteDataGridView)
        Me.Panel1.Controls.Add(Me.Association_1DataGridView)
        Me.Panel1.Location = New System.Drawing.Point(90, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 605)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'Venta_servicioDataGridView
        '
        Me.Venta_servicioDataGridView.AutoGenerateColumns = False
        Me.Venta_servicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venta_servicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn107, Me.DataGridViewTextBoxColumn108, Me.DataGridViewTextBoxColumn109, Me.DataGridViewTextBoxColumn110, Me.DataGridViewTextBoxColumn111, Me.DataGridViewTextBoxColumn112})
        Me.Venta_servicioDataGridView.DataSource = Me.Venta_servicioBindingSource
        Me.Venta_servicioDataGridView.Location = New System.Drawing.Point(631, 85)
        Me.Venta_servicioDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Venta_servicioDataGridView.Name = "Venta_servicioDataGridView"
        Me.Venta_servicioDataGridView.RowTemplate.Height = 28
        Me.Venta_servicioDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.Venta_servicioDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn107
        '
        Me.DataGridViewTextBoxColumn107.DataPropertyName = "id_venta_servicio"
        Me.DataGridViewTextBoxColumn107.HeaderText = "id_venta_servicio"
        Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
        '
        'DataGridViewTextBoxColumn108
        '
        Me.DataGridViewTextBoxColumn108.DataPropertyName = "id_servicio"
        Me.DataGridViewTextBoxColumn108.HeaderText = "id_servicio"
        Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
        '
        'DataGridViewTextBoxColumn109
        '
        Me.DataGridViewTextBoxColumn109.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn109.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
        '
        'DataGridViewTextBoxColumn110
        '
        Me.DataGridViewTextBoxColumn110.DataPropertyName = "fecha_venta_servicio"
        Me.DataGridViewTextBoxColumn110.HeaderText = "fecha_venta_servicio"
        Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
        '
        'DataGridViewTextBoxColumn111
        '
        Me.DataGridViewTextBoxColumn111.DataPropertyName = "precio_venta_servicio"
        Me.DataGridViewTextBoxColumn111.HeaderText = "precio_venta_servicio"
        Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
        '
        'DataGridViewTextBoxColumn112
        '
        Me.DataGridViewTextBoxColumn112.DataPropertyName = "n_factura_venta_servicio"
        Me.DataGridViewTextBoxColumn112.HeaderText = "n_factura_venta_servicio"
        Me.DataGridViewTextBoxColumn112.Name = "DataGridViewTextBoxColumn112"
        '
        'Venta_servicioBindingSource
        '
        Me.Venta_servicioBindingSource.DataMember = "venta_servicio"
        Me.Venta_servicioBindingSource.DataSource = Me.DataSet1
        '
        'Venta_productoDataGridView
        '
        Me.Venta_productoDataGridView.AutoGenerateColumns = False
        Me.Venta_productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venta_productoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn101, Me.DataGridViewTextBoxColumn102, Me.DataGridViewTextBoxColumn103, Me.DataGridViewTextBoxColumn104, Me.DataGridViewTextBoxColumn105, Me.DataGridViewTextBoxColumn106})
        Me.Venta_productoDataGridView.DataSource = Me.Venta_productoBindingSource
        Me.Venta_productoDataGridView.Location = New System.Drawing.Point(609, 55)
        Me.Venta_productoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Venta_productoDataGridView.Name = "Venta_productoDataGridView"
        Me.Venta_productoDataGridView.RowTemplate.Height = 28
        Me.Venta_productoDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.Venta_productoDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn101
        '
        Me.DataGridViewTextBoxColumn101.DataPropertyName = "id_venta_producto"
        Me.DataGridViewTextBoxColumn101.HeaderText = "id_venta_producto"
        Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.DataPropertyName = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn102.HeaderText = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn103.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        '
        'DataGridViewTextBoxColumn104
        '
        Me.DataGridViewTextBoxColumn104.DataPropertyName = "fecha_venta"
        Me.DataGridViewTextBoxColumn104.HeaderText = "fecha_venta"
        Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
        '
        'DataGridViewTextBoxColumn105
        '
        Me.DataGridViewTextBoxColumn105.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn105.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
        '
        'DataGridViewTextBoxColumn106
        '
        Me.DataGridViewTextBoxColumn106.DataPropertyName = "n_factura_venta_producto"
        Me.DataGridViewTextBoxColumn106.HeaderText = "n_factura_venta_producto"
        Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
        '
        'Venta_productoBindingSource
        '
        Me.Venta_productoBindingSource.DataMember = "venta_producto"
        Me.Venta_productoBindingSource.DataSource = Me.DataSet1
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn97, Me.DataGridViewTextBoxColumn98, Me.DataGridViewTextBoxColumn99, Me.DataGridViewTextBoxColumn100})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(581, 33)
        Me.UsuarioDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.RowTemplate.Height = 28
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.UsuarioDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn56.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn57.HeaderText = "cuenta"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "pass"
        Me.DataGridViewTextBoxColumn58.HeaderText = "pass"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "nivel"
        Me.DataGridViewTextBoxColumn59.HeaderText = "nivel"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "estado_usuario"
        Me.DataGridViewTextBoxColumn60.HeaderText = "estado_usuario"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn97
        '
        Me.DataGridViewTextBoxColumn97.DataPropertyName = "nombre_usuario"
        Me.DataGridViewTextBoxColumn97.HeaderText = "nombre_usuario"
        Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
        '
        'DataGridViewTextBoxColumn98
        '
        Me.DataGridViewTextBoxColumn98.DataPropertyName = "apellido_usuario"
        Me.DataGridViewTextBoxColumn98.HeaderText = "apellido_usuario"
        Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
        '
        'DataGridViewTextBoxColumn99
        '
        Me.DataGridViewTextBoxColumn99.DataPropertyName = "numero_usuario"
        Me.DataGridViewTextBoxColumn99.HeaderText = "numero_usuario"
        Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
        '
        'DataGridViewTextBoxColumn100
        '
        Me.DataGridViewTextBoxColumn100.DataPropertyName = "mail_usuario"
        Me.DataGridViewTextBoxColumn100.HeaderText = "mail_usuario"
        Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "usuario"
        Me.UsuarioBindingSource.DataSource = Me.DataSet1
        '
        'ServicioDataGridView
        '
        Me.ServicioDataGridView.AutoGenerateColumns = False
        Me.ServicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55})
        Me.ServicioDataGridView.DataSource = Me.ServicioBindingSource
        Me.ServicioDataGridView.Location = New System.Drawing.Point(557, 14)
        Me.ServicioDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ServicioDataGridView.Name = "ServicioDataGridView"
        Me.ServicioDataGridView.RowTemplate.Height = 28
        Me.ServicioDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.ServicioDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "id_servicio"
        Me.DataGridViewTextBoxColumn52.HeaderText = "id_servicio"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "nombre_servicio"
        Me.DataGridViewTextBoxColumn53.HeaderText = "nombre_servicio"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "descripcion_servicio"
        Me.DataGridViewTextBoxColumn54.HeaderText = "descripcion_servicio"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "forma_calculo"
        Me.DataGridViewTextBoxColumn55.HeaderText = "forma_calculo"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "servicio"
        Me.ServicioBindingSource.DataSource = Me.DataSet1
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(349, 68)
        Me.ProveedorDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.RowTemplate.Height = 28
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.ProveedorDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn49.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn50.HeaderText = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn51.HeaderText = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSet1
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(321, 47)
        Me.ProductoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.RowTemplate.Height = 28
        Me.ProductoDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.ProductoDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn45.HeaderText = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn46.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn47.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn48.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.DataSet1
        '
        'PedidoDataGridView
        '
        Me.PedidoDataGridView.AutoGenerateColumns = False
        Me.PedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44})
        Me.PedidoDataGridView.DataSource = Me.PedidoBindingSource
        Me.PedidoDataGridView.Location = New System.Drawing.Point(294, 27)
        Me.PedidoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.PedidoDataGridView.Name = "PedidoDataGridView"
        Me.PedidoDataGridView.RowTemplate.Height = 28
        Me.PedidoDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.PedidoDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "id_pedido"
        Me.DataGridViewTextBoxColumn36.HeaderText = "id_pedido"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn37.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn38.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "plazo_entrega"
        Me.DataGridViewTextBoxColumn39.HeaderText = "plazo_entrega"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "plazo_cobro"
        Me.DataGridViewTextBoxColumn40.HeaderText = "plazo_cobro"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "oferta"
        Me.DataGridViewTextBoxColumn41.HeaderText = "oferta"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn42.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn43.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "nombre_pedido"
        Me.DataGridViewTextBoxColumn44.HeaderText = "nombre_pedido"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'Ingreso_productoDataGridView
        '
        Me.Ingreso_productoDataGridView.AutoGenerateColumns = False
        Me.Ingreso_productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ingreso_productoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.Ingreso_productoDataGridView.DataSource = Me.Ingreso_productoBindingSource
        Me.Ingreso_productoDataGridView.Location = New System.Drawing.Point(267, 6)
        Me.Ingreso_productoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Ingreso_productoDataGridView.Name = "Ingreso_productoDataGridView"
        Me.Ingreso_productoDataGridView.RowTemplate.Height = 28
        Me.Ingreso_productoDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.Ingreso_productoDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "id_ingreso_producto"
        Me.DataGridViewTextBoxColumn28.HeaderText = "id_ingreso_producto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn29.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn30.HeaderText = "id_stock_mugen"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn31.HeaderText = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "numero_factura_ingreso"
        Me.DataGridViewTextBoxColumn32.HeaderText = "numero_factura_ingreso"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "cantidad_ingreso"
        Me.DataGridViewTextBoxColumn33.HeaderText = "cantidad_ingreso"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn34.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "precio_compra_unitario"
        Me.DataGridViewTextBoxColumn35.HeaderText = "precio_compra_unitario"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'Contabilidad2DataGridView
        '
        Me.Contabilidad2DataGridView.AutoGenerateColumns = False
        Me.Contabilidad2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Contabilidad2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.Contabilidad2DataGridView.DataSource = Me.Contabilidad2BindingSource
        Me.Contabilidad2DataGridView.Location = New System.Drawing.Point(62, 47)
        Me.Contabilidad2DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Contabilidad2DataGridView.Name = "Contabilidad2DataGridView"
        Me.Contabilidad2DataGridView.RowTemplate.Height = 28
        Me.Contabilidad2DataGridView.Size = New System.Drawing.Size(200, 143)
        Me.Contabilidad2DataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_contabilidad3"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_contabilidad3"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "descripcion_modificacion"
        Me.DataGridViewTextBoxColumn20.HeaderText = "descripcion_modificacion"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "fecha_modificacion"
        Me.DataGridViewTextBoxColumn21.HeaderText = "fecha_modificacion"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "deber2"
        Me.DataGridViewTextBoxColumn22.HeaderText = "deber2"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "haber2"
        Me.DataGridViewTextBoxColumn23.HeaderText = "haber2"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "fecha2"
        Me.DataGridViewTextBoxColumn24.HeaderText = "fecha2"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "saldo2"
        Me.DataGridViewTextBoxColumn25.HeaderText = "saldo2"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "numero_factura2"
        Me.DataGridViewTextBoxColumn26.HeaderText = "numero_factura2"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "descripcion2"
        Me.DataGridViewTextBoxColumn27.HeaderText = "descripcion2"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'ContabilidadDataGridView
        '
        Me.ContabilidadDataGridView.AutoGenerateColumns = False
        Me.ContabilidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContabilidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ContabilidadDataGridView.DataSource = Me.ContabilidadBindingSource
        Me.ContabilidadDataGridView.Location = New System.Drawing.Point(48, 32)
        Me.ContabilidadDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ContabilidadDataGridView.Name = "ContabilidadDataGridView"
        Me.ContabilidadDataGridView.RowTemplate.Height = 28
        Me.ContabilidadDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.ContabilidadDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "id_contabilidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "id_contabilidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "deber"
        Me.DataGridViewTextBoxColumn14.HeaderText = "deber"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "haber"
        Me.DataGridViewTextBoxColumn15.HeaderText = "haber"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "saldo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "saldo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "numero_factura"
        Me.DataGridViewTextBoxColumn18.HeaderText = "numero_factura"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(27, 20)
        Me.ClienteDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowTemplate.Height = 28
        Me.ClienteDataGridView.Size = New System.Drawing.Size(200, 143)
        Me.ClienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ruc"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ruc"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn7.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn8.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "estado_cliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "estado_cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Association_1DataGridView
        '
        Me.Association_1DataGridView.AutoGenerateColumns = False
        Me.Association_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Association_1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Association_1DataGridView.DataSource = Me.Association_1BindingSource
        Me.Association_1DataGridView.Location = New System.Drawing.Point(7, 5)
        Me.Association_1DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Association_1DataGridView.Name = "Association_1DataGridView"
        Me.Association_1DataGridView.RowTemplate.Height = 28
        Me.Association_1DataGridView.Size = New System.Drawing.Size(200, 143)
        Me.Association_1DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_contabilidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_contabilidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Venta_productoTableAdapter
        '
        Me.Venta_productoTableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1180, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 23)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Contabilidad"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(177, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(161, 23)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Administrar cuentas"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(846, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Cargar Gastos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(512, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Clientes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(679, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Trabajos Pendientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Realizar Cobro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cargar Presupuesto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panel_cuentas
        '
        Me.panel_cuentas.Controls.Add(Me.panel_crear_usuarios)
        Me.panel_cuentas.Controls.Add(Me.Button9)
        Me.panel_cuentas.Controls.Add(Me.Button8)
        Me.panel_cuentas.Controls.Add(Me.Label1)
        Me.panel_cuentas.Controls.Add(Me.Panel_mod_user)
        Me.panel_cuentas.Location = New System.Drawing.Point(21, 88)
        Me.panel_cuentas.Name = "panel_cuentas"
        Me.panel_cuentas.Size = New System.Drawing.Size(1167, 684)
        Me.panel_cuentas.TabIndex = 22
        Me.panel_cuentas.Visible = False
        '
        'panel_crear_usuarios
        '
        Me.panel_crear_usuarios.Controls.Add(Me.label_error_crear)
        Me.panel_crear_usuarios.Controls.Add(Me.Button11)
        Me.panel_crear_usuarios.Controls.Add(Me.Button10)
        Me.panel_crear_usuarios.Controls.Add(Me.ComboBox1)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_mail)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_numero)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_apellido)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_nombre)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_rep_pass)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_pass)
        Me.panel_crear_usuarios.Controls.Add(Me.textbox_cuenta)
        Me.panel_crear_usuarios.Controls.Add(Me.Label10)
        Me.panel_crear_usuarios.Controls.Add(Me.Label9)
        Me.panel_crear_usuarios.Controls.Add(Me.Label8)
        Me.panel_crear_usuarios.Controls.Add(Me.Label7)
        Me.panel_crear_usuarios.Controls.Add(Me.Label6)
        Me.panel_crear_usuarios.Controls.Add(Me.Label4)
        Me.panel_crear_usuarios.Controls.Add(Me.Label3)
        Me.panel_crear_usuarios.Controls.Add(Me.Label5)
        Me.panel_crear_usuarios.Controls.Add(Me.Label2)
        Me.panel_crear_usuarios.Location = New System.Drawing.Point(190, 51)
        Me.panel_crear_usuarios.Name = "panel_crear_usuarios"
        Me.panel_crear_usuarios.Size = New System.Drawing.Size(314, 303)
        Me.panel_crear_usuarios.TabIndex = 3
        Me.panel_crear_usuarios.Visible = False
        '
        'label_error_crear
        '
        Me.label_error_crear.AutoSize = True
        Me.label_error_crear.Location = New System.Drawing.Point(81, 222)
        Me.label_error_crear.Name = "label_error_crear"
        Me.label_error_crear.Size = New System.Drawing.Size(0, 13)
        Me.label_error_crear.TabIndex = 19
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(217, 266)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "Cerrar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(135, 267)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Aceptar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrador", "Usuario Normal"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 191)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'textbox_mail
        '
        Me.textbox_mail.Location = New System.Drawing.Point(145, 169)
        Me.textbox_mail.Name = "textbox_mail"
        Me.textbox_mail.Size = New System.Drawing.Size(147, 20)
        Me.textbox_mail.TabIndex = 15
        '
        'textbox_numero
        '
        Me.textbox_numero.Location = New System.Drawing.Point(145, 147)
        Me.textbox_numero.Name = "textbox_numero"
        Me.textbox_numero.Size = New System.Drawing.Size(147, 20)
        Me.textbox_numero.TabIndex = 14
        '
        'textbox_apellido
        '
        Me.textbox_apellido.Location = New System.Drawing.Point(145, 126)
        Me.textbox_apellido.Name = "textbox_apellido"
        Me.textbox_apellido.Size = New System.Drawing.Size(147, 20)
        Me.textbox_apellido.TabIndex = 13
        '
        'textbox_nombre
        '
        Me.textbox_nombre.Location = New System.Drawing.Point(145, 105)
        Me.textbox_nombre.Name = "textbox_nombre"
        Me.textbox_nombre.Size = New System.Drawing.Size(147, 20)
        Me.textbox_nombre.TabIndex = 12
        '
        'textbox_rep_pass
        '
        Me.textbox_rep_pass.Location = New System.Drawing.Point(145, 82)
        Me.textbox_rep_pass.Name = "textbox_rep_pass"
        Me.textbox_rep_pass.Size = New System.Drawing.Size(147, 20)
        Me.textbox_rep_pass.TabIndex = 11
        '
        'textbox_pass
        '
        Me.textbox_pass.Location = New System.Drawing.Point(145, 60)
        Me.textbox_pass.Name = "textbox_pass"
        Me.textbox_pass.Size = New System.Drawing.Size(147, 20)
        Me.textbox_pass.TabIndex = 10
        '
        'textbox_cuenta
        '
        Me.textbox_cuenta.Location = New System.Drawing.Point(145, 36)
        Me.textbox_cuenta.Name = "textbox_cuenta"
        Me.textbox_cuenta.Size = New System.Drawing.Size(147, 20)
        Me.textbox_cuenta.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nivel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Repetir Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Crear Usuario"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(29, 81)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(124, 23)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "Modificar Usuario"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(29, 51)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(124, 23)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Crear Usuario"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administrador de usuarios"
        '
        'Panel_mod_user
        '
        Me.Panel_mod_user.Controls.Add(Me.Label21)
        Me.Panel_mod_user.Controls.Add(Me.RichTextBox1)
        Me.Panel_mod_user.Controls.Add(Me.panel_mod_cuenta)
        Me.Panel_mod_user.Controls.Add(Me.Button12)
        Me.Panel_mod_user.Controls.Add(Me.textbox_mod_pass)
        Me.Panel_mod_user.Controls.Add(Me.textbox_mod_cuenta)
        Me.Panel_mod_user.Controls.Add(Me.Label13)
        Me.Panel_mod_user.Controls.Add(Me.Label12)
        Me.Panel_mod_user.Controls.Add(Me.Label11)
        Me.Panel_mod_user.Location = New System.Drawing.Point(510, 51)
        Me.Panel_mod_user.Name = "Panel_mod_user"
        Me.Panel_mod_user.Size = New System.Drawing.Size(637, 487)
        Me.Panel_mod_user.TabIndex = 4
        Me.Panel_mod_user.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(32, 126)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 13)
        Me.Label21.TabIndex = 36
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(299, 17)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(322, 96)
        Me.RichTextBox1.TabIndex = 35
        Me.RichTextBox1.Text = "Escriba la cuenta y la contraseña del usuario que desee modificar"
        Me.RichTextBox1.ZoomFactor = 2.0!
        '
        'panel_mod_cuenta
        '
        Me.panel_mod_cuenta.Controls.Add(Me.GroupBox2)
        Me.panel_mod_cuenta.Controls.Add(Me.GroupBox1)
        Me.panel_mod_cuenta.Location = New System.Drawing.Point(23, 155)
        Me.panel_mod_cuenta.Name = "panel_mod_cuenta"
        Me.panel_mod_cuenta.Size = New System.Drawing.Size(598, 308)
        Me.panel_mod_cuenta.TabIndex = 23
        Me.panel_mod_cuenta.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Button16)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 289)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar Datos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 151)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 13)
        Me.Label23.TabIndex = 29
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(178, 201)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 23)
        Me.Button16.TabIndex = 23
        Me.Button16.Text = "Aceptar"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Administrador", "Usuario Normal"})
        Me.ComboBox2.Location = New System.Drawing.Point(106, 103)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox2.TabIndex = 28
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 20)
        Me.TextBox3.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Nombre"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Apellido"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Numero"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(106, 17)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 20)
        Me.TextBox4.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Mail"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Nivel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.texbox_nueva_pass_rep)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.textbox_nueva_pass)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambiar Contraseña"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 23
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(169, 106)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 21
        Me.Button13.Text = "Aceptar"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'texbox_nueva_pass_rep
        '
        Me.texbox_nueva_pass_rep.Location = New System.Drawing.Point(145, 36)
        Me.texbox_nueva_pass_rep.Name = "texbox_nueva_pass_rep"
        Me.texbox_nueva_pass_rep.Size = New System.Drawing.Size(100, 20)
        Me.texbox_nueva_pass_rep.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Repetir Contraseña"
        '
        'textbox_nueva_pass
        '
        Me.textbox_nueva_pass.Location = New System.Drawing.Point(145, 14)
        Me.textbox_nueva_pass.Name = "textbox_nueva_pass"
        Me.textbox_nueva_pass.Size = New System.Drawing.Size(100, 20)
        Me.textbox_nueva_pass.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nueva Contraseña"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(161, 90)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(115, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "Modificar Cuenta"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'textbox_mod_pass
        '
        Me.textbox_mod_pass.Location = New System.Drawing.Point(160, 60)
        Me.textbox_mod_pass.Name = "textbox_mod_pass"
        Me.textbox_mod_pass.Size = New System.Drawing.Size(116, 20)
        Me.textbox_mod_pass.TabIndex = 21
        '
        'textbox_mod_cuenta
        '
        Me.textbox_mod_cuenta.Location = New System.Drawing.Point(160, 32)
        Me.textbox_mod_cuenta.Name = "textbox_mod_cuenta"
        Me.textbox_mod_cuenta.Size = New System.Drawing.Size(116, 20)
        Me.textbox_mod_cuenta.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Contraseña"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Cuenta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Modificar Usuario"
        '
        'panel_carga_presupuesto
        '
        Me.panel_carga_presupuesto.Controls.Add(Me.Label70)
        Me.panel_carga_presupuesto.Controls.Add(Me.TextBox22)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label69)
        Me.panel_carga_presupuesto.Controls.Add(Me.GroupBox3)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label30)
        Me.panel_carga_presupuesto.Controls.Add(Me.ComboBox3)
        Me.panel_carga_presupuesto.Controls.Add(Me.Button17)
        Me.panel_carga_presupuesto.Controls.Add(Me.MonthCalendar1)
        Me.panel_carga_presupuesto.Controls.Add(Me.Button15)
        Me.panel_carga_presupuesto.Controls.Add(Me.aceptar_carga_presupuesto)
        Me.panel_carga_presupuesto.Controls.Add(Me.TextBox8)
        Me.panel_carga_presupuesto.Controls.Add(Me.RichTextBox2)
        Me.panel_carga_presupuesto.Controls.Add(Me.TextBox7)
        Me.panel_carga_presupuesto.Controls.Add(Me.TextBox6)
        Me.panel_carga_presupuesto.Controls.Add(Me.TextBox5)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label29)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label28)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label27)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label26)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label25)
        Me.panel_carga_presupuesto.Controls.Add(Me.Label24)
        Me.panel_carga_presupuesto.Location = New System.Drawing.Point(18, 93)
        Me.panel_carga_presupuesto.Name = "panel_carga_presupuesto"
        Me.panel_carga_presupuesto.Size = New System.Drawing.Size(1167, 606)
        Me.panel_carga_presupuesto.TabIndex = 23
        Me.panel_carga_presupuesto.Visible = False
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(197, 365)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(45, 13)
        Me.Label70.TabIndex = 23
        Me.Label70.Text = "Label70"
        Me.Label70.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(199, 75)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(283, 20)
        Me.TextBox22.TabIndex = 22
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(29, 77)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(33, 13)
        Me.Label69.TabIndex = 21
        Me.Label69.Text = "Titulo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.TextBox14)
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Button19)
        Me.GroupBox3.Controls.Add(Me.Button18)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Location = New System.Drawing.Point(533, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(611, 422)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Cliente"
        Me.GroupBox3.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(369, 66)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(0, 13)
        Me.Label40.TabIndex = 17
        Me.Label40.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(369, 33)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(0, 13)
        Me.Label39.TabIndex = 16
        Me.Label39.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(154, 237)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(0, 13)
        Me.Label38.TabIndex = 15
        Me.Label38.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(369, 134)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(0, 13)
        Me.Label37.TabIndex = 14
        Me.Label37.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(154, 199)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(192, 20)
        Me.TextBox14.TabIndex = 13
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(153, 161)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(193, 20)
        Me.TextBox13.TabIndex = 12
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(153, 127)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(193, 20)
        Me.TextBox12.TabIndex = 11
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(153, 91)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(193, 20)
        Me.TextBox11.TabIndex = 10
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(153, 59)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(193, 20)
        Me.TextBox10.TabIndex = 9
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(153, 30)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(193, 20)
        Me.TextBox9.TabIndex = 8
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(271, 288)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(75, 23)
        Me.Button19.TabIndex = 7
        Me.Button19.Text = "Cancelar"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(154, 288)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 23)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "Aceptar"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(34, 207)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(26, 13)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "Mail"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(31, 169)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 13)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Numero"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(31, 134)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 3
        Me.Label34.Text = "RUC"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(31, 100)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(23, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "C.I."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(31, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Apellido"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(31, 33)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Nombre"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(489, 62)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(0, 13)
        Me.Label30.TabIndex = 16
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"PYG", "USD"})
        Me.ComboBox3.Location = New System.Drawing.Point(408, 322)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox3.TabIndex = 15
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(899, 196)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(248, 23)
        Me.Button17.TabIndex = 14
        Me.Button17.Text = "Agregar Cliente"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(899, 27)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(406, 405)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 12
        Me.Button15.Text = "Cancelar"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'aceptar_carga_presupuesto
        '
        Me.aceptar_carga_presupuesto.Location = New System.Drawing.Point(200, 406)
        Me.aceptar_carga_presupuesto.Name = "aceptar_carga_presupuesto"
        Me.aceptar_carga_presupuesto.Size = New System.Drawing.Size(75, 23)
        Me.aceptar_carga_presupuesto.TabIndex = 11
        Me.aceptar_carga_presupuesto.Text = "Aceptar"
        Me.aceptar_carga_presupuesto.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(200, 323)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(200, 20)
        Me.TextBox8.TabIndex = 10
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(200, 247)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(282, 61)
        Me.RichTextBox2.TabIndex = 9
        Me.RichTextBox2.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(200, 193)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(282, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(200, 149)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(282, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(200, 113)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(282, 20)
        Me.TextBox5.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(29, 331)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Precio"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(29, 247)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Oferta"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(29, 201)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Plazo de cobranza"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(29, 157)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Plazo de entrega"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(29, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Cliente"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(117, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Carga de Presupuestos"
        '
        'panel_botones_mugen
        '
        Me.panel_botones_mugen.Controls.Add(Me.boton_stock)
        Me.panel_botones_mugen.Controls.Add(Me.boton_vender)
        Me.panel_botones_mugen.Location = New System.Drawing.Point(9, 41)
        Me.panel_botones_mugen.Name = "panel_botones_mugen"
        Me.panel_botones_mugen.Size = New System.Drawing.Size(1165, 26)
        Me.panel_botones_mugen.TabIndex = 24
        '
        'boton_stock
        '
        Me.boton_stock.Location = New System.Drawing.Point(168, 0)
        Me.boton_stock.Name = "boton_stock"
        Me.boton_stock.Size = New System.Drawing.Size(161, 23)
        Me.boton_stock.TabIndex = 1
        Me.boton_stock.Text = "Stock"
        Me.boton_stock.UseVisualStyleBackColor = True
        '
        'boton_vender
        '
        Me.boton_vender.Location = New System.Drawing.Point(0, 0)
        Me.boton_vender.Name = "boton_vender"
        Me.boton_vender.Size = New System.Drawing.Size(162, 23)
        Me.boton_vender.TabIndex = 0
        Me.boton_vender.Text = "Vender"
        Me.boton_vender.UseVisualStyleBackColor = True
        '
        'boton_servicios
        '
        Me.boton_servicios.Location = New System.Drawing.Point(1014, 11)
        Me.boton_servicios.Name = "boton_servicios"
        Me.boton_servicios.Size = New System.Drawing.Size(160, 24)
        Me.boton_servicios.TabIndex = 25
        Me.boton_servicios.Text = "Servicios"
        Me.boton_servicios.UseVisualStyleBackColor = True
        '
        'panel_vender
        '
        Me.panel_vender.Controls.Add(Me.n_factura_textbox)
        Me.panel_vender.Controls.Add(Me.label_n_factura)
        Me.panel_vender.Controls.Add(Me.Button24)
        Me.panel_vender.Controls.Add(Me.label_ruc_venta)
        Me.panel_vender.Controls.Add(Me.text_total)
        Me.panel_vender.Controls.Add(Me.label_total)
        Me.panel_vender.Controls.Add(Me.text_iva)
        Me.panel_vender.Controls.Add(Me.label_iva)
        Me.panel_vender.Controls.Add(Me.text_sub_total)
        Me.panel_vender.Controls.Add(Me.label_subtotal)
        Me.panel_vender.Controls.Add(Me.venta_guardar)
        Me.panel_vender.Controls.Add(Me.DataGridView1)
        Me.panel_vender.Controls.Add(Me.TextBox17)
        Me.panel_vender.Controls.Add(Me.label_fecha)
        Me.panel_vender.Controls.Add(Me.TextBox16)
        Me.panel_vender.Controls.Add(Me.label_venta_cliente)
        Me.panel_vender.Controls.Add(Me.text_ruc_venta)
        Me.panel_vender.Controls.Add(Me.label_ruc)
        Me.panel_vender.Location = New System.Drawing.Point(12, 96)
        Me.panel_vender.Name = "panel_vender"
        Me.panel_vender.Size = New System.Drawing.Size(1319, 530)
        Me.panel_vender.TabIndex = 26
        Me.panel_vender.Visible = False
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(110, 483)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(75, 23)
        Me.Button24.TabIndex = 15
        Me.Button24.Text = "Nuevo"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'label_ruc_venta
        '
        Me.label_ruc_venta.AutoSize = True
        Me.label_ruc_venta.Location = New System.Drawing.Point(179, 6)
        Me.label_ruc_venta.Name = "label_ruc_venta"
        Me.label_ruc_venta.Size = New System.Drawing.Size(83, 13)
        Me.label_ruc_venta.TabIndex = 14
        Me.label_ruc_venta.Text = "label_ruc_venta"
        '
        'text_total
        '
        Me.text_total.Location = New System.Drawing.Point(471, 438)
        Me.text_total.Name = "text_total"
        Me.text_total.ReadOnly = True
        Me.text_total.Size = New System.Drawing.Size(100, 20)
        Me.text_total.TabIndex = 13
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Location = New System.Drawing.Point(370, 445)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(42, 13)
        Me.label_total.TabIndex = 12
        Me.label_total.Text = "TOTAL"
        '
        'text_iva
        '
        Me.text_iva.Location = New System.Drawing.Point(471, 402)
        Me.text_iva.Name = "text_iva"
        Me.text_iva.ReadOnly = True
        Me.text_iva.Size = New System.Drawing.Size(100, 20)
        Me.text_iva.TabIndex = 11
        '
        'label_iva
        '
        Me.label_iva.AutoSize = True
        Me.label_iva.Location = New System.Drawing.Point(371, 409)
        Me.label_iva.Name = "label_iva"
        Me.label_iva.Size = New System.Drawing.Size(24, 13)
        Me.label_iva.TabIndex = 10
        Me.label_iva.Text = "IVA"
        '
        'text_sub_total
        '
        Me.text_sub_total.Location = New System.Drawing.Point(471, 363)
        Me.text_sub_total.Name = "text_sub_total"
        Me.text_sub_total.ReadOnly = True
        Me.text_sub_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.text_sub_total.Size = New System.Drawing.Size(100, 20)
        Me.text_sub_total.TabIndex = 9
        Me.text_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_subtotal
        '
        Me.label_subtotal.AutoSize = True
        Me.label_subtotal.Location = New System.Drawing.Point(371, 371)
        Me.label_subtotal.Name = "label_subtotal"
        Me.label_subtotal.Size = New System.Drawing.Size(67, 13)
        Me.label_subtotal.TabIndex = 8
        Me.label_subtotal.Text = "SUB TOTAL"
        '
        'venta_guardar
        '
        Me.venta_guardar.Location = New System.Drawing.Point(29, 483)
        Me.venta_guardar.Name = "venta_guardar"
        Me.venta_guardar.Size = New System.Drawing.Size(75, 23)
        Me.venta_guardar.TabIndex = 7
        Me.venta_guardar.Text = "Guardar"
        Me.venta_guardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Punit, Me.cant, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 206)
        Me.DataGridView1.TabIndex = 6
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Producto
        '
        Me.Producto.Frozen = True
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Punit
        '
        Me.Punit.HeaderText = "P/unid"
        Me.Punit.Name = "Punit"
        Me.Punit.ReadOnly = True
        '
        'cant
        '
        Me.cant.HeaderText = "Cant"
        Me.cant.Name = "cant"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(519, 0)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(109, 20)
        Me.TextBox17.TabIndex = 5
        '
        'label_fecha
        '
        Me.label_fecha.AutoSize = True
        Me.label_fecha.Location = New System.Drawing.Point(468, 5)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(37, 13)
        Me.label_fecha.TabIndex = 4
        Me.label_fecha.Text = "Fecha"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(71, 43)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(335, 20)
        Me.TextBox16.TabIndex = 3
        '
        'label_venta_cliente
        '
        Me.label_venta_cliente.AutoSize = True
        Me.label_venta_cliente.Location = New System.Drawing.Point(26, 48)
        Me.label_venta_cliente.Name = "label_venta_cliente"
        Me.label_venta_cliente.Size = New System.Drawing.Size(39, 13)
        Me.label_venta_cliente.TabIndex = 2
        Me.label_venta_cliente.Text = "Cliente"
        '
        'text_ruc_venta
        '
        Me.text_ruc_venta.Location = New System.Drawing.Point(62, 3)
        Me.text_ruc_venta.Name = "text_ruc_venta"
        Me.text_ruc_venta.Size = New System.Drawing.Size(100, 20)
        Me.text_ruc_venta.TabIndex = 1
        '
        'label_ruc
        '
        Me.label_ruc.AutoSize = True
        Me.label_ruc.Location = New System.Drawing.Point(26, 8)
        Me.label_ruc.Name = "label_ruc"
        Me.label_ruc.Size = New System.Drawing.Size(30, 13)
        Me.label_ruc.TabIndex = 0
        Me.label_ruc.Text = "RUC"
        '
        'PanelClientes
        '
        Me.PanelClientes.Controls.Add(Me.ClienteDataGridView1ModificarCliente)
        Me.PanelClientes.Controls.Add(Me.GroupBoxCrearClienteasd)
        Me.PanelClientes.Controls.Add(Me.GroupBoxEstadisticasdelCliente)
        Me.PanelClientes.Controls.Add(Me.EstadisticasDeClienteBoton)
        Me.PanelClientes.Controls.Add(Me.GroupBoxModificarClienteasd)
        Me.PanelClientes.Controls.Add(Me.ModificarClienteBoton)
        Me.PanelClientes.Controls.Add(Me.CrearClienteBoton)
        Me.PanelClientes.Location = New System.Drawing.Point(35, 84)
        Me.PanelClientes.Name = "PanelClientes"
        Me.PanelClientes.Size = New System.Drawing.Size(1341, 605)
        Me.PanelClientes.TabIndex = 40
        Me.PanelClientes.Visible = False
        '
        'ClienteDataGridView1ModificarCliente
        '
        Me.ClienteDataGridView1ModificarCliente.AutoGenerateColumns = False
        Me.ClienteDataGridView1ModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView1ModificarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn69})
        Me.ClienteDataGridView1ModificarCliente.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView1ModificarCliente.Location = New System.Drawing.Point(869, 68)
        Me.ClienteDataGridView1ModificarCliente.Name = "ClienteDataGridView1ModificarCliente"
        Me.ClienteDataGridView1ModificarCliente.Size = New System.Drawing.Size(452, 220)
        Me.ClienteDataGridView1ModificarCliente.TabIndex = 21
        Me.ClienteDataGridView1ModificarCliente.Visible = False
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn61.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn62.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn63.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "ruc"
        Me.DataGridViewTextBoxColumn64.HeaderText = "ruc"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn65.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn66.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "estado_cliente"
        Me.DataGridViewTextBoxColumn67.HeaderText = "estado_cliente"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn69.HeaderText = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'GroupBoxCrearClienteasd
        '
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.Label72CrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.MailTextBoxCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.NumeroTextBoxCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.RucTextBoxCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.ApellidoTextBoxCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.NombreTextBoxCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.CheckBoxClientePrioritarioCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.Button9CrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(Me.CrearClienteBotonCrearCliente)
        Me.GroupBoxCrearClienteasd.Controls.Add(MailLabelM)
        Me.GroupBoxCrearClienteasd.Controls.Add(NumeroLabelN)
        Me.GroupBoxCrearClienteasd.Controls.Add(RucLabelR)
        Me.GroupBoxCrearClienteasd.Controls.Add(ApellidoLabelA)
        Me.GroupBoxCrearClienteasd.Controls.Add(NombreLabelN)
        Me.GroupBoxCrearClienteasd.Location = New System.Drawing.Point(208, 24)
        Me.GroupBoxCrearClienteasd.Name = "GroupBoxCrearClienteasd"
        Me.GroupBoxCrearClienteasd.Size = New System.Drawing.Size(319, 361)
        Me.GroupBoxCrearClienteasd.TabIndex = 2
        Me.GroupBoxCrearClienteasd.TabStop = False
        Me.GroupBoxCrearClienteasd.Text = "Crear Cliente"
        Me.GroupBoxCrearClienteasd.Visible = False
        '
        'Label72CrearCliente
        '
        Me.Label72CrearCliente.AutoSize = True
        Me.Label72CrearCliente.Location = New System.Drawing.Point(94, 241)
        Me.Label72CrearCliente.Name = "Label72CrearCliente"
        Me.Label72CrearCliente.Size = New System.Drawing.Size(45, 13)
        Me.Label72CrearCliente.TabIndex = 11
        Me.Label72CrearCliente.Text = "Label72"
        Me.Label72CrearCliente.Visible = False
        '
        'MailTextBoxCrearCliente
        '
        Me.MailTextBoxCrearCliente.Location = New System.Drawing.Point(97, 164)
        Me.MailTextBoxCrearCliente.Name = "MailTextBoxCrearCliente"
        Me.MailTextBoxCrearCliente.Size = New System.Drawing.Size(169, 20)
        Me.MailTextBoxCrearCliente.TabIndex = 20
        '
        'NumeroTextBoxCrearCliente
        '
        Me.NumeroTextBoxCrearCliente.Location = New System.Drawing.Point(97, 136)
        Me.NumeroTextBoxCrearCliente.Name = "NumeroTextBoxCrearCliente"
        Me.NumeroTextBoxCrearCliente.Size = New System.Drawing.Size(169, 20)
        Me.NumeroTextBoxCrearCliente.TabIndex = 19
        '
        'RucTextBoxCrearCliente
        '
        Me.RucTextBoxCrearCliente.Location = New System.Drawing.Point(97, 108)
        Me.RucTextBoxCrearCliente.Name = "RucTextBoxCrearCliente"
        Me.RucTextBoxCrearCliente.Size = New System.Drawing.Size(169, 20)
        Me.RucTextBoxCrearCliente.TabIndex = 18
        '
        'ApellidoTextBoxCrearCliente
        '
        Me.ApellidoTextBoxCrearCliente.Location = New System.Drawing.Point(97, 80)
        Me.ApellidoTextBoxCrearCliente.Name = "ApellidoTextBoxCrearCliente"
        Me.ApellidoTextBoxCrearCliente.Size = New System.Drawing.Size(169, 20)
        Me.ApellidoTextBoxCrearCliente.TabIndex = 17
        '
        'NombreTextBoxCrearCliente
        '
        Me.NombreTextBoxCrearCliente.Location = New System.Drawing.Point(97, 52)
        Me.NombreTextBoxCrearCliente.Name = "NombreTextBoxCrearCliente"
        Me.NombreTextBoxCrearCliente.Size = New System.Drawing.Size(169, 20)
        Me.NombreTextBoxCrearCliente.TabIndex = 16
        '
        'CheckBoxClientePrioritarioCrearCliente
        '
        Me.CheckBoxClientePrioritarioCrearCliente.AutoSize = True
        Me.CheckBoxClientePrioritarioCrearCliente.Location = New System.Drawing.Point(129, 198)
        Me.CheckBoxClientePrioritarioCrearCliente.Name = "CheckBoxClientePrioritarioCrearCliente"
        Me.CheckBoxClientePrioritarioCrearCliente.Size = New System.Drawing.Size(104, 17)
        Me.CheckBoxClientePrioritarioCrearCliente.TabIndex = 15
        Me.CheckBoxClientePrioritarioCrearCliente.Text = "Cliente Prioritario"
        Me.CheckBoxClientePrioritarioCrearCliente.UseVisualStyleBackColor = True
        '
        'Button9CrearCliente
        '
        Me.Button9CrearCliente.Location = New System.Drawing.Point(166, 263)
        Me.Button9CrearCliente.Name = "Button9CrearCliente"
        Me.Button9CrearCliente.Size = New System.Drawing.Size(75, 23)
        Me.Button9CrearCliente.TabIndex = 12
        Me.Button9CrearCliente.Text = "Cerrar"
        Me.Button9CrearCliente.UseVisualStyleBackColor = True
        '
        'CrearClienteBotonCrearCliente
        '
        Me.CrearClienteBotonCrearCliente.Location = New System.Drawing.Point(45, 263)
        Me.CrearClienteBotonCrearCliente.Name = "CrearClienteBotonCrearCliente"
        Me.CrearClienteBotonCrearCliente.Size = New System.Drawing.Size(75, 23)
        Me.CrearClienteBotonCrearCliente.TabIndex = 10
        Me.CrearClienteBotonCrearCliente.Text = "Crear Cliente"
        Me.CrearClienteBotonCrearCliente.UseVisualStyleBackColor = True
        '
        'GroupBoxEstadisticasdelCliente
        '
        Me.GroupBoxEstadisticasdelCliente.Controls.Add(Me.Button14)
        Me.GroupBoxEstadisticasdelCliente.Controls.Add(Me.Button20)
        Me.GroupBoxEstadisticasdelCliente.Controls.Add(Me.Button21)
        Me.GroupBoxEstadisticasdelCliente.Controls.Add(Me.Button22)
        Me.GroupBoxEstadisticasdelCliente.Controls.Add(Me.Button23)
        Me.GroupBoxEstadisticasdelCliente.Location = New System.Drawing.Point(225, 38)
        Me.GroupBoxEstadisticasdelCliente.Name = "GroupBoxEstadisticasdelCliente"
        Me.GroupBoxEstadisticasdelCliente.Size = New System.Drawing.Size(286, 361)
        Me.GroupBoxEstadisticasdelCliente.TabIndex = 5
        Me.GroupBoxEstadisticasdelCliente.TabStop = False
        Me.GroupBoxEstadisticasdelCliente.Text = "Estadísticas de Cliente"
        Me.GroupBoxEstadisticasdelCliente.Visible = False
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(98, 273)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 4
        Me.Button14.Text = "Cerrar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(54, 194)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(181, 23)
        Me.Button20.TabIndex = 3
        Me.Button20.Text = "Gráficas estadísticas del Cliente"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(54, 150)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(181, 23)
        Me.Button21.TabIndex = 2
        Me.Button21.Text = "Deudas del Cliente"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(54, 106)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(181, 23)
        Me.Button22.TabIndex = 1
        Me.Button22.Text = "Pedidos pendientes del Cliente"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(54, 62)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(181, 23)
        Me.Button23.TabIndex = 0
        Me.Button23.Text = "Datos de Cliente"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'EstadisticasDeClienteBoton
        '
        Me.EstadisticasDeClienteBoton.Location = New System.Drawing.Point(26, 120)
        Me.EstadisticasDeClienteBoton.Name = "EstadisticasDeClienteBoton"
        Me.EstadisticasDeClienteBoton.Size = New System.Drawing.Size(125, 22)
        Me.EstadisticasDeClienteBoton.TabIndex = 4
        Me.EstadisticasDeClienteBoton.Text = "Estadísticas de Cliente"
        Me.EstadisticasDeClienteBoton.UseVisualStyleBackColor = True
        '
        'GroupBoxModificarClienteasd
        '
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.Label1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.Button15ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.MailTextBox1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.NumeroTextBox1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.ApellidoTextBox1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.NombreTextBox1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.RucTextBox1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.CheckBoxClientePrioritario1ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.Button10ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.Button25ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(Me.Button24ModificarCliente)
        Me.GroupBoxModificarClienteasd.Controls.Add(MailLabel1M)
        Me.GroupBoxModificarClienteasd.Controls.Add(NumeroLabel1N)
        Me.GroupBoxModificarClienteasd.Controls.Add(ApellidoLabel1A)
        Me.GroupBoxModificarClienteasd.Controls.Add(NombreLabel1N)
        Me.GroupBoxModificarClienteasd.Controls.Add(RucLabel1R)
        Me.GroupBoxModificarClienteasd.Location = New System.Drawing.Point(533, 38)
        Me.GroupBoxModificarClienteasd.Name = "GroupBoxModificarClienteasd"
        Me.GroupBoxModificarClienteasd.Size = New System.Drawing.Size(330, 361)
        Me.GroupBoxModificarClienteasd.TabIndex = 3
        Me.GroupBoxModificarClienteasd.TabStop = False
        Me.GroupBoxModificarClienteasd.Text = "Modificar Cliente"
        Me.GroupBoxModificarClienteasd.Visible = False
        '
        'Label1ModificarCliente
        '
        Me.Label1ModificarCliente.AutoSize = True
        Me.Label1ModificarCliente.Location = New System.Drawing.Point(70, 241)
        Me.Label1ModificarCliente.Name = "Label1ModificarCliente"
        Me.Label1ModificarCliente.Size = New System.Drawing.Size(39, 13)
        Me.Label1ModificarCliente.TabIndex = 22
        Me.Label1ModificarCliente.Text = "Label1"
        Me.Label1ModificarCliente.Visible = False
        '
        'Button15ModificarCliente
        '
        Me.Button15ModificarCliente.Location = New System.Drawing.Point(252, 41)
        Me.Button15ModificarCliente.Name = "Button15ModificarCliente"
        Me.Button15ModificarCliente.Size = New System.Drawing.Size(57, 23)
        Me.Button15ModificarCliente.TabIndex = 22
        Me.Button15ModificarCliente.Text = "Buscar"
        Me.Button15ModificarCliente.UseVisualStyleBackColor = True
        '
        'MailTextBox1ModificarCliente
        '
        Me.MailTextBox1ModificarCliente.Location = New System.Drawing.Point(73, 166)
        Me.MailTextBox1ModificarCliente.Name = "MailTextBox1ModificarCliente"
        Me.MailTextBox1ModificarCliente.ReadOnly = True
        Me.MailTextBox1ModificarCliente.Size = New System.Drawing.Size(236, 20)
        Me.MailTextBox1ModificarCliente.TabIndex = 20
        '
        'NumeroTextBox1ModificarCliente
        '
        Me.NumeroTextBox1ModificarCliente.Location = New System.Drawing.Point(73, 135)
        Me.NumeroTextBox1ModificarCliente.Name = "NumeroTextBox1ModificarCliente"
        Me.NumeroTextBox1ModificarCliente.ReadOnly = True
        Me.NumeroTextBox1ModificarCliente.Size = New System.Drawing.Size(236, 20)
        Me.NumeroTextBox1ModificarCliente.TabIndex = 19
        '
        'ApellidoTextBox1ModificarCliente
        '
        Me.ApellidoTextBox1ModificarCliente.Location = New System.Drawing.Point(73, 104)
        Me.ApellidoTextBox1ModificarCliente.Name = "ApellidoTextBox1ModificarCliente"
        Me.ApellidoTextBox1ModificarCliente.ReadOnly = True
        Me.ApellidoTextBox1ModificarCliente.Size = New System.Drawing.Size(236, 20)
        Me.ApellidoTextBox1ModificarCliente.TabIndex = 18
        '
        'NombreTextBox1ModificarCliente
        '
        Me.NombreTextBox1ModificarCliente.Location = New System.Drawing.Point(73, 73)
        Me.NombreTextBox1ModificarCliente.Name = "NombreTextBox1ModificarCliente"
        Me.NombreTextBox1ModificarCliente.ReadOnly = True
        Me.NombreTextBox1ModificarCliente.Size = New System.Drawing.Size(236, 20)
        Me.NombreTextBox1ModificarCliente.TabIndex = 17
        '
        'RucTextBox1ModificarCliente
        '
        Me.RucTextBox1ModificarCliente.Location = New System.Drawing.Point(73, 42)
        Me.RucTextBox1ModificarCliente.Name = "RucTextBox1ModificarCliente"
        Me.RucTextBox1ModificarCliente.Size = New System.Drawing.Size(173, 20)
        Me.RucTextBox1ModificarCliente.TabIndex = 16
        '
        'CheckBoxClientePrioritario1ModificarCliente
        '
        Me.CheckBoxClientePrioritario1ModificarCliente.AutoSize = True
        Me.CheckBoxClientePrioritario1ModificarCliente.Location = New System.Drawing.Point(156, 207)
        Me.CheckBoxClientePrioritario1ModificarCliente.Name = "CheckBoxClientePrioritario1ModificarCliente"
        Me.CheckBoxClientePrioritario1ModificarCliente.Size = New System.Drawing.Size(104, 17)
        Me.CheckBoxClientePrioritario1ModificarCliente.TabIndex = 15
        Me.CheckBoxClientePrioritario1ModificarCliente.Text = "Cliente Prioritario"
        Me.CheckBoxClientePrioritario1ModificarCliente.UseVisualStyleBackColor = True
        '
        'Button10ModificarCliente
        '
        Me.Button10ModificarCliente.Location = New System.Drawing.Point(131, 305)
        Me.Button10ModificarCliente.Name = "Button10ModificarCliente"
        Me.Button10ModificarCliente.Size = New System.Drawing.Size(75, 23)
        Me.Button10ModificarCliente.TabIndex = 13
        Me.Button10ModificarCliente.Text = "Cerrar"
        Me.Button10ModificarCliente.UseVisualStyleBackColor = True
        '
        'Button25ModificarCliente
        '
        Me.Button25ModificarCliente.Location = New System.Drawing.Point(185, 259)
        Me.Button25ModificarCliente.Name = "Button25ModificarCliente"
        Me.Button25ModificarCliente.Size = New System.Drawing.Size(94, 23)
        Me.Button25ModificarCliente.TabIndex = 11
        Me.Button25ModificarCliente.Text = "Borrar Cliente"
        Me.Button25ModificarCliente.UseVisualStyleBackColor = True
        '
        'Button24ModificarCliente
        '
        Me.Button24ModificarCliente.Location = New System.Drawing.Point(62, 259)
        Me.Button24ModificarCliente.Name = "Button24ModificarCliente"
        Me.Button24ModificarCliente.Size = New System.Drawing.Size(94, 23)
        Me.Button24ModificarCliente.TabIndex = 10
        Me.Button24ModificarCliente.Text = "Modificar Cliente"
        Me.Button24ModificarCliente.UseVisualStyleBackColor = True
        '
        'ModificarClienteBoton
        '
        Me.ModificarClienteBoton.Location = New System.Drawing.Point(26, 81)
        Me.ModificarClienteBoton.Name = "ModificarClienteBoton"
        Me.ModificarClienteBoton.Size = New System.Drawing.Size(125, 22)
        Me.ModificarClienteBoton.TabIndex = 1
        Me.ModificarClienteBoton.Text = "Modificar Cliente"
        Me.ModificarClienteBoton.UseVisualStyleBackColor = True
        '
        'CrearClienteBoton
        '
        Me.CrearClienteBoton.Location = New System.Drawing.Point(26, 42)
        Me.CrearClienteBoton.Name = "CrearClienteBoton"
        Me.CrearClienteBoton.Size = New System.Drawing.Size(125, 22)
        Me.CrearClienteBoton.TabIndex = 0
        Me.CrearClienteBoton.Text = "Crear Cliente"
        Me.CrearClienteBoton.UseVisualStyleBackColor = True
        '
        'PanelTrabajosPendientes
        '
        Me.PanelTrabajosPendientes.AutoScroll = True
        Me.PanelTrabajosPendientes.Controls.Add(Me.pedidoGridView)
        Me.PanelTrabajosPendientes.Controls.Add(Me.UsuarioDataGrid)
        Me.PanelTrabajosPendientes.Controls.Add(Me.ClienteGridView)
        Me.PanelTrabajosPendientes.Controls.Add(Me.graficoTrabajos)
        Me.PanelTrabajosPendientes.Controls.Add(Me.graficoPagados)
        Me.PanelTrabajosPendientes.Controls.Add(Me.btpGenerar)
        Me.PanelTrabajosPendientes.Controls.Add(Me.BindingNavigator1)
        Me.PanelTrabajosPendientes.Controls.Add(Me.idClientesAux)
        Me.PanelTrabajosPendientes.Controls.Add(Me.pbBorrar)
        Me.PanelTrabajosPendientes.Controls.Add(Me.pbCambiar)
        Me.PanelTrabajosPendientes.Controls.Add(Me.label47)
        Me.PanelTrabajosPendientes.Controls.Add(Me.pcEstado)
        Me.PanelTrabajosPendientes.Controls.Add(Me.idClienteActual)
        Me.PanelTrabajosPendientes.Controls.Add(Me.noHayPendientes)
        Me.PanelTrabajosPendientes.Controls.Add(Me.noExiste)
        Me.PanelTrabajosPendientes.Controls.Add(Me.sinDatos)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label55)
        Me.PanelTrabajosPendientes.Controls.Add(Me.TextIden)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label54)
        Me.PanelTrabajosPendientes.Controls.Add(Me.TextApellido)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label53)
        Me.PanelTrabajosPendientes.Controls.Add(Me.calendarioCobro)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label52)
        Me.PanelTrabajosPendientes.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelTrabajosPendientes.Controls.Add(Me.botonBuscar)
        Me.PanelTrabajosPendientes.Controls.Add(Me.calendarioEntregas)
        Me.PanelTrabajosPendientes.Controls.Add(Me.resultadosPedidos)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label44)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label43)
        Me.PanelTrabajosPendientes.Controls.Add(Me.TextCliente)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label42)
        Me.PanelTrabajosPendientes.Controls.Add(Me.Label41)
        Me.PanelTrabajosPendientes.Location = New System.Drawing.Point(9, 84)
        Me.PanelTrabajosPendientes.Name = "PanelTrabajosPendientes"
        Me.PanelTrabajosPendientes.Size = New System.Drawing.Size(1517, 563)
        Me.PanelTrabajosPendientes.TabIndex = 41
        Me.PanelTrabajosPendientes.Visible = False
        '
        'pedidoGridView
        '
        Me.pedidoGridView.AutoGenerateColumns = False
        Me.pedidoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pedidoGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn88, Me.DataGridViewTextBoxColumn89, Me.DataGridViewTextBoxColumn90, Me.DataGridViewTextBoxColumn91, Me.DataGridViewTextBoxColumn92, Me.DataGridViewTextBoxColumn93, Me.DataGridViewTextBoxColumn94, Me.DataGridViewTextBoxColumn95, Me.DataGridViewTextBoxColumn96})
        Me.pedidoGridView.DataSource = Me.PedidoBindingSource
        Me.pedidoGridView.Location = New System.Drawing.Point(1149, 7)
        Me.pedidoGridView.Name = "pedidoGridView"
        Me.pedidoGridView.Size = New System.Drawing.Size(114, 138)
        Me.pedidoGridView.TabIndex = 41
        Me.pedidoGridView.Visible = False
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.DataPropertyName = "id_pedido"
        Me.DataGridViewTextBoxColumn88.HeaderText = "id_pedido"
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn89.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        '
        'DataGridViewTextBoxColumn90
        '
        Me.DataGridViewTextBoxColumn90.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn90.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
        '
        'DataGridViewTextBoxColumn91
        '
        Me.DataGridViewTextBoxColumn91.DataPropertyName = "plazo_entrega"
        Me.DataGridViewTextBoxColumn91.HeaderText = "plazo_entrega"
        Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
        '
        'DataGridViewTextBoxColumn92
        '
        Me.DataGridViewTextBoxColumn92.DataPropertyName = "plazo_cobro"
        Me.DataGridViewTextBoxColumn92.HeaderText = "plazo_cobro"
        Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
        '
        'DataGridViewTextBoxColumn93
        '
        Me.DataGridViewTextBoxColumn93.DataPropertyName = "oferta"
        Me.DataGridViewTextBoxColumn93.HeaderText = "oferta"
        Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn94.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        '
        'DataGridViewTextBoxColumn95
        '
        Me.DataGridViewTextBoxColumn95.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn95.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
        '
        'DataGridViewTextBoxColumn96
        '
        Me.DataGridViewTextBoxColumn96.DataPropertyName = "nombre_pedido"
        Me.DataGridViewTextBoxColumn96.HeaderText = "nombre_pedido"
        Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
        '
        'UsuarioDataGrid
        '
        Me.UsuarioDataGrid.AutoGenerateColumns = False
        Me.UsuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn79, Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn81, Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83, Me.DataGridViewTextBoxColumn84, Me.DataGridViewTextBoxColumn85, Me.DataGridViewTextBoxColumn86, Me.DataGridViewTextBoxColumn87})
        Me.UsuarioDataGrid.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGrid.Location = New System.Drawing.Point(995, 136)
        Me.UsuarioDataGrid.Name = "UsuarioDataGrid"
        Me.UsuarioDataGrid.Size = New System.Drawing.Size(130, 125)
        Me.UsuarioDataGrid.TabIndex = 41
        Me.UsuarioDataGrid.Visible = False
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn79.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn80.HeaderText = "cuenta"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "pass"
        Me.DataGridViewTextBoxColumn81.HeaderText = "pass"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "nivel"
        Me.DataGridViewTextBoxColumn82.HeaderText = "nivel"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "estado_usuario"
        Me.DataGridViewTextBoxColumn83.HeaderText = "estado_usuario"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.DataPropertyName = "nombre_usuario"
        Me.DataGridViewTextBoxColumn84.HeaderText = "nombre_usuario"
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "apellido_usuario"
        Me.DataGridViewTextBoxColumn85.HeaderText = "apellido_usuario"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.DataPropertyName = "numero_usuario"
        Me.DataGridViewTextBoxColumn86.HeaderText = "numero_usuario"
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.DataPropertyName = "mail_usuario"
        Me.DataGridViewTextBoxColumn87.HeaderText = "mail_usuario"
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        '
        'ClienteGridView
        '
        Me.ClienteGridView.AutoGenerateColumns = False
        Me.ClienteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn78})
        Me.ClienteGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteGridView.Location = New System.Drawing.Point(972, 4)
        Me.ClienteGridView.Name = "ClienteGridView"
        Me.ClienteGridView.Size = New System.Drawing.Size(154, 116)
        Me.ClienteGridView.TabIndex = 41
        Me.ClienteGridView.Visible = False
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn70.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn71.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn72.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "ruc"
        Me.DataGridViewTextBoxColumn73.HeaderText = "ruc"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn74.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn75.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "estado_cliente"
        Me.DataGridViewTextBoxColumn76.HeaderText = "estado_cliente"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn78.HeaderText = "cliente_prioritario"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'graficoTrabajos
        '
        ChartArea1.Name = "ChartArea1"
        Me.graficoTrabajos.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.graficoTrabajos.Legends.Add(Legend1)
        Me.graficoTrabajos.Location = New System.Drawing.Point(573, 145)
        Me.graficoTrabajos.Name = "graficoTrabajos"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.graficoTrabajos.Series.Add(Series1)
        Me.graficoTrabajos.Size = New System.Drawing.Size(416, 244)
        Me.graficoTrabajos.TabIndex = 41
        Me.graficoTrabajos.Text = "Chart2"
        Me.graficoTrabajos.Visible = False
        '
        'graficoPagados
        '
        ChartArea2.Name = "ChartArea1"
        Me.graficoPagados.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.graficoPagados.Legends.Add(Legend2)
        Me.graficoPagados.Location = New System.Drawing.Point(369, 143)
        Me.graficoPagados.Name = "graficoPagados"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.graficoPagados.Series.Add(Series2)
        Me.graficoPagados.Size = New System.Drawing.Size(416, 244)
        Me.graficoPagados.TabIndex = 40
        Me.graficoPagados.Text = "Chart1"
        Me.graficoPagados.Visible = False
        '
        'btpGenerar
        '
        Me.btpGenerar.Location = New System.Drawing.Point(513, 206)
        Me.btpGenerar.Name = "btpGenerar"
        Me.btpGenerar.Size = New System.Drawing.Size(194, 23)
        Me.btpGenerar.TabIndex = 39
        Me.btpGenerar.Text = "Generar Resumen"
        Me.btpGenerar.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1517, 27)
        Me.BindingNavigator1.TabIndex = 38
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'idClientesAux
        '
        Me.idClientesAux.FormattingEnabled = True
        Me.idClientesAux.Location = New System.Drawing.Point(626, 71)
        Me.idClientesAux.Name = "idClientesAux"
        Me.idClientesAux.Size = New System.Drawing.Size(40, 69)
        Me.idClientesAux.TabIndex = 35
        Me.idClientesAux.Visible = False
        '
        'pbBorrar
        '
        Me.pbBorrar.Location = New System.Drawing.Point(117, 164)
        Me.pbBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBorrar.Name = "pbBorrar"
        Me.pbBorrar.Size = New System.Drawing.Size(60, 24)
        Me.pbBorrar.TabIndex = 34
        Me.pbBorrar.Text = "Borrar"
        Me.pbBorrar.UseVisualStyleBackColor = True
        '
        'pbCambiar
        '
        Me.pbCambiar.Location = New System.Drawing.Point(478, 496)
        Me.pbCambiar.Margin = New System.Windows.Forms.Padding(2)
        Me.pbCambiar.Name = "pbCambiar"
        Me.pbCambiar.Size = New System.Drawing.Size(64, 21)
        Me.pbCambiar.TabIndex = 33
        Me.pbCambiar.Text = "Cambiar"
        Me.pbCambiar.UseVisualStyleBackColor = True
        '
        'label47
        '
        Me.label47.AutoSize = True
        Me.label47.Location = New System.Drawing.Point(279, 503)
        Me.label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(107, 13)
        Me.label47.TabIndex = 31
        Me.label47.Text = "Cambiar de estado a:"
        '
        'pcEstado
        '
        Me.pcEstado.FormattingEnabled = True
        Me.pcEstado.Location = New System.Drawing.Point(388, 496)
        Me.pcEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.pcEstado.Name = "pcEstado"
        Me.pcEstado.Size = New System.Drawing.Size(82, 21)
        Me.pcEstado.TabIndex = 32
        '
        'idClienteActual
        '
        Me.idClienteActual.AutoSize = True
        Me.idClienteActual.Location = New System.Drawing.Point(8, 175)
        Me.idClienteActual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idClienteActual.Name = "idClienteActual"
        Me.idClienteActual.Size = New System.Drawing.Size(0, 13)
        Me.idClienteActual.TabIndex = 30
        Me.idClienteActual.Visible = False
        '
        'noHayPendientes
        '
        Me.noHayPendientes.AutoSize = True
        Me.noHayPendientes.ForeColor = System.Drawing.Color.Red
        Me.noHayPendientes.Location = New System.Drawing.Point(6, 143)
        Me.noHayPendientes.Name = "noHayPendientes"
        Me.noHayPendientes.Size = New System.Drawing.Size(219, 13)
        Me.noHayPendientes.TabIndex = 29
        Me.noHayPendientes.Text = "No existe trabajos cargados para este cliente"
        Me.noHayPendientes.Visible = False
        '
        'noExiste
        '
        Me.noExiste.AutoSize = True
        Me.noExiste.ForeColor = System.Drawing.Color.Red
        Me.noExiste.Location = New System.Drawing.Point(6, 145)
        Me.noExiste.Name = "noExiste"
        Me.noExiste.Size = New System.Drawing.Size(96, 13)
        Me.noExiste.TabIndex = 28
        Me.noExiste.Text = "No existe el cliente"
        Me.noExiste.Visible = False
        '
        'sinDatos
        '
        Me.sinDatos.AutoSize = True
        Me.sinDatos.ForeColor = System.Drawing.Color.Red
        Me.sinDatos.Location = New System.Drawing.Point(7, 145)
        Me.sinDatos.Name = "sinDatos"
        Me.sinDatos.Size = New System.Drawing.Size(146, 13)
        Me.sinDatos.TabIndex = 27
        Me.sinDatos.Text = "Complete al menos un campo"
        Me.sinDatos.Visible = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(5, 121)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(108, 13)
        Me.Label55.TabIndex = 26
        Me.Label55.Text = "Identificacion o RUC:"
        '
        'TextIden
        '
        Me.TextIden.Location = New System.Drawing.Point(117, 119)
        Me.TextIden.Name = "TextIden"
        Me.TextIden.Size = New System.Drawing.Size(142, 20)
        Me.TextIden.TabIndex = 25
        Me.TextIden.Tag = ""
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(5, 98)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(98, 13)
        Me.Label54.TabIndex = 24
        Me.Label54.Text = "Apellido del cliente:"
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(117, 95)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(142, 20)
        Me.TextApellido.TabIndex = 23
        Me.TextApellido.Tag = ""
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(702, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(252, 13)
        Me.Label53.TabIndex = 19
        Me.Label53.Text = "Trabajos pendientes agendados por fecha de cobro"
        '
        'calendarioCobro
        '
        Me.calendarioCobro.ForeColor = System.Drawing.SystemColors.Highlight
        Me.calendarioCobro.Location = New System.Drawing.Point(705, 28)
        Me.calendarioCobro.Name = "calendarioCobro"
        Me.calendarioCobro.TabIndex = 18
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(338, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(261, 13)
        Me.Label52.TabIndex = 17
        Me.Label52.Text = "Trabajos pendientes agendados por fecha de entrega"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label51, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label50, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label49, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label56, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.labelRuc, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label58, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pcProyecto, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptNombre, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptApellido, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptRuc, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptDescrip, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptEntrega, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ptCobro, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label48, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ptPrecio, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label45, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label46, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbEstado, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(280, 294)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.542713!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45728!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 197)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(646, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(63, 13)
        Me.Label51.TabIndex = 10
        Me.Label51.Text = "Descripcion"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(530, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(78, 13)
        Me.Label50.TabIndex = 9
        Me.Label50.Text = "Plazo de cobro"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(423, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(87, 13)
        Me.Label49.TabIndex = 8
        Me.Label49.Text = "Plazo de entrega"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(104, 0)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(44, 13)
        Me.Label56.TabIndex = 12
        Me.Label56.Text = "Apellido"
        '
        'labelRuc
        '
        Me.labelRuc.AutoSize = True
        Me.labelRuc.Location = New System.Drawing.Point(202, 0)
        Me.labelRuc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelRuc.Name = "labelRuc"
        Me.labelRuc.Size = New System.Drawing.Size(30, 13)
        Me.labelRuc.TabIndex = 13
        Me.labelRuc.Text = "RUC"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(308, 0)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(49, 13)
        Me.Label58.TabIndex = 14
        Me.Label58.Text = "Proyecto"
        '
        'pcProyecto
        '
        Me.pcProyecto.FormattingEnabled = True
        Me.pcProyecto.Location = New System.Drawing.Point(308, 15)
        Me.pcProyecto.Margin = New System.Windows.Forms.Padding(2)
        Me.pcProyecto.Name = "pcProyecto"
        Me.pcProyecto.Size = New System.Drawing.Size(110, 21)
        Me.pcProyecto.TabIndex = 17
        '
        'ptNombre
        '
        Me.ptNombre.Location = New System.Drawing.Point(2, 15)
        Me.ptNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.ptNombre.Name = "ptNombre"
        Me.ptNombre.Size = New System.Drawing.Size(98, 20)
        Me.ptNombre.TabIndex = 18
        '
        'ptApellido
        '
        Me.ptApellido.Location = New System.Drawing.Point(104, 15)
        Me.ptApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.ptApellido.Name = "ptApellido"
        Me.ptApellido.Size = New System.Drawing.Size(94, 20)
        Me.ptApellido.TabIndex = 19
        '
        'ptRuc
        '
        Me.ptRuc.Location = New System.Drawing.Point(202, 15)
        Me.ptRuc.Margin = New System.Windows.Forms.Padding(2)
        Me.ptRuc.Name = "ptRuc"
        Me.ptRuc.Size = New System.Drawing.Size(102, 20)
        Me.ptRuc.TabIndex = 20
        '
        'ptDescrip
        '
        Me.ptDescrip.Location = New System.Drawing.Point(645, 15)
        Me.ptDescrip.Margin = New System.Windows.Forms.Padding(2)
        Me.ptDescrip.Multiline = True
        Me.ptDescrip.Name = "ptDescrip"
        Me.ptDescrip.Size = New System.Drawing.Size(191, 139)
        Me.ptDescrip.TabIndex = 21
        '
        'ptEntrega
        '
        Me.ptEntrega.Location = New System.Drawing.Point(422, 15)
        Me.ptEntrega.Margin = New System.Windows.Forms.Padding(2)
        Me.ptEntrega.Name = "ptEntrega"
        Me.ptEntrega.Size = New System.Drawing.Size(103, 20)
        Me.ptEntrega.TabIndex = 24
        '
        'ptCobro
        '
        Me.ptCobro.Location = New System.Drawing.Point(529, 15)
        Me.ptCobro.Margin = New System.Windows.Forms.Padding(2)
        Me.ptCobro.Name = "ptCobro"
        Me.ptCobro.Size = New System.Drawing.Size(112, 20)
        Me.ptCobro.TabIndex = 25
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(3, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(44, 13)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Nombre"
        '
        'ptPrecio
        '
        Me.ptPrecio.Location = New System.Drawing.Point(645, 174)
        Me.ptPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.ptPrecio.Name = "ptPrecio"
        Me.ptPrecio.Size = New System.Drawing.Size(122, 20)
        Me.ptPrecio.TabIndex = 29
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(645, 156)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(37, 13)
        Me.Label45.TabIndex = 28
        Me.Label45.Text = "Precio"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(2, 172)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(78, 13)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "Estado actual: "
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(104, 172)
        Me.lbEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(51, 13)
        Me.lbEstado.TabIndex = 29
        Me.lbEstado.Text = "ESTADO"
        '
        'botonBuscar
        '
        Me.botonBuscar.Location = New System.Drawing.Point(184, 164)
        Me.botonBuscar.Name = "botonBuscar"
        Me.botonBuscar.Size = New System.Drawing.Size(75, 24)
        Me.botonBuscar.TabIndex = 11
        Me.botonBuscar.Text = "Buscar"
        Me.botonBuscar.UseVisualStyleBackColor = True
        '
        'calendarioEntregas
        '
        Me.calendarioEntregas.BackColor = System.Drawing.SystemColors.Window
        Me.calendarioEntregas.ForeColor = System.Drawing.SystemColors.Highlight
        Me.calendarioEntregas.Location = New System.Drawing.Point(341, 28)
        Me.calendarioEntregas.Name = "calendarioEntregas"
        Me.calendarioEntregas.TabIndex = 10
        Me.calendarioEntregas.TrailingForeColor = System.Drawing.SystemColors.Highlight
        '
        'resultadosPedidos
        '
        Me.resultadosPedidos.FormattingEnabled = True
        Me.resultadosPedidos.Location = New System.Drawing.Point(10, 197)
        Me.resultadosPedidos.Name = "resultadosPedidos"
        Me.resultadosPedidos.Size = New System.Drawing.Size(248, 238)
        Me.resultadosPedidos.TabIndex = 9
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 106)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(0, 13)
        Me.Label44.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(5, 75)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(98, 13)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "Nombre del cliente:"
        '
        'TextCliente
        '
        Me.TextCliente.Location = New System.Drawing.Point(117, 71)
        Me.TextCliente.Name = "TextCliente"
        Me.TextCliente.Size = New System.Drawing.Size(142, 20)
        Me.TextCliente.TabIndex = 2
        Me.TextCliente.Tag = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 49)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(156, 13)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Buscar trabajos pendientes por:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 10)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(104, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Trabajos Pendientes"
        '
        'GroupBox4Stock
        '
        Me.GroupBox4Stock.Controls.Add(Me.GroupBoxModificarProducto)
        Me.GroupBox4Stock.Controls.Add(Me.GroupBoxIngresodeProducto)
        Me.GroupBox4Stock.Controls.Add(Me.GroupBoxNuevoProducto)
        Me.GroupBox4Stock.Controls.Add(Me.Button27)
        Me.GroupBox4Stock.Controls.Add(Me.Button26)
        Me.GroupBox4Stock.Controls.Add(Me.Button25)
        Me.GroupBox4Stock.Controls.Add(Me.Button24NuevoProducto)
        Me.GroupBox4Stock.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox4Stock.Name = "GroupBox4Stock"
        Me.GroupBox4Stock.Size = New System.Drawing.Size(1317, 605)
        Me.GroupBox4Stock.TabIndex = 42
        Me.GroupBox4Stock.TabStop = False
        Me.GroupBox4Stock.Text = "Stock"
        Me.GroupBox4Stock.Visible = False
        '
        'GroupBoxModificarProducto
        '
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelModificarProducto)
        Me.GroupBoxModificarProducto.Controls.Add(Me.ButtonCerrar3)
        Me.GroupBoxModificarProducto.Controls.Add(Me.ButtonModificarProducto)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxPrecio2)
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelPrecio)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxDescripcion2)
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelDescripcion)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxCodigo2)
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelCodigo)
        Me.GroupBoxModificarProducto.Location = New System.Drawing.Point(896, 48)
        Me.GroupBoxModificarProducto.Name = "GroupBoxModificarProducto"
        Me.GroupBoxModificarProducto.Size = New System.Drawing.Size(321, 359)
        Me.GroupBoxModificarProducto.TabIndex = 0
        Me.GroupBoxModificarProducto.TabStop = False
        Me.GroupBoxModificarProducto.Text = "Modificar Producto"
        Me.GroupBoxModificarProducto.Visible = False
        '
        'LabelModificarProducto
        '
        Me.LabelModificarProducto.AutoSize = True
        Me.LabelModificarProducto.Location = New System.Drawing.Point(59, 241)
        Me.LabelModificarProducto.Name = "LabelModificarProducto"
        Me.LabelModificarProducto.Size = New System.Drawing.Size(119, 13)
        Me.LabelModificarProducto.TabIndex = 14
        Me.LabelModificarProducto.Text = "LabelModificarProducto"
        Me.LabelModificarProducto.Visible = False
        '
        'ButtonCerrar3
        '
        Me.ButtonCerrar3.Location = New System.Drawing.Point(185, 294)
        Me.ButtonCerrar3.Name = "ButtonCerrar3"
        Me.ButtonCerrar3.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCerrar3.TabIndex = 10
        Me.ButtonCerrar3.Text = "Cerrar"
        Me.ButtonCerrar3.UseVisualStyleBackColor = True
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(34, 294)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(106, 23)
        Me.ButtonModificarProducto.TabIndex = 9
        Me.ButtonModificarProducto.Text = "Modificar Producto"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxPrecio2
        '
        Me.TextBoxPrecio2.Location = New System.Drawing.Point(131, 118)
        Me.TextBoxPrecio2.Name = "TextBoxPrecio2"
        Me.TextBoxPrecio2.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecio2.TabIndex = 8
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Location = New System.Drawing.Point(40, 121)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(85, 13)
        Me.LabelPrecio.TabIndex = 5
        Me.LabelPrecio.Text = "Precio de venta:"
        '
        'TextBoxDescripcion2
        '
        Me.TextBoxDescripcion2.Location = New System.Drawing.Point(131, 83)
        Me.TextBoxDescripcion2.Name = "TextBoxDescripcion2"
        Me.TextBoxDescripcion2.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxDescripcion2.TabIndex = 7
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Location = New System.Drawing.Point(59, 86)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.LabelDescripcion.TabIndex = 4
        Me.LabelDescripcion.Text = "Descripción:"
        '
        'TextBoxCodigo2
        '
        Me.TextBoxCodigo2.Location = New System.Drawing.Point(131, 48)
        Me.TextBoxCodigo2.Name = "TextBoxCodigo2"
        Me.TextBoxCodigo2.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigo2.TabIndex = 6
        '
        'LabelCodigo
        '
        Me.LabelCodigo.AutoSize = True
        Me.LabelCodigo.Location = New System.Drawing.Point(82, 51)
        Me.LabelCodigo.Name = "LabelCodigo"
        Me.LabelCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LabelCodigo.TabIndex = 3
        Me.LabelCodigo.Text = "Código:"
        '
        'GroupBoxIngresodeProducto
        '
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBox18)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBox15)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label57)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxDeshabilitado2)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxDeshabilitado)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.LabelIngresoProducto)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.ButtonCerrar2)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.ButtonInsertarProducto)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxIVA)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxPreciodeCompra)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxProveedor)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxFacturaNro)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxSeleccionarCantidad)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.TextBoxSeleccionarProducto)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label59)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label60)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label61)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label62)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label63)
        Me.GroupBoxIngresodeProducto.Controls.Add(Me.Label64)
        Me.GroupBoxIngresodeProducto.Location = New System.Drawing.Point(543, 48)
        Me.GroupBoxIngresodeProducto.Name = "GroupBoxIngresodeProducto"
        Me.GroupBoxIngresodeProducto.Size = New System.Drawing.Size(321, 359)
        Me.GroupBoxIngresodeProducto.TabIndex = 5
        Me.GroupBoxIngresodeProducto.TabStop = False
        Me.GroupBoxIngresodeProducto.Text = "Ingreso de Producto"
        Me.GroupBoxIngresodeProducto.Visible = False
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(220, 66)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(93, 20)
        Me.TextBox18.TabIndex = 18
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(144, 236)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(169, 20)
        Me.TextBox15.TabIndex = 17
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(5, 240)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(133, 13)
        Me.Label57.TabIndex = 16
        Me.Label57.Text = "Precio de Compra Unitario:"
        '
        'TextBoxDeshabilitado2
        '
        Me.TextBoxDeshabilitado2.Location = New System.Drawing.Point(220, 32)
        Me.TextBoxDeshabilitado2.Name = "TextBoxDeshabilitado2"
        Me.TextBoxDeshabilitado2.ReadOnly = True
        Me.TextBoxDeshabilitado2.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxDeshabilitado2.TabIndex = 15
        '
        'TextBoxDeshabilitado
        '
        Me.TextBoxDeshabilitado.Location = New System.Drawing.Point(219, 134)
        Me.TextBoxDeshabilitado.Name = "TextBoxDeshabilitado"
        Me.TextBoxDeshabilitado.ReadOnly = True
        Me.TextBoxDeshabilitado.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxDeshabilitado.TabIndex = 14
        '
        'LabelIngresoProducto
        '
        Me.LabelIngresoProducto.AutoSize = True
        Me.LabelIngresoProducto.Location = New System.Drawing.Point(71, 289)
        Me.LabelIngresoProducto.Name = "LabelIngresoProducto"
        Me.LabelIngresoProducto.Size = New System.Drawing.Size(111, 13)
        Me.LabelIngresoProducto.TabIndex = 9
        Me.LabelIngresoProducto.Text = "LabelIngresoProducto"
        Me.LabelIngresoProducto.Visible = False
        '
        'ButtonCerrar2
        '
        Me.ButtonCerrar2.Location = New System.Drawing.Point(181, 321)
        Me.ButtonCerrar2.Name = "ButtonCerrar2"
        Me.ButtonCerrar2.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCerrar2.TabIndex = 13
        Me.ButtonCerrar2.Text = "Cerrar"
        Me.ButtonCerrar2.UseVisualStyleBackColor = True
        '
        'ButtonInsertarProducto
        '
        Me.ButtonInsertarProducto.Location = New System.Drawing.Point(35, 321)
        Me.ButtonInsertarProducto.Name = "ButtonInsertarProducto"
        Me.ButtonInsertarProducto.Size = New System.Drawing.Size(106, 23)
        Me.ButtonInsertarProducto.TabIndex = 12
        Me.ButtonInsertarProducto.Text = "Insertar Producto"
        Me.ButtonInsertarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxIVA
        '
        Me.TextBoxIVA.Location = New System.Drawing.Point(143, 202)
        Me.TextBoxIVA.Name = "TextBoxIVA"
        Me.TextBoxIVA.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxIVA.TabIndex = 11
        '
        'TextBoxPreciodeCompra
        '
        Me.TextBoxPreciodeCompra.Location = New System.Drawing.Point(143, 168)
        Me.TextBoxPreciodeCompra.Name = "TextBoxPreciodeCompra"
        Me.TextBoxPreciodeCompra.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxPreciodeCompra.TabIndex = 10
        '
        'TextBoxProveedor
        '
        Me.TextBoxProveedor.Location = New System.Drawing.Point(144, 32)
        Me.TextBoxProveedor.Name = "TextBoxProveedor"
        Me.TextBoxProveedor.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxProveedor.TabIndex = 9
        '
        'TextBoxFacturaNro
        '
        Me.TextBoxFacturaNro.Location = New System.Drawing.Point(143, 100)
        Me.TextBoxFacturaNro.Name = "TextBoxFacturaNro"
        Me.TextBoxFacturaNro.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxFacturaNro.TabIndex = 8
        '
        'TextBoxSeleccionarCantidad
        '
        Me.TextBoxSeleccionarCantidad.Location = New System.Drawing.Point(143, 66)
        Me.TextBoxSeleccionarCantidad.Name = "TextBoxSeleccionarCantidad"
        Me.TextBoxSeleccionarCantidad.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxSeleccionarCantidad.TabIndex = 7
        '
        'TextBoxSeleccionarProducto
        '
        Me.TextBoxSeleccionarProducto.Location = New System.Drawing.Point(143, 134)
        Me.TextBoxSeleccionarProducto.Name = "TextBoxSeleccionarProducto"
        Me.TextBoxSeleccionarProducto.Size = New System.Drawing.Size(77, 20)
        Me.TextBoxSeleccionarProducto.TabIndex = 6
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(44, 206)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(94, 13)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "Precio de Compra:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(86, 172)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(52, 13)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "Cantidad:"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(79, 36)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(59, 13)
        Me.Label61.TabIndex = 3
        Me.Label61.Text = "Proveedor:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(45, 104)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(93, 13)
        Me.Label62.TabIndex = 2
        Me.Label62.Text = "Fecha de Ingreso:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(50, 70)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(88, 13)
        Me.Label63.TabIndex = 1
        Me.Label63.Text = "ID Stock Mugen:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(69, 138)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(69, 13)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Nro. Factura:"
        '
        'GroupBoxNuevoProducto
        '
        Me.GroupBoxNuevoProducto.Controls.Add(Me.LabelNuevoProducto)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.ButtonCerrar1)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.ButtonCrearProducto)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.Label43d)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.Label42s)
        Me.GroupBoxNuevoProducto.Controls.Add(Me.Label41a)
        Me.GroupBoxNuevoProducto.Location = New System.Drawing.Point(190, 48)
        Me.GroupBoxNuevoProducto.Name = "GroupBoxNuevoProducto"
        Me.GroupBoxNuevoProducto.Size = New System.Drawing.Size(321, 359)
        Me.GroupBoxNuevoProducto.TabIndex = 4
        Me.GroupBoxNuevoProducto.TabStop = False
        Me.GroupBoxNuevoProducto.Text = "Nuevo Producto"
        Me.GroupBoxNuevoProducto.Visible = False
        '
        'LabelNuevoProducto
        '
        Me.LabelNuevoProducto.AutoSize = True
        Me.LabelNuevoProducto.Location = New System.Drawing.Point(66, 220)
        Me.LabelNuevoProducto.Name = "LabelNuevoProducto"
        Me.LabelNuevoProducto.Size = New System.Drawing.Size(108, 13)
        Me.LabelNuevoProducto.TabIndex = 8
        Me.LabelNuevoProducto.Text = "LabelNuevoProducto"
        Me.LabelNuevoProducto.Visible = False
        '
        'ButtonCerrar1
        '
        Me.ButtonCerrar1.Location = New System.Drawing.Point(175, 294)
        Me.ButtonCerrar1.Name = "ButtonCerrar1"
        Me.ButtonCerrar1.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCerrar1.TabIndex = 7
        Me.ButtonCerrar1.Text = "Cerrar"
        Me.ButtonCerrar1.UseVisualStyleBackColor = True
        '
        'ButtonCrearProducto
        '
        Me.ButtonCrearProducto.Location = New System.Drawing.Point(30, 294)
        Me.ButtonCrearProducto.Name = "ButtonCrearProducto"
        Me.ButtonCrearProducto.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCrearProducto.TabIndex = 6
        Me.ButtonCrearProducto.Text = "Crear Producto"
        Me.ButtonCrearProducto.UseVisualStyleBackColor = True
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(108, 116)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecio.TabIndex = 5
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(108, 81)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxDescripcion.TabIndex = 4
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(108, 46)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigo.TabIndex = 3
        '
        'Label43d
        '
        Me.Label43d.AutoSize = True
        Me.Label43d.Location = New System.Drawing.Point(19, 120)
        Me.Label43d.Name = "Label43d"
        Me.Label43d.Size = New System.Drawing.Size(85, 13)
        Me.Label43d.TabIndex = 2
        Me.Label43d.Text = "Precio de venta:"
        '
        'Label42s
        '
        Me.Label42s.AutoSize = True
        Me.Label42s.Location = New System.Drawing.Point(38, 85)
        Me.Label42s.Name = "Label42s"
        Me.Label42s.Size = New System.Drawing.Size(66, 13)
        Me.Label42s.TabIndex = 1
        Me.Label42s.Text = "Descripción:"
        '
        'Label41a
        '
        Me.Label41a.AutoSize = True
        Me.Label41a.Location = New System.Drawing.Point(61, 50)
        Me.Label41a.Name = "Label41a"
        Me.Label41a.Size = New System.Drawing.Size(43, 13)
        Me.Label41a.TabIndex = 0
        Me.Label41a.Text = "Código:"
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(26, 188)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(124, 23)
        Me.Button27.TabIndex = 3
        Me.Button27.Text = "Estado de Stock"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(26, 143)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(124, 23)
        Me.Button26.TabIndex = 2
        Me.Button26.Text = "Modificar Producto"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(26, 98)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(124, 23)
        Me.Button25.TabIndex = 1
        Me.Button25.Text = "Ingreso de Producto"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button24NuevoProducto
        '
        Me.Button24NuevoProducto.Location = New System.Drawing.Point(26, 53)
        Me.Button24NuevoProducto.Name = "Button24NuevoProducto"
        Me.Button24NuevoProducto.Size = New System.Drawing.Size(124, 23)
        Me.Button24NuevoProducto.TabIndex = 0
        Me.Button24NuevoProducto.Text = "Nuevo Producto"
        Me.Button24NuevoProducto.UseVisualStyleBackColor = True
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'Venta_servicioTableAdapter
        '
        Me.Venta_servicioTableAdapter.ClearBeforeFill = True
        '
        'label_n_factura
        '
        Me.label_n_factura.AutoSize = True
        Me.label_n_factura.Location = New System.Drawing.Point(439, 46)
        Me.label_n_factura.Name = "label_n_factura"
        Me.label_n_factura.Size = New System.Drawing.Size(66, 13)
        Me.label_n_factura.TabIndex = 16
        Me.label_n_factura.Text = "Nro. Factura"
        '
        'n_factura_textbox
        '
        Me.n_factura_textbox.Location = New System.Drawing.Point(519, 41)
        Me.n_factura_textbox.Name = "n_factura_textbox"
        Me.n_factura_textbox.Size = New System.Drawing.Size(109, 20)
        Me.n_factura_textbox.TabIndex = 17
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1669, 679)
        Me.Controls.Add(Me.boton_servicios)
        Me.Controls.Add(Me.panel_botones_mugen)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panel_vender)
        Me.Controls.Add(Me.panel_carga_presupuesto)
        Me.Controls.Add(Me.panel_cuentas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelClientes)
        Me.Controls.Add(Me.GroupBox4Stock)
        Me.Controls.Add(Me.PanelTrabajosPendientes)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Ingreso_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contabilidad2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContabilidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Association_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Venta_servicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_servicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_productoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venta_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingreso_productoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contabilidad2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContabilidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Association_1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_cuentas.ResumeLayout(False)
        Me.panel_cuentas.PerformLayout()
        Me.panel_crear_usuarios.ResumeLayout(False)
        Me.panel_crear_usuarios.PerformLayout()
        Me.Panel_mod_user.ResumeLayout(False)
        Me.Panel_mod_user.PerformLayout()
        Me.panel_mod_cuenta.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel_carga_presupuesto.ResumeLayout(False)
        Me.panel_carga_presupuesto.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panel_botones_mugen.ResumeLayout(False)
        Me.panel_vender.ResumeLayout(False)
        Me.panel_vender.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelClientes.ResumeLayout(False)
        CType(Me.ClienteDataGridView1ModificarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCrearClienteasd.ResumeLayout(False)
        Me.GroupBoxCrearClienteasd.PerformLayout()
        Me.GroupBoxEstadisticasdelCliente.ResumeLayout(False)
        Me.GroupBoxModificarClienteasd.ResumeLayout(False)
        Me.GroupBoxModificarClienteasd.PerformLayout()
        Me.PanelTrabajosPendientes.ResumeLayout(False)
        Me.PanelTrabajosPendientes.PerformLayout()
        CType(Me.pedidoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graficoTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graficoPagados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox4Stock.ResumeLayout(False)
        Me.GroupBoxModificarProducto.ResumeLayout(False)
        Me.GroupBoxModificarProducto.PerformLayout()
        Me.GroupBoxIngresodeProducto.ResumeLayout(False)
        Me.GroupBoxIngresodeProducto.PerformLayout()
        Me.GroupBoxNuevoProducto.ResumeLayout(False)
        Me.GroupBoxNuevoProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Association_1BindingSource As BindingSource
    Friend WithEvents Association_1TableAdapter As DataSet1TableAdapters.association_1TableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ContabilidadTableAdapter As DataSet1TableAdapters.contabilidadTableAdapter
    Friend WithEvents ContabilidadBindingSource As BindingSource
    Friend WithEvents Contabilidad2TableAdapter As DataSet1TableAdapters.contabilidad2TableAdapter
    Friend WithEvents Contabilidad2BindingSource As BindingSource
    Friend WithEvents Ingreso_productoTableAdapter As DataSet1TableAdapters.ingreso_productoTableAdapter
    Friend WithEvents Ingreso_productoBindingSource As BindingSource
    Friend WithEvents PedidoTableAdapter As DataSet1TableAdapters.pedidoTableAdapter
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As DataSet1TableAdapters.productoTableAdapter
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As DataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As DataSet1TableAdapters.usuarioTableAdapter
    Friend WithEvents Venta_productoBindingSource As BindingSource
    Friend WithEvents Venta_productoTableAdapter As DataSet1TableAdapters.venta_productoTableAdapter
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panel_cuentas As Panel
    Friend WithEvents panel_crear_usuarios As Panel
    Friend WithEvents label_error_crear As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents textbox_mail As TextBox
    Friend WithEvents textbox_numero As TextBox
    Friend WithEvents textbox_apellido As TextBox
    Friend WithEvents textbox_nombre As TextBox
    Friend WithEvents textbox_rep_pass As TextBox
    Friend WithEvents textbox_pass As TextBox
    Friend WithEvents textbox_cuenta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_mod_user As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents panel_mod_cuenta As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents texbox_nueva_pass_rep As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents textbox_nueva_pass As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents textbox_mod_pass As TextBox
    Friend WithEvents textbox_mod_cuenta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents panel_carga_presupuesto As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button17 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button15 As Button
    Friend WithEvents aceptar_carga_presupuesto As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents panel_botones_mugen As Panel
    Friend WithEvents boton_stock As Button
    Friend WithEvents boton_vender As Button
    Friend WithEvents boton_servicios As Button
    Friend WithEvents panel_vender As Panel
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents label_fecha As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents label_venta_cliente As Label
    Friend WithEvents text_ruc_venta As TextBox
    Friend WithEvents label_ruc As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents venta_guardar As Button
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents Punit As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents text_sub_total As TextBox
    Friend WithEvents label_subtotal As Label
    Friend WithEvents text_total As TextBox
    Friend WithEvents label_total As Label
    Friend WithEvents text_iva As TextBox
    Friend WithEvents label_iva As Label
    Friend WithEvents label_ruc_venta As Label
    Friend WithEvents PanelClientes As Panel
    Friend WithEvents ClienteDataGridView1ModificarCliente As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxCrearClienteasd As GroupBox
    Friend WithEvents Label72CrearCliente As Label
    Friend WithEvents MailTextBoxCrearCliente As TextBox
    Friend WithEvents NumeroTextBoxCrearCliente As TextBox
    Friend WithEvents RucTextBoxCrearCliente As TextBox
    Friend WithEvents ApellidoTextBoxCrearCliente As TextBox
    Friend WithEvents NombreTextBoxCrearCliente As TextBox
    Friend WithEvents CheckBoxClientePrioritarioCrearCliente As CheckBox
    Friend WithEvents Button9CrearCliente As Button
    Friend WithEvents CrearClienteBotonCrearCliente As Button
    Friend WithEvents GroupBoxEstadisticasdelCliente As GroupBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents EstadisticasDeClienteBoton As Button
    Friend WithEvents GroupBoxModificarClienteasd As GroupBox
    Friend WithEvents Label1ModificarCliente As Label
    Friend WithEvents Button15ModificarCliente As Button
    Friend WithEvents MailTextBox1ModificarCliente As TextBox
    Friend WithEvents NumeroTextBox1ModificarCliente As TextBox
    Friend WithEvents ApellidoTextBox1ModificarCliente As TextBox
    Friend WithEvents NombreTextBox1ModificarCliente As TextBox
    Friend WithEvents RucTextBox1ModificarCliente As TextBox
    Friend WithEvents CheckBoxClientePrioritario1ModificarCliente As CheckBox
    Friend WithEvents Button10ModificarCliente As Button
    Friend WithEvents Button25ModificarCliente As Button
    Friend WithEvents Button24ModificarCliente As Button
    Friend WithEvents ModificarClienteBoton As Button
    Friend WithEvents CrearClienteBoton As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents PanelTrabajosPendientes As Panel
    Friend WithEvents graficoTrabajos As DataVisualization.Charting.Chart
    Friend WithEvents graficoPagados As DataVisualization.Charting.Chart
    Friend WithEvents btpGenerar As Button
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents idClientesAux As ListBox
    Friend WithEvents pbBorrar As Button
    Friend WithEvents pbCambiar As Button
    Friend WithEvents label47 As Label
    Friend WithEvents pcEstado As ComboBox
    Friend WithEvents idClienteActual As Label
    Friend WithEvents noHayPendientes As Label
    Friend WithEvents noExiste As Label
    Friend WithEvents sinDatos As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents TextIden As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents calendarioCobro As MonthCalendar
    Friend WithEvents Label52 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents labelRuc As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents pcProyecto As ComboBox
    Friend WithEvents ptNombre As TextBox
    Friend WithEvents ptApellido As TextBox
    Friend WithEvents ptRuc As TextBox
    Friend WithEvents ptDescrip As TextBox
    Friend WithEvents ptEntrega As TextBox
    Friend WithEvents ptCobro As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents ptPrecio As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents botonBuscar As Button
    Friend WithEvents calendarioEntregas As MonthCalendar
    Friend WithEvents resultadosPedidos As ListBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents TextCliente As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents pedidoGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn88 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn89 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn90 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn91 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn92 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn93 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn94 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn95 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn96 As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGrid As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn79 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn82 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn84 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn86 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn87 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn70 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox4Stock As GroupBox
    Friend WithEvents GroupBoxModificarProducto As GroupBox
    Friend WithEvents LabelModificarProducto As Label
    Friend WithEvents ButtonCerrar3 As Button
    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents TextBoxPrecio2 As TextBox
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents TextBoxDescripcion2 As TextBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TextBoxCodigo2 As TextBox
    Friend WithEvents LabelCodigo As Label
    Friend WithEvents GroupBoxIngresodeProducto As GroupBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents TextBoxDeshabilitado2 As TextBox
    Friend WithEvents TextBoxDeshabilitado As TextBox
    Friend WithEvents LabelIngresoProducto As Label
    Friend WithEvents ButtonCerrar2 As Button
    Friend WithEvents ButtonInsertarProducto As Button
    Friend WithEvents TextBoxIVA As TextBox
    Friend WithEvents TextBoxPreciodeCompra As TextBox
    Friend WithEvents TextBoxProveedor As TextBox
    Friend WithEvents TextBoxFacturaNro As TextBox
    Friend WithEvents TextBoxSeleccionarCantidad As TextBox
    Friend WithEvents TextBoxSeleccionarProducto As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents GroupBoxNuevoProducto As GroupBox
    Friend WithEvents LabelNuevoProducto As Label
    Friend WithEvents ButtonCerrar1 As Button
    Friend WithEvents ButtonCrearProducto As Button
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label43d As Label
    Friend WithEvents Label42s As Label
    Friend WithEvents Label41a As Label
    Friend WithEvents Button27 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button24NuevoProducto As Button
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents PedidoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents Ingreso_productoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents Contabilidad2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents ContabilidadDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Association_1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As DataSet1TableAdapters.servicioTableAdapter
    Friend WithEvents Venta_productoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn101 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn102 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn103 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn104 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn105 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn106 As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn97 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn98 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn99 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn100 As DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents Venta_servicioBindingSource As BindingSource
    Friend WithEvents Venta_servicioTableAdapter As DataSet1TableAdapters.venta_servicioTableAdapter
    Friend WithEvents Venta_servicioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn107 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn108 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn109 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn110 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn111 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn112 As DataGridViewTextBoxColumn
    Friend WithEvents n_factura_textbox As TextBox
    Friend WithEvents label_n_factura As Label
End Class
