<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiagnosticoCIE10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiagnosticoCIE10))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboSubClase = New System.Windows.Forms.ComboBox()
        Me.CboClase = New System.Windows.Forms.ComboBox()
        Me.CboTitulo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtcDiagDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtcDiagCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nKey = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cDiagCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDiagDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 120)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CboSubClase)
        Me.TabPage1.Controls.Add(Me.CboClase)
        Me.TabPage1.Controls.Add(Me.CboTitulo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(575, 91)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Por Capítulos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sub. Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Clase"
        '
        'CboSubClase
        '
        Me.CboSubClase.BackColor = System.Drawing.SystemColors.Info
        Me.CboSubClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CboSubClase.FormattingEnabled = True
        Me.CboSubClase.Location = New System.Drawing.Point(78, 65)
        Me.CboSubClase.Name = "CboSubClase"
        Me.CboSubClase.Size = New System.Drawing.Size(491, 23)
        Me.CboSubClase.TabIndex = 3
        '
        'CboClase
        '
        Me.CboClase.BackColor = System.Drawing.SystemColors.Info
        Me.CboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CboClase.FormattingEnabled = True
        Me.CboClase.Location = New System.Drawing.Point(78, 38)
        Me.CboClase.Name = "CboClase"
        Me.CboClase.Size = New System.Drawing.Size(491, 23)
        Me.CboClase.TabIndex = 2
        '
        'CboTitulo
        '
        Me.CboTitulo.BackColor = System.Drawing.SystemColors.Info
        Me.CboTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CboTitulo.FormattingEnabled = True
        Me.CboTitulo.Location = New System.Drawing.Point(78, 11)
        Me.CboTitulo.Name = "CboTitulo"
        Me.CboTitulo.Size = New System.Drawing.Size(491, 23)
        Me.CboTitulo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage2.Controls.Add(Me.TxtcDiagDescripcion)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(575, 91)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Por Texto"
        '
        'TxtcDiagDescripcion
        '
        Me.TxtcDiagDescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.TxtcDiagDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtcDiagDescripcion.Location = New System.Drawing.Point(94, 28)
        Me.TxtcDiagDescripcion.Name = "TxtcDiagDescripcion"
        Me.TxtcDiagDescripcion.Size = New System.Drawing.Size(475, 21)
        Me.TxtcDiagDescripcion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Descripción"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage3.Controls.Add(Me.TxtcDiagCodigo)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(575, 91)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Por Codigo"
        '
        'TxtcDiagCodigo
        '
        Me.TxtcDiagCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtcDiagCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtcDiagCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtcDiagCodigo.Location = New System.Drawing.Point(84, 37)
        Me.TxtcDiagCodigo.Name = "TxtcDiagCodigo"
        Me.TxtcDiagCodigo.Size = New System.Drawing.Size(113, 21)
        Me.TxtcDiagCodigo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Código"
        '
        'Table1
        '
        Me.Table1.AllowUserToAddRows = False
        Me.Table1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nKey, Me.cDiagCodigo, Me.cDiagDescripcion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Table1.Location = New System.Drawing.Point(16, 157)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Table1.Size = New System.Drawing.Size(575, 189)
        Me.Table1.TabIndex = 10
        '
        'nKey
        '
        Me.nKey.DataPropertyName = "nKey"
        Me.nKey.FalseValue = "0"
        Me.nKey.HeaderText = "?"
        Me.nKey.IndeterminateValue = "0"
        Me.nKey.Name = "nKey"
        Me.nKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nKey.TrueValue = "1"
        Me.nKey.Width = 30
        '
        'cDiagCodigo
        '
        Me.cDiagCodigo.DataPropertyName = "cDiagCodigo"
        Me.cDiagCodigo.HeaderText = "Código"
        Me.cDiagCodigo.Name = "cDiagCodigo"
        Me.cDiagCodigo.ReadOnly = True
        Me.cDiagCodigo.Width = 60
        '
        'cDiagDescripcion
        '
        Me.cDiagDescripcion.DataPropertyName = "cDiagDescripcion"
        Me.cDiagDescripcion.HeaderText = "Descripción"
        Me.cDiagDescripcion.Name = "cDiagDescripcion"
        Me.cDiagDescripcion.ReadOnly = True
        Me.cDiagDescripcion.Width = 460
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(605, 28)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "҉     Clasificación internacional de enfermedades  - CIE-v10"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.CheckButtons_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(33, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(469, 352)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(116, 25)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "        &Cancelar (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = Global.Integration.Test.My.Resources.Resources.check_icon
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(347, 352)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(116, 25)
        Me.BtnSeleccionar.TabIndex = 11
        Me.BtnSeleccionar.Text = "    &Agregar (INS)"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(70, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Marque la fila(s) por favor."
        '
        'FormDiagnosticoCIE10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(605, 389)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormDiagnosticoCIE10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clasificación internacional de enfermedades  - CIE-v10"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboSubClase As System.Windows.Forms.ComboBox
    Friend WithEvents CboClase As System.Windows.Forms.ComboBox
    Friend WithEvents CboTitulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtcDiagDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TxtcDiagCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nKey As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cDiagCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDiagDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
