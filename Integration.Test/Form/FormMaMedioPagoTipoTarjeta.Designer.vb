<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaMedioPagoTipoTarjeta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaMedioPagoTipoTarjeta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboBanco = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboTipoTarjeta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtSiglas = New System.Windows.Forms.TextBox()
        Me.BtnAgregarUNI = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerIntClase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerIntJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerIntTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entidad bancaria:"
        '
        'CboBanco
        '
        Me.CboBanco.FormattingEnabled = True
        Me.CboBanco.Location = New System.Drawing.Point(102, 13)
        Me.CboBanco.Name = "CboBanco"
        Me.CboBanco.Size = New System.Drawing.Size(371, 21)
        Me.CboBanco.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de Tarjeta:"
        '
        'CboTipoTarjeta
        '
        Me.CboTipoTarjeta.FormattingEnabled = True
        Me.CboTipoTarjeta.Location = New System.Drawing.Point(102, 40)
        Me.CboTipoTarjeta.Name = "CboTipoTarjeta"
        Me.CboTipoTarjeta.Size = New System.Drawing.Size(194, 21)
        Me.CboTipoTarjeta.TabIndex = 1
        Me.CboTipoTarjeta.Tag = "nIntClase=1023;nIntTipo=1000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Siglas Entidad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDesc)
        Me.GroupBox1.Controls.Add(Me.TxtSiglas)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarUNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboBanco)
        Me.GroupBox1.Controls.Add(Me.CboTipoTarjeta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 127)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TxtDesc
        '
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.Location = New System.Drawing.Point(102, 92)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(370, 20)
        Me.TxtDesc.TabIndex = 32
        '
        'TxtSiglas
        '
        Me.TxtSiglas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSiglas.Location = New System.Drawing.Point(103, 66)
        Me.TxtSiglas.Name = "TxtSiglas"
        Me.TxtSiglas.Size = New System.Drawing.Size(95, 20)
        Me.TxtSiglas.TabIndex = 31
        '
        'BtnAgregarUNI
        '
        Me.BtnAgregarUNI.Image = Global.Integration.Test.My.Resources.Resources.house
        Me.BtnAgregarUNI.Location = New System.Drawing.Point(474, 12)
        Me.BtnAgregarUNI.Name = "BtnAgregarUNI"
        Me.BtnAgregarUNI.Size = New System.Drawing.Size(30, 21)
        Me.BtnAgregarUNI.TabIndex = 30
        Me.BtnAgregarUNI.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(204, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 9)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ejemplo: Banco de Crédito - Siglas: BCP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(535, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉    Medio de Pago - Tipo de Tarjetas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.Border.DarkColor = System.Drawing.SystemColors.ControlLight
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldr
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 31)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(366, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.C1CmdNuevo)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdGrabar)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCancel)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Owner = Me
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "Nuevo"
        Me.C1CmdNuevo.ToolTipText = "Agrega nuevo registro a la base datos."
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "&Guardar"
        '
        'C1CmdCancel
        '
        Me.C1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancel.Name = "C1CmdCancel"
        Me.C1CmdCancel.Text = "Cancelar"
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
        Me.C1CmdCerrar.Text = "Cerrar"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdNuevo
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGrabar
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancel
        Me.C1CommandLink3.SortOrder = 2
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 3
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 4
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerCodigo, Me.cPerApellido, Me.nPerIntCodigo, Me.cIntDescripcion, Me.nPerIntClase, Me.cPerIntJerarquia, Me.cPerIntDescripcion, Me.nPerIntTipo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Table1.Location = New System.Drawing.Point(9, 190)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Table1.Size = New System.Drawing.Size(516, 280)
        Me.Table1.TabIndex = 19
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        Me.cPerCodigo.HeaderText = "cPerCodigo"
        Me.cPerCodigo.Name = "cPerCodigo"
        Me.cPerCodigo.ReadOnly = True
        Me.cPerCodigo.Visible = False
        '
        'cPerApellido
        '
        Me.cPerApellido.DataPropertyName = "cPerApellido"
        Me.cPerApellido.HeaderText = "Entidad bancaria"
        Me.cPerApellido.Name = "cPerApellido"
        Me.cPerApellido.ReadOnly = True
        Me.cPerApellido.Width = 230
        '
        'nPerIntCodigo
        '
        Me.nPerIntCodigo.DataPropertyName = "nPerIntCodigo"
        Me.nPerIntCodigo.HeaderText = "nPerIntCodigo"
        Me.nPerIntCodigo.Name = "nPerIntCodigo"
        Me.nPerIntCodigo.ReadOnly = True
        Me.nPerIntCodigo.Visible = False
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        Me.cIntDescripcion.HeaderText = "Tipo Tarjeta"
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.ReadOnly = True
        Me.cIntDescripcion.Width = 110
        '
        'nPerIntClase
        '
        Me.nPerIntClase.DataPropertyName = "nPerIntClase"
        Me.nPerIntClase.HeaderText = "nPerIntClase"
        Me.nPerIntClase.Name = "nPerIntClase"
        Me.nPerIntClase.ReadOnly = True
        Me.nPerIntClase.Visible = False
        '
        'cPerIntJerarquia
        '
        Me.cPerIntJerarquia.DataPropertyName = "cPerIntJerarquia"
        Me.cPerIntJerarquia.HeaderText = "cPerIntJerarquia"
        Me.cPerIntJerarquia.Name = "cPerIntJerarquia"
        Me.cPerIntJerarquia.ReadOnly = True
        Me.cPerIntJerarquia.Visible = False
        '
        'cPerIntDescripcion
        '
        Me.cPerIntDescripcion.DataPropertyName = "cPerIntDescripcion"
        Me.cPerIntDescripcion.HeaderText = "Descripción"
        Me.cPerIntDescripcion.Name = "cPerIntDescripcion"
        Me.cPerIntDescripcion.ReadOnly = True
        Me.cPerIntDescripcion.Width = 190
        '
        'nPerIntTipo
        '
        Me.nPerIntTipo.HeaderText = "nPerIntTipo"
        Me.nPerIntTipo.Name = "nPerIntTipo"
        Me.nPerIntTipo.ReadOnly = True
        Me.nPerIntTipo.Visible = False
        '
        'FormMaMedioPagoTipoTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 482)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMaMedioPagoTipoTarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medio de Pago - Tipo de Tarjetas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboTipoTarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarUNI As System.Windows.Forms.Button
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents TxtSiglas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerIntClase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerIntJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPerIntTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
