<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUbigeo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboDst = New System.Windows.Forms.ComboBox()
        Me.CboPrv = New System.Windows.Forms.ComboBox()
        Me.CboDpto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSelecciona = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboDst)
        Me.GroupBox1.Controls.Add(Me.CboPrv)
        Me.GroupBox1.Controls.Add(Me.CboDpto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CboDst
        '
        Me.CboDst.FormattingEnabled = True
        Me.CboDst.Location = New System.Drawing.Point(94, 73)
        Me.CboDst.Name = "CboDst"
        Me.CboDst.Size = New System.Drawing.Size(218, 21)
        Me.CboDst.TabIndex = 2
        '
        'CboPrv
        '
        Me.CboPrv.FormattingEnabled = True
        Me.CboPrv.Location = New System.Drawing.Point(94, 46)
        Me.CboPrv.Name = "CboPrv"
        Me.CboPrv.Size = New System.Drawing.Size(218, 21)
        Me.CboPrv.TabIndex = 1
        '
        'CboDpto
        '
        Me.CboDpto.FormattingEnabled = True
        Me.CboDpto.Location = New System.Drawing.Point(94, 19)
        Me.CboDpto.Name = "CboDpto"
        Me.CboDpto.Size = New System.Drawing.Size(218, 21)
        Me.CboDpto.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Distrito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento:"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Image = Global.Integration.Test.My.Resources.Resources._16_em_cross
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(247, 117)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(77, 27)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSelecciona
        '
        Me.BtnSelecciona.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnSelecciona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelecciona.Location = New System.Drawing.Point(149, 117)
        Me.BtnSelecciona.Name = "BtnSelecciona"
        Me.BtnSelecciona.Size = New System.Drawing.Size(97, 27)
        Me.BtnSelecciona.TabIndex = 3
        Me.BtnSelecciona.Text = "Seleccionar.."
        Me.BtnSelecciona.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelecciona.UseVisualStyleBackColor = True
        '
        'FormUbigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(347, 152)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSelecciona)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUbigeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Ubigeo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSelecciona As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CboDst As System.Windows.Forms.ComboBox
    Friend WithEvents CboPrv As System.Windows.Forms.ComboBox
    Friend WithEvents CboDpto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
