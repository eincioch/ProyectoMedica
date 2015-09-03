<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConstante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConstante))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTabla = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.c1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.c1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkGrabar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.LblnConValor = New System.Windows.Forms.Label()
        Me.TxtDescrp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c_codi_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_codi_cara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_name_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTabla)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Seleccionar Tabla "
        '
        'CboTabla
        '
        Me.CboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTabla.FormattingEnabled = True
        Me.CboTabla.Location = New System.Drawing.Point(108, 26)
        Me.CboTabla.Name = "CboTabla"
        Me.CboTabla.Size = New System.Drawing.Size(422, 21)
        Me.CboTabla.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Constante: "
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_codi_prod, Me.c_codi_cara, Me.c_name_prod})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Location = New System.Drawing.Point(10, 115)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Table1.Size = New System.Drawing.Size(555, 280)
        Me.Table1.TabIndex = 14
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
        Me.C1CmdLinkNuevo.Command = Me.c1CmdNuevo
        '
        'C1CmdLinkGrabar
        '
        Me.C1CmdLinkGrabar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkGrabar.Command = Me.c1CmdGrabar
        Me.C1CmdLinkGrabar.SortOrder = 1
        Me.C1CmdLinkGrabar.Text = "&Guardar"
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
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.LblnConValor)
        Me.GrpBox.Controls.Add(Me.TxtDescrp)
        Me.GrpBox.Controls.Add(Me.Label2)
        Me.GrpBox.Location = New System.Drawing.Point(10, 136)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(553, 76)
        Me.GrpBox.TabIndex = 15
        Me.GrpBox.TabStop = False
        Me.GrpBox.Visible = False
        '
        'LblnConValor
        '
        Me.LblnConValor.AutoSize = True
        Me.LblnConValor.Location = New System.Drawing.Point(462, 56)
        Me.LblnConValor.Name = "LblnConValor"
        Me.LblnConValor.Size = New System.Drawing.Size(10, 13)
        Me.LblnConValor.TabIndex = 2
        Me.LblnConValor.Text = "."
        '
        'TxtDescrp
        '
        Me.TxtDescrp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescrp.Location = New System.Drawing.Point(103, 33)
        Me.TxtDescrp.MaxLength = 100
        Me.TxtDescrp.Name = "TxtDescrp"
        Me.TxtDescrp.Size = New System.Drawing.Size(425, 20)
        Me.TxtDescrp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(572, 28)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "҉    Constantes - [variables sistema]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'c_codi_prod
        '
        Me.c_codi_prod.DataPropertyName = "nConCodigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.c_codi_prod.DefaultCellStyle = DataGridViewCellStyle2
        Me.c_codi_prod.HeaderText = "Código"
        Me.c_codi_prod.Name = "c_codi_prod"
        Me.c_codi_prod.ReadOnly = True
        Me.c_codi_prod.Width = 50
        '
        'c_codi_cara
        '
        Me.c_codi_cara.DataPropertyName = "nConValor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.c_codi_cara.DefaultCellStyle = DataGridViewCellStyle3
        Me.c_codi_cara.HeaderText = "ConValor"
        Me.c_codi_cara.Name = "c_codi_cara"
        Me.c_codi_cara.ReadOnly = True
        '
        'c_name_prod
        '
        Me.c_name_prod.DataPropertyName = "cConDescripcion"
        Me.c_name_prod.HeaderText = "Descripción"
        Me.c_name_prod.Name = "c_name_prod"
        Me.c_name_prod.ReadOnly = True
        Me.c_name_prod.Width = 295
        '
        'FormConstante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 402)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConstante"
        Me.Text = "Constantes del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboTabla As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescrp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblnConValor As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c_codi_prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_codi_cara As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_name_prod As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
