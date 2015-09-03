<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFiltroServicios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFiltroServicios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CboClase = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtCaracter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.nKey = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIntJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerKeyWord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nMonCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nIntCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBoxCampana = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCampana = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Table1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 323)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Parametros de busqueda"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(51, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(563, 82)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Bisque
        Me.TabPage1.Controls.Add(Me.TxtCodigo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(555, 53)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "por Codigo (F1)"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(101, 14)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(148, 24)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Código"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Bisque
        Me.TabPage3.Controls.Add(Me.CboClase)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(555, 53)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Grupo / Clase (F2)"
        '
        'CboClase
        '
        Me.CboClase.BackColor = System.Drawing.SystemColors.Info
        Me.CboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboClase.FormattingEnabled = True
        Me.CboClase.Location = New System.Drawing.Point(69, 13)
        Me.CboClase.Name = "CboClase"
        Me.CboClase.Size = New System.Drawing.Size(480, 26)
        Me.CboClase.TabIndex = 1
        Me.CboClase.Tag = "nIntClase=1014;nIntTipo=1000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clase"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Bisque
        Me.TabPage2.Controls.Add(Me.TxtCaracter)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(555, 53)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "por Descripción (F3)"
        '
        'TxtCaracter
        '
        Me.TxtCaracter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaracter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaracter.Location = New System.Drawing.Point(100, 12)
        Me.TxtCaracter.Name = "TxtCaracter"
        Me.TxtCaracter.Size = New System.Drawing.Size(449, 24)
        Me.TxtCaracter.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nKey, Me.cPerJurCodigo, Me.nCtaCteSerCodigo, Me.cIntJerarquia, Me.cCtaCteSerJerarquia, Me.cCtaCteSerKeyWord, Me.nMonCodigo, Me.nIntCodigo, Me.nCtaCteSerCosto, Me.nFlag})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Location = New System.Drawing.Point(6, 120)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Table1.Size = New System.Drawing.Size(637, 197)
        Me.Table1.TabIndex = 9
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
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.Visible = False
        Me.cPerJurCodigo.Width = 90
        '
        'nCtaCteSerCodigo
        '
        Me.nCtaCteSerCodigo.DataPropertyName = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.HeaderText = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Name = "nCtaCteSerCodigo"
        Me.nCtaCteSerCodigo.Visible = False
        Me.nCtaCteSerCodigo.Width = 30
        '
        'cIntJerarquia
        '
        Me.cIntJerarquia.DataPropertyName = "cIntJerarquia"
        Me.cIntJerarquia.HeaderText = "cIntJerarquia"
        Me.cIntJerarquia.Name = "cIntJerarquia"
        Me.cIntJerarquia.Visible = False
        '
        'cCtaCteSerJerarquia
        '
        Me.cCtaCteSerJerarquia.DataPropertyName = "cCtaCteSerJerarquia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.cCtaCteSerJerarquia.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCtaCteSerJerarquia.HeaderText = "Cod. Laboratorio"
        Me.cCtaCteSerJerarquia.Name = "cCtaCteSerJerarquia"
        Me.cCtaCteSerJerarquia.ReadOnly = True
        Me.cCtaCteSerJerarquia.Width = 120
        '
        'cCtaCteSerKeyWord
        '
        Me.cCtaCteSerKeyWord.DataPropertyName = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.HeaderText = "Descripción"
        Me.cCtaCteSerKeyWord.Name = "cCtaCteSerKeyWord"
        Me.cCtaCteSerKeyWord.ReadOnly = True
        Me.cCtaCteSerKeyWord.Width = 360
        '
        'nMonCodigo
        '
        Me.nMonCodigo.DataPropertyName = "nMonCodigo"
        Me.nMonCodigo.HeaderText = "nMonCodigo"
        Me.nMonCodigo.Name = "nMonCodigo"
        Me.nMonCodigo.Visible = False
        Me.nMonCodigo.Width = 20
        '
        'nIntCodigo
        '
        Me.nIntCodigo.DataPropertyName = "nIntCodigo"
        Me.nIntCodigo.HeaderText = "nIntCodigo"
        Me.nIntCodigo.Name = "nIntCodigo"
        Me.nIntCodigo.Visible = False
        Me.nIntCodigo.Width = 20
        '
        'nCtaCteSerCosto
        '
        Me.nCtaCteSerCosto.DataPropertyName = "nCtaCteSerCosto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.nCtaCteSerCosto.DefaultCellStyle = DataGridViewCellStyle3
        Me.nCtaCteSerCosto.HeaderText = "Precio"
        Me.nCtaCteSerCosto.Name = "nCtaCteSerCosto"
        Me.nCtaCteSerCosto.ReadOnly = True
        '
        'nFlag
        '
        Me.nFlag.DataPropertyName = "nFlag"
        Me.nFlag.HeaderText = "nFlag"
        Me.nFlag.Name = "nFlag"
        Me.nFlag.Visible = False
        '
        'LstBoxCampana
        '
        Me.LstBoxCampana.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LstBoxCampana.Enabled = False
        Me.LstBoxCampana.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LstBoxCampana.ForeColor = System.Drawing.Color.Blue
        Me.LstBoxCampana.FormattingEnabled = True
        Me.LstBoxCampana.ItemHeight = 17
        Me.LstBoxCampana.Location = New System.Drawing.Point(677, 40)
        Me.LstBoxCampana.Name = "LstBoxCampana"
        Me.LstBoxCampana.Size = New System.Drawing.Size(218, 276)
        Me.LstBoxCampana.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(696, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Campaña Vigente(s) *"
        '
        'CboCampana
        '
        Me.CboCampana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboCampana.FormattingEnabled = True
        Me.CboCampana.Location = New System.Drawing.Point(250, 332)
        Me.CboCampana.Name = "CboCampana"
        Me.CboCampana.Size = New System.Drawing.Size(61, 46)
        Me.CboCampana.TabIndex = 14
        Me.CboCampana.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(60, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Marque la fila(s) por favor."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Integration.Test.My.Resources.Resources.CheckButtons_32x32
        Me.PictureBox1.Location = New System.Drawing.Point(23, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Integration.Test.My.Resources.Resources.cancel1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(524, 332)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(135, 39)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "        &Cancelar (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = Global.Integration.Test.My.Resources.Resources.accept
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(383, 332)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(135, 39)
        Me.BtnSeleccionar.TabIndex = 0
        Me.BtnSeleccionar.Text = "          &Agregar (INS)"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Integration.Test.My.Resources.Resources.medica
        Me.PictureBox2.Location = New System.Drawing.Point(7, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'FormFiltroServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(674, 383)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstBoxCampana)
        Me.Controls.Add(Me.CboCampana)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormFiltroServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboClase As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCaracter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents LstBoxCampana As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CboCampana As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents nKey As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIntJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteSerJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteSerKeyWord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nMonCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nIntCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
