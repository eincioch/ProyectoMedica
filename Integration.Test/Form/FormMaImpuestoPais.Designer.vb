<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaImpuestoPais
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaImpuestoPais))
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.c1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.c1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.C1CmdLinkGrabar = New C1.Win.C1Command.C1CommandLink()
        Me.TxtnIntClase = New System.Windows.Forms.TextBox()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nSysTasContry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSysTasCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSysTasFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSysTasDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSysTasNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fSysTasValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtTasaImp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpBxImp = New System.Windows.Forms.GroupBox()
        Me.CboPais = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox.SuspendLayout()
        Me.GrpBxImp.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.c1CmdNuevo)
        Me.C1CmdHldr.Commands.Add(Me.c1CmdGrabar)
        Me.C1CmdHldr.Commands.Add(Me.c1CmdCancel)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Owner = Me
        '
        'c1CmdNuevo
        '
        Me.c1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdNuevo.Name = "c1CmdNuevo"
        Me.c1CmdNuevo.Text = "&Nuevo"
        '
        'c1CmdGrabar
        '
        Me.c1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.c1CmdGrabar.Name = "c1CmdGrabar"
        Me.c1CmdGrabar.Text = "&Save"
        '
        'c1CmdCancel
        '
        Me.c1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.c1CmdCancel.Name = "c1CmdCancel"
        Me.c1CmdCancel.Text = "Cancel"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "&Modificar"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'TxtDesc
        '
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.Location = New System.Drawing.Point(97, 13)
        Me.TxtDesc.MaxLength = 250
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(316, 20)
        Me.TxtDesc.TabIndex = 1
        '
        'C1CmdLinkGrabar
        '
        Me.C1CmdLinkGrabar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkGrabar.Command = Me.c1CmdGrabar
        Me.C1CmdLinkGrabar.SortOrder = 1
        Me.C1CmdLinkGrabar.Text = "&Guardar"
        '
        'TxtnIntClase
        '
        Me.TxtnIntClase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtnIntClase.Location = New System.Drawing.Point(97, 37)
        Me.TxtnIntClase.MaxLength = 15
        Me.TxtnIntClase.Name = "TxtnIntClase"
        Me.TxtnIntClase.Size = New System.Drawing.Size(98, 20)
        Me.TxtnIntClase.TabIndex = 2
        Me.TxtnIntClase.Tag = ""
        '
        'C1CmdLinkNuevo
        '
        Me.C1CmdLinkNuevo.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkNuevo.Command = Me.c1CmdNuevo
        '
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.c1CmdCancel
        Me.C1CmdLinkCancel.SortOrder = 2
        Me.C1CmdLinkCancel.Text = "&Cancelar"
        '
        'C1CmdLinkEdit
        '
        Me.C1CmdLinkEdit.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkEdit.Command = Me.C1CmdEdit
        Me.C1CmdLinkEdit.SortOrder = 3
        Me.C1CmdLinkEdit.Text = "&Modificar"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 4
        Me.C1CmdLinkCerrar.Text = "&Cerrar"
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkNuevo, Me.C1CmdLinkGrabar, Me.C1CmdLinkCancel, Me.C1CmdLinkEdit, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 31)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(366, 24)
        Me.C1ToolBar.Text = "C1ToolBar1"
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Siglas:"
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nSysTasContry, Me.Country, Me.nSysTasCodigo, Me.nSysTasFecha, Me.cSysTasDescripcion, Me.cSysTasNombre, Me.fSysTasValor})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Location = New System.Drawing.Point(9, 194)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Table1.Size = New System.Drawing.Size(439, 215)
        Me.Table1.TabIndex = 21
        '
        'nSysTasContry
        '
        Me.nSysTasContry.DataPropertyName = "nSysTasContry"
        Me.nSysTasContry.HeaderText = "nSysTasContry"
        Me.nSysTasContry.Name = "nSysTasContry"
        Me.nSysTasContry.ReadOnly = True
        Me.nSysTasContry.Visible = False
        '
        'Country
        '
        Me.Country.DataPropertyName = "Country"
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        Me.Country.ReadOnly = True
        Me.Country.Width = 50
        '
        'nSysTasCodigo
        '
        Me.nSysTasCodigo.DataPropertyName = "nSysTasCodigo"
        Me.nSysTasCodigo.HeaderText = "nSysTasCodigo"
        Me.nSysTasCodigo.Name = "nSysTasCodigo"
        Me.nSysTasCodigo.ReadOnly = True
        Me.nSysTasCodigo.Visible = False
        '
        'nSysTasFecha
        '
        Me.nSysTasFecha.DataPropertyName = "nSysTasFecha"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Format = "d"
        Me.nSysTasFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.nSysTasFecha.HeaderText = "Fecha Efectiva"
        Me.nSysTasFecha.Name = "nSysTasFecha"
        Me.nSysTasFecha.ReadOnly = True
        Me.nSysTasFecha.Width = 70
        '
        'cSysTasDescripcion
        '
        Me.cSysTasDescripcion.DataPropertyName = "cSysTasDescripcion"
        Me.cSysTasDescripcion.HeaderText = "Descripcion"
        Me.cSysTasDescripcion.Name = "cSysTasDescripcion"
        Me.cSysTasDescripcion.ReadOnly = True
        Me.cSysTasDescripcion.Width = 220
        '
        'cSysTasNombre
        '
        Me.cSysTasNombre.DataPropertyName = "cSysTasNombre"
        Me.cSysTasNombre.HeaderText = "Siglas"
        Me.cSysTasNombre.Name = "cSysTasNombre"
        Me.cSysTasNombre.ReadOnly = True
        Me.cSysTasNombre.Width = 50
        '
        'fSysTasValor
        '
        Me.fSysTasValor.DataPropertyName = "fSysTasValor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.fSysTasValor.DefaultCellStyle = DataGridViewCellStyle3
        Me.fSysTasValor.HeaderText = "Tasa"
        Me.fSysTasValor.Name = "fSysTasValor"
        Me.fSysTasValor.ReadOnly = True
        Me.fSysTasValor.Width = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción:"
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.DtpFecha)
        Me.GrpBox.Controls.Add(Me.TxtDesc)
        Me.GrpBox.Controls.Add(Me.TxtTasaImp)
        Me.GrpBox.Controls.Add(Me.TxtnIntClase)
        Me.GrpBox.Controls.Add(Me.Label2)
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Location = New System.Drawing.Point(9, 99)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(439, 89)
        Me.GrpBox.TabIndex = 20
        Me.GrpBox.TabStop = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(97, 63)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(211, 20)
        Me.DtpFecha.TabIndex = 4
        '
        'TxtTasaImp
        '
        Me.TxtTasaImp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTasaImp.Location = New System.Drawing.Point(315, 37)
        Me.TxtTasaImp.MaxLength = 9
        Me.TxtTasaImp.Name = "TxtTasaImp"
        Me.TxtTasaImp.Size = New System.Drawing.Size(98, 20)
        Me.TxtTasaImp.TabIndex = 3
        Me.TxtTasaImp.Tag = ""
        Me.TxtTasaImp.Text = "0"
        Me.TxtTasaImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tasa Valor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha cambio:"
        '
        'GrpBxImp
        '
        Me.GrpBxImp.Controls.Add(Me.CboPais)
        Me.GrpBxImp.Controls.Add(Me.Label4)
        Me.GrpBxImp.Location = New System.Drawing.Point(9, 61)
        Me.GrpBxImp.Name = "GrpBxImp"
        Me.GrpBxImp.Size = New System.Drawing.Size(439, 45)
        Me.GrpBxImp.TabIndex = 4
        Me.GrpBxImp.TabStop = False
        Me.GrpBxImp.Text = " Seleccione... "
        '
        'CboPais
        '
        Me.CboPais.FormattingEnabled = True
        Me.CboPais.Location = New System.Drawing.Point(97, 19)
        Me.CboPais.Name = "CboPais"
        Me.CboPais.Size = New System.Drawing.Size(322, 21)
        Me.CboPais.TabIndex = 0
        Me.CboPais.Tag = "nIntClase=4010;nIntTipo=1000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "País:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(457, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "҉    Tipo de Impuestos aplicados a comprobante"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMaImpuestoPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 415)
        Me.Controls.Add(Me.GrpBxImp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GrpBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMaImpuestoPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impuesto Aplicado a Comprobantes"
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.GrpBxImp.ResumeLayout(False)
        Me.GrpBxImp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents TxtnIntClase As System.Windows.Forms.TextBox
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBxImp As System.Windows.Forms.GroupBox
    Friend WithEvents CboPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTasaImp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nSysTasContry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSysTasCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSysTasFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSysTasDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSysTasNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fSysTasValor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
