<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcAfiliacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcAfiliacion))
        Me.GrpBoxRepre = New System.Windows.Forms.GroupBox()
        Me.LblcNomRepre = New System.Windows.Forms.Label()
        Me.LblcPerCodPer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNroPer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.BtnAddPer = New System.Windows.Forms.Button()
        Me.CboPerAutoFill = New System.Windows.Forms.ComboBox()
        Me.LblFecReg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTPorc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nDocPerTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPerRelacion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPorc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtObser = New System.Windows.Forms.TextBox()
        Me.TxtNroPoliza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.LblNewIdcDocCodigo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GrpBoxRepre.SuspendLayout()
        Me.GrpBox.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxRepre
        '
        Me.GrpBoxRepre.Controls.Add(Me.LblcNomRepre)
        Me.GrpBoxRepre.Controls.Add(Me.LblcPerCodPer)
        Me.GrpBoxRepre.Controls.Add(Me.Label2)
        Me.GrpBoxRepre.Controls.Add(Me.TxtNroPer)
        Me.GrpBoxRepre.Controls.Add(Me.Label4)
        Me.GrpBoxRepre.Location = New System.Drawing.Point(12, 62)
        Me.GrpBoxRepre.Name = "GrpBoxRepre"
        Me.GrpBoxRepre.Size = New System.Drawing.Size(616, 67)
        Me.GrpBoxRepre.TabIndex = 0
        Me.GrpBoxRepre.TabStop = False
        Me.GrpBoxRepre.Text = " Datos Colegiado"
        '
        'LblcNomRepre
        '
        Me.LblcNomRepre.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblcNomRepre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNomRepre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNomRepre.Location = New System.Drawing.Point(203, 42)
        Me.LblcNomRepre.Name = "LblcNomRepre"
        Me.LblcNomRepre.Size = New System.Drawing.Size(405, 20)
        Me.LblcNomRepre.TabIndex = 23
        Me.LblcNomRepre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblcPerCodPer
        '
        Me.LblcPerCodPer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblcPerCodPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodPer.Location = New System.Drawing.Point(100, 42)
        Me.LblcPerCodPer.Name = "LblcPerCodPer"
        Me.LblcPerCodPer.Size = New System.Drawing.Size(102, 20)
        Me.LblcPerCodPer.TabIndex = 20
        Me.LblcPerCodPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'TxtNroPer
        '
        Me.TxtNroPer.Location = New System.Drawing.Point(100, 19)
        Me.TxtNroPer.Name = "TxtNroPer"
        Me.TxtNroPer.Size = New System.Drawing.Size(104, 20)
        Me.TxtNroPer.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cod. Cole./D.N.I:"
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.BtnAddPer)
        Me.GrpBox.Controls.Add(Me.CboPerAutoFill)
        Me.GrpBox.Controls.Add(Me.LblFecReg)
        Me.GrpBox.Controls.Add(Me.Label7)
        Me.GrpBox.Controls.Add(Me.LblTPorc)
        Me.GrpBox.Controls.Add(Me.Label6)
        Me.GrpBox.Controls.Add(Me.BtnQuitar)
        Me.GrpBox.Controls.Add(Me.BtnAgregar)
        Me.GrpBox.Controls.Add(Me.Table1)
        Me.GrpBox.Controls.Add(Me.TxtObser)
        Me.GrpBox.Controls.Add(Me.TxtNroPoliza)
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Location = New System.Drawing.Point(12, 134)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(615, 347)
        Me.GrpBox.TabIndex = 1
        Me.GrpBox.TabStop = False
        '
        'BtnAddPer
        '
        Me.BtnAddPer.Image = Global.Integration.Test.My.Resources.Resources.user
        Me.BtnAddPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddPer.Location = New System.Drawing.Point(7, 41)
        Me.BtnAddPer.Name = "BtnAddPer"
        Me.BtnAddPer.Size = New System.Drawing.Size(27, 25)
        Me.BtnAddPer.TabIndex = 6
        Me.BtnAddPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddPer.UseVisualStyleBackColor = True
        '
        'CboPerAutoFill
        '
        Me.CboPerAutoFill.FormattingEnabled = True
        Me.CboPerAutoFill.Location = New System.Drawing.Point(100, 44)
        Me.CboPerAutoFill.Name = "CboPerAutoFill"
        Me.CboPerAutoFill.Size = New System.Drawing.Size(366, 21)
        Me.CboPerAutoFill.TabIndex = 1
        '
        'LblFecReg
        '
        Me.LblFecReg.BackColor = System.Drawing.Color.White
        Me.LblFecReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFecReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecReg.Location = New System.Drawing.Point(364, 21)
        Me.LblFecReg.Name = "LblFecReg"
        Me.LblFecReg.Size = New System.Drawing.Size(102, 20)
        Me.LblFecReg.TabIndex = 20
        Me.LblFecReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha registro:"
        '
        'LblTPorc
        '
        Me.LblTPorc.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblTPorc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPorc.Location = New System.Drawing.Point(561, 243)
        Me.LblTPorc.Name = "LblTPorc"
        Me.LblTPorc.Size = New System.Drawing.Size(48, 20)
        Me.LblTPorc.TabIndex = 20
        Me.LblTPorc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Porc.(%):"
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Image = Global.Integration.Test.My.Resources.Resources.user_delete1
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.Location = New System.Drawing.Point(544, 41)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(64, 25)
        Me.BtnQuitar.TabIndex = 3
        Me.BtnQuitar.Text = "&Quitar"
        Me.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.Integration.Test.My.Resources.Resources.user_add1
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(472, 41)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(70, 25)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "&Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.UseVisualStyleBackColor = True
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerCodigo, Me.nDocPerTipo, Me.nPerRelacion, Me.cNombreCompleto, Me.nPorc})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Table1.Location = New System.Drawing.Point(7, 71)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Size = New System.Drawing.Size(602, 170)
        Me.Table1.TabIndex = 4
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        Me.cPerCodigo.HeaderText = "Código Persona"
        Me.cPerCodigo.Name = "cPerCodigo"
        Me.cPerCodigo.ReadOnly = True
        Me.cPerCodigo.Visible = False
        Me.cPerCodigo.Width = 70
        '
        'nDocPerTipo
        '
        Me.nDocPerTipo.DataPropertyName = "nDocPerTipo"
        Me.nDocPerTipo.HeaderText = "nDocPerTipo"
        Me.nDocPerTipo.Name = "nDocPerTipo"
        Me.nDocPerTipo.ReadOnly = True
        Me.nDocPerTipo.Visible = False
        Me.nDocPerTipo.Width = 30
        '
        'nPerRelacion
        '
        Me.nPerRelacion.DataPropertyName = "nPerRelacion"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        Me.nPerRelacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.nPerRelacion.HeaderText = "Parentesco"
        Me.nPerRelacion.Name = "nPerRelacion"
        Me.nPerRelacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nPerRelacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nPerRelacion.Width = 150
        '
        'cNombreCompleto
        '
        Me.cNombreCompleto.DataPropertyName = "cNombreCompleto"
        Me.cNombreCompleto.HeaderText = "Apellidos y Nombre(s)"
        Me.cNombreCompleto.Name = "cNombreCompleto"
        Me.cNombreCompleto.ReadOnly = True
        Me.cNombreCompleto.Width = 330
        '
        'nPorc
        '
        Me.nPorc.HeaderText = "Porc (%)"
        Me.nPorc.Name = "nPorc"
        Me.nPorc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nPorc.Width = 60
        '
        'TxtObser
        '
        Me.TxtObser.Location = New System.Drawing.Point(101, 266)
        Me.TxtObser.Multiline = True
        Me.TxtObser.Name = "TxtObser"
        Me.TxtObser.Size = New System.Drawing.Size(508, 77)
        Me.TxtObser.TabIndex = 5
        '
        'TxtNroPoliza
        '
        Me.TxtNroPoliza.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNroPoliza.Location = New System.Drawing.Point(100, 19)
        Me.TxtNroPoliza.Name = "TxtNroPoliza"
        Me.TxtNroPoliza.Size = New System.Drawing.Size(104, 20)
        Me.TxtNroPoliza.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Beneficiario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Poliza Nro.:"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldr
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(12, 34)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(360, 24)
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
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "Grabar"
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
        Me.C1CommandLink1.Text = "Nuevo"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGrabar
        Me.C1CommandLink2.SortOrder = 1
        Me.C1CommandLink2.Text = "Grabar"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancel
        Me.C1CommandLink3.SortOrder = 2
        Me.C1CommandLink3.Text = "Cancelar"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 3
        Me.C1CommandLink4.Text = "Modificar"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 4
        Me.C1CommandLink5.Text = "Cerrar"
        '
        'LblNewIdcDocCodigo
        '
        Me.LblNewIdcDocCodigo.BackColor = System.Drawing.SystemColors.Menu
        Me.LblNewIdcDocCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewIdcDocCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNewIdcDocCodigo.Location = New System.Drawing.Point(508, 39)
        Me.LblNewIdcDocCodigo.Name = "LblNewIdcDocCodigo"
        Me.LblNewIdcDocCodigo.Size = New System.Drawing.Size(126, 20)
        Me.LblNewIdcDocCodigo.TabIndex = 20
        Me.LblNewIdcDocCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(636, 28)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "҉     Afiliación Fondo Mortorio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPrcAfiliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 489)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.LblNewIdcDocCodigo)
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.GrpBoxRepre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrcAfiliacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Afiliación Fondo Mortorio"
        Me.GrpBoxRepre.ResumeLayout(False)
        Me.GrpBoxRepre.PerformLayout()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxRepre As System.Windows.Forms.GroupBox
    Friend WithEvents LblcNomRepre As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodPer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNroPer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboPerAutoFill As System.Windows.Forms.ComboBox
    Friend WithEvents LblTPorc As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblNewIdcDocCodigo As System.Windows.Forms.Label
    Friend WithEvents LblFecReg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAddPer As System.Windows.Forms.Button
    Private WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nDocPerTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nPerRelacion As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents cNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents nPorc As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
