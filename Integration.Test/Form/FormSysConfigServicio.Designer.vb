<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSysConfigServicio
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSysConfigServicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CmdHldr = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CmdNuevo = New C1.Win.C1Command.C1Command()
        Me.C1CmdGrabar = New C1.Win.C1Command.C1Command()
        Me.C1CmdCancel = New C1.Win.C1Command.C1Command()
        Me.C1CmdEdit = New C1.Win.C1Command.C1Command()
        Me.C1CmdDelete = New C1.Win.C1Command.C1Command()
        Me.C1CmdCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.ChBoxEstado = New System.Windows.Forms.CheckBox()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.CboModalidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboPrograma = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboServ = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboTipoCta = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cPerJurCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSisModulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nParCodigo_nProCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nParCodigo_nSolAdmTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSolAdmTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nParCodigo_nCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dSysFecEfctiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCtaCteSerCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSysValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteSerImpDef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSysEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCtaCteTipoCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desc. Servicio:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPerJurCodigo, Me.nSisModulo, Me.nParCodigo_nProCodigo, Me.cProCodigo, Me.nParCodigo_nSolAdmTipo, Me.cSolAdmTipo, Me.nParCodigo_nCtaCteSerCodigo, Me.dSysFecEfctiva, Me.cCtaCteSerCodigo, Me.nSysValor, Me.nCtaCteSerImpDef, Me.nSysEstado, Me.nCtaCteTipoCta})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Table1.Location = New System.Drawing.Point(10, 192)
        Me.Table1.Name = "Table1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Table1.Size = New System.Drawing.Size(478, 188)
        Me.Table1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(497, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "҉     Parametros de configuracion Servicios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CmdHldr
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink6, Me.C1CommandLink5})
        Me.C1ToolBar1.Location = New System.Drawing.Point(1, 29)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(418, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP
        '
        'C1CmdHldr
        '
        Me.C1CmdHldr.Commands.Add(Me.C1CmdNuevo)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdGrabar)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCancel)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdEdit)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdDelete)
        Me.C1CmdHldr.Commands.Add(Me.C1CmdCerrar)
        Me.C1CmdHldr.Owner = Me
        '
        'C1CmdNuevo
        '
        Me.C1CmdNuevo.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.C1CmdNuevo.Name = "C1CmdNuevo"
        Me.C1CmdNuevo.Text = "&Nuevo"
        '
        'C1CmdGrabar
        '
        Me.C1CmdGrabar.Image = Global.Integration.Test.My.Resources.Resources.disk
        Me.C1CmdGrabar.Name = "C1CmdGrabar"
        Me.C1CmdGrabar.Text = "&Grabar"
        '
        'C1CmdCancel
        '
        Me.C1CmdCancel.Image = Global.Integration.Test.My.Resources.Resources.cancel
        Me.C1CmdCancel.Name = "C1CmdCancel"
        Me.C1CmdCancel.Text = "Cancelar"
        '
        'C1CmdEdit
        '
        Me.C1CmdEdit.Image = Global.Integration.Test.My.Resources.Resources._16_em_pencil
        Me.C1CmdEdit.Name = "C1CmdEdit"
        Me.C1CmdEdit.Text = "&Editar"
        Me.C1CmdEdit.Visible = False
        '
        'C1CmdDelete
        '
        Me.C1CmdDelete.Image = Global.Integration.Test.My.Resources.Resources.page_delete
        Me.C1CmdDelete.Name = "C1CmdDelete"
        Me.C1CmdDelete.Text = "Eliminar"
        Me.C1CmdDelete.Visible = False
        '
        'C1CmdCerrar
        '
        Me.C1CmdCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.C1CmdCerrar.Name = "C1CmdCerrar"
        Me.C1CmdCerrar.Text = "&Cerrar"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.C1CmdNuevo
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.C1CmdGrabar
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.C1CmdCancel
        Me.C1CommandLink3.SortOrder = 2
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.C1CmdEdit
        Me.C1CommandLink4.SortOrder = 3
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink6.Command = Me.C1CmdDelete
        Me.C1CommandLink6.SortOrder = 4
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.C1CmdCerrar
        Me.C1CommandLink5.SortOrder = 5
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.ChBoxEstado)
        Me.GrpBox.Controls.Add(Me.TxtImporte)
        Me.GrpBox.Controls.Add(Me.CboModalidad)
        Me.GrpBox.Controls.Add(Me.Label4)
        Me.GrpBox.Controls.Add(Me.CboPrograma)
        Me.GrpBox.Controls.Add(Me.Label2)
        Me.GrpBox.Controls.Add(Me.CboServ)
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Controls.Add(Me.CboTipoCta)
        Me.GrpBox.Controls.Add(Me.Label15)
        Me.GrpBox.Location = New System.Drawing.Point(8, 50)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(482, 139)
        Me.GrpBox.TabIndex = 0
        Me.GrpBox.TabStop = False
        '
        'ChBoxEstado
        '
        Me.ChBoxEstado.BackColor = System.Drawing.Color.DimGray
        Me.ChBoxEstado.ForeColor = System.Drawing.Color.White
        Me.ChBoxEstado.Location = New System.Drawing.Point(316, 111)
        Me.ChBoxEstado.Name = "ChBoxEstado"
        Me.ChBoxEstado.Size = New System.Drawing.Size(70, 21)
        Me.ChBoxEstado.TabIndex = 10
        Me.ChBoxEstado.Text = "Estado"
        Me.ChBoxEstado.UseVisualStyleBackColor = False
        '
        'TxtImporte
        '
        Me.TxtImporte.BackColor = System.Drawing.SystemColors.Info
        Me.TxtImporte.Location = New System.Drawing.Point(95, 112)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(90, 20)
        Me.TxtImporte.TabIndex = 3
        Me.TxtImporte.Text = "0.00"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboModalidad
        '
        Me.CboModalidad.FormattingEnabled = True
        Me.CboModalidad.Location = New System.Drawing.Point(94, 40)
        Me.CboModalidad.Name = "CboModalidad"
        Me.CboModalidad.Size = New System.Drawing.Size(269, 21)
        Me.CboModalidad.TabIndex = 9
        Me.CboModalidad.Tag = "nIntClase=1022;nIntTipo=1000"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Modalidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboPrograma
        '
        Me.CboPrograma.FormattingEnabled = True
        Me.CboPrograma.Location = New System.Drawing.Point(94, 16)
        Me.CboPrograma.Name = "CboPrograma"
        Me.CboPrograma.Size = New System.Drawing.Size(380, 21)
        Me.CboPrograma.TabIndex = 9
        Me.CboPrograma.Tag = "nIntClase=1002;nIntTipo=1000"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo Grupo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboServ
        '
        Me.CboServ.FormattingEnabled = True
        Me.CboServ.Location = New System.Drawing.Point(94, 88)
        Me.CboServ.Name = "CboServ"
        Me.CboServ.Size = New System.Drawing.Size(380, 21)
        Me.CboServ.TabIndex = 9
        Me.CboServ.Tag = "nIntClase=1014;nIntTipo=1000"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Valor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboTipoCta
        '
        Me.CboTipoCta.FormattingEnabled = True
        Me.CboTipoCta.Location = New System.Drawing.Point(94, 64)
        Me.CboTipoCta.Name = "CboTipoCta"
        Me.CboTipoCta.Size = New System.Drawing.Size(269, 21)
        Me.CboTipoCta.TabIndex = 9
        Me.CboTipoCta.Tag = "nConCodigo=1133"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DimGray
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 21)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Tipo Servicio:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cPerJurCodigo
        '
        Me.cPerJurCodigo.DataPropertyName = "cPerJurCodigo"
        Me.cPerJurCodigo.HeaderText = "cPerJurCodigo"
        Me.cPerJurCodigo.Name = "cPerJurCodigo"
        Me.cPerJurCodigo.Visible = False
        '
        'nSisModulo
        '
        Me.nSisModulo.DataPropertyName = "nSisModulo"
        Me.nSisModulo.HeaderText = "nSisModulo"
        Me.nSisModulo.Name = "nSisModulo"
        Me.nSisModulo.Visible = False
        '
        'nParCodigo_nProCodigo
        '
        Me.nParCodigo_nProCodigo.DataPropertyName = "nParCodigo_nProCodigo"
        Me.nParCodigo_nProCodigo.HeaderText = "nParCodigo_nProCodigo"
        Me.nParCodigo_nProCodigo.Name = "nParCodigo_nProCodigo"
        Me.nParCodigo_nProCodigo.Visible = False
        '
        'cProCodigo
        '
        Me.cProCodigo.DataPropertyName = "cProCodigo"
        Me.cProCodigo.HeaderText = "Grupo"
        Me.cProCodigo.Name = "cProCodigo"
        Me.cProCodigo.Width = 160
        '
        'nParCodigo_nSolAdmTipo
        '
        Me.nParCodigo_nSolAdmTipo.DataPropertyName = "nParCodigo_nSolAdmTipo"
        Me.nParCodigo_nSolAdmTipo.HeaderText = "nParCodigo_nSolAdmTipo"
        Me.nParCodigo_nSolAdmTipo.Name = "nParCodigo_nSolAdmTipo"
        Me.nParCodigo_nSolAdmTipo.Visible = False
        '
        'cSolAdmTipo
        '
        Me.cSolAdmTipo.DataPropertyName = "cSolAdmTipo"
        Me.cSolAdmTipo.HeaderText = "Modalidad"
        Me.cSolAdmTipo.Name = "cSolAdmTipo"
        '
        'nParCodigo_nCtaCteSerCodigo
        '
        Me.nParCodigo_nCtaCteSerCodigo.DataPropertyName = "nParCodigo_nCtaCteSerCodigo"
        Me.nParCodigo_nCtaCteSerCodigo.HeaderText = "nParCodigo_nCtaCteSerCodigo"
        Me.nParCodigo_nCtaCteSerCodigo.Name = "nParCodigo_nCtaCteSerCodigo"
        Me.nParCodigo_nCtaCteSerCodigo.Visible = False
        '
        'dSysFecEfctiva
        '
        Me.dSysFecEfctiva.DataPropertyName = "dSysFecEfctiva"
        Me.dSysFecEfctiva.HeaderText = "Fecha Efectiva"
        Me.dSysFecEfctiva.Name = "dSysFecEfctiva"
        Me.dSysFecEfctiva.Width = 120
        '
        'cCtaCteSerCodigo
        '
        Me.cCtaCteSerCodigo.DataPropertyName = "cCtaCteSerCodigo"
        Me.cCtaCteSerCodigo.HeaderText = "Desc. Servicio"
        Me.cCtaCteSerCodigo.Name = "cCtaCteSerCodigo"
        Me.cCtaCteSerCodigo.Width = 310
        '
        'nSysValor
        '
        Me.nSysValor.DataPropertyName = "nSysValor"
        Me.nSysValor.HeaderText = "Valor"
        Me.nSysValor.Name = "nSysValor"
        Me.nSysValor.Width = 90
        '
        'nCtaCteSerImpDef
        '
        Me.nCtaCteSerImpDef.DataPropertyName = "nCtaCteSerImpDef"
        Me.nCtaCteSerImpDef.HeaderText = "Importe Servicio"
        Me.nCtaCteSerImpDef.Name = "nCtaCteSerImpDef"
        Me.nCtaCteSerImpDef.Width = 90
        '
        'nSysEstado
        '
        Me.nSysEstado.DataPropertyName = "nSysEstado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.nSysEstado.DefaultCellStyle = DataGridViewCellStyle2
        Me.nSysEstado.HeaderText = "Estado"
        Me.nSysEstado.Name = "nSysEstado"
        Me.nSysEstado.Width = 40
        '
        'nCtaCteTipoCta
        '
        Me.nCtaCteTipoCta.DataPropertyName = "nCtaCteTipoCta"
        Me.nCtaCteTipoCta.HeaderText = "nCtaCteTipoCta"
        Me.nCtaCteTipoCta.Name = "nCtaCteTipoCta"
        Me.nCtaCteTipoCta.Visible = False
        '
        'FormSysConfigServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 385)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.GrpBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSysConfigServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros de configuracion Servicios"
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CmdHldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CmdHldr As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CmdNuevo As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdGrabar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCancel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdEdit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CmdCerrar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboPrograma As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboServ As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboTipoCta As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChBoxEstado As System.Windows.Forms.CheckBox
    Friend WithEvents C1CmdDelete As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cPerJurCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSisModulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nParCodigo_nProCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nParCodigo_nSolAdmTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSolAdmTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nParCodigo_nCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dSysFecEfctiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCtaCteSerCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSysValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteSerImpDef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSysEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCtaCteTipoCta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
