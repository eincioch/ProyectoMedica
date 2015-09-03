<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCrystalReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCrystalReport))
        Me.CrystalRptVwr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalRptVwr
        '
        Me.CrystalRptVwr.ActiveViewIndex = -1
        Me.CrystalRptVwr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalRptVwr.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalRptVwr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalRptVwr.Location = New System.Drawing.Point(0, 0)
        Me.CrystalRptVwr.Name = "CrystalRptVwr"
        Me.CrystalRptVwr.Size = New System.Drawing.Size(365, 249)
        Me.CrystalRptVwr.TabIndex = 0
        '
        'FormCrystalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 249)
        Me.Controls.Add(Me.CrystalRptVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCrystalReport"
        Me.Text = "FormCrystalReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalRptVwr As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
