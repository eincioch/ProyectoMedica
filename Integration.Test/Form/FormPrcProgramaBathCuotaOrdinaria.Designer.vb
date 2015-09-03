<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcProgramaBathCuotaOrdinaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcProgramaBathCuotaOrdinaria))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboServicios = New System.Windows.Forms.ComboBox()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFechaProceso = New System.Windows.Forms.DateTimePicker()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnProgramar = New System.Windows.Forms.Button()
        Me.GrpBx2 = New System.Windows.Forms.GroupBox()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.DtpFecFallecido = New System.Windows.Forms.DateTimePicker()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblcDocCodigo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBx2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(546, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "҉     Programación Bath - Cuota Ordinaria"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboServicios)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.CboPeriodo)
        Me.GroupBox1.Controls.Add(Me.CboTipoCta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CboServicios
        '
        Me.CboServicios.FormattingEnabled = True
        Me.CboServicios.Location = New System.Drawing.Point(119, 70)
        Me.CboServicios.Name = "CboServicios"
        Me.CboServicios.Size = New System.Drawing.Size(400, 21)
        Me.CboServicios.TabIndex = 1
        Me.CboServicios.Tag = ""
        '
        'CboMes
        '
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(307, 18)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(212, 21)
        Me.CboMes.TabIndex = 0
        Me.CboMes.Tag = ""
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(119, 18)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(118, 21)
        Me.CboPeriodo.TabIndex = 0
        Me.CboPeriodo.Tag = ""
        '
        'CboTipoCta
        '
        Me.CboTipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboTipoCta.Enabled = False
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(119, 45)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(297, 21)
        Me.CboTipoCta.TabIndex = 2
        Me.CboTipoCta.Tag = "nConCodigo=1133"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de Servicio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha de Proceso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodo:"
        '
        'DtpFechaProceso
        '
        Me.DtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaProceso.Location = New System.Drawing.Point(497, 5)
        Me.DtpFechaProceso.Name = "DtpFechaProceso"
        Me.DtpFechaProceso.Size = New System.Drawing.Size(107, 20)
        Me.DtpFechaProceso.TabIndex = 3
        Me.DtpFechaProceso.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(134, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(89, 27)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "  &Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnProgramar
        '
        Me.BtnProgramar.Image = Global.Integration.Test.My.Resources.Resources.update
        Me.BtnProgramar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnProgramar.Location = New System.Drawing.Point(3, 3)
        Me.BtnProgramar.Name = "BtnProgramar"
        Me.BtnProgramar.Size = New System.Drawing.Size(125, 27)
        Me.BtnProgramar.TabIndex = 0
        Me.BtnProgramar.Text = "  &Programar  "
        Me.BtnProgramar.UseVisualStyleBackColor = True
        '
        'GrpBx2
        '
        Me.GrpBx2.Controls.Add(Me.LblcNombre)
        Me.GrpBx2.Controls.Add(Me.TxtNroFind)
        Me.GrpBx2.Controls.Add(Me.DtpFecFallecido)
        Me.GrpBx2.Controls.Add(Me.LblcPerCodigo)
        Me.GrpBx2.Controls.Add(Me.Label7)
        Me.GrpBx2.Controls.Add(Me.Label8)
        Me.GrpBx2.Controls.Add(Me.Label6)
        Me.GrpBx2.Controls.Add(Me.Label9)
        Me.GrpBx2.Location = New System.Drawing.Point(12, 142)
        Me.GrpBx2.Name = "GrpBx2"
        Me.GrpBx2.Size = New System.Drawing.Size(526, 94)
        Me.GrpBx2.TabIndex = 1
        Me.GrpBx2.TabStop = False
        Me.GrpBx2.Text = " Datos de Fallecido: "
        '
        'LblcNombre
        '
        Me.LblcNombre.BackColor = System.Drawing.SystemColors.Info
        Me.LblcNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.Location = New System.Drawing.Point(119, 42)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(400, 20)
        Me.LblcNombre.TabIndex = 2
        Me.LblcNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNroFind
        '
        Me.TxtNroFind.Location = New System.Drawing.Point(119, 19)
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(126, 20)
        Me.TxtNroFind.TabIndex = 0
        '
        'DtpFecFallecido
        '
        Me.DtpFecFallecido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFallecido.Location = New System.Drawing.Point(119, 68)
        Me.DtpFecFallecido.Name = "DtpFecFallecido"
        Me.DtpFecFallecido.Size = New System.Drawing.Size(107, 20)
        Me.DtpFecFallecido.TabIndex = 1
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(430, 19)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(89, 20)
        Me.LblcPerCodigo.TabIndex = 24
        Me.LblcPerCodigo.Text = "0000000001"
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Apellidos y Nombres:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fecha de Fallecimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Nro. Documento:"
        '
        'LblcDocCodigo
        '
        Me.LblcDocCodigo.AutoSize = True
        Me.LblcDocCodigo.Location = New System.Drawing.Point(37, 249)
        Me.LblcDocCodigo.Name = "LblcDocCodigo"
        Me.LblcDocCodigo.Size = New System.Drawing.Size(10, 13)
        Me.LblcDocCodigo.TabIndex = 20
        Me.LblcDocCodigo.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnProgramar)
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Location = New System.Drawing.Point(312, 242)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 33)
        Me.Panel1.TabIndex = 2
        '
        'FormPrcProgramaBathCuotaOrdinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 282)
        Me.Controls.Add(Me.DtpFechaProceso)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpBx2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblcDocCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrcProgramaBathCuotaOrdinaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programación Bath - Cuota Ordinaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBx2.ResumeLayout(False)
        Me.GrpBx2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnProgramar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents CboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFechaProceso As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpBx2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecFallecido As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblcDocCodigo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
