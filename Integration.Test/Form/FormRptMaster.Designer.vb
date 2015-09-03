<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptMaster
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Por Comprobante - Resumido")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Por Comprobante - Detallado")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Por Formas de Pago")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuadre de Caja", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingresos por Servicios")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Ingresos Percibidos - Detallado")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servicios", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Estado Cuenta por Couta Ordinaria")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listado Colegiado(s) Habiles por Cuota Ordinaria")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estado Cuenta ", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listado de Reportes...", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7, TreeNode10})
        Me.Split1 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Split2 = New System.Windows.Forms.SplitContainer()
        Me.TreeViewList = New System.Windows.Forms.TreeView()
        Me.Split3 = New System.Windows.Forms.SplitContainer()
        Me.PanelRangoFechas = New System.Windows.Forms.Panel()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.GrpBxEstadoCta = New System.Windows.Forms.GroupBox()
        Me.DtpFecCorte = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMostarEstado = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboServicios = New System.Windows.Forms.ComboBox()
        Me.TxtNroPer = New System.Windows.Forms.TextBox()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblcNomRepre = New System.Windows.Forms.Label()
        Me.LblcPerCodPer = New System.Windows.Forms.Label()
        Me.GrpBxRangoFec = New System.Windows.Forms.GroupBox()
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.DtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalRptVwr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.Split1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Split1.Panel1.SuspendLayout()
        Me.Split1.Panel2.SuspendLayout()
        Me.Split1.SuspendLayout()
        CType(Me.Split2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Split2.Panel1.SuspendLayout()
        Me.Split2.Panel2.SuspendLayout()
        Me.Split2.SuspendLayout()
        CType(Me.Split3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Split3.Panel1.SuspendLayout()
        Me.Split3.Panel2.SuspendLayout()
        Me.Split3.SuspendLayout()
        Me.PanelRangoFechas.SuspendLayout()
        Me.GrpBxEstadoCta.SuspendLayout()
        Me.GrpBxRangoFec.SuspendLayout()
        Me.SuspendLayout()
        '
        'Split1
        '
        Me.Split1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Split1.Location = New System.Drawing.Point(0, 0)
        Me.Split1.Name = "Split1"
        Me.Split1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Split1.Panel1
        '
        Me.Split1.Panel1.Controls.Add(Me.Label6)
        '
        'Split1.Panel2
        '
        Me.Split1.Panel2.Controls.Add(Me.Split2)
        Me.Split1.Size = New System.Drawing.Size(1013, 535)
        Me.Split1.SplitterDistance = 30
        Me.Split1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1013, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "҉     Reportes Generales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Split2
        '
        Me.Split2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Split2.Location = New System.Drawing.Point(0, 0)
        Me.Split2.Name = "Split2"
        '
        'Split2.Panel1
        '
        Me.Split2.Panel1.Controls.Add(Me.TreeViewList)
        '
        'Split2.Panel2
        '
        Me.Split2.Panel2.Controls.Add(Me.Split3)
        Me.Split2.Size = New System.Drawing.Size(1013, 501)
        Me.Split2.SplitterDistance = 249
        Me.Split2.TabIndex = 0
        '
        'TreeViewList
        '
        Me.TreeViewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewList.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewList.Name = "TreeViewList"
        TreeNode1.Name = "Nodo2"
        TreeNode1.Text = "Por Comprobante - Resumido"
        TreeNode2.Name = "Nodo3"
        TreeNode2.Text = "Por Comprobante - Detallado"
        TreeNode3.Name = "Nodo4"
        TreeNode3.Text = "Por Formas de Pago"
        TreeNode4.Name = "Nodo1"
        TreeNode4.Text = "Cuadre de Caja"
        TreeNode5.Name = "Nodo6"
        TreeNode5.Text = "Ingresos por Servicios"
        TreeNode6.Name = "Nodo7"
        TreeNode6.Text = "Informe Ingresos Percibidos - Detallado"
        TreeNode7.Name = "Nodo5"
        TreeNode7.Text = "Servicios"
        TreeNode8.Name = "Nodo9"
        TreeNode8.Text = "Informe Estado Cuenta por Couta Ordinaria"
        TreeNode9.Name = "Nodo10"
        TreeNode9.Text = "Listado Colegiado(s) Habiles por Cuota Ordinaria"
        TreeNode10.Name = "Nodo8"
        TreeNode10.Text = "Estado Cuenta "
        TreeNode11.Name = "Nodo0"
        TreeNode11.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode11.Text = "Listado de Reportes..."
        Me.TreeViewList.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11})
        Me.TreeViewList.Size = New System.Drawing.Size(249, 501)
        Me.TreeViewList.TabIndex = 0
        '
        'Split3
        '
        Me.Split3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Split3.Location = New System.Drawing.Point(0, 0)
        Me.Split3.Name = "Split3"
        Me.Split3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Split3.Panel1
        '
        Me.Split3.Panel1.Controls.Add(Me.PanelRangoFechas)
        '
        'Split3.Panel2
        '
        Me.Split3.Panel2.Controls.Add(Me.CrystalRptVwr)
        Me.Split3.Size = New System.Drawing.Size(760, 501)
        Me.Split3.SplitterDistance = 123
        Me.Split3.TabIndex = 0
        '
        'PanelRangoFechas
        '
        Me.PanelRangoFechas.Controls.Add(Me.LblMsg)
        Me.PanelRangoFechas.Controls.Add(Me.GrpBxEstadoCta)
        Me.PanelRangoFechas.Controls.Add(Me.GrpBxRangoFec)
        Me.PanelRangoFechas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRangoFechas.Location = New System.Drawing.Point(0, 0)
        Me.PanelRangoFechas.Name = "PanelRangoFechas"
        Me.PanelRangoFechas.Size = New System.Drawing.Size(760, 123)
        Me.PanelRangoFechas.TabIndex = 0
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblMsg.Location = New System.Drawing.Point(10, 8)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(10, 13)
        Me.LblMsg.TabIndex = 32
        Me.LblMsg.Text = "."
        '
        'GrpBxEstadoCta
        '
        Me.GrpBxEstadoCta.Controls.Add(Me.DtpFecCorte)
        Me.GrpBxEstadoCta.Controls.Add(Me.Label3)
        Me.GrpBxEstadoCta.Controls.Add(Me.BtnMostarEstado)
        Me.GrpBxEstadoCta.Controls.Add(Me.Label7)
        Me.GrpBxEstadoCta.Controls.Add(Me.Label5)
        Me.GrpBxEstadoCta.Controls.Add(Me.CboServicios)
        Me.GrpBxEstadoCta.Controls.Add(Me.TxtNroPer)
        Me.GrpBxEstadoCta.Controls.Add(Me.CboTipoCta)
        Me.GrpBxEstadoCta.Controls.Add(Me.Label4)
        Me.GrpBxEstadoCta.Controls.Add(Me.LblcNomRepre)
        Me.GrpBxEstadoCta.Controls.Add(Me.LblcPerCodPer)
        Me.GrpBxEstadoCta.Location = New System.Drawing.Point(17, 12)
        Me.GrpBxEstadoCta.Name = "GrpBxEstadoCta"
        Me.GrpBxEstadoCta.Size = New System.Drawing.Size(712, 105)
        Me.GrpBxEstadoCta.TabIndex = 31
        Me.GrpBxEstadoCta.TabStop = False
        Me.GrpBxEstadoCta.Visible = False
        '
        'DtpFecCorte
        '
        Me.DtpFecCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecCorte.Location = New System.Drawing.Point(482, 23)
        Me.DtpFecCorte.Name = "DtpFecCorte"
        Me.DtpFecCorte.Size = New System.Drawing.Size(105, 20)
        Me.DtpFecCorte.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo Colegiado:"
        '
        'BtnMostarEstado
        '
        Me.BtnMostarEstado.Location = New System.Drawing.Point(593, 59)
        Me.BtnMostarEstado.Name = "BtnMostarEstado"
        Me.BtnMostarEstado.Size = New System.Drawing.Size(114, 28)
        Me.BtnMostarEstado.TabIndex = 30
        Me.BtnMostarEstado.Text = " &Mostrar"
        Me.BtnMostarEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha de Corte:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Servicio:"
        '
        'CboServicios
        '
        Me.CboServicios.FormattingEnabled = True
        Me.CboServicios.Location = New System.Drawing.Point(307, 69)
        Me.CboServicios.Name = "CboServicios"
        Me.CboServicios.Size = New System.Drawing.Size(280, 21)
        Me.CboServicios.TabIndex = 29
        Me.CboServicios.Tag = "nConCodigo=1133"
        '
        'TxtNroPer
        '
        Me.TxtNroPer.Location = New System.Drawing.Point(108, 23)
        Me.TxtNroPer.Name = "TxtNroPer"
        Me.TxtNroPer.Size = New System.Drawing.Size(104, 20)
        Me.TxtNroPer.TabIndex = 24
        '
        'CboTipoCta
        '
        Me.CboTipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboTipoCta.Enabled = False
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(108, 69)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(193, 21)
        Me.CboTipoCta.TabIndex = 28
        Me.CboTipoCta.Tag = "nConCodigo=1133"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nombre:"
        '
        'LblcNomRepre
        '
        Me.LblcNomRepre.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblcNomRepre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNomRepre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNomRepre.Location = New System.Drawing.Point(211, 46)
        Me.LblcNomRepre.Name = "LblcNomRepre"
        Me.LblcNomRepre.Size = New System.Drawing.Size(376, 20)
        Me.LblcNomRepre.TabIndex = 27
        Me.LblcNomRepre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblcPerCodPer
        '
        Me.LblcPerCodPer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblcPerCodPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodPer.Location = New System.Drawing.Point(108, 46)
        Me.LblcPerCodPer.Name = "LblcPerCodPer"
        Me.LblcPerCodPer.Size = New System.Drawing.Size(102, 20)
        Me.LblcPerCodPer.TabIndex = 26
        Me.LblcPerCodPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBxRangoFec
        '
        Me.GrpBxRangoFec.Controls.Add(Me.DtpFecFin)
        Me.GrpBxRangoFec.Controls.Add(Me.BtnMostrar)
        Me.GrpBxRangoFec.Controls.Add(Me.DtpFecIni)
        Me.GrpBxRangoFec.Controls.Add(Me.Label2)
        Me.GrpBxRangoFec.Controls.Add(Me.Label1)
        Me.GrpBxRangoFec.Location = New System.Drawing.Point(52, 21)
        Me.GrpBxRangoFec.Name = "GrpBxRangoFec"
        Me.GrpBxRangoFec.Size = New System.Drawing.Size(544, 66)
        Me.GrpBxRangoFec.TabIndex = 21
        Me.GrpBxRangoFec.TabStop = False
        Me.GrpBxRangoFec.Text = " Rango de fechas:"
        Me.GrpBxRangoFec.Visible = False
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(251, 28)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(110, 20)
        Me.DtpFecFin.TabIndex = 1
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(389, 26)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(114, 28)
        Me.BtnMostrar.TabIndex = 22
        Me.BtnMostrar.Text = " &Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'DtpFecIni
        '
        Me.DtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecIni.Location = New System.Drawing.Point(78, 28)
        Me.DtpFecIni.Name = "DtpFecIni"
        Me.DtpFecIni.Size = New System.Drawing.Size(110, 20)
        Me.DtpFecIni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'CrystalRptVwr
        '
        Me.CrystalRptVwr.ActiveViewIndex = -1
        Me.CrystalRptVwr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalRptVwr.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalRptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalRptVwr.Location = New System.Drawing.Point(0, 0)
        Me.CrystalRptVwr.Name = "CrystalRptVwr"
        Me.CrystalRptVwr.Size = New System.Drawing.Size(760, 374)
        Me.CrystalRptVwr.TabIndex = 0
        Me.CrystalRptVwr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormRptMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 535)
        Me.Controls.Add(Me.Split1)
        Me.Name = "FormRptMaster"
        Me.Text = "Reportes Generales - Caja"
        Me.Split1.Panel1.ResumeLayout(False)
        Me.Split1.Panel2.ResumeLayout(False)
        CType(Me.Split1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Split1.ResumeLayout(False)
        Me.Split2.Panel1.ResumeLayout(False)
        Me.Split2.Panel2.ResumeLayout(False)
        CType(Me.Split2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Split2.ResumeLayout(False)
        Me.Split3.Panel1.ResumeLayout(False)
        Me.Split3.Panel2.ResumeLayout(False)
        CType(Me.Split3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Split3.ResumeLayout(False)
        Me.PanelRangoFechas.ResumeLayout(False)
        Me.PanelRangoFechas.PerformLayout()
        Me.GrpBxEstadoCta.ResumeLayout(False)
        Me.GrpBxEstadoCta.PerformLayout()
        Me.GrpBxRangoFec.ResumeLayout(False)
        Me.GrpBxRangoFec.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Split1 As System.Windows.Forms.SplitContainer
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Split2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Split3 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelRangoFechas As System.Windows.Forms.Panel
    Friend WithEvents TreeViewList As System.Windows.Forms.TreeView
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents GrpBxRangoFec As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalRptVwr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblcNomRepre As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodPer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNroPer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnMostarEstado As System.Windows.Forms.Button
    Friend WithEvents CboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents GrpBxEstadoCta As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblMsg As System.Windows.Forms.Label
End Class
