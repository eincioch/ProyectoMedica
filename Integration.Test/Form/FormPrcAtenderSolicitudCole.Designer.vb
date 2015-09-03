<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcAtenderSolicitudCole
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcAtenderSolicitudCole))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtpFecINI = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFecFIN = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTipoFiltro = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.CboCondicion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nPerAdmEstado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cPerJuridica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nProCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSolAdmNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dPerAdmRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSolAdmFecSecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerPriNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerSegNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerTerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdNroColegiado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteImpAplicado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHldrAdmSol = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevaSol = New C1.Win.C1Command.C1Command()
        Me.C1CmdAtender = New C1.Win.C1Command.C1Command()
        Me.C1CmdPrintDGV = New C1.Win.C1Command.C1Command()
        Me.C1CmdPrintFichaInd = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldrAdmSol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboTipoFiltro)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.CboCondicion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtpFecINI)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DtpFecFIN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(207, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 30)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'DtpFecINI
        '
        Me.DtpFecINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecINI.Location = New System.Drawing.Point(57, 8)
        Me.DtpFecINI.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DtpFecINI.Name = "DtpFecINI"
        Me.DtpFecINI.Size = New System.Drawing.Size(97, 20)
        Me.DtpFecINI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'DtpFecFIN
        '
        Me.DtpFecFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFIN.Location = New System.Drawing.Point(199, 8)
        Me.DtpFecFIN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DtpFecFIN.Name = "DtpFecFIN"
        Me.DtpFecFIN.Size = New System.Drawing.Size(97, 20)
        Me.DtpFecFIN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Buscar por:"
        '
        'CboTipoFiltro
        '
        Me.CboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoFiltro.FormattingEnabled = True
        Me.CboTipoFiltro.Items.AddRange(New Object() {"Nro. Solicitud", "D.N.I.", "Rango de fechas"})
        Me.CboTipoFiltro.Location = New System.Drawing.Point(82, 15)
        Me.CboTipoFiltro.Name = "CboTipoFiltro"
        Me.CboTipoFiltro.Size = New System.Drawing.Size(122, 21)
        Me.CboTipoFiltro.TabIndex = 6
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.zoom_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(729, 9)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(82, 28)
        Me.BtnMostrar.TabIndex = 5
        Me.BtnMostrar.Text = "Mostrar..."
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'CboCondicion
        '
        Me.CboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCondicion.FormattingEnabled = True
        Me.CboCondicion.Items.AddRange(New Object() {"Pendiente", "Atendido"})
        Me.CboCondicion.Location = New System.Drawing.Point(577, 14)
        Me.CboCondicion.Name = "CboCondicion"
        Me.CboCondicion.Size = New System.Drawing.Size(146, 21)
        Me.CboCondicion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Condición:"
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
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nPerAdmEstado, Me.cPerJuridica, Me.nProCodigo, Me.cIntDescripcion, Me.nSolAdmNumero, Me.dPerAdmRegistro, Me.nSolAdmFecSecuencia, Me.nPerTipo, Me.cPerCodigo, Me.dni, Me.cPerNombreCompleto, Me.cPerApellPaterno, Me.cPerApellMaterno, Me.cPerPriNombre, Me.cPerSegNombre, Me.cPerTerNombre, Me.cIdNroColegiado, Me.cCtaCteRecibo, Me.nCtaCteImporte, Me.nCtaCteImpAplicado})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Table1.Location = New System.Drawing.Point(12, 101)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Table1.Size = New System.Drawing.Size(820, 160)
        Me.Table1.TabIndex = 15
        '
        'nPerAdmEstado
        '
        Me.nPerAdmEstado.DataPropertyName = "nPerAdmEstado"
        Me.nPerAdmEstado.FalseValue = "0"
        Me.nPerAdmEstado.HeaderText = "Estado"
        Me.nPerAdmEstado.Name = "nPerAdmEstado"
        Me.nPerAdmEstado.TrueValue = "1"
        Me.nPerAdmEstado.Width = 50
        '
        'cPerJuridica
        '
        Me.cPerJuridica.DataPropertyName = "cPerJuridica"
        Me.cPerJuridica.HeaderText = "cPerJuridica"
        Me.cPerJuridica.Name = "cPerJuridica"
        Me.cPerJuridica.Visible = False
        '
        'nProCodigo
        '
        Me.nProCodigo.DataPropertyName = "nProCodigo"
        Me.nProCodigo.HeaderText = "nProCodigo"
        Me.nProCodigo.Name = "nProCodigo"
        Me.nProCodigo.Visible = False
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.cIntDescripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.cIntDescripcion.HeaderText = "Programa"
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.Width = 150
        '
        'nSolAdmNumero
        '
        Me.nSolAdmNumero.DataPropertyName = "nSolAdmNumero"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nSolAdmNumero.DefaultCellStyle = DataGridViewCellStyle3
        Me.nSolAdmNumero.HeaderText = "Nro. Solicitud"
        Me.nSolAdmNumero.Name = "nSolAdmNumero"
        '
        'dPerAdmRegistro
        '
        Me.dPerAdmRegistro.DataPropertyName = "dPerAdmRegistro"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Format = "d"
        Me.dPerAdmRegistro.DefaultCellStyle = DataGridViewCellStyle4
        Me.dPerAdmRegistro.HeaderText = "Fecha Solicitud"
        Me.dPerAdmRegistro.Name = "dPerAdmRegistro"
        Me.dPerAdmRegistro.Width = 80
        '
        'nSolAdmFecSecuencia
        '
        Me.nSolAdmFecSecuencia.DataPropertyName = "nSolAdmFecSecuencia"
        Me.nSolAdmFecSecuencia.HeaderText = "SEQ."
        Me.nSolAdmFecSecuencia.Name = "nSolAdmFecSecuencia"
        Me.nSolAdmFecSecuencia.Width = 40
        '
        'nPerTipo
        '
        Me.nPerTipo.DataPropertyName = "nPerTipo"
        Me.nPerTipo.HeaderText = "nPerTipo"
        Me.nPerTipo.Name = "nPerTipo"
        Me.nPerTipo.Visible = False
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerCodigo.DefaultCellStyle = DataGridViewCellStyle5
        Me.cPerCodigo.HeaderText = "Codigo Persona"
        Me.cPerCodigo.Name = "cPerCodigo"
        '
        'dni
        '
        Me.dni.DataPropertyName = "cPerIdeNumero"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dni.DefaultCellStyle = DataGridViewCellStyle6
        Me.dni.HeaderText = "Documento Nacional de Identidad"
        Me.dni.Name = "dni"
        '
        'cPerNombreCompleto
        '
        Me.cPerNombreCompleto.DataPropertyName = "cPerNombreCompleto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.cPerNombreCompleto.DefaultCellStyle = DataGridViewCellStyle7
        Me.cPerNombreCompleto.HeaderText = "Apellidos y Nombre(s)"
        Me.cPerNombreCompleto.Name = "cPerNombreCompleto"
        Me.cPerNombreCompleto.Width = 350
        '
        'cPerApellPaterno
        '
        Me.cPerApellPaterno.DataPropertyName = "cPerApellPaterno"
        Me.cPerApellPaterno.HeaderText = "cPerApellPaterno"
        Me.cPerApellPaterno.Name = "cPerApellPaterno"
        Me.cPerApellPaterno.Visible = False
        '
        'cPerApellMaterno
        '
        Me.cPerApellMaterno.DataPropertyName = "cPerApellMaterno"
        Me.cPerApellMaterno.HeaderText = "cPerApellMaterno"
        Me.cPerApellMaterno.Name = "cPerApellMaterno"
        Me.cPerApellMaterno.Visible = False
        '
        'cPerPriNombre
        '
        Me.cPerPriNombre.DataPropertyName = "cPerPriNombre"
        Me.cPerPriNombre.HeaderText = "cPerPriNombre"
        Me.cPerPriNombre.Name = "cPerPriNombre"
        Me.cPerPriNombre.Visible = False
        '
        'cPerSegNombre
        '
        Me.cPerSegNombre.DataPropertyName = "cPerSegNombre"
        Me.cPerSegNombre.HeaderText = "cPerSegNombre"
        Me.cPerSegNombre.Name = "cPerSegNombre"
        Me.cPerSegNombre.Visible = False
        '
        'cPerTerNombre
        '
        Me.cPerTerNombre.DataPropertyName = "cPerTerNombre"
        Me.cPerTerNombre.HeaderText = "cPerTerNombre"
        Me.cPerTerNombre.Name = "cPerTerNombre"
        Me.cPerTerNombre.Visible = False
        '
        'cIdNroColegiado
        '
        Me.cIdNroColegiado.DataPropertyName = "cIdNroColegiado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cIdNroColegiado.DefaultCellStyle = DataGridViewCellStyle8
        Me.cIdNroColegiado.HeaderText = "Codigo Colegiado"
        Me.cIdNroColegiado.Name = "cIdNroColegiado"
        Me.cIdNroColegiado.Width = 120
        '
        'cCtaCteRecibo
        '
        Me.cCtaCteRecibo.DataPropertyName = "cCtaCteRecibo"
        Me.cCtaCteRecibo.HeaderText = "Recibo pago"
        Me.cCtaCteRecibo.Name = "cCtaCteRecibo"
        '
        'nCtaCteImporte
        '
        Me.nCtaCteImporte.DataPropertyName = "nCtaCteImporte"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N2"
        Me.nCtaCteImporte.DefaultCellStyle = DataGridViewCellStyle9
        Me.nCtaCteImporte.HeaderText = "nCtaCteImporte"
        Me.nCtaCteImporte.Name = "nCtaCteImporte"
        Me.nCtaCteImporte.Visible = False
        '
        'nCtaCteImpAplicado
        '
        Me.nCtaCteImpAplicado.DataPropertyName = "nCtaCteImpAplicado"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N2"
        Me.nCtaCteImpAplicado.DefaultCellStyle = DataGridViewCellStyle10
        Me.nCtaCteImpAplicado.HeaderText = "nCtaCteImpAplicado"
        Me.nCtaCteImpAplicado.Name = "nCtaCteImpAplicado"
        Me.nCtaCteImpAplicado.Visible = False
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldrAdmSol
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink5, Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 31)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(546, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHldrAdmSol
        '
        Me.C1CmdHldrAdmSol.Commands.Add(Me.C1CmdNuevaSol)
        Me.C1CmdHldrAdmSol.Commands.Add(Me.C1CmdAtender)
        Me.C1CmdHldrAdmSol.Commands.Add(Me.C1CmdPrintDGV)
        Me.C1CmdHldrAdmSol.Commands.Add(Me.C1CmdPrintFichaInd)
        Me.C1CmdHldrAdmSol.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldrAdmSol.Owner = Me
        '
        'C1CmdNuevaSol
        '
        Me.C1CmdNuevaSol.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevaSol.Name = "C1CmdNuevaSol"
        Me.C1CmdNuevaSol.Text = "Nueva Solicitud"
        '
        'C1CmdAtender
        '
        Me.C1CmdAtender.Image = Global.Integration.Test.My.Resources.Resources.document_mark_as_final
        Me.C1CmdAtender.Name = "C1CmdAtender"
        '
        'C1CmdPrintDGV
        '
        Me.C1CmdPrintDGV.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.C1CmdPrintDGV.Name = "C1CmdPrintDGV"
        '
        'C1CmdPrintFichaInd
        '
        Me.C1CmdPrintFichaInd.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.C1CmdPrintFichaInd.Name = "C1CmdPrintFichaInd"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdNuevaSol
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdAtender
        Me.C1CommandLink1.SortOrder = 1
        Me.C1CommandLink1.Text = "Aprobar solicitud(es)"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdPrintDGV
        Me.C1CommandLink2.SortOrder = 2
        Me.C1CommandLink2.Text = "Lista Colegiados"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdPrintFichaInd
        Me.C1CommandLink3.SortOrder = 3
        Me.C1CommandLink3.Text = "Ficha Individual"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdCerrar
        Me.C1CommandLink4.SortOrder = 4
        Me.C1CommandLink4.Text = "Cerrar"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(840, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉     Atender solicitud Colegiatura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(219, 67)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(286, 20)
        Me.TxtDato.TabIndex = 9
        '
        'FormPrcAtenderSolicitudCole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 270)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrcAtenderSolicitudCole"
        Me.Text = "Atender solicitud Colegiatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldrAdmSol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents CboCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFecFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHldrAdmSol As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdAtender As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdPrintDGV As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdPrintFichaInd As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1CmdNuevaSol As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboTipoFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Private WithEvents nPerAdmEstado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents cPerJuridica As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nProCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nSolAdmNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dPerAdmRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nSolAdmFecSecuencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nPerTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerApellPaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerApellMaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerPriNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerSegNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cPerTerNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cIdNroColegiado As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteImpAplicado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
