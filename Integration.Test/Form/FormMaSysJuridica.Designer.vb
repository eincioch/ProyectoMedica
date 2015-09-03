<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaSysJuridica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaSysJuridica))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTEmp = New System.Windows.Forms.ComboBox()
        Me.GrpBoxRepre = New System.Windows.Forms.GroupBox()
        Me.LblcNomRepre = New System.Windows.Forms.Label()
        Me.BtnAgregarPersona = New System.Windows.Forms.Button()
        Me.LblcPerCodPer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNroPer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.CboSectorE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.c1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.c1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.c1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdLinkNuevo = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkGrabar = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkEdit = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCancel = New C1.Win.C1Command.C1CommandLink()
        Me.C1CmdLinkCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxRepre.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CboTEmp)
        Me.GroupBox1.Controls.Add(Me.GrpBoxRepre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LblcPerCodigo)
        Me.GroupBox1.Controls.Add(Me.CboSectorE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox1.Controls.Add(Me.CboTipoPer)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.LblcNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNroFind)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 193)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Buscar Empresa: "
        '
        'CboTEmp
        '
        Me.CboTEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTEmp.FormattingEnabled = True
        Me.CboTEmp.Location = New System.Drawing.Point(103, 99)
        Me.CboTEmp.Name = "CboTEmp"
        Me.CboTEmp.Size = New System.Drawing.Size(146, 21)
        Me.CboTEmp.TabIndex = 2
        Me.CboTEmp.Tag = "1023"
        '
        'GrpBoxRepre
        '
        Me.GrpBoxRepre.Controls.Add(Me.LblcNomRepre)
        Me.GrpBoxRepre.Controls.Add(Me.BtnAgregarPersona)
        Me.GrpBoxRepre.Controls.Add(Me.LblcPerCodPer)
        Me.GrpBoxRepre.Controls.Add(Me.Label2)
        Me.GrpBoxRepre.Controls.Add(Me.TxtNroPer)
        Me.GrpBoxRepre.Controls.Add(Me.Label4)
        Me.GrpBoxRepre.Location = New System.Drawing.Point(4, 123)
        Me.GrpBoxRepre.Name = "GrpBoxRepre"
        Me.GrpBoxRepre.Size = New System.Drawing.Size(616, 67)
        Me.GrpBoxRepre.TabIndex = 2
        Me.GrpBoxRepre.TabStop = False
        Me.GrpBoxRepre.Text = " Datos representante"
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
        'BtnAgregarPersona
        '
        Me.BtnAgregarPersona.Image = Global.Integration.Test.My.Resources.Resources.user_nude
        Me.BtnAgregarPersona.Location = New System.Drawing.Point(204, 18)
        Me.BtnAgregarPersona.Name = "BtnAgregarPersona"
        Me.BtnAgregarPersona.Size = New System.Drawing.Size(29, 21)
        Me.BtnAgregarPersona.TabIndex = 4
        Me.BtnAgregarPersona.UseVisualStyleBackColor = True
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
        Me.Label2.Location = New System.Drawing.Point(47, 47)
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
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nro. Documento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Tipo Empresa:"
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(104, 74)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(104, 20)
        Me.LblcPerCodigo.TabIndex = 18
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboSectorE
        '
        Me.CboSectorE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSectorE.FormattingEnabled = True
        Me.CboSectorE.Location = New System.Drawing.Point(351, 100)
        Me.CboSectorE.Name = "CboSectorE"
        Me.CboSectorE.Size = New System.Drawing.Size(236, 21)
        Me.CboSectorE.TabIndex = 3
        Me.CboSectorE.Tag = "1024"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Sector Económico:"
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(351, 25)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(261, 21)
        Me.CboTipoDocu.TabIndex = 1
        '
        'CboTipoPer
        '
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboTipoPer.Enabled = False
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(104, 25)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(133, 21)
        Me.CboTipoPer.TabIndex = 0
        Me.CboTipoPer.Tag = "1010"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.Integration.Test.My.Resources.Resources.house
        Me.BtnAgregar.Location = New System.Drawing.Point(208, 52)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(29, 21)
        Me.BtnAgregar.TabIndex = 21
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblcNombre
        '
        Me.LblcNombre.BackColor = System.Drawing.SystemColors.Info
        Me.LblcNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.Location = New System.Drawing.Point(208, 74)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(404, 20)
        Me.LblcNombre.TabIndex = 19
        Me.LblcNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razon Social:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tipo de documento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo de persona:"
        '
        'TxtNroFind
        '
        Me.TxtNroFind.Location = New System.Drawing.Point(104, 52)
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(104, 20)
        Me.TxtNroFind.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Documento:"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdNuevo)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdGrabar)
        Me.C1CommandHolder1.Commands.Add(Me.c1CmdCancel)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdEdit)
        Me.C1CommandHolder1.Commands.Add(Me.C1CmdCerrar)
        Me.C1CommandHolder1.Owner = Me
        '
        'c1CmdNuevo
        '
        Me.c1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.c1CmdNuevo.Name = "c1CmdNuevo"
        Me.c1CmdNuevo.Text = "&Nuevo"
        '
        'c1CmdGrabar
        '
        Me.c1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
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
        Me.C1ToolBar.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CmdLinkNuevo, Me.C1CmdLinkGrabar, Me.C1CmdLinkEdit, Me.C1CmdLinkCancel, Me.C1CmdLinkCerrar})
        Me.C1ToolBar.Location = New System.Drawing.Point(12, 1)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(490, 24)
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
        Me.C1CmdLinkGrabar.Text = "&Establecer como Empresa"
        '
        'C1CmdLinkEdit
        '
        Me.C1CmdLinkEdit.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkEdit.Command = Me.C1CmdEdit
        Me.C1CmdLinkEdit.SortOrder = 2
        Me.C1CmdLinkEdit.Text = "&Quitar Empresa"
        '
        'C1CmdLinkCancel
        '
        Me.C1CmdLinkCancel.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCancel.Command = Me.c1CmdCancel
        Me.C1CmdLinkCancel.SortOrder = 3
        Me.C1CmdLinkCancel.Text = "&Cancelar"
        '
        'C1CmdLinkCerrar
        '
        Me.C1CmdLinkCerrar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CmdLinkCerrar.Command = Me.C1CmdCerrar
        Me.C1CmdLinkCerrar.SortOrder = 4
        Me.C1CmdLinkCerrar.Text = "&Cerrar"
        '
        'FormMaSysJuridica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 239)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMaSysJuridica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro Empresa - Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBoxRepre.ResumeLayout(False)
        Me.GrpBoxRepre.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GrpBoxRepre As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgregarPersona As System.Windows.Forms.Button
    Friend WithEvents LblcPerCodPer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblcNomRepre As System.Windows.Forms.Label
    Friend WithEvents CboTEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CboSectorE As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNroPer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
