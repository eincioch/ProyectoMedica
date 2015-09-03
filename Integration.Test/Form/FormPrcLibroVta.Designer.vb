<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrcLibroVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrcLibroVta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboAnno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecVence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipDocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroDocumentoIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Miembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacExportado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGrabado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotExonerado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inafectas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoSC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIArroz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IArroz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otroImp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCtePagImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECoriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodocMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Srie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCModi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoOpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnExportTxt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExportTxt)
        Me.GroupBox1.Controls.Add(Me.BtnCerrar)
        Me.GroupBox1.Controls.Add(Me.BtnExport)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CboAnno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(740, 11)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(72, 28)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "   &Cerrar "
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExport.Location = New System.Drawing.Point(493, 11)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(130, 28)
        Me.BtnExport.TabIndex = 2
        Me.BtnExport.Text = " &Exportar a XLS"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Image = Global.Integration.Test.My.Resources.Resources.zoom_refresh
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(403, 11)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(84, 28)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = " &Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'CboMes
        '
        Me.CboMes.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CboMes.Location = New System.Drawing.Point(196, 16)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(201, 21)
        Me.CboMes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mes:"
        '
        'CboAnno
        '
        Me.CboAnno.FormattingEnabled = True
        Me.CboAnno.Location = New System.Drawing.Point(56, 16)
        Me.CboAnno.Name = "CboAnno"
        Me.CboAnno.Size = New System.Drawing.Size(98, 21)
        Me.CboAnno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(830, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "҉     Libro Ventas Electronico"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Periodo, Me.Correlativo, Me.FecEmision, Me.FecVence, Me.TipoDocComp, Me.SerieComprobante, Me.NumeroComprobante, Me.Col8, Me.TipDocumentoIdentidad, Me.nroDocumentoIdentidad, Me.Miembro, Me.FacExportado, Me.IGrabado, Me.TotExonerado, Me.inafectas, Me.ImpuestoSC, Me.IGV, Me.BIArroz, Me.IArroz, Me.otroImp, Me.nCtaCtePagImporte, Me.TC, Me.FECoriginal, Me.ImpCOriginal, Me.tipodocMod, Me.Srie, Me.NumeroCModi, Me.tipoOpe})
        Me.Table1.Location = New System.Drawing.Point(9, 84)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(810, 234)
        Me.Table1.TabIndex = 19
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "Periodo"
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        '
        'Correlativo
        '
        Me.Correlativo.DataPropertyName = "Correlativo"
        Me.Correlativo.HeaderText = "Correlativo"
        Me.Correlativo.Name = "Correlativo"
        Me.Correlativo.ReadOnly = True
        Me.Correlativo.Width = 110
        '
        'FecEmision
        '
        Me.FecEmision.DataPropertyName = "FecEmision"
        Me.FecEmision.HeaderText = "FecEmision"
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.ReadOnly = True
        '
        'FecVence
        '
        Me.FecVence.DataPropertyName = "FecVence"
        Me.FecVence.HeaderText = "FecVence"
        Me.FecVence.Name = "FecVence"
        Me.FecVence.ReadOnly = True
        '
        'TipoDocComp
        '
        Me.TipoDocComp.DataPropertyName = "TipoDocComp"
        Me.TipoDocComp.HeaderText = "TipoDocComp"
        Me.TipoDocComp.Name = "TipoDocComp"
        Me.TipoDocComp.ReadOnly = True
        '
        'SerieComprobante
        '
        Me.SerieComprobante.DataPropertyName = "SerieComprobante"
        Me.SerieComprobante.HeaderText = "Serie Comprobante"
        Me.SerieComprobante.Name = "SerieComprobante"
        Me.SerieComprobante.ReadOnly = True
        Me.SerieComprobante.Width = 90
        '
        'NumeroComprobante
        '
        Me.NumeroComprobante.DataPropertyName = "NumeroComprobante"
        Me.NumeroComprobante.HeaderText = "Numero Comprobante"
        Me.NumeroComprobante.Name = "NumeroComprobante"
        Me.NumeroComprobante.ReadOnly = True
        Me.NumeroComprobante.Width = 110
        '
        'Col8
        '
        Me.Col8.DataPropertyName = "Col8"
        Me.Col8.HeaderText = "Col8"
        Me.Col8.Name = "Col8"
        Me.Col8.ReadOnly = True
        '
        'TipDocumentoIdentidad
        '
        Me.TipDocumentoIdentidad.DataPropertyName = "TipDocumentoIdentidad"
        Me.TipDocumentoIdentidad.HeaderText = "Tipo Documento Identidad"
        Me.TipDocumentoIdentidad.Name = "TipDocumentoIdentidad"
        Me.TipDocumentoIdentidad.ReadOnly = True
        '
        'nroDocumentoIdentidad
        '
        Me.nroDocumentoIdentidad.DataPropertyName = "nroDocumentoIdentidad"
        Me.nroDocumentoIdentidad.HeaderText = "nroDocumentoIdentidad"
        Me.nroDocumentoIdentidad.Name = "nroDocumentoIdentidad"
        Me.nroDocumentoIdentidad.ReadOnly = True
        '
        'Miembro
        '
        Me.Miembro.DataPropertyName = "Miembro"
        Me.Miembro.HeaderText = "Miembro"
        Me.Miembro.Name = "Miembro"
        Me.Miembro.ReadOnly = True
        '
        'FacExportado
        '
        Me.FacExportado.DataPropertyName = "FacExportado"
        Me.FacExportado.HeaderText = "FacExportado"
        Me.FacExportado.Name = "FacExportado"
        Me.FacExportado.ReadOnly = True
        '
        'IGrabado
        '
        Me.IGrabado.DataPropertyName = "IGrabado"
        Me.IGrabado.HeaderText = "IGrabado"
        Me.IGrabado.Name = "IGrabado"
        Me.IGrabado.ReadOnly = True
        '
        'TotExonerado
        '
        Me.TotExonerado.DataPropertyName = "TotExonerado"
        Me.TotExonerado.HeaderText = "TotExonerado"
        Me.TotExonerado.Name = "TotExonerado"
        Me.TotExonerado.ReadOnly = True
        '
        'inafectas
        '
        Me.inafectas.DataPropertyName = "inafectas"
        Me.inafectas.HeaderText = "inafectas"
        Me.inafectas.Name = "inafectas"
        Me.inafectas.ReadOnly = True
        '
        'ImpuestoSC
        '
        Me.ImpuestoSC.DataPropertyName = "ImpuestoSC"
        Me.ImpuestoSC.HeaderText = "ImpuestoSC"
        Me.ImpuestoSC.Name = "ImpuestoSC"
        Me.ImpuestoSC.ReadOnly = True
        '
        'IGV
        '
        Me.IGV.DataPropertyName = "IGV"
        Me.IGV.HeaderText = "IGV"
        Me.IGV.Name = "IGV"
        Me.IGV.ReadOnly = True
        '
        'BIArroz
        '
        Me.BIArroz.DataPropertyName = "BIArroz"
        Me.BIArroz.HeaderText = "BIArroz"
        Me.BIArroz.Name = "BIArroz"
        Me.BIArroz.ReadOnly = True
        '
        'IArroz
        '
        Me.IArroz.DataPropertyName = "IArroz"
        Me.IArroz.HeaderText = "IArroz"
        Me.IArroz.Name = "IArroz"
        Me.IArroz.ReadOnly = True
        '
        'otroImp
        '
        Me.otroImp.DataPropertyName = "otroImp"
        Me.otroImp.HeaderText = "otroImp"
        Me.otroImp.Name = "otroImp"
        Me.otroImp.ReadOnly = True
        '
        'nCtaCtePagImporte
        '
        Me.nCtaCtePagImporte.DataPropertyName = "nCtaCtePagImporte"
        Me.nCtaCtePagImporte.HeaderText = "nCtaCtePagImporte"
        Me.nCtaCtePagImporte.Name = "nCtaCtePagImporte"
        Me.nCtaCtePagImporte.ReadOnly = True
        '
        'TC
        '
        Me.TC.DataPropertyName = "TC"
        Me.TC.HeaderText = "TC"
        Me.TC.Name = "TC"
        Me.TC.ReadOnly = True
        '
        'FECoriginal
        '
        Me.FECoriginal.DataPropertyName = "FECoriginal"
        Me.FECoriginal.HeaderText = "FECoriginal"
        Me.FECoriginal.Name = "FECoriginal"
        Me.FECoriginal.ReadOnly = True
        '
        'ImpCOriginal
        '
        Me.ImpCOriginal.DataPropertyName = "ImpCOriginal"
        Me.ImpCOriginal.HeaderText = "ImpCOriginal"
        Me.ImpCOriginal.Name = "ImpCOriginal"
        Me.ImpCOriginal.ReadOnly = True
        '
        'tipodocMod
        '
        Me.tipodocMod.DataPropertyName = "tipodocMod"
        Me.tipodocMod.HeaderText = "tipodocMod"
        Me.tipodocMod.Name = "tipodocMod"
        Me.tipodocMod.ReadOnly = True
        '
        'Srie
        '
        Me.Srie.DataPropertyName = "Srie"
        Me.Srie.HeaderText = "Srie"
        Me.Srie.Name = "Srie"
        Me.Srie.ReadOnly = True
        '
        'NumeroCModi
        '
        Me.NumeroCModi.DataPropertyName = "NumeroCModi"
        Me.NumeroCModi.HeaderText = "NumeroCModi"
        Me.NumeroCModi.Name = "NumeroCModi"
        Me.NumeroCModi.ReadOnly = True
        '
        'tipoOpe
        '
        Me.tipoOpe.DataPropertyName = "tipoOpe"
        Me.tipoOpe.HeaderText = "tipoOpe"
        Me.tipoOpe.Name = "tipoOpe"
        Me.tipoOpe.ReadOnly = True
        '
        'BtnExportTxt
        '
        Me.BtnExportTxt.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExportTxt.Image = Global.Integration.Test.My.Resources.Resources.file_extension_txt
        Me.BtnExportTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportTxt.Location = New System.Drawing.Point(629, 11)
        Me.BtnExportTxt.Name = "BtnExportTxt"
        Me.BtnExportTxt.Size = New System.Drawing.Size(105, 28)
        Me.BtnExportTxt.TabIndex = 21
        Me.BtnExportTxt.Text = "   Exportar a &TXT"
        Me.BtnExportTxt.UseVisualStyleBackColor = False
        '
        'FormPrcLibroVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 326)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrcLibroVta"
        Me.Text = "Libro Ventas Electronico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecEmision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecVence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipDocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroDocumentoIdentidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Miembro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacExportado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGrabado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotExonerado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inafectas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoSC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BIArroz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IArroz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents otroImp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCtePagImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECoriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpCOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipodocMod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroCModi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoOpe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnExportTxt As System.Windows.Forms.Button
End Class
