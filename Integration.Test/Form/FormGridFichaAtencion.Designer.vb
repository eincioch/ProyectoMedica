<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGridFichaAtencion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGridFichaAtencion))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkBuscar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdBuscar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkPago = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdPago = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.CboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cPerJuridica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerCodigoTerceros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSolAdmNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerIdeNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerPriNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFecRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFecExamen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFecEntResultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.nAdmSolEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cConDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nImpTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerUseCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteComCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescTipoDocu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteComNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CntxtMnuStrp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirFichaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntxtMnuStrp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkBuscar, Me.C1CmdLinkNuevo, Me.C1CmdLinkEdit, Me.C1CmdLinkPago, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(36, 31)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(516, 24)
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdLinkBuscar
        '
        Me.C1CmdLinkBuscar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkBuscar.Command = Me.C1CmdBuscar
        Me.C1CmdLinkBuscar.Text = "&Buscar (F5)"
        '
        'C1CmdBuscar
        '
        Me.C1CmdBuscar.Image = Global.Integration.Test.My.Resources.Resources.find
        Me.C1CmdBuscar.Name = "C1CmdBuscar"
        '
        'C1CmdLinkNuevo
        '
        Me.C1CmdLinkNuevo.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkNuevo.Command = Me.c1CmdNuevo
        Me.C1CmdLinkNuevo.SortOrder = 1
        Me.C1CmdLinkNuevo.Text = "&Nuevo (F6)"
        '
        'c1CmdNuevo
        '
        Me.c1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdNuevo.Name = "c1CmdNuevo"
        Me.c1CmdNuevo.Text = "&Nuevo"
        '
        'C1CmdLinkEdit
        '
        Me.C1CmdLinkEdit.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkEdit.Command = Me.C1CmdEdit
        Me.C1CmdLinkEdit.SortOrder = 2
        Me.C1CmdLinkEdit.Text = "&Modificar (F7)"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "&Modificar"
        '
        'C1CmdLinkPago
        '
        Me.C1CmdLinkPago.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkPago.Command = Me.c1CmdPago
        Me.C1CmdLinkPago.SortOrder = 3
        Me.C1CmdLinkPago.Text = "&Realizar Pago (F9)"
        '
        'c1CmdPago
        '
        Me.c1CmdPago.Image = Global.Integration.Test.My.Resources.Resources.money_add
        Me.c1CmdPago.Name = "c1CmdPago"
        Me.c1CmdPago.Text = "&Realizar Pago"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 4
        Me.C1CmdLinkCerrar.Text = "&Cerrar (ESC)"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdBuscar)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdNuevo)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdEdit)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdPago)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtBuscar.Location = New System.Drawing.Point(239, 15)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(391, 26)
        Me.TxtBuscar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(781, 28)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "҉    Registro / Maestro Ficha Atención"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Panel1)
        Me.GroupBox.Controls.Add(Me.TxtBuscar)
        Me.GroupBox.Controls.Add(Me.CboFiltro)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(3, 61)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(774, 51)
        Me.GroupBox.TabIndex = 24
        Me.GroupBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtpFecFin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DtpFecIni)
        Me.Panel1.Location = New System.Drawing.Point(240, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 32)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(208, 4)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(87, 20)
        Me.DtpFecFin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "hasta"
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(60, 4)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(87, 20)
        Me.DtpFecIni.TabIndex = 3
        '
        'CboFiltro
        '
        Me.CboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboFiltro.FormattingEnabled = True
        Me.CboFiltro.Items.AddRange(New Object() {"Nro. Ficha Atención", "D.N.I./R.U.C.", "Apellidos", "Rango Fechas"})
        Me.CboFiltro.Location = New System.Drawing.Point(43, 15)
        Me.CboFiltro.Name = "CboFiltro"
        Me.CboFiltro.Size = New System.Drawing.Size(192, 28)
        Me.CboFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro:"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table1.ColumnHeadersHeight = 30
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imagen, Me.cPerJuridica, Me.nIntCodigo, Me.cIntDescripcion, Me.cPerCodigoTerceros, Me.nSolAdmNumero, Me.cPerCodigo, Me.cPerIdeNumero, Me.cPerApellidos, Me.cPerNombreCompleto, Me.cPerPriNombre, Me.dFecRegistro, Me.dFecExamen, Me.dFecEntResultado, Me.ImgStatus, Me.nAdmSolEstado, Me.cConDescripcion, Me.nImpTotal, Me.cCtaCteRecibo, Me.cPerUseCodigo, Me.nPerTipo, Me.nCtaCteComCodigo, Me.DescTipoDocu, Me.cCtaCteComNumero})
        Me.Table1.ContextMenuStrip = Me.CntxtMnuStrp
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle14
        Me.Table1.Location = New System.Drawing.Point(3, 114)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.Table1.Size = New System.Drawing.Size(774, 123)
        Me.Table1.TabIndex = 23
        '
        'Imagen
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        Me.Imagen.DefaultCellStyle = DataGridViewCellStyle2
        Me.Imagen.HeaderText = "!"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Width = 35
        '
        'cPerJuridica
        '
        Me.cPerJuridica.DataPropertyName = "cPerJuridica"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerJuridica.DefaultCellStyle = DataGridViewCellStyle3
        Me.cPerJuridica.HeaderText = "cPerJuridica"
        Me.cPerJuridica.Name = "cPerJuridica"
        Me.cPerJuridica.ReadOnly = True
        Me.cPerJuridica.Visible = False
        Me.cPerJuridica.Width = 50
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.ReadOnly = True
        Me.nIntCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nIntCodigo.Visible = False
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        Me.cIntDescripcion.HeaderText = "Tipo Atención"
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.ReadOnly = True
        Me.cIntDescripcion.Width = 170
        '
        'cPerCodigoTerceros
        '
        Me.cPerCodigoTerceros.DataPropertyName = "cPerCodigoTerceros"
        Me.cPerCodigoTerceros.HeaderText = "cPerCodigoTerceros"
        Me.cPerCodigoTerceros.Name = "cPerCodigoTerceros"
        Me.cPerCodigoTerceros.ReadOnly = True
        Me.cPerCodigoTerceros.Visible = False
        '
        'nSolAdmNumero
        '
        Me.nSolAdmNumero.DataPropertyName = "nSolAdmNumero"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nSolAdmNumero.DefaultCellStyle = DataGridViewCellStyle4
        Me.nSolAdmNumero.HeaderText = "Numero Ficha"
        Me.nSolAdmNumero.Name = "nSolAdmNumero"
        Me.nSolAdmNumero.ReadOnly = True
        Me.nSolAdmNumero.Width = 120
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        Me.cPerCodigo.HeaderText = "cPerCodigo"
        Me.cPerCodigo.Name = "cPerCodigo"
        Me.cPerCodigo.ReadOnly = True
        Me.cPerCodigo.Visible = False
        Me.cPerCodigo.Width = 150
        '
        'cPerIdeNumero
        '
        Me.cPerIdeNumero.DataPropertyName = "cPerIdeNumero"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerIdeNumero.DefaultCellStyle = DataGridViewCellStyle5
        Me.cPerIdeNumero.HeaderText = "Nro. Documento (DNI)"
        Me.cPerIdeNumero.Name = "cPerIdeNumero"
        Me.cPerIdeNumero.ReadOnly = True
        Me.cPerIdeNumero.Width = 130
        '
        'cPerApellidos
        '
        Me.cPerApellidos.DataPropertyName = "cPerApellidos"
        Me.cPerApellidos.HeaderText = "cPerApellidos"
        Me.cPerApellidos.Name = "cPerApellidos"
        Me.cPerApellidos.ReadOnly = True
        Me.cPerApellidos.Visible = False
        '
        'cPerNombreCompleto
        '
        Me.cPerNombreCompleto.DataPropertyName = "cPerNombreCompleto"
        Me.cPerNombreCompleto.HeaderText = "Apellidos y Nombres"
        Me.cPerNombreCompleto.Name = "cPerNombreCompleto"
        Me.cPerNombreCompleto.ReadOnly = True
        Me.cPerNombreCompleto.Width = 350
        '
        'cPerPriNombre
        '
        Me.cPerPriNombre.DataPropertyName = "dPerNacimiento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerPriNombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.cPerPriNombre.HeaderText = "Edad"
        Me.cPerPriNombre.Name = "cPerPriNombre"
        Me.cPerPriNombre.ReadOnly = True
        '
        'dFecRegistro
        '
        Me.dFecRegistro.DataPropertyName = "dFecRegistro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dFecRegistro.DefaultCellStyle = DataGridViewCellStyle7
        Me.dFecRegistro.HeaderText = "Fecha registro"
        Me.dFecRegistro.Name = "dFecRegistro"
        Me.dFecRegistro.ReadOnly = True
        Me.dFecRegistro.Width = 90
        '
        'dFecExamen
        '
        Me.dFecExamen.DataPropertyName = "dFecExamen"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.dFecExamen.DefaultCellStyle = DataGridViewCellStyle8
        Me.dFecExamen.HeaderText = "Fecha Examen"
        Me.dFecExamen.Name = "dFecExamen"
        Me.dFecExamen.ReadOnly = True
        Me.dFecExamen.Width = 90
        '
        'dFecEntResultado
        '
        Me.dFecEntResultado.DataPropertyName = "dFecEntResultado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.dFecEntResultado.DefaultCellStyle = DataGridViewCellStyle9
        Me.dFecEntResultado.HeaderText = "Fecha Resultado"
        Me.dFecEntResultado.Name = "dFecEntResultado"
        Me.dFecEntResultado.ReadOnly = True
        Me.dFecEntResultado.Width = 90
        '
        'ImgStatus
        '
        Me.ImgStatus.HeaderText = "?"
        Me.ImgStatus.Name = "ImgStatus"
        Me.ImgStatus.ReadOnly = True
        Me.ImgStatus.Width = 35
        '
        'nAdmSolEstado
        '
        Me.nAdmSolEstado.DataPropertyName = "nAdmSolEstado"
        Me.nAdmSolEstado.HeaderText = "nAdmSolEstado"
        Me.nAdmSolEstado.Name = "nAdmSolEstado"
        Me.nAdmSolEstado.ReadOnly = True
        Me.nAdmSolEstado.Visible = False
        Me.nAdmSolEstado.Width = 90
        '
        'cConDescripcion
        '
        Me.cConDescripcion.DataPropertyName = "cConDescripcion"
        Me.cConDescripcion.HeaderText = "Estado"
        Me.cConDescripcion.Name = "cConDescripcion"
        Me.cConDescripcion.ReadOnly = True
        Me.cConDescripcion.Width = 140
        '
        'nImpTotal
        '
        Me.nImpTotal.DataPropertyName = "nImpTotal"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.nImpTotal.DefaultCellStyle = DataGridViewCellStyle10
        Me.nImpTotal.HeaderText = "Importe Total"
        Me.nImpTotal.Name = "nImpTotal"
        Me.nImpTotal.ReadOnly = True
        '
        'cCtaCteRecibo
        '
        Me.cCtaCteRecibo.DataPropertyName = "cCtaCteRecibo"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteRecibo.DefaultCellStyle = DataGridViewCellStyle11
        Me.cCtaCteRecibo.HeaderText = "Nro. Recibo"
        Me.cCtaCteRecibo.Name = "cCtaCteRecibo"
        Me.cCtaCteRecibo.ReadOnly = True
        Me.cCtaCteRecibo.Width = 110
        '
        'cPerUseCodigo
        '
        Me.cPerUseCodigo.DataPropertyName = "cPerUseCodigo"
        Me.cPerUseCodigo.HeaderText = "cPerUseCodigo"
        Me.cPerUseCodigo.Name = "cPerUseCodigo"
        Me.cPerUseCodigo.ReadOnly = True
        Me.cPerUseCodigo.Visible = False
        '
        'nPerTipo
        '
        Me.nPerTipo.DataPropertyName = "nPerTipo"
        Me.nPerTipo.HeaderText = "nPerTipo"
        Me.nPerTipo.Name = "nPerTipo"
        Me.nPerTipo.ReadOnly = True
        Me.nPerTipo.Visible = False
        '
        'nCtaCteComCodigo
        '
        Me.nCtaCteComCodigo.DataPropertyName = "nCtaCteComCodigo"
        Me.nCtaCteComCodigo.HeaderText = "nCtaCteComCodigo"
        Me.nCtaCteComCodigo.Name = "nCtaCteComCodigo"
        Me.nCtaCteComCodigo.ReadOnly = True
        Me.nCtaCteComCodigo.Visible = False
        '
        'DescTipoDocu
        '
        Me.DescTipoDocu.DataPropertyName = "DescTipoDocu"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DescTipoDocu.DefaultCellStyle = DataGridViewCellStyle12
        Me.DescTipoDocu.HeaderText = "Docu. Venta"
        Me.DescTipoDocu.Name = "DescTipoDocu"
        Me.DescTipoDocu.ReadOnly = True
        Me.DescTipoDocu.Width = 150
        '
        'cCtaCteComNumero
        '
        Me.cCtaCteComNumero.DataPropertyName = "cCtaCteComNumero"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteComNumero.DefaultCellStyle = DataGridViewCellStyle13
        Me.cCtaCteComNumero.HeaderText = "Serie/Correlativo"
        Me.cCtaCteComNumero.Name = "cCtaCteComNumero"
        Me.cCtaCteComNumero.ReadOnly = True
        '
        'CntxtMnuStrp
        '
        Me.CntxtMnuStrp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirFichaToolStripMenuItem})
        Me.CntxtMnuStrp.Name = "ContextMenuStrip1"
        Me.CntxtMnuStrp.Size = New System.Drawing.Size(152, 26)
        '
        'ImprimirFichaToolStripMenuItem
        '
        Me.ImprimirFichaToolStripMenuItem.Name = "ImprimirFichaToolStripMenuItem"
        Me.ImprimirFichaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ImprimirFichaToolStripMenuItem.Text = "Imprimir Ficha"
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.ForeColor = System.Drawing.Color.Navy
        Me.LblMsg.Location = New System.Drawing.Point(784, 92)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(10, 13)
        Me.LblMsg.TabIndex = 26
        Me.LblMsg.Text = "."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.vcard_add1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'FormGridFichaAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 243)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.LblMsg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormGridFichaAtencion"
        Me.Text = "Registro / Maestro Ficha Atención"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntxtMnuStrp.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkBuscar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkPago As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cPerJuridica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerCodigoTerceros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSolAdmNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerIdeNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerPriNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFecRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFecExamen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFecEntResultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgStatus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents nAdmSolEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cConDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nImpTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerUseCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteComCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescTipoDocu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteComNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CntxtMnuStrp As System.Windows.Forms.ContextMenuStrip
    Private WithEvents C1CmdBuscar As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdPago As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents ImprimirFichaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
