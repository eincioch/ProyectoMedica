<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptMasterColegiado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRptMasterColegiado))
        Me.GrpBx = New System.Windows.Forms.GroupBox()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFecFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecIni = New System.Windows.Forms.DateTimePicker()
        Me.RdBtnFecCumple = New System.Windows.Forms.RadioButton()
        Me.RdBtnEstado = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExportTxt = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportExcel = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.GrpBx.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBx
        '
        Me.GrpBx.Controls.Add(Me.CboEstado)
        Me.GrpBx.Controls.Add(Me.Label2)
        Me.GrpBx.Controls.Add(Me.Label3)
        Me.GrpBx.Controls.Add(Me.Label1)
        Me.GrpBx.Controls.Add(Me.DTPFecFin)
        Me.GrpBx.Controls.Add(Me.DTPFecIni)
        Me.GrpBx.Controls.Add(Me.RdBtnFecCumple)
        Me.GrpBx.Controls.Add(Me.RdBtnEstado)
        Me.GrpBx.Location = New System.Drawing.Point(12, 33)
        Me.GrpBx.Name = "GrpBx"
        Me.GrpBx.Size = New System.Drawing.Size(620, 69)
        Me.GrpBx.TabIndex = 0
        Me.GrpBx.TabStop = False
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Items.AddRange(New Object() {"Hábiles", "Inhábiles", "Todos"})
        Me.CboEstado.Location = New System.Drawing.Point(101, 39)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(180, 21)
        Me.CboEstado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Condición:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'DTPFecFin
        '
        Me.DTPFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecFin.Location = New System.Drawing.Point(510, 40)
        Me.DTPFecFin.Name = "DTPFecFin"
        Me.DTPFecFin.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecFin.TabIndex = 1
        '
        'DTPFecIni
        '
        Me.DTPFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecIni.Location = New System.Drawing.Point(362, 40)
        Me.DTPFecIni.Name = "DTPFecIni"
        Me.DTPFecIni.Size = New System.Drawing.Size(100, 20)
        Me.DTPFecIni.TabIndex = 1
        '
        'RdBtnFecCumple
        '
        Me.RdBtnFecCumple.AutoSize = True
        Me.RdBtnFecCumple.Location = New System.Drawing.Point(318, 19)
        Me.RdBtnFecCumple.Name = "RdBtnFecCumple"
        Me.RdBtnFecCumple.Size = New System.Drawing.Size(131, 17)
        Me.RdBtnFecCumple.TabIndex = 0
        Me.RdBtnFecCumple.Text = "Fecha de Cumpleaños"
        Me.RdBtnFecCumple.UseVisualStyleBackColor = True
        '
        'RdBtnEstado
        '
        Me.RdBtnEstado.AutoSize = True
        Me.RdBtnEstado.Checked = True
        Me.RdBtnEstado.Location = New System.Drawing.Point(16, 19)
        Me.RdBtnEstado.Name = "RdBtnEstado"
        Me.RdBtnEstado.Size = New System.Drawing.Size(63, 17)
        Me.RdBtnEstado.TabIndex = 0
        Me.RdBtnEstado.TabStop = True
        Me.RdBtnEstado.Text = "Estados"
        Me.RdBtnEstado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(751, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉     Consulta con Colegiados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Location = New System.Drawing.Point(12, 108)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(730, 130)
        Me.Table1.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnExportTxt)
        Me.Panel1.Controls.Add(Me.BtnExportPDF)
        Me.Panel1.Controls.Add(Me.BtnExportExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 40)
        Me.Panel1.TabIndex = 21
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(636, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(103, 29)
        Me.BtnCerrar.TabIndex = 20
        Me.BtnCerrar.Text = " &Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnExportTxt
        '
        Me.BtnExportTxt.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExportTxt.Image = Global.Integration.Test.My.Resources.Resources.file_extension_txt
        Me.BtnExportTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportTxt.Location = New System.Drawing.Point(293, 4)
        Me.BtnExportTxt.Name = "BtnExportTxt"
        Me.BtnExportTxt.Size = New System.Drawing.Size(116, 29)
        Me.BtnExportTxt.TabIndex = 20
        Me.BtnExportTxt.Text = "   Exportar a &TXT"
        Me.BtnExportTxt.UseVisualStyleBackColor = False
        '
        'BtnExportPDF
        '
        Me.BtnExportPDF.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExportPDF.Image = Global.Integration.Test.My.Resources.Resources.file_extension_pdf
        Me.BtnExportPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportPDF.Location = New System.Drawing.Point(11, 4)
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.Size = New System.Drawing.Size(128, 29)
        Me.BtnExportPDF.TabIndex = 20
        Me.BtnExportPDF.Text = "  Exportar a &PDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = False
        '
        'BtnExportExcel
        '
        Me.BtnExportExcel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExportExcel.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportExcel.Location = New System.Drawing.Point(152, 4)
        Me.BtnExportExcel.Name = "BtnExportExcel"
        Me.BtnExportExcel.Size = New System.Drawing.Size(128, 29)
        Me.BtnExportExcel.TabIndex = 20
        Me.BtnExportExcel.Text = "  Exportar a &XLS"
        Me.BtnExportExcel.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.table_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(638, 52)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(104, 36)
        Me.BtnMostrar.TabIndex = 20
        Me.BtnMostrar.Text = "    &Mostrar..."
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'FormRptMasterColegiado
        '
        Me.AcceptButton = Me.BtnMostrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCerrar
        Me.ClientSize = New System.Drawing.Size(751, 283)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpBx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRptMasterColegiado"
        Me.Text = "Consulta con Colegiados"
        Me.GrpBx.ResumeLayout(False)
        Me.GrpBx.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents RdBtnEstado As System.Windows.Forms.RadioButton
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents RdBtnFecCumple As System.Windows.Forms.RadioButton
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnExportTxt As System.Windows.Forms.Button
    Friend WithEvents BtnExportExcel As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
End Class
