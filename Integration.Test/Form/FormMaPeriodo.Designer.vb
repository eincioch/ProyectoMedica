<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaPeriodo
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaPeriodo))
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.DtpAnno = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nprdcodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprddescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nprdactividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dprdini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dprdfin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nprdtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nprdestado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CntxtMnuStrpPrd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TlStrpMnuItemPrdDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdCrearPrd = New C1.Win.C1Command.C1Command()
        Me.C1CmdMostrarPrd = New C1.Win.C1Command.C1Command()
        Me.C1CmdUpdEstado = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.GrpBox.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntxtMnuStrpPrd.SuspendLayout()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.DtpAnno)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Location = New System.Drawing.Point(420, 20)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(103, 35)
        Me.GrpBox.TabIndex = 0
        Me.GrpBox.TabStop = False
        '
        'DtpAnno
        '
        Me.DtpAnno.CustomFormat = "yyyy"
        Me.DtpAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAnno.Location = New System.Drawing.Point(41, 10)
        Me.DtpAnno.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.DtpAnno.Name = "DtpAnno"
        Me.DtpAnno.ShowUpDown = True
        Me.DtpAnno.Size = New System.Drawing.Size(62, 22)
        Me.DtpAnno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nprdcodigo, Me.cprddescripcion, Me.nprdactividad, Me.dprdini, Me.dprdfin, Me.nprdtipo, Me.nprdestado})
        Me.Table1.ContextMenuStrip = Me.CntxtMnuStrpPrd
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Location = New System.Drawing.Point(5, 58)
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
        Me.Table1.Size = New System.Drawing.Size(520, 369)
        Me.Table1.TabIndex = 15
        '
        'nprdcodigo
        '
        Me.nprdcodigo.DataPropertyName = "nprdcodigo"
        Me.nprdcodigo.HeaderText = "nprdcodigo"
        Me.nprdcodigo.Name = "nprdcodigo"
        Me.nprdcodigo.ReadOnly = True
        Me.nprdcodigo.Visible = False
        '
        'cprddescripcion
        '
        Me.cprddescripcion.DataPropertyName = "cprddescripcion"
        Me.cprddescripcion.HeaderText = "Descripción"
        Me.cprddescripcion.Name = "cprddescripcion"
        Me.cprddescripcion.ReadOnly = True
        Me.cprddescripcion.Width = 110
        '
        'nprdactividad
        '
        Me.nprdactividad.DataPropertyName = "nprdactividad"
        Me.nprdactividad.HeaderText = "nprdactividad"
        Me.nprdactividad.Name = "nprdactividad"
        Me.nprdactividad.ReadOnly = True
        Me.nprdactividad.Visible = False
        '
        'dprdini
        '
        Me.dprdini.DataPropertyName = "dprdini"
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dprdini.DefaultCellStyle = DataGridViewCellStyle2
        Me.dprdini.HeaderText = "Fecha Inicio"
        Me.dprdini.Name = "dprdini"
        Me.dprdini.ReadOnly = True
        Me.dprdini.Width = 150
        '
        'dprdfin
        '
        Me.dprdfin.DataPropertyName = "dprdfin"
        DataGridViewCellStyle3.Format = "G"
        Me.dprdfin.DefaultCellStyle = DataGridViewCellStyle3
        Me.dprdfin.HeaderText = "Fecha Final"
        Me.dprdfin.Name = "dprdfin"
        Me.dprdfin.ReadOnly = True
        Me.dprdfin.Width = 150
        '
        'nprdtipo
        '
        Me.nprdtipo.DataPropertyName = "nprdtipo"
        Me.nprdtipo.HeaderText = "nprdtipo"
        Me.nprdtipo.Name = "nprdtipo"
        Me.nprdtipo.ReadOnly = True
        Me.nprdtipo.Visible = False
        '
        'nprdestado
        '
        Me.nprdestado.DataPropertyName = "nprdestado"
        Me.nprdestado.HeaderText = "Estado"
        Me.nprdestado.Name = "nprdestado"
        Me.nprdestado.ReadOnly = True
        Me.nprdestado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nprdestado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nprdestado.ToolTipText = "1073"
        '
        'CntxtMnuStrpPrd
        '
        Me.CntxtMnuStrpPrd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnuItemPrdDefault})
        Me.CntxtMnuStrpPrd.Name = "CntxtMnuStrpPrd"
        Me.CntxtMnuStrpPrd.Size = New System.Drawing.Size(250, 26)
        '
        'TlStrpMnuItemPrdDefault
        '
        Me.TlStrpMnuItemPrdDefault.Image = Global.Integration.Test.My.Resources.Resources.sallary_deferrais
        Me.TlStrpMnuItemPrdDefault.Name = "TlStrpMnuItemPrdDefault"
        Me.TlStrpMnuItemPrdDefault.Size = New System.Drawing.Size(249, 22)
        Me.TlStrpMnuItemPrdDefault.Text = "Establecer como predeterminado"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(530, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉    Periodo Contable [estado]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldr
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 31)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(406, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCrearPrd)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdMostrarPrd)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdUpdEstado)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Owner = Me
        '
        'C1CmdCrearPrd
        '
        Me.C1CmdCrearPrd.Image = Global.Integration.Test.My.Resources.Resources.calendar_add
        Me.C1CmdCrearPrd.Name = "C1CmdCrearPrd"
        Me.C1CmdCrearPrd.Text = "Crear Periodo"
        '
        'C1CmdMostrarPrd
        '
        Me.C1CmdMostrarPrd.Image = Global.Integration.Test.My.Resources.Resources.zoom_refresh
        Me.C1CmdMostrarPrd.Name = "C1CmdMostrarPrd"
        Me.C1CmdMostrarPrd.Text = "Mostrar Periodo"
        '
        'C1CmdUpdEstado
        '
        Me.C1CmdUpdEstado.Image = Global.Integration.Test.My.Resources.Resources.update
        Me.C1CmdUpdEstado.Name = "C1CmdUpdEstado"
        Me.C1CmdUpdEstado.Text = "Actualizar Estado"
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
        Me.C1CommandLink1.Command = Me.C1CmdCrearPrd
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdMostrarPrd
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdUpdEstado
        Me.C1CommandLink3.SortOrder = 2
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdCerrar
        Me.C1CommandLink4.SortOrder = 3
        '
        'FormMaPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 432)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GrpBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMaPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo Contable"
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntxtMnuStrpPrd.ResumeLayout(False)
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents DtpAnno As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdCrearPrd As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdMostrarPrd As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdUpdEstado As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents CntxtMnuStrpPrd As System.Windows.Forms.ContextMenuStrip
    Private WithEvents TlStrpMnuItemPrdDefault As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents nprdcodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cprddescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nprdactividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dprdini As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dprdfin As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nprdtipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nprdestado As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
