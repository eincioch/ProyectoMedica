<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcProgramarServicio
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblCostoServ = New System.Windows.Forms.TextBox()
        Me.CboMoneda = New System.Windows.Forms.ComboBox()
        Me.CboServicios = New System.Windows.Forms.ComboBox()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.LblTC = New System.Windows.Forms.Label()
        Me.LblTPagar = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnProgServ = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(567, 20)
        Me.LblTitulo.TabIndex = 23
        Me.LblTitulo.Text = "҉     Programar Servicio"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Descripcion Servicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Costo Servicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total Importe a Pagar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCostoServ)
        Me.GroupBox1.Controls.Add(Me.CboMoneda)
        Me.GroupBox1.Controls.Add(Me.CboServicios)
        Me.GroupBox1.Controls.Add(Me.CboTipoCta)
        Me.GroupBox1.Controls.Add(Me.LblTC)
        Me.GroupBox1.Controls.Add(Me.LblTPagar)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LblCostoServ
        '
        Me.LblCostoServ.BackColor = System.Drawing.SystemColors.Info
        Me.LblCostoServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblCostoServ.Location = New System.Drawing.Point(124, 85)
        Me.LblCostoServ.Name = "LblCostoServ"
        Me.LblCostoServ.Size = New System.Drawing.Size(103, 21)
        Me.LblCostoServ.TabIndex = 3
        Me.LblCostoServ.Text = "0.00"
        Me.LblCostoServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboMoneda.Enabled = False
        Me.CboMoneda.FormattingEnabled = True
        Me.CboMoneda.Location = New System.Drawing.Point(124, 61)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(146, 21)
        Me.CboMoneda.TabIndex = 2
        Me.CboMoneda.Tag = "nConCodigo=1001"
        '
        'CboServicios
        '
        Me.CboServicios.FormattingEnabled = True
        Me.CboServicios.Location = New System.Drawing.Point(124, 36)
        Me.CboServicios.Name = "CboServicios"
        Me.CboServicios.Size = New System.Drawing.Size(400, 21)
        Me.CboServicios.TabIndex = 1
        Me.CboServicios.Tag = "nConCodigo=1133"
        '
        'CboTipoCta
        '
        Me.CboTipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(124, 13)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(221, 21)
        Me.CboTipoCta.TabIndex = 0
        Me.CboTipoCta.Tag = "nConCodigo=1133"
        '
        'LblTC
        '
        Me.LblTC.BackColor = System.Drawing.SystemColors.Info
        Me.LblTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTC.ForeColor = System.Drawing.Color.Black
        Me.LblTC.Location = New System.Drawing.Point(351, 61)
        Me.LblTC.Name = "LblTC"
        Me.LblTC.Size = New System.Drawing.Size(101, 20)
        Me.LblTC.TabIndex = 118
        Me.LblTC.Text = "0.00"
        Me.LblTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTPagar
        '
        Me.LblTPagar.BackColor = System.Drawing.SystemColors.Info
        Me.LblTPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPagar.ForeColor = System.Drawing.Color.Black
        Me.LblTPagar.Location = New System.Drawing.Point(124, 135)
        Me.LblTPagar.Name = "LblTPagar"
        Me.LblTPagar.Size = New System.Drawing.Size(101, 20)
        Me.LblTPagar.TabIndex = 118
        Me.LblTPagar.Text = "0.00"
        Me.LblTPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(124, 109)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(101, 20)
        Me.TxtCantidad.TabIndex = 4
        Me.TxtCantidad.Text = "1"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Tipo de Servicio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Tipo Cambio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Tipo Moneda:"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel1
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(404, 197)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(142, 40)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "         Cancelar (ESC)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnProgServ
        '
        Me.BtnProgServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProgServ.ForeColor = System.Drawing.Color.Black
        Me.BtnProgServ.Image = Global.Integration.Test.My.Resources.Resources.accept
        Me.BtnProgServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProgServ.Location = New System.Drawing.Point(217, 197)
        Me.BtnProgServ.Name = "BtnProgServ"
        Me.BtnProgServ.Size = New System.Drawing.Size(182, 40)
        Me.BtnProgServ.TabIndex = 1
        Me.BtnProgServ.Text = "          Programar Servicio (F2)"
        Me.BtnProgServ.UseVisualStyleBackColor = True
        '
        'FormPrcProgramarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(567, 244)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnProgServ)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTitulo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FormPrcProgramarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrcProgramarServicio"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnProgServ As System.Windows.Forms.Button
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents CboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblTPagar As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LblTC As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblCostoServ As System.Windows.Forms.TextBox
End Class
