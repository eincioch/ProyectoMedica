<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCtaCteNumeracionC
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCtaCteNumeracionC))
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCajCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nComCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteNumIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCtaNumFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCorrFin = New System.Windows.Forms.TextBox()
        Me.TxtCorrActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCorrIni = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTDocu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.GrpBxKey = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboCaja = New System.Windows.Forms.ComboBox()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkGrabar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox.SuspendLayout()
        Me.GrpBxKey.SuspendLayout()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerJurCodigo, Me.Empresa, Me.nCajCodigo, Me.Caja, Me.nComCodigo, Me.cIntDescripcion, Me.nCtaCteNumero, Me.cCtaCteSerie, Me.nCtaCteNumIni, Me.nCtaCtaNumFin})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Table1.Location = New System.Drawing.Point(6, 152)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Table1.Size = New System.Drawing.Size(618, 287)
        Me.Table1.TabIndex = 18
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerJurCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.ReadOnly = True
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 60
        '
        'Empresa
        '
        Me.Empresa.DataPropertyName = "Empresa"
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Visible = False
        '
        'nCajCodigo
        '
        Me.nCajCodigo.DataPropertyName = "nCajCodigo"
        Me.nCajCodigo.HeaderText = "nCajCodigo"
        Me.nCajCodigo.Name = "nCajCodigo"
        Me.nCajCodigo.ReadOnly = True
        Me.nCajCodigo.Visible = False
        '
        'Caja
        '
        Me.Caja.DataPropertyName = "Caja"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Caja.DefaultCellStyle = DataGridViewCellStyle3
        Me.Caja.HeaderText = "Caja Nro."
        Me.Caja.Name = "Caja"
        Me.Caja.Width = 70
        '
        'nComCodigo
        '
        Me.nComCodigo.DataPropertyName = "nComCodigo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nComCodigo.DefaultCellStyle = DataGridViewCellStyle4
        Me.nComCodigo.HeaderText = "nComCodigo"
        Me.nComCodigo.Name = "nComCodigo"
        Me.nComCodigo.ReadOnly = True
        Me.nComCodigo.Visible = False
        Me.nComCodigo.Width = 80
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.cIntDescripcion.DefaultCellStyle = DataGridViewCellStyle5
        Me.cIntDescripcion.HeaderText = "Tipo Documento"
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.Width = 180
        '
        'nCtaCteNumero
        '
        Me.nCtaCteNumero.DataPropertyName = "nCtaCteNumero"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nCtaCteNumero.DefaultCellStyle = DataGridViewCellStyle6
        Me.nCtaCteNumero.HeaderText = "Correlativo actual"
        Me.nCtaCteNumero.Name = "nCtaCteNumero"
        Me.nCtaCteNumero.Width = 90
        '
        'cCtaCteSerie
        '
        Me.cCtaCteSerie.DataPropertyName = "cCtaCteSerie"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteSerie.DefaultCellStyle = DataGridViewCellStyle7
        Me.cCtaCteSerie.HeaderText = "Serie"
        Me.cCtaCteSerie.Name = "cCtaCteSerie"
        Me.cCtaCteSerie.Width = 60
        '
        'nCtaCteNumIni
        '
        Me.nCtaCteNumIni.DataPropertyName = "nCtaCteNumIni"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.nCtaCteNumIni.DefaultCellStyle = DataGridViewCellStyle8
        Me.nCtaCteNumIni.HeaderText = "Correlativo inicial"
        Me.nCtaCteNumIni.Name = "nCtaCteNumIni"
        Me.nCtaCteNumIni.Width = 90
        '
        'nCtaCtaNumFin
        '
        Me.nCtaCtaNumFin.DataPropertyName = "nCtaCtaNumFin"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nCtaCtaNumFin.DefaultCellStyle = DataGridViewCellStyle9
        Me.nCtaCtaNumFin.HeaderText = "Ultimo correlativo"
        Me.nCtaCtaNumFin.Name = "nCtaCtaNumFin"
        Me.nCtaCtaNumFin.Width = 90
        '
        'TxtCorrFin
        '
        Me.TxtCorrFin.Location = New System.Drawing.Point(362, 67)
        Me.TxtCorrFin.MaxLength = 8
        Me.TxtCorrFin.Name = "TxtCorrFin"
        Me.TxtCorrFin.Size = New System.Drawing.Size(126, 20)
        Me.TxtCorrFin.TabIndex = 6
        '
        'TxtCorrActual
        '
        Me.TxtCorrActual.Location = New System.Drawing.Point(362, 45)
        Me.TxtCorrActual.MaxLength = 8
        Me.TxtCorrActual.Name = "TxtCorrActual"
        Me.TxtCorrActual.Size = New System.Drawing.Size(126, 20)
        Me.TxtCorrActual.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Correlativo actual:"
        '
        'TxtCorrIni
        '
        Me.TxtCorrIni.Location = New System.Drawing.Point(109, 67)
        Me.TxtCorrIni.MaxLength = 8
        Me.TxtCorrIni.Name = "TxtCorrIni"
        Me.TxtCorrIni.Size = New System.Drawing.Size(126, 20)
        Me.TxtCorrIni.TabIndex = 5
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(109, 45)
        Me.TxtSerie.MaxLength = 4
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(62, 20)
        Me.TxtSerie.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Correlativo Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Serie:"
        '
        'CboTDocu
        '
        Me.CboTDocu.BackColor = System.Drawing.SystemColors.Info
        Me.CboTDocu.FormattingEnabled = True
        Me.CboTDocu.Location = New System.Drawing.Point(356, 13)
        Me.CboTDocu.Name = "CboTDocu"
        Me.CboTDocu.Size = New System.Drawing.Size(229, 21)
        Me.CboTDocu.TabIndex = 2
        Me.CboTDocu.Tag = "nIntClase=7004;nIntTipo=1000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Correlativo Inicial:"
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.GrpBxKey)
        Me.GrpBox.Controls.Add(Me.Label4)
        Me.GrpBox.Controls.Add(Me.TxtCorrFin)
        Me.GrpBox.Controls.Add(Me.TxtCorrActual)
        Me.GrpBox.Controls.Add(Me.TxtCorrIni)
        Me.GrpBox.Controls.Add(Me.TxtSerie)
        Me.GrpBox.Controls.Add(Me.Label6)
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Location = New System.Drawing.Point(6, 59)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(618, 92)
        Me.GrpBox.TabIndex = 17
        Me.GrpBox.TabStop = False
        '
        'GrpBxKey
        '
        Me.GrpBxKey.Controls.Add(Me.CboTDocu)
        Me.GrpBxKey.Controls.Add(Me.Label1)
        Me.GrpBxKey.Controls.Add(Me.Label2)
        Me.GrpBxKey.Controls.Add(Me.CboCaja)
        Me.GrpBxKey.Location = New System.Drawing.Point(6, 0)
        Me.GrpBxKey.Name = "GrpBxKey"
        Me.GrpBxKey.Size = New System.Drawing.Size(595, 39)
        Me.GrpBxKey.TabIndex = 7
        Me.GrpBxKey.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desc. Caja:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo documento:"
        '
        'CboCaja
        '
        Me.CboCaja.BackColor = System.Drawing.SystemColors.Info
        Me.CboCaja.FormattingEnabled = True
        Me.CboCaja.Location = New System.Drawing.Point(103, 14)
        Me.CboCaja.Name = "CboCaja"
        Me.CboCaja.Size = New System.Drawing.Size(129, 21)
        Me.CboCaja.TabIndex = 1
        Me.CboCaja.Tag = "1069"
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
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "Guardar"
        '
        'C1CmdCancel
        '
        Me.C1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancel.Name = "C1CmdCancel"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        '
        'C1ToolBar
        '
        Me.C1ToolBar.AccessibleName = "Tool Bar"
        Me.C1ToolBar.CommandHolder = Nothing
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkNuevo, Me.C1CmdLinkGrabar, Me.C1CmdLinkCancel, Me.C1CmdLinkEdit, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(12, 31)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(366, 24)
        Me.C1ToolBar.Text = "C1ToolBar1"
        Me.C1ToolBar.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdLinkNuevo
        '
        Me.C1CmdLinkNuevo.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkNuevo.Command = Me.C1CmdNuevo
        Me.C1CmdLinkNuevo.Text = "&Nuevo"
        '
        'C1CmdLinkGrabar
        '
        Me.C1CmdLinkGrabar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkGrabar.Command = Me.C1CmdGrabar
        Me.C1CmdLinkGrabar.SortOrder = 1
        Me.C1CmdLinkGrabar.Text = "&Guardar"
        '
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.C1CmdCancel
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
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(629, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "҉    Cajas, serie y correlativo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCtaCteNumeracionC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 448)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GrpBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCtaCteNumeracionC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja y Numeración"
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.GrpBxKey.ResumeLayout(False)
        Me.GrpBxKey.PerformLayout()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCorrFin As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorrActual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCorrIni As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboTDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents CboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents GrpBxKey As System.Windows.Forms.GroupBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCajCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nComCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cCtaCteSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCteNumIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nCtaCtaNumFin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
