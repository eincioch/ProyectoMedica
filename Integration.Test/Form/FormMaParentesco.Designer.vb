<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaParentesco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaParentesco))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboParentesco = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblnEdad = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboAnio = New System.Windows.Forms.ComboBox()
        Me.DtpFecNacCrea = New System.Windows.Forms.DateTimePicker()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.CboDia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboSexoTEmp = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboTratoPer = New System.Windows.Forms.ComboBox()
        Me.CboTipoPer = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNroDocu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNroDocu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboTipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.TxtApePat = New System.Windows.Forms.TextBox()
        Me.Txt1Nombre = New System.Windows.Forms.TextBox()
        Me.TxtApeMat = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboParentesco)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.LblnEdad)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.CboAnio)
        Me.GroupBox1.Controls.Add(Me.DtpFecNacCrea)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.CboDia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboSexoTEmp)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CboTratoPer)
        Me.GroupBox1.Controls.Add(Me.CboTipoPer)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNroDocu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblNroDocu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CboTipoDocu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblcPerCodigo)
        Me.GroupBox1.Controls.Add(Me.TxtApePat)
        Me.GroupBox1.Controls.Add(Me.Txt1Nombre)
        Me.GroupBox1.Controls.Add(Me.TxtApeMat)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Familiar"
        '
        'CboParentesco
        '
        Me.CboParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboParentesco.FormattingEnabled = True
        Me.CboParentesco.Location = New System.Drawing.Point(140, 57)
        Me.CboParentesco.Name = "CboParentesco"
        Me.CboParentesco.Size = New System.Drawing.Size(321, 23)
        Me.CboParentesco.TabIndex = 0
        Me.CboParentesco.Tag = "1006"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Parentesco"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(206, 313)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 15)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "año(s)."
        '
        'LblnEdad
        '
        Me.LblnEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblnEdad.Location = New System.Drawing.Point(141, 312)
        Me.LblnEdad.Name = "LblnEdad"
        Me.LblnEdad.Size = New System.Drawing.Size(58, 21)
        Me.LblnEdad.TabIndex = 56
        Me.LblnEdad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 313)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 15)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Edad"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(370, 261)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 21)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Año"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(206, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 21)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Mes"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(141, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 21)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Dia"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CboAnio
        '
        Me.CboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnio.FormattingEnabled = True
        Me.CboAnio.Location = New System.Drawing.Point(367, 282)
        Me.CboAnio.Name = "CboAnio"
        Me.CboAnio.Size = New System.Drawing.Size(94, 23)
        Me.CboAnio.TabIndex = 9
        Me.CboAnio.Tag = "1021"
        '
        'DtpFecNacCrea
        '
        Me.DtpFecNacCrea.Enabled = False
        Me.DtpFecNacCrea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecNacCrea.Location = New System.Drawing.Point(27, 262)
        Me.DtpFecNacCrea.Name = "DtpFecNacCrea"
        Me.DtpFecNacCrea.Size = New System.Drawing.Size(111, 21)
        Me.DtpFecNacCrea.TabIndex = 48
        Me.DtpFecNacCrea.Visible = False
        '
        'CboMes
        '
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(206, 283)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(153, 23)
        Me.CboMes.TabIndex = 8
        Me.CboMes.Tag = "1005"
        '
        'CboDia
        '
        Me.CboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDia.FormattingEnabled = True
        Me.CboDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CboDia.Location = New System.Drawing.Point(140, 283)
        Me.CboDia.Name = "CboDia"
        Me.CboDia.Size = New System.Drawing.Size(59, 23)
        Me.CboDia.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'CboSexoTEmp
        '
        Me.CboSexoTEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexoTEmp.FormattingEnabled = True
        Me.CboSexoTEmp.Location = New System.Drawing.Point(141, 336)
        Me.CboSexoTEmp.Name = "CboSexoTEmp"
        Me.CboSexoTEmp.Size = New System.Drawing.Size(320, 23)
        Me.CboSexoTEmp.TabIndex = 10
        Me.CboSexoTEmp.Tag = "1002"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Sexo"
        '
        'CboTratoPer
        '
        Me.CboTratoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTratoPer.FormattingEnabled = True
        Me.CboTratoPer.Location = New System.Drawing.Point(141, 143)
        Me.CboTratoPer.Name = "CboTratoPer"
        Me.CboTratoPer.Size = New System.Drawing.Size(107, 23)
        Me.CboTratoPer.TabIndex = 3
        Me.CboTratoPer.Tag = "2837"
        '
        'CboTipoPer
        '
        Me.CboTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPer.Enabled = False
        Me.CboTipoPer.FormattingEnabled = True
        Me.CboTipoPer.Location = New System.Drawing.Point(418, 9)
        Me.CboTipoPer.Name = "CboTipoPer"
        Me.CboTipoPer.Size = New System.Drawing.Size(63, 23)
        Me.CboTipoPer.TabIndex = 30
        Me.CboTipoPer.Tag = "1010"
        Me.CboTipoPer.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Tratamiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Codigo"
        '
        'TxtNroDocu
        '
        Me.TxtNroDocu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroDocu.Location = New System.Drawing.Point(141, 114)
        Me.TxtNroDocu.Name = "TxtNroDocu"
        Me.TxtNroDocu.Size = New System.Drawing.Size(191, 21)
        Me.TxtNroDocu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Apellido Paterno"
        '
        'LblNroDocu
        '
        Me.LblNroDocu.AutoSize = True
        Me.LblNroDocu.Location = New System.Drawing.Point(28, 118)
        Me.LblNroDocu.Name = "LblNroDocu"
        Me.LblNroDocu.Size = New System.Drawing.Size(97, 15)
        Me.LblNroDocu.TabIndex = 43
        Me.LblNroDocu.Text = "Nro. Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Apellido Materno"
        '
        'CboTipoDocu
        '
        Me.CboTipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDocu.Enabled = False
        Me.CboTipoDocu.FormattingEnabled = True
        Me.CboTipoDocu.Location = New System.Drawing.Point(141, 87)
        Me.CboTipoDocu.Name = "CboTipoDocu"
        Me.CboTipoDocu.Size = New System.Drawing.Size(319, 23)
        Me.CboTipoDocu.TabIndex = 1
        Me.CboTipoDocu.Tag = "1010"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tipo de Persona"
        Me.Label5.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 15)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Tipo de Docu."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Primer nombre"
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(141, 29)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(106, 23)
        Me.LblcPerCodigo.TabIndex = 41
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtApePat
        '
        Me.TxtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApePat.Location = New System.Drawing.Point(141, 174)
        Me.TxtApePat.Name = "TxtApePat"
        Me.TxtApePat.Size = New System.Drawing.Size(320, 21)
        Me.TxtApePat.TabIndex = 4
        '
        'Txt1Nombre
        '
        Me.Txt1Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt1Nombre.Location = New System.Drawing.Point(141, 234)
        Me.Txt1Nombre.Name = "Txt1Nombre"
        Me.Txt1Nombre.Size = New System.Drawing.Size(320, 21)
        Me.Txt1Nombre.TabIndex = 6
        '
        'TxtApeMat
        '
        Me.TxtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApeMat.Location = New System.Drawing.Point(141, 204)
        Me.TxtApeMat.Name = "TxtApeMat"
        Me.TxtApeMat.Size = New System.Drawing.Size(320, 21)
        Me.TxtApeMat.TabIndex = 5
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources._16_em_cross
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(376, 423)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(117, 30)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "&Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(248, 423)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 30)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(512, 32)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "҉     Registro Pariente del Menor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMaParentesco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(512, 467)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMaParentesco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Parentesco..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboTratoPer As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNroDocu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblNroDocu As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtApePat As System.Windows.Forms.TextBox
    Friend WithEvents Txt1Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApeMat As System.Windows.Forms.TextBox
    Friend WithEvents CboSexoTEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblnEdad As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecNacCrea As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents CboDia As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboParentesco As System.Windows.Forms.ComboBox
    Private WithEvents Label7 As System.Windows.Forms.Label
End Class
