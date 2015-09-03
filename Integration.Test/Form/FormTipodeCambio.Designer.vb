<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipodeCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTipodeCambio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.DTpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdCargar = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.TDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ncompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpBx.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBx
        '
        Me.GrpBx.Controls.Add(Me.DTpFecha)
        Me.GrpBx.Controls.Add(Me.Label2)
        Me.GrpBx.Controls.Add(Me.CboMoneda)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Location = New System.Drawing.Point(3, 48)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(447, 44)
        Me.GrpBx.TabIndex = 0
        Me.GrpBx.TabStop = False
        '
        'DTpFecha
        '
        Me.DTpFecha.CustomFormat = " MMMM 'del' yyyy"
        Me.DTpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTpFecha.Location = New System.Drawing.Point(262, 17)
        Me.DTpFecha.MinDate = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.DTpFecha.Name = "DTpFecha"
        Me.DTpFecha.ShowUpDown = True
        Me.DTpFecha.Size = New System.Drawing.Size(138, 20)
        Me.DTpFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mes:"
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMoneda.FormattingEnabled = True
        Me.CboMoneda.Location = New System.Drawing.Point(76, 16)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(135, 21)
        Me.CboMoneda.TabIndex = 1
        Me.CboMoneda.Tag = "1001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Moneda:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(456, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉     Tipo de Cambio por día"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(330, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Tipo Cambio de hoy"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3})
        Me.C1ToolBar1.Location = New System.Drawing.Point(3, 28)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(276, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCargar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdGrabar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CmdCargar
        '
        Me.C1CmdCargar.Image = CType(resources.GetObject("C1CmdCargar.Image"), System.Drawing.Image)
        Me.C1CmdCargar.Name = "C1CmdCargar"
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = CType(resources.GetObject("C1CmdGrabar.Image"), System.Drawing.Image)
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = CType(resources.GetObject("C1CmdCerrar.Image"), System.Drawing.Image)
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdCargar
        Me.C1CommandLink1.Text = "Cargar días"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGrabar
        Me.C1CommandLink2.SortOrder = 1
        Me.C1CommandLink2.Text = "Grabar/Actualiza"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCerrar
        Me.C1CommandLink3.SortOrder = 2
        Me.C1CommandLink3.Text = "Cerrar"
        '
        'Table1
        '
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TDias, Me.tcompra, Me.ncompra, Me.tventa, Me.nventa})
        Me.Table1.Location = New System.Drawing.Point(3, 91)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(447, 388)
        Me.Table1.TabIndex = 23
        '
        'TDias
        '
        Me.TDias.DataPropertyName = "TDias"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Format = "dd"
        Me.TDias.DefaultCellStyle = DataGridViewCellStyle1
        Me.TDias.HeaderText = "Día"
        Me.TDias.Name = "TDias"
        Me.TDias.ReadOnly = True
        '
        'tcompra
        '
        Me.tcompra.DataPropertyName = "tcompra"
        Me.tcompra.HeaderText = "tcompra"
        Me.tcompra.Name = "tcompra"
        Me.tcompra.Visible = False
        Me.tcompra.Width = 20
        '
        'ncompra
        '
        Me.ncompra.DataPropertyName = "ncompra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N4"
        Me.ncompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.ncompra.HeaderText = "Valor Compra"
        Me.ncompra.Name = "ncompra"
        '
        'tventa
        '
        Me.tventa.DataPropertyName = "tventa"
        Me.tventa.HeaderText = "tventa"
        Me.tventa.Name = "tventa"
        Me.tventa.Visible = False
        Me.tventa.Width = 20
        '
        'nventa
        '
        Me.nventa.DataPropertyName = "nventa"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N4"
        Me.nventa.DefaultCellStyle = DataGridViewCellStyle3
        Me.nventa.HeaderText = "Valor Venta"
        Me.nventa.Name = "nventa"
        '
        'FormTipodeCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 485)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpBx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTipodeCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Cambio"
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents DTpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CmdCargar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TDias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ncompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nventa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
