<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSQLEstadoCuenta_for_Colegiado
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSQLEstadoCuenta_for_Colegiado))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblcNombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblcPerCodigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.cPerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPerIdeNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApeNomb_RSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dCtaCteFecVence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dCtaCteFecCorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpDeuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2 = New System.Windows.Forms.DataGridView()
        Me.nPrdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dCtaCteFecRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dCtaCteFecVence1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntDescripcion1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeudaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fMontoSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRegPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCaptionGrd = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportExcel = New System.Windows.Forms.Button()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Size = New System.Drawing.Size(745, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "҉     Consultar Estado Cuenta por Colegiado "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblcNombre
        '
        Me.LblcNombre.BackColor = System.Drawing.SystemColors.Info
        Me.LblcNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcNombre.Location = New System.Drawing.Point(122, 42)
        Me.LblcNombre.Name = "LblcNombre"
        Me.LblcNombre.Size = New System.Drawing.Size(579, 20)
        Me.LblcNombre.TabIndex = 23
        Me.LblcNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellidos y Nombres:"
        '
        'TxtNroFind
        '
        Me.TxtNroFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroFind.Location = New System.Drawing.Point(122, 19)
        Me.TxtNroFind.Name = "TxtNroFind"
        Me.TxtNroFind.Size = New System.Drawing.Size(126, 21)
        Me.TxtNroFind.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cod. Colegiado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblcPerCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNroFind)
        Me.GroupBox1.Controls.Add(Me.LblcNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 76)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'LblcPerCodigo
        '
        Me.LblcPerCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.LblcPerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblcPerCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblcPerCodigo.Location = New System.Drawing.Point(607, 19)
        Me.LblcPerCodigo.Name = "LblcPerCodigo"
        Me.LblcPerCodigo.Size = New System.Drawing.Size(94, 20)
        Me.LblcPerCodigo.TabIndex = 25
        Me.LblcPerCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Codigo Interno:"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerCodigo, Me.cPerIdeNumero, Me.ApeNomb_RSocial, Me.nCtaCteSerCodigo, Me.cIntDescripcion, Me.dCtaCteFecVence, Me.dCtaCteFecCorte, Me.ImpDeuda, Me.Estado})
        Me.Table1.Location = New System.Drawing.Point(11, 109)
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.Size = New System.Drawing.Size(728, 86)
        Me.Table1.TabIndex = 25
        '
        'cPerCodigo
        '
        Me.cPerCodigo.DataPropertyName = "cPerCodigo"
        Me.cPerCodigo.HeaderText = "cPerCodigo"
        Me.cPerCodigo.Name = "cPerCodigo"
        Me.cPerCodigo.ReadOnly = True
        Me.cPerCodigo.Visible = False
        '
        'cPerIdeNumero
        '
        Me.cPerIdeNumero.DataPropertyName = "cPerIdeNumero"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cPerIdeNumero.DefaultCellStyle = DataGridViewCellStyle1
        Me.cPerIdeNumero.HeaderText = "Código Colegiado"
        Me.cPerIdeNumero.Name = "cPerIdeNumero"
        Me.cPerIdeNumero.ReadOnly = True
        Me.cPerIdeNumero.Width = 70
        '
        'ApeNomb_RSocial
        '
        Me.ApeNomb_RSocial.DataPropertyName = "ApeNomb_RSocial"
        Me.ApeNomb_RSocial.HeaderText = "Apellido(s) y Nombres"
        Me.ApeNomb_RSocial.Name = "ApeNomb_RSocial"
        Me.ApeNomb_RSocial.ReadOnly = True
        Me.ApeNomb_RSocial.Width = 290
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.ReadOnly = True
        Me.nCtaCteSerCodigo.Visible = False
        '
        'cIntDescripcion
        '
        Me.cIntDescripcion.DataPropertyName = "cIntDescripcion"
        Me.cIntDescripcion.HeaderText = "Servicio"
        Me.cIntDescripcion.Name = "cIntDescripcion"
        Me.cIntDescripcion.ReadOnly = True
        Me.cIntDescripcion.Width = 170
        '
        'dCtaCteFecVence
        '
        Me.dCtaCteFecVence.DataPropertyName = "dCtaCteFecVence"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dCtaCteFecVence.DefaultCellStyle = DataGridViewCellStyle2
        Me.dCtaCteFecVence.HeaderText = "Fecha último vencimiento"
        Me.dCtaCteFecVence.Name = "dCtaCteFecVence"
        Me.dCtaCteFecVence.ReadOnly = True
        Me.dCtaCteFecVence.Width = 80
        '
        'dCtaCteFecCorte
        '
        Me.dCtaCteFecCorte.DataPropertyName = "dCtaCteFecCorte"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Format = "d"
        Me.dCtaCteFecCorte.DefaultCellStyle = DataGridViewCellStyle3
        Me.dCtaCteFecCorte.HeaderText = "Fecha Corte ↓"
        Me.dCtaCteFecCorte.Name = "dCtaCteFecCorte"
        Me.dCtaCteFecCorte.ReadOnly = True
        Me.dCtaCteFecCorte.Width = 75
        '
        'ImpDeuda
        '
        Me.ImpDeuda.DataPropertyName = "ImpDeuda"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ImpDeuda.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImpDeuda.HeaderText = "Importe Total Deuda"
        Me.ImpDeuda.Name = "ImpDeuda"
        Me.ImpDeuda.ReadOnly = True
        Me.ImpDeuda.Width = 70
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Estado.DefaultCellStyle = DataGridViewCellStyle5
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 80
        '
        'Table2
        '
        Me.Table2.AllowUserToAddRows = False
        Me.Table2.AllowUserToDeleteRows = False
        Me.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nPrdCodigo, Me.nYear, Me.cCtaCteRecibo, Me.dCtaCteFecRegistro, Me.dCtaCteFecVence1, Me.nCtaCteEstado, Me.nCtaCteSerCodigo1, Me.cIntDescripcion1, Me.DeudaTotal, Me.fMontoSaldo, Me.NroCaja, Me.FechaPago, Me.TipoDocu, Me.NroComprobante, Me.ImpPago, Me.UserRegPago})
        Me.Table2.Location = New System.Drawing.Point(11, 218)
        Me.Table2.Name = "Table2"
        Me.Table2.ReadOnly = True
        Me.Table2.Size = New System.Drawing.Size(728, 150)
        Me.Table2.TabIndex = 26
        '
        'nPrdCodigo
        '
        Me.nPrdCodigo.DataPropertyName = "nPrdCodigo"
        Me.nPrdCodigo.HeaderText = "nPrdCodigo"
        Me.nPrdCodigo.Name = "nPrdCodigo"
        Me.nPrdCodigo.ReadOnly = True
        Me.nPrdCodigo.Visible = False
        '
        'nYear
        '
        Me.nYear.DataPropertyName = "nYear"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.nYear.DefaultCellStyle = DataGridViewCellStyle6
        Me.nYear.HeaderText = "Año"
        Me.nYear.Name = "nYear"
        Me.nYear.ReadOnly = True
        Me.nYear.Width = 50
        '
        'cCtaCteRecibo
        '
        Me.cCtaCteRecibo.DataPropertyName = "cCtaCteRecibo"
        Me.cCtaCteRecibo.HeaderText = "cCtaCteRecibo"
        Me.cCtaCteRecibo.Name = "cCtaCteRecibo"
        Me.cCtaCteRecibo.ReadOnly = True
        Me.cCtaCteRecibo.Visible = False
        '
        'dCtaCteFecRegistro
        '
        Me.dCtaCteFecRegistro.DataPropertyName = "dCtaCteFecRegistro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.Format = "d"
        Me.dCtaCteFecRegistro.DefaultCellStyle = DataGridViewCellStyle7
        Me.dCtaCteFecRegistro.HeaderText = "Fecha Registro Recibo"
        Me.dCtaCteFecRegistro.Name = "dCtaCteFecRegistro"
        Me.dCtaCteFecRegistro.ReadOnly = True
        Me.dCtaCteFecRegistro.Width = 80
        '
        'dCtaCteFecVence1
        '
        Me.dCtaCteFecVence1.DataPropertyName = "dCtaCteFecVence"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Format = "d"
        Me.dCtaCteFecVence1.DefaultCellStyle = DataGridViewCellStyle8
        Me.dCtaCteFecVence1.HeaderText = "Fecha Vencimiento Recibo"
        Me.dCtaCteFecVence1.Name = "dCtaCteFecVence1"
        Me.dCtaCteFecVence1.ReadOnly = True
        Me.dCtaCteFecVence1.Width = 80
        '
        'nCtaCteEstado
        '
        Me.nCtaCteEstado.DataPropertyName = "nCtaCteEstado"
        Me.nCtaCteEstado.HeaderText = "nCtaCteEstado"
        Me.nCtaCteEstado.Name = "nCtaCteEstado"
        Me.nCtaCteEstado.ReadOnly = True
        Me.nCtaCteEstado.Visible = False
        '
        'nCtaCteSerCodigo1
        '
        Me.nCtaCteSerCodigo1.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo1.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo1.Name = "nCtaCteSerCodigo1"
        Me.nCtaCteSerCodigo1.ReadOnly = True
        Me.nCtaCteSerCodigo1.Visible = False
        '
        'cIntDescripcion1
        '
        Me.cIntDescripcion1.DataPropertyName = "cIntDescripcion"
        Me.cIntDescripcion1.HeaderText = "Servicio"
        Me.cIntDescripcion1.Name = "cIntDescripcion1"
        Me.cIntDescripcion1.ReadOnly = True
        Me.cIntDescripcion1.Width = 170
        '
        'DeudaTotal
        '
        Me.DeudaTotal.DataPropertyName = "DeudaTotal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N2"
        Me.DeudaTotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.DeudaTotal.HeaderText = "Importe Deuda"
        Me.DeudaTotal.Name = "DeudaTotal"
        Me.DeudaTotal.ReadOnly = True
        Me.DeudaTotal.Width = 75
        '
        'fMontoSaldo
        '
        Me.fMontoSaldo.DataPropertyName = "fMontoSaldo"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N2"
        Me.fMontoSaldo.DefaultCellStyle = DataGridViewCellStyle10
        Me.fMontoSaldo.HeaderText = "Saldo"
        Me.fMontoSaldo.Name = "fMontoSaldo"
        Me.fMontoSaldo.ReadOnly = True
        Me.fMontoSaldo.Width = 75
        '
        'NroCaja
        '
        Me.NroCaja.DataPropertyName = "NroCaja"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NroCaja.DefaultCellStyle = DataGridViewCellStyle11
        Me.NroCaja.HeaderText = "Nro. Caja"
        Me.NroCaja.Name = "NroCaja"
        Me.NroCaja.ReadOnly = True
        Me.NroCaja.Width = 50
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaPago"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle12.Format = "d"
        Me.FechaPago.DefaultCellStyle = DataGridViewCellStyle12
        Me.FechaPago.HeaderText = "FechaPago"
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 75
        '
        'TipoDocu
        '
        Me.TipoDocu.DataPropertyName = "TipoDocu"
        Me.TipoDocu.HeaderText = "TipoDocu"
        Me.TipoDocu.Name = "TipoDocu"
        Me.TipoDocu.ReadOnly = True
        Me.TipoDocu.Visible = False
        '
        'NroComprobante
        '
        Me.NroComprobante.DataPropertyName = "NroComprobante"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NroComprobante.DefaultCellStyle = DataGridViewCellStyle13
        Me.NroComprobante.HeaderText = "Nro. Comprobante Pago"
        Me.NroComprobante.Name = "NroComprobante"
        Me.NroComprobante.ReadOnly = True
        Me.NroComprobante.Width = 80
        '
        'ImpPago
        '
        Me.ImpPago.DataPropertyName = "ImpPago"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle14.Format = "N2"
        Me.ImpPago.DefaultCellStyle = DataGridViewCellStyle14
        Me.ImpPago.HeaderText = "Importe Pago"
        Me.ImpPago.Name = "ImpPago"
        Me.ImpPago.ReadOnly = True
        Me.ImpPago.Width = 75
        '
        'UserRegPago
        '
        Me.UserRegPago.DataPropertyName = "UserRegPago"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.UserRegPago.DefaultCellStyle = DataGridViewCellStyle15
        Me.UserRegPago.HeaderText = "Realizo Operación"
        Me.UserRegPago.Name = "UserRegPago"
        Me.UserRegPago.ReadOnly = True
        Me.UserRegPago.Width = 90
        '
        'LblCaptionGrd
        '
        Me.LblCaptionGrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCaptionGrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaptionGrd.ForeColor = System.Drawing.Color.White
        Me.LblCaptionGrd.Location = New System.Drawing.Point(11, 199)
        Me.LblCaptionGrd.Name = "LblCaptionGrd"
        Me.LblCaptionGrd.Size = New System.Drawing.Size(728, 19)
        Me.LblCaptionGrd.TabIndex = 28
        Me.LblCaptionGrd.Text = "Estado Cuenta - Detallado ↓"
        Me.LblCaptionGrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnExportPDF)
        Me.Panel1.Controls.Add(Me.BtnExportExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 40)
        Me.Panel1.TabIndex = 29
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
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(804, 40)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(0, 25)
        Me.LblEstado.TabIndex = 30
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServicio.Location = New System.Drawing.Point(804, 72)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(0, 19)
        Me.LblServicio.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(755, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(750, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Servicio:"
        '
        'FormSQLEstadoCuenta_for_Colegiado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 416)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblCaptionGrd)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSQLEstadoCuenta_for_Colegiado"
        Me.Text = "Consultar Estado Cuenta por Colegiado "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblcNombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNroFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents Table2 As System.Windows.Forms.DataGridView
    Private WithEvents LblCaptionGrd As System.Windows.Forms.Label
    Friend WithEvents LblcPerCodigo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cPerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPerIdeNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApeNomb_RSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dCtaCteFecVence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dCtaCteFecCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpDeuda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents BtnExportExcel As System.Windows.Forms.Button
    Friend WithEvents nPrdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dCtaCteFecRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dCtaCteFecVence1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCodigo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntDescripcion1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeudaTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fMontoSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserRegPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblServicio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
