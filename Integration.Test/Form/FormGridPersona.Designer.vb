<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGridPersona
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGridPersona))
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkBuscar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdBuscar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.c1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CmdHldrPersona = New C1.Win.C1Command.C1CommandHolder()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerIdeTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerIdeNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerTratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerPriNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerSegNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerTerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpernombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dPerNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerNatSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerNatEstCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerJurSecEconomico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerJurTipInversion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUbiGeoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.CboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.C1CmdHldrPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkBuscar, Me.C1CmdLinkNuevo, Me.C1CmdLinkEdit, Me.C1CmdLinkCancel, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(33, 28)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(466, 24)
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
        Me.C1CmdBuscar.Image = Global.Integration.Test.My.Resources.Resources.FindCustomers_16x16
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
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.c1CmdCancelar
        Me.C1CmdLinkCancel.SortOrder = 3
        Me.C1CmdLinkCancel.Text = "&Cancelar"
        '
        'c1CmdCancelar
        '
        Me.c1CmdCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.c1CmdCancelar.Name = "c1CmdCancelar"
        Me.c1CmdCancelar.Text = "&Cancelar"
        Me.c1CmdCancelar.Visible = False
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
        'C1CmdHldrPersona
        '
        Me.C1CmdHldrPersona.Commands.Add(Me.c1CmdNuevo)
        Me.C1CmdHldrPersona.Commands.Add(Me.C1CmdBuscar)
        Me.C1CmdHldrPersona.Commands.Add(Me.c1CmdCancelar)
        Me.C1CmdHldrPersona.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldrPersona.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldrPersona.Owner = Me
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerCodigo, Me.nPerTipo, Me.TipoPersona, Me.nPerIdeTipo, Me.TipoDocu, Me.cPerIdeNumero, Me.nPerTratamiento, Me.cPerApellPaterno, Me.cPerApellMaterno, Me.cPerPriNombre, Me.cPerSegNombre, Me.cPerTerNombre, Me.cpernombre, Me.dPerNacimiento, Me.nPerNatSexo, Me.nPerNatEstCivil, Me.nPerJurSecEconomico, Me.nPerJurTipInversion, Me.cUbiGeoCodigo, Me.nIntCodigo, Me.Pais, Me.nEdad})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Table1.Location = New System.Drawing.Point(12, 111)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Table1.Size = New System.Drawing.Size(774, 125)
        Me.Table1.TabIndex = 0
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cPerCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cPerCodigo.HeaderText = "Código"
        Me.cPerCodigo.Name = "cPerCodigo"
        Me.cPerCodigo.ReadOnly = True
        Me.cPerCodigo.Width = 80
        '
        'nPerTipo
        '
        Me.nPerTipo.DataPropertyName = "nPerTipo"
        Me.nPerTipo.HeaderText = "nPerTipo"
        Me.nPerTipo.Name = "nPerTipo"
        Me.nPerTipo.ReadOnly = True
        Me.nPerTipo.Visible = False
        '
        'TipoPersona
        '
        Me.TipoPersona.DataPropertyName = "TipoPersona"
        Me.TipoPersona.HeaderText = "TipoPersona"
        Me.TipoPersona.Name = "TipoPersona"
        Me.TipoPersona.ReadOnly = True
        Me.TipoPersona.Width = 170
        '
        'nPerIdeTipo
        '
        Me.nPerIdeTipo.DataPropertyName = "nPerIdeTipo"
        Me.nPerIdeTipo.HeaderText = "nPerIdeTipo"
        Me.nPerIdeTipo.Name = "nPerIdeTipo"
        Me.nPerIdeTipo.ReadOnly = True
        Me.nPerIdeTipo.Visible = False
        '
        'TipoDocu
        '
        Me.TipoDocu.DataPropertyName = "TipoDocu"
        Me.TipoDocu.HeaderText = "Tipo Documento"
        Me.TipoDocu.Name = "TipoDocu"
        Me.TipoDocu.ReadOnly = True
        Me.TipoDocu.Width = 210
        '
        'cPerIdeNumero
        '
        Me.cPerIdeNumero.DataPropertyName = "cPerIdeNumero"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cPerIdeNumero.DefaultCellStyle = DataGridViewCellStyle3
        Me.cPerIdeNumero.HeaderText = "Numero / DNI / RUC"
        Me.cPerIdeNumero.Name = "cPerIdeNumero"
        Me.cPerIdeNumero.ReadOnly = True
        Me.cPerIdeNumero.Width = 150
        '
        'nPerTratamiento
        '
        Me.nPerTratamiento.DataPropertyName = "nPerTratamiento"
        Me.nPerTratamiento.HeaderText = "nPerTratamiento"
        Me.nPerTratamiento.Name = "nPerTratamiento"
        Me.nPerTratamiento.ReadOnly = True
        Me.nPerTratamiento.Visible = False
        '
        'cPerApellPaterno
        '
        Me.cPerApellPaterno.DataPropertyName = "cPerApellPaterno"
        Me.cPerApellPaterno.HeaderText = "cPerApellPaterno"
        Me.cPerApellPaterno.Name = "cPerApellPaterno"
        Me.cPerApellPaterno.ReadOnly = True
        Me.cPerApellPaterno.Visible = False
        '
        'cPerApellMaterno
        '
        Me.cPerApellMaterno.DataPropertyName = "cPerApellMaterno"
        Me.cPerApellMaterno.HeaderText = "Apellido Materno"
        Me.cPerApellMaterno.Name = "cPerApellMaterno"
        Me.cPerApellMaterno.ReadOnly = True
        Me.cPerApellMaterno.Visible = False
        Me.cPerApellMaterno.Width = 220
        '
        'cPerPriNombre
        '
        Me.cPerPriNombre.DataPropertyName = "cPerPriNombre"
        Me.cPerPriNombre.HeaderText = "cPerPriNombre"
        Me.cPerPriNombre.Name = "cPerPriNombre"
        Me.cPerPriNombre.ReadOnly = True
        Me.cPerPriNombre.Visible = False
        '
        'cPerSegNombre
        '
        Me.cPerSegNombre.DataPropertyName = "cPerSegNombre"
        Me.cPerSegNombre.HeaderText = "cPerSegNombre"
        Me.cPerSegNombre.Name = "cPerSegNombre"
        Me.cPerSegNombre.ReadOnly = True
        Me.cPerSegNombre.Visible = False
        '
        'cPerTerNombre
        '
        Me.cPerTerNombre.DataPropertyName = "cPerTerNombre"
        Me.cPerTerNombre.HeaderText = "cPerTerNombre"
        Me.cPerTerNombre.Name = "cPerTerNombre"
        Me.cPerTerNombre.ReadOnly = True
        Me.cPerTerNombre.Visible = False
        '
        'cpernombre
        '
        Me.cpernombre.DataPropertyName = "cpernombre"
        Me.cpernombre.HeaderText = "Nombre Completo / Razon Social"
        Me.cpernombre.Name = "cpernombre"
        Me.cpernombre.ReadOnly = True
        Me.cpernombre.Width = 400
        '
        'dPerNacimiento
        '
        Me.dPerNacimiento.DataPropertyName = "dPerNacimiento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dPerNacimiento.DefaultCellStyle = DataGridViewCellStyle4
        Me.dPerNacimiento.HeaderText = "Fec. Naci. / Creación"
        Me.dPerNacimiento.Name = "dPerNacimiento"
        Me.dPerNacimiento.ReadOnly = True
        Me.dPerNacimiento.Width = 90
        '
        'nPerNatSexo
        '
        Me.nPerNatSexo.DataPropertyName = "nPerNatSexo"
        Me.nPerNatSexo.HeaderText = "nPerNatSexo"
        Me.nPerNatSexo.Name = "nPerNatSexo"
        Me.nPerNatSexo.ReadOnly = True
        Me.nPerNatSexo.Visible = False
        '
        'nPerNatEstCivil
        '
        Me.nPerNatEstCivil.DataPropertyName = "nPerNatEstCivil"
        Me.nPerNatEstCivil.HeaderText = "nPerNatEstCivil"
        Me.nPerNatEstCivil.Name = "nPerNatEstCivil"
        Me.nPerNatEstCivil.ReadOnly = True
        Me.nPerNatEstCivil.Visible = False
        '
        'nPerJurSecEconomico
        '
        Me.nPerJurSecEconomico.DataPropertyName = "nPerJurSecEconomico"
        Me.nPerJurSecEconomico.HeaderText = "nPerJurSecEconomico"
        Me.nPerJurSecEconomico.Name = "nPerJurSecEconomico"
        Me.nPerJurSecEconomico.ReadOnly = True
        Me.nPerJurSecEconomico.Visible = False
        '
        'nPerJurTipInversion
        '
        Me.nPerJurTipInversion.DataPropertyName = "nPerJurTipInversion"
        Me.nPerJurTipInversion.HeaderText = "nPerJurTipInversion"
        Me.nPerJurTipInversion.Name = "nPerJurTipInversion"
        Me.nPerJurTipInversion.ReadOnly = True
        Me.nPerJurTipInversion.Visible = False
        '
        'cUbiGeoCodigo
        '
        Me.cUbiGeoCodigo.DataPropertyName = "cUbiGeoCodigo"
        Me.cUbiGeoCodigo.HeaderText = "Ubigeo"
        Me.cUbiGeoCodigo.Name = "cUbiGeoCodigo"
        Me.cUbiGeoCodigo.ReadOnly = True
        Me.cUbiGeoCodigo.Width = 150
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.ReadOnly = True
        Me.nIntCodigo.Visible = False
        '
        'Pais
        '
        Me.Pais.DataPropertyName = "Pais"
        Me.Pais.HeaderText = "Nacionalidad"
        Me.Pais.Name = "Pais"
        Me.Pais.ReadOnly = True
        Me.Pais.Width = 180
        '
        'nEdad
        '
        Me.nEdad.DataPropertyName = "nEdad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nEdad.DefaultCellStyle = DataGridViewCellStyle5
        Me.nEdad.HeaderText = "Edad"
        Me.nEdad.Name = "nEdad"
        Me.nEdad.ReadOnly = True
        Me.nEdad.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.CboTipoPer)
        Me.GroupBox.Controls.Add(Me.TxtBuscar)
        Me.GroupBox.Controls.Add(Me.CboFiltro)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(33, 60)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(782, 45)
        Me.GroupBox.TabIndex = 17
        Me.GroupBox.TabStop = False
        '
        'CboTipoPer
        '
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(219, 15)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(164, 21)
        Me.CboTipoPer.TabIndex = 1
        Me.CboTipoPer.Tag = "1010"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(389, 16)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(379, 20)
        Me.TxtBuscar.TabIndex = 2
        '
        'CboFiltro
        '
        Me.CboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltro.FormattingEnabled = True
        Me.CboFiltro.Items.AddRange(New Object() {"DNI / RUC", "Comienza", "Contiene", "Termina"})
        Me.CboFiltro.Location = New System.Drawing.Point(35, 15)
        Me.CboFiltro.Name = "CboFiltro"
        Me.CboFiltro.Size = New System.Drawing.Size(110, 21)
        Me.CboFiltro.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo persona:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(794, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "҉    Registro Persona [Natural y/o Jurídica]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.ForeColor = System.Drawing.Color.Navy
        Me.LblMsg.Location = New System.Drawing.Point(821, 92)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(10, 13)
        Me.LblMsg.TabIndex = 21
        Me.LblMsg.Text = "."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.AllowUsersToEditRanges_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FormGridPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 242)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormGridPersona"
        Me.Text = "Registro Persona [Natural y/o Jurídica]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1CmdHldrPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkBuscar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdHldrPersona As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerIdeTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerIdeNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerTratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerApellPaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerApellMaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerPriNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerSegNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerTerNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpernombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dPerNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerNatSexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerNatEstCivil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerJurSecEconomico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerJurTipInversion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUbiGeoCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nEdad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Private WithEvents c1CmdCancelar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Private WithEvents C1CmdBuscar As C1.Win.C1Command.C1Command
End Class
