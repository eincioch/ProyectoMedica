<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGridAfiliacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGridAfiliacion))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.CboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dDocFecRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nropoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nDocTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodColegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Titular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tDocConContenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroBeneficiarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHldrAfiliacion = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdPrint = New C1.Win.C1Command.C1Command()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdBuscar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldrAfiliacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.CboTipoPer)
        Me.GroupBox.Controls.Add(Me.TxtBuscar)
        Me.GroupBox.Controls.Add(Me.CboFiltro)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(631, 45)
        Me.GroupBox.TabIndex = 19
        Me.GroupBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nro.:"
        '
        'CboTipoPer
        '
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboTipoPer.Enabled = False
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(256, 15)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(164, 21)
        Me.CboTipoPer.TabIndex = 2
        Me.CboTipoPer.Tag = "1010"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(471, 16)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(142, 20)
        Me.TxtBuscar.TabIndex = 0
        '
        'CboFiltro
        '
        Me.CboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltro.FormattingEnabled = True
        Me.CboFiltro.Items.AddRange(New Object() {"Codigo Colegiado", "D.N.I."})
        Me.CboFiltro.Location = New System.Drawing.Point(35, 15)
        Me.CboFiltro.Name = "CboFiltro"
        Me.CboFiltro.Size = New System.Drawing.Size(137, 21)
        Me.CboFiltro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 19)
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nEstado, Me.cDocCodigo, Me.dDocFecRegistro, Me.nropoliza, Me.nDocTipo, Me.cDocTipo, Me.CodColegio, Me.dni, Me.Titular, Me.dFechaFin, Me.tDocConContenido, Me.NroBeneficiarios})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Table1.Location = New System.Drawing.Point(12, 112)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Table1.Size = New System.Drawing.Size(774, 125)
        Me.Table1.TabIndex = 18
        '
        'nEstado
        '
        Me.nEstado.DataPropertyName = "nEstado"
        Me.nEstado.HeaderText = "nEstado"
        Me.nEstado.Name = "nEstado"
        Me.nEstado.ReadOnly = True
        Me.nEstado.Visible = False
        '
        'cDocCodigo
        '
        Me.cDocCodigo.DataPropertyName = "cDocCodigo"
        Me.cDocCodigo.HeaderText = "cDocCodigo"
        Me.cDocCodigo.Name = "cDocCodigo"
        Me.cDocCodigo.ReadOnly = True
        Me.cDocCodigo.Visible = False
        '
        'dDocFecRegistro
        '
        Me.dDocFecRegistro.DataPropertyName = "dDocFecRegistro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Format = "d"
        Me.dDocFecRegistro.DefaultCellStyle = DataGridViewCellStyle2
        Me.dDocFecRegistro.HeaderText = "Fecha registro"
        Me.dDocFecRegistro.Name = "dDocFecRegistro"
        Me.dDocFecRegistro.ReadOnly = True
        Me.dDocFecRegistro.Width = 80
        '
        'nropoliza
        '
        Me.nropoliza.DataPropertyName = "nropoliza"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nropoliza.DefaultCellStyle = DataGridViewCellStyle3
        Me.nropoliza.HeaderText = "Nro. POLIZA"
        Me.nropoliza.Name = "nropoliza"
        Me.nropoliza.ReadOnly = True
        Me.nropoliza.Width = 90
        '
        'nDocTipo
        '
        Me.nDocTipo.DataPropertyName = "nDocTipo"
        Me.nDocTipo.HeaderText = "nDocTipo"
        Me.nDocTipo.Name = "nDocTipo"
        Me.nDocTipo.ReadOnly = True
        Me.nDocTipo.Visible = False
        '
        'cDocTipo
        '
        Me.cDocTipo.DataPropertyName = "cDocTipo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.cDocTipo.DefaultCellStyle = DataGridViewCellStyle4
        Me.cDocTipo.HeaderText = "Tipo documento"
        Me.cDocTipo.Name = "cDocTipo"
        Me.cDocTipo.ReadOnly = True
        Me.cDocTipo.Width = 140
        '
        'CodColegio
        '
        Me.CodColegio.DataPropertyName = "CodColegio"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.CodColegio.DefaultCellStyle = DataGridViewCellStyle5
        Me.CodColegio.HeaderText = "Código CCP"
        Me.CodColegio.Name = "CodColegio"
        Me.CodColegio.ReadOnly = True
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.dni.DefaultCellStyle = DataGridViewCellStyle6
        Me.dni.HeaderText = "D.N.I"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.Width = 90
        '
        'Titular
        '
        Me.Titular.DataPropertyName = "Titular"
        Me.Titular.HeaderText = "Titular"
        Me.Titular.Name = "Titular"
        Me.Titular.ReadOnly = True
        Me.Titular.Width = 260
        '
        'dFechaFin
        '
        Me.dFechaFin.DataPropertyName = "dFechaFin"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.Format = "d"
        Me.dFechaFin.DefaultCellStyle = DataGridViewCellStyle7
        Me.dFechaFin.HeaderText = "Fecha Termino"
        Me.dFechaFin.Name = "dFechaFin"
        Me.dFechaFin.ReadOnly = True
        Me.dFechaFin.Width = 80
        '
        'tDocConContenido
        '
        Me.tDocConContenido.DataPropertyName = "tDocConContenido"
        Me.tDocConContenido.HeaderText = "Observaciones"
        Me.tDocConContenido.Name = "tDocConContenido"
        Me.tDocConContenido.ReadOnly = True
        Me.tDocConContenido.Width = 200
        '
        'NroBeneficiarios
        '
        Me.NroBeneficiarios.DataPropertyName = "NroBeneficiarios"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.NroBeneficiarios.DefaultCellStyle = DataGridViewCellStyle8
        Me.NroBeneficiarios.HeaderText = "Nro. de Beneficiarios"
        Me.NroBeneficiarios.Name = "NroBeneficiarios"
        Me.NroBeneficiarios.ReadOnly = True
        Me.NroBeneficiarios.Width = 90
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldrAfiliacion
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink6, Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(12, 29)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(465, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHldrAfiliacion
        '
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdPrint)
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdNuevo)
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdBuscar)
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdCancelar)
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldrAfiliacion.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldrAfiliacion.Owner = Me
        '
        'C1CmdPrint
        '
        Me.C1CmdPrint.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.C1CmdPrint.Name = "C1CmdPrint"
        Me.C1CmdPrint.Text = "Imprimir"
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "Nuevo"
        '
        'C1CmdBuscar
        '
        Me.C1CmdBuscar.Image = Global.Integration.Test.My.Resources.Resources.find
        Me.C1CmdBuscar.Name = "C1CmdBuscar"
        '
        'C1CmdCancelar
        '
        Me.C1CmdCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancelar.Name = "C1CmdCancelar"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "Modificar"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.C1CmdPrint
        Me.C1CommandLink6.Text = "Imprimir Ficha"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdBuscar
        Me.C1CommandLink1.SortOrder = 1
        Me.C1CommandLink1.Text = "Buscar"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdNuevo
        Me.C1CommandLink2.SortOrder = 2
        Me.C1CommandLink2.Text = "Nuevo"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancelar
        Me.C1CommandLink3.SortOrder = 3
        Me.C1CommandLink3.Text = "Cancelar"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 4
        Me.C1CommandLink4.Text = "Modificar"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 5
        Me.C1CommandLink5.Text = "Cerrar"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(793, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉    Afiliación Seguro Mutual - Colegiados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormGridAfiliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 244)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Table1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGridAfiliacion"
        Me.Text = "Afiliacion Seguro Mutual"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldrAfiliacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CboFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHldrAfiliacion As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdBuscar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1CmdPrint As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents nEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cDocCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dDocFecRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nropoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nDocTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cDocTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents CodColegio As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Titular As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tDocConContenido As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents NroBeneficiarios As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
