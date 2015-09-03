<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcAdmision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcAdmision))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboModalidad = New System.Windows.Forms.ComboBox()
        Me.GrpBoxDatoAcademico = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarUNI = New System.Windows.Forms.Button()
        Me.BtnSubirFoto = New System.Windows.Forms.Button()
        Me.PctrBoxFoto = New System.Windows.Forms.PictureBox()
        Me.CboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.DtpFecCole = New System.Windows.Forms.DateTimePicker()
        Me.CboListaUNI = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblNroSolicitud = New System.Windows.Forms.Label()
        Me.CboPrograma = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGeneraCargo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpBoxDatoAcademico.SuspendLayout()
        CType(Me.PctrBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboTipoPer)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.LblcNombre)
        Me.GroupBox1.Controls.Add(Me.LblcPerCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNroFind)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Buscar Persona / Empresa"
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(403, 25)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(281, 21)
        Me.CboTipoDocu.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboModalidad)
        Me.GroupBox2.Controls.Add(Me.GrpBoxDatoAcademico)
        Me.GroupBox2.Controls.Add(Me.LblNroSolicitud)
        Me.GroupBox2.Controls.Add(Me.CboPrograma)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(8, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(679, 241)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Datos solicitud: "
        '
        'CboModalidad
        '
        Me.CboModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModalidad.FormattingEnabled = True
        Me.CboModalidad.Location = New System.Drawing.Point(167, 46)
        Me.CboModalidad.Name = "CboModalidad"
        Me.CboModalidad.Size = New System.Drawing.Size(170, 21)
        Me.CboModalidad.TabIndex = 3
        Me.CboModalidad.Tag = "nIntClase=1022;nIntTipo=1000"
        '
        'GrpBoxDatoAcademico
        '
        Me.GrpBoxDatoAcademico.Controls.Add(Me.BtnAgregarUNI)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.BtnSubirFoto)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.PctrBoxFoto)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.CboEspecialidad)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.DtpFecCole)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.CboListaUNI)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.Label12)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.Label10)
        Me.GrpBoxDatoAcademico.Controls.Add(Me.Label11)
        Me.GrpBoxDatoAcademico.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GrpBoxDatoAcademico.Location = New System.Drawing.Point(8, 67)
        Me.GrpBoxDatoAcademico.Name = "GrpBoxDatoAcademico"
        Me.GrpBoxDatoAcademico.Size = New System.Drawing.Size(663, 172)
        Me.GrpBoxDatoAcademico.TabIndex = 25
        Me.GrpBoxDatoAcademico.TabStop = False
        Me.GrpBoxDatoAcademico.Text = "Datos academicos: "
        '
        'BtnAgregarUNI
        '
        Me.BtnAgregarUNI.Image = Global.Integration.Test.My.Resources.Resources.house
        Me.BtnAgregarUNI.Location = New System.Drawing.Point(457, 29)
        Me.BtnAgregarUNI.Name = "BtnAgregarUNI"
        Me.BtnAgregarUNI.Size = New System.Drawing.Size(30, 21)
        Me.BtnAgregarUNI.TabIndex = 29
        Me.BtnAgregarUNI.UseVisualStyleBackColor = True
        '
        'BtnSubirFoto
        '
        Me.BtnSubirFoto.Image = Global.Integration.Test.My.Resources.Resources.photo_add
        Me.BtnSubirFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSubirFoto.Location = New System.Drawing.Point(411, 139)
        Me.BtnSubirFoto.Name = "BtnSubirFoto"
        Me.BtnSubirFoto.Size = New System.Drawing.Size(98, 25)
        Me.BtnSubirFoto.TabIndex = 8
        Me.BtnSubirFoto.Text = "Subir foto..."
        Me.BtnSubirFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubirFoto.UseVisualStyleBackColor = True
        '
        'PctrBoxFoto
        '
        Me.PctrBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PctrBoxFoto.Location = New System.Drawing.Point(517, 19)
        Me.PctrBoxFoto.Name = "PctrBoxFoto"
        Me.PctrBoxFoto.Size = New System.Drawing.Size(136, 145)
        Me.PctrBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctrBoxFoto.TabIndex = 28
        Me.PctrBoxFoto.TabStop = False
        '
        'CboEspecialidad
        '
        Me.CboEspecialidad.FormattingEnabled = True
        Me.CboEspecialidad.Location = New System.Drawing.Point(154, 81)
        Me.CboEspecialidad.Name = "CboEspecialidad"
        Me.CboEspecialidad.Size = New System.Drawing.Size(302, 21)
        Me.CboEspecialidad.TabIndex = 6
        Me.CboEspecialidad.Tag = "1943"
        '
        'DtpFecCole
        '
        Me.DtpFecCole.Location = New System.Drawing.Point(154, 57)
        Me.DtpFecCole.Name = "DtpFecCole"
        Me.DtpFecCole.Size = New System.Drawing.Size(213, 20)
        Me.DtpFecCole.TabIndex = 5
        '
        'CboListaUNI
        '
        Me.CboListaUNI.FormattingEnabled = True
        Me.CboListaUNI.Location = New System.Drawing.Point(154, 30)
        Me.CboListaUNI.Name = "CboListaUNI"
        Me.CboListaUNI.Size = New System.Drawing.Size(302, 21)
        Me.CboListaUNI.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(78, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Especialidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(45, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fecha de Egresado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(15, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Titulado en la Universidad:"
        '
        'LblNroSolicitud
        '
        Me.LblNroSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNroSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNroSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroSolicitud.ForeColor = System.Drawing.Color.White
        Me.LblNroSolicitud.Location = New System.Drawing.Point(568, 0)
        Me.LblNroSolicitud.Name = "LblNroSolicitud"
        Me.LblNroSolicitud.Size = New System.Drawing.Size(94, 20)
        Me.LblNroSolicitud.TabIndex = 24
        Me.LblNroSolicitud.Text = "0000000000"
        Me.LblNroSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboPrograma
        '
        Me.CboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPrograma.FormattingEnabled = True
        Me.CboPrograma.Location = New System.Drawing.Point(167, 19)
        Me.CboPrograma.Name = "CboPrograma"
        Me.CboPrograma.Size = New System.Drawing.Size(304, 21)
        Me.CboPrograma.TabIndex = 3
        Me.CboPrograma.Tag = "nIntClase=1002;nIntTipo=0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(107, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Modalidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(494, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nro. Solicitud:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(77, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de Solicitud:"
        '
        'CboTipoPer
        '
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(121, 25)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(156, 21)
        Me.CboTipoPer.TabIndex = 0
        Me.CboTipoPer.Tag = "1010"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.Integration.Test.My.Resources.Resources.user_student
        Me.BtnAgregar.Location = New System.Drawing.Point(247, 51)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 21)
        Me.BtnAgregar.TabIndex = 21
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblcNombre
        '
        Me.LblcNombre.BackColor = System.Drawing.SystemColors.Info
        Me.LblcNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.Location = New System.Drawing.Point(121, 75)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(563, 20)
        Me.LblcNombre.TabIndex = 19
        Me.LblcNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(403, 50)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(89, 20)
        Me.LblcPerCodigo.TabIndex = 18
        Me.LblcPerCodigo.Text = "0000000001"
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos y Nombres:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tipo de documento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo de persona:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'TxtNroFind
        '
        Me.TxtNroFind.Location = New System.Drawing.Point(121, 52)
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(126, 20)
        Me.TxtNroFind.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Documento:"
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
        Me.C1ToolBar.Location = New System.Drawing.Point(3, 28)
        Me.C1ToolBar.Name = "C1ToolBar"
        Me.C1ToolBar.Size = New System.Drawing.Size(360, 24)
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
        Me.C1CmdLinkGrabar.Text = "&Grabar"
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(712, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "҉     Registro solicitud para Colegiatura"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnGeneraCargo
        '
        Me.BtnGeneraCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGeneraCargo.ForeColor = System.Drawing.Color.White
        Me.BtnGeneraCargo.Image = Global.Integration.Test.My.Resources.Resources.note_add
        Me.BtnGeneraCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGeneraCargo.Location = New System.Drawing.Point(586, 31)
        Me.BtnGeneraCargo.Name = "BtnGeneraCargo"
        Me.BtnGeneraCargo.Size = New System.Drawing.Size(115, 30)
        Me.BtnGeneraCargo.TabIndex = 20
        Me.BtnGeneraCargo.Text = "  Genera Cargo   "
        Me.BtnGeneraCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGeneraCargo.UseVisualStyleBackColor = False
        '
        'FormPrcAdmision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 411)
        Me.Controls.Add(Me.BtnGeneraCargo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.C1ToolBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrcAdmision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud - Nueva Colegiatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpBoxDatoAcademico.ResumeLayout(False)
        Me.GrpBoxDatoAcademico.PerformLayout()
        CType(Me.PctrBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxDatoAcademico As System.Windows.Forms.GroupBox
    Friend WithEvents CboListaUNI As System.Windows.Forms.ComboBox
    Friend WithEvents LblNroSolicitud As System.Windows.Forms.Label
    Friend WithEvents CboPrograma As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnSubirFoto As System.Windows.Forms.Button
    Friend WithEvents PctrBoxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents CboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecCole As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents c1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents c1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1ToolBar As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdLinkNuevo As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkGrabar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCancel As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkEdit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdLinkCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents BtnAgregarUNI As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnGeneraCargo As System.Windows.Forms.Button
    Friend WithEvents CboModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
