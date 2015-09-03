<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMDI))
        Me.SSpBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.SSServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSNameDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSNroCaja = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSReport = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSfecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemPersona = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemMLine1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemConceptoCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemCampana = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemTipoDocu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemImpuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemCajaNumeracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemMLine2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemTCambio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemPrdContable = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemMLine3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemTipoProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemConstante = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemMLine4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemRegColegiado = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemALine1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemAtenderSolicitud = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemAfiliacionFMorto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemRegistroFichaDeAtención = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemALine2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemConfigParamServ = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemPrcFactu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemPLine1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemPrcProgramaCoutaOrdinaria = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemPLine2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemRptGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemRptBookVta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemRptSQLEstadoCuentaCole = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemRptCole = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemRptReImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemSysConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemSLine1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMnuItemEstabEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemSQLSunat = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemVentMinimizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemVentMaximizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMnuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificarUnErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CboAnno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SSpBarraEstado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SSpBarraEstado
        '
        Me.SSpBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSServer, Me.SSNameDB, Me.SSUser, Me.SSNroCaja, Me.SSReport, Me.SSfecha, Me.SSVersion, Me.ToolStripStatusLabel2})
        Me.SSpBarraEstado.Location = New System.Drawing.Point(0, 250)
        Me.SSpBarraEstado.Name = "SSpBarraEstado"
        Me.SSpBarraEstado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SSpBarraEstado.Size = New System.Drawing.Size(816, 22)
        Me.SSpBarraEstado.TabIndex = 4
        '
        'SSServer
        '
        Me.SSServer.Image = Global.Integration.Test.My.Resources.Resources.server
        Me.SSServer.Name = "SSServer"
        Me.SSServer.Size = New System.Drawing.Size(54, 17)
        Me.SSServer.Text = "server"
        Me.SSServer.ToolTipText = "Servidor conectado Actual"
        '
        'SSNameDB
        '
        Me.SSNameDB.Image = Global.Integration.Test.My.Resources.Resources.database
        Me.SSNameDB.Name = "SSNameDB"
        Me.SSNameDB.Size = New System.Drawing.Size(35, 17)
        Me.SSNameDB.Text = "db"
        Me.SSNameDB.ToolTipText = "Base de Datos actual"
        '
        'SSUser
        '
        Me.SSUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SSUser.Image = Global.Integration.Test.My.Resources.Resources.user
        Me.SSUser.Name = "SSUser"
        Me.SSUser.Size = New System.Drawing.Size(44, 17)
        Me.SSUser.Text = "user"
        Me.SSUser.ToolTipText = "Usuario actual conectado"
        '
        'SSNroCaja
        '
        Me.SSNroCaja.ForeColor = System.Drawing.Color.Blue
        Me.SSNroCaja.Name = "SSNroCaja"
        Me.SSNroCaja.Size = New System.Drawing.Size(77, 17)
        Me.SSNroCaja.Text = "Caja Nro.: Null"
        Me.SSNroCaja.ToolTipText = "Numero de Caja establecida"
        '
        'SSReport
        '
        Me.SSReport.ForeColor = System.Drawing.Color.Green
        Me.SSReport.Image = Global.Integration.Test.My.Resources.Resources.report
        Me.SSReport.Name = "SSReport"
        Me.SSReport.Size = New System.Drawing.Size(95, 17)
        Me.SSReport.Text = "Report: C\Rpt\"
        Me.SSReport.ToolTipText = "Ruta de reportes"
        '
        'SSfecha
        '
        Me.SSfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SSfecha.Image = Global.Integration.Test.My.Resources.Resources._date
        Me.SSfecha.Name = "SSfecha"
        Me.SSfecha.Size = New System.Drawing.Size(431, 17)
        Me.SSfecha.Spring = True
        Me.SSfecha.Text = "Fecha: "
        Me.SSfecha.ToolTipText = "Fecha Servidor"
        '
        'SSVersion
        '
        Me.SSVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SSVersion.Image = Global.Integration.Test.My.Resources.Resources.bricks
        Me.SSVersion.Name = "SSVersion"
        Me.SSVersion.Size = New System.Drawing.Size(65, 17)
        Me.SSVersion.Tag = ""
        Me.SSVersion.Text = "Versión: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.ProcesosToolStripMenuItem1, Me.ReportesToolStripMenuItem, Me.SistemaToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemPersona, Me.TSMnuItemMLine1, Me.TSMnuItemConceptoCaja, Me.TSMnuItemCampana, Me.ToolStripMenuItem3, Me.TSMnuItemTipoDocu, Me.TSMnuItemImpuesto, Me.TSMnuItemCajaNumeracion, Me.TSMnuItemMLine2, Me.TSMnuItemTCambio, Me.TSMnuItemPrdContable, Me.TSMnuItemMLine3, Me.TSMnuItemTipoProg, Me.TSMnuItemConstante, Me.TSMnuItemMLine4, Me.TSMnuItemCerrar})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MaestrosToolStripMenuItem.Text = "&Maestros"
        '
        'TSMnuItemPersona
        '
        Me.TSMnuItemPersona.Image = Global.Integration.Test.My.Resources.Resources.icono_creditos
        Me.TSMnuItemPersona.Name = "TSMnuItemPersona"
        Me.TSMnuItemPersona.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemPersona.Text = "&Persona"
        '
        'TSMnuItemMLine1
        '
        Me.TSMnuItemMLine1.Name = "TSMnuItemMLine1"
        Me.TSMnuItemMLine1.Size = New System.Drawing.Size(235, 6)
        '
        'TSMnuItemConceptoCaja
        '
        Me.TSMnuItemConceptoCaja.Name = "TSMnuItemConceptoCaja"
        Me.TSMnuItemConceptoCaja.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemConceptoCaja.Text = "Tipo Servicios"
        '
        'TSMnuItemCampana
        '
        Me.TSMnuItemCampana.Name = "TSMnuItemCampana"
        Me.TSMnuItemCampana.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemCampana.Text = "Crear Campaña"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(235, 6)
        '
        'TSMnuItemTipoDocu
        '
        Me.TSMnuItemTipoDocu.Image = Global.Integration.Test.My.Resources.Resources.page_white_add
        Me.TSMnuItemTipoDocu.Name = "TSMnuItemTipoDocu"
        Me.TSMnuItemTipoDocu.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemTipoDocu.Text = "Tipo documentos - SUNAT"
        '
        'TSMnuItemImpuesto
        '
        Me.TSMnuItemImpuesto.Name = "TSMnuItemImpuesto"
        Me.TSMnuItemImpuesto.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemImpuesto.Text = "Impuesto Comprobante"
        '
        'TSMnuItemCajaNumeracion
        '
        Me.TSMnuItemCajaNumeracion.Image = Global.Integration.Test.My.Resources.Resources.box
        Me.TSMnuItemCajaNumeracion.Name = "TSMnuItemCajaNumeracion"
        Me.TSMnuItemCajaNumeracion.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemCajaNumeracion.Text = "Caja y correlativos"
        '
        'TSMnuItemMLine2
        '
        Me.TSMnuItemMLine2.Name = "TSMnuItemMLine2"
        Me.TSMnuItemMLine2.Size = New System.Drawing.Size(235, 6)
        '
        'TSMnuItemTCambio
        '
        Me.TSMnuItemTCambio.Name = "TSMnuItemTCambio"
        Me.TSMnuItemTCambio.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemTCambio.Text = "Tipo de Cambio"
        '
        'TSMnuItemPrdContable
        '
        Me.TSMnuItemPrdContable.Name = "TSMnuItemPrdContable"
        Me.TSMnuItemPrdContable.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemPrdContable.Text = "Periodo Contable"
        '
        'TSMnuItemMLine3
        '
        Me.TSMnuItemMLine3.Name = "TSMnuItemMLine3"
        Me.TSMnuItemMLine3.Size = New System.Drawing.Size(235, 6)
        '
        'TSMnuItemTipoProg
        '
        Me.TSMnuItemTipoProg.Name = "TSMnuItemTipoProg"
        Me.TSMnuItemTipoProg.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemTipoProg.Text = "Tipo de Interfaces - Configuración"
        '
        'TSMnuItemConstante
        '
        Me.TSMnuItemConstante.Name = "TSMnuItemConstante"
        Me.TSMnuItemConstante.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemConstante.Text = "Constantes"
        '
        'TSMnuItemMLine4
        '
        Me.TSMnuItemMLine4.Name = "TSMnuItemMLine4"
        Me.TSMnuItemMLine4.Size = New System.Drawing.Size(235, 6)
        '
        'TSMnuItemCerrar
        '
        Me.TSMnuItemCerrar.Image = Global.Integration.Test.My.Resources.Resources.door_out
        Me.TSMnuItemCerrar.Name = "TSMnuItemCerrar"
        Me.TSMnuItemCerrar.Size = New System.Drawing.Size(238, 22)
        Me.TSMnuItemCerrar.Text = "Cerrar sistema"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemRegColegiado, Me.TSMnuItemALine1, Me.TSMnuItemAtenderSolicitud, Me.TSMnuItemAfiliacionFMorto, Me.TSMnuItemRegistroFichaDeAtención, Me.TSMnuItemALine2, Me.TSMnuItemConfigParamServ})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProcesosToolStripMenuItem.Text = "Admisión"
        '
        'TSMnuItemRegColegiado
        '
        Me.TSMnuItemRegColegiado.Image = Global.Integration.Test.My.Resources.Resources.user_student
        Me.TSMnuItemRegColegiado.Name = "TSMnuItemRegColegiado"
        Me.TSMnuItemRegColegiado.Size = New System.Drawing.Size(275, 22)
        Me.TSMnuItemRegColegiado.Text = "Registrar Colegiado"
        Me.TSMnuItemRegColegiado.Visible = False
        '
        'TSMnuItemALine1
        '
        Me.TSMnuItemALine1.Name = "TSMnuItemALine1"
        Me.TSMnuItemALine1.Size = New System.Drawing.Size(272, 6)
        Me.TSMnuItemALine1.Visible = False
        '
        'TSMnuItemAtenderSolicitud
        '
        Me.TSMnuItemAtenderSolicitud.Image = Global.Integration.Test.My.Resources.Resources.user_student
        Me.TSMnuItemAtenderSolicitud.Name = "TSMnuItemAtenderSolicitud"
        Me.TSMnuItemAtenderSolicitud.Size = New System.Drawing.Size(275, 22)
        Me.TSMnuItemAtenderSolicitud.Text = "Registra / confirmar Solicitud - Colegiado"
        Me.TSMnuItemAtenderSolicitud.Visible = False
        '
        'TSMnuItemAfiliacionFMorto
        '
        Me.TSMnuItemAfiliacionFMorto.Image = Global.Integration.Test.My.Resources.Resources.document_mark_as_final
        Me.TSMnuItemAfiliacionFMorto.Name = "TSMnuItemAfiliacionFMorto"
        Me.TSMnuItemAfiliacionFMorto.Size = New System.Drawing.Size(275, 22)
        Me.TSMnuItemAfiliacionFMorto.Text = "Afiliacion Seguro Mutual"
        Me.TSMnuItemAfiliacionFMorto.Visible = False
        '
        'TSMnuItemRegistroFichaDeAtención
        '
        Me.TSMnuItemRegistroFichaDeAtención.Name = "TSMnuItemRegistroFichaDeAtención"
        Me.TSMnuItemRegistroFichaDeAtención.Size = New System.Drawing.Size(275, 22)
        Me.TSMnuItemRegistroFichaDeAtención.Text = "Registro Ficha de Atención"
        '
        'TSMnuItemALine2
        '
        Me.TSMnuItemALine2.Name = "TSMnuItemALine2"
        Me.TSMnuItemALine2.Size = New System.Drawing.Size(272, 6)
        '
        'TSMnuItemConfigParamServ
        '
        Me.TSMnuItemConfigParamServ.Image = Global.Integration.Test.My.Resources.Resources.interface_preferences
        Me.TSMnuItemConfigParamServ.Name = "TSMnuItemConfigParamServ"
        Me.TSMnuItemConfigParamServ.Size = New System.Drawing.Size(275, 22)
        Me.TSMnuItemConfigParamServ.Text = "Configuración - Pago Derecho Colegiatura"
        Me.TSMnuItemConfigParamServ.Visible = False
        '
        'ProcesosToolStripMenuItem1
        '
        Me.ProcesosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemPrcFactu, Me.TSMnuItemPLine1, Me.TSMnuItemPrcProgramaCoutaOrdinaria, Me.TSMnuItemPLine2, Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem, Me.AnularComprobanteToolStripMenuItem})
        Me.ProcesosToolStripMenuItem1.Name = "ProcesosToolStripMenuItem1"
        Me.ProcesosToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.ProcesosToolStripMenuItem1.Text = "Procesos"
        '
        'TSMnuItemPrcFactu
        '
        Me.TSMnuItemPrcFactu.Image = Global.Integration.Test.My.Resources.Resources.save_money
        Me.TSMnuItemPrcFactu.Name = "TSMnuItemPrcFactu"
        Me.TSMnuItemPrcFactu.Size = New System.Drawing.Size(247, 22)
        Me.TSMnuItemPrcFactu.Text = "Modulo Facturación - Caja"
        '
        'TSMnuItemPLine1
        '
        Me.TSMnuItemPLine1.Name = "TSMnuItemPLine1"
        Me.TSMnuItemPLine1.Size = New System.Drawing.Size(244, 6)
        '
        'TSMnuItemPrcProgramaCoutaOrdinaria
        '
        Me.TSMnuItemPrcProgramaCoutaOrdinaria.Image = Global.Integration.Test.My.Resources.Resources.widgets
        Me.TSMnuItemPrcProgramaCoutaOrdinaria.Name = "TSMnuItemPrcProgramaCoutaOrdinaria"
        Me.TSMnuItemPrcProgramaCoutaOrdinaria.Size = New System.Drawing.Size(247, 22)
        Me.TSMnuItemPrcProgramaCoutaOrdinaria.Text = "Programación Cuota Ordinaria"
        '
        'TSMnuItemPLine2
        '
        Me.TSMnuItemPLine2.Name = "TSMnuItemPLine2"
        Me.TSMnuItemPLine2.Size = New System.Drawing.Size(244, 6)
        '
        'TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem
        '
        Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem.Image = Global.Integration.Test.My.Resources.Resources.master_card
        Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem.Name = "TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem"
        Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem.Text = "Tipo Tarjetas por Entidad Financiera"
        '
        'AnularComprobanteToolStripMenuItem
        '
        Me.AnularComprobanteToolStripMenuItem.Image = Global.Integration.Test.My.Resources.Resources.page_delete
        Me.AnularComprobanteToolStripMenuItem.Name = "AnularComprobanteToolStripMenuItem"
        Me.AnularComprobanteToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.AnularComprobanteToolStripMenuItem.Text = "&Anular Comprobante"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemRptGeneral, Me.TSMnuItemRptBookVta, Me.ToolStripMenuItem1, Me.TSMnuItemRptSQLEstadoCuentaCole, Me.TSMnuItemRptCole, Me.ToolStripMenuItem2, Me.TSMnuItemRptReImprimir})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        Me.ReportesToolStripMenuItem.Visible = False
        '
        'TSMnuItemRptGeneral
        '
        Me.TSMnuItemRptGeneral.Image = Global.Integration.Test.My.Resources.Resources.report_add
        Me.TSMnuItemRptGeneral.Name = "TSMnuItemRptGeneral"
        Me.TSMnuItemRptGeneral.Size = New System.Drawing.Size(251, 22)
        Me.TSMnuItemRptGeneral.Text = "Reportes Generales"
        '
        'TSMnuItemRptBookVta
        '
        Me.TSMnuItemRptBookVta.Image = Global.Integration.Test.My.Resources.Resources.export_excel1
        Me.TSMnuItemRptBookVta.Name = "TSMnuItemRptBookVta"
        Me.TSMnuItemRptBookVta.Size = New System.Drawing.Size(251, 22)
        Me.TSMnuItemRptBookVta.Text = "Libro Electronico Ventas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(248, 6)
        '
        'TSMnuItemRptSQLEstadoCuentaCole
        '
        Me.TSMnuItemRptSQLEstadoCuentaCole.Image = Global.Integration.Test.My.Resources.Resources.advanced_data_grid
        Me.TSMnuItemRptSQLEstadoCuentaCole.Name = "TSMnuItemRptSQLEstadoCuentaCole"
        Me.TSMnuItemRptSQLEstadoCuentaCole.Size = New System.Drawing.Size(251, 22)
        Me.TSMnuItemRptSQLEstadoCuentaCole.Text = "Consultar Estado Cuenta - Colegiado"
        '
        'TSMnuItemRptCole
        '
        Me.TSMnuItemRptCole.Name = "TSMnuItemRptCole"
        Me.TSMnuItemRptCole.Size = New System.Drawing.Size(251, 22)
        Me.TSMnuItemRptCole.Text = "Con Colegiados"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(248, 6)
        '
        'TSMnuItemRptReImprimir
        '
        Me.TSMnuItemRptReImprimir.Image = Global.Integration.Test.My.Resources.Resources.printer
        Me.TSMnuItemRptReImprimir.Name = "TSMnuItemRptReImprimir"
        Me.TSMnuItemRptReImprimir.Size = New System.Drawing.Size(251, 22)
        Me.TSMnuItemRptReImprimir.Text = "Re-Impresion Documentos"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemSysConfig, Me.TSMnuItemSLine1, Me.TSMnuItemEstabEmpresa, Me.TSMnuItemSQLSunat})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'TSMnuItemSysConfig
        '
        Me.TSMnuItemSysConfig.Name = "TSMnuItemSysConfig"
        Me.TSMnuItemSysConfig.Size = New System.Drawing.Size(254, 22)
        Me.TSMnuItemSysConfig.Text = "Parametros de configuracion (Equipo)"
        '
        'TSMnuItemSLine1
        '
        Me.TSMnuItemSLine1.Name = "TSMnuItemSLine1"
        Me.TSMnuItemSLine1.Size = New System.Drawing.Size(251, 6)
        '
        'TSMnuItemEstabEmpresa
        '
        Me.TSMnuItemEstabEmpresa.Image = Global.Integration.Test.My.Resources.Resources.house
        Me.TSMnuItemEstabEmpresa.Name = "TSMnuItemEstabEmpresa"
        Me.TSMnuItemEstabEmpresa.Size = New System.Drawing.Size(254, 22)
        Me.TSMnuItemEstabEmpresa.Text = "Establecer Empresas"
        '
        'TSMnuItemSQLSunat
        '
        Me.TSMnuItemSQLSunat.Name = "TSMnuItemSQLSunat"
        Me.TSMnuItemSQLSunat.Size = New System.Drawing.Size(254, 22)
        Me.TSMnuItemSQLSunat.Text = "Consulta de RUC - sunat.gob.pe"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemVentMinimizar, Me.TSMnuItemVentMaximizar})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.VentanaToolStripMenuItem.Text = "Ventana"
        '
        'TSMnuItemVentMinimizar
        '
        Me.TSMnuItemVentMinimizar.Name = "TSMnuItemVentMinimizar"
        Me.TSMnuItemVentMinimizar.Size = New System.Drawing.Size(121, 22)
        Me.TSMnuItemVentMinimizar.Text = "Minimizar"
        '
        'TSMnuItemVentMaximizar
        '
        Me.TSMnuItemVentMaximizar.Name = "TSMnuItemVentMaximizar"
        Me.TSMnuItemVentMaximizar.Size = New System.Drawing.Size(121, 22)
        Me.TSMnuItemVentMaximizar.Text = "Maximizar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMnuItemHelp, Me.NotificarUnErrorToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'TSMnuItemHelp
        '
        Me.TSMnuItemHelp.Image = Global.Integration.Test.My.Resources.Resources.help
        Me.TSMnuItemHelp.Name = "TSMnuItemHelp"
        Me.TSMnuItemHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.TSMnuItemHelp.Size = New System.Drawing.Size(156, 22)
        Me.TSMnuItemHelp.Text = "Ver la Ayuda"
        '
        'NotificarUnErrorToolStripMenuItem
        '
        Me.NotificarUnErrorToolStripMenuItem.Name = "NotificarUnErrorToolStripMenuItem"
        Me.NotificarUnErrorToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NotificarUnErrorToolStripMenuItem.Text = "Notificar un error"
        '
        'CboAnno
        '
        Me.CboAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAnno.FormattingEnabled = True
        Me.CboAnno.Location = New System.Drawing.Point(595, 1)
        Me.CboAnno.Name = "CboAnno"
        Me.CboAnno.Size = New System.Drawing.Size(74, 23)
        Me.CboAnno.TabIndex = 7
        Me.CboAnno.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Año actual:"
        Me.Label1.Visible = False
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(759, 1)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(133, 23)
        Me.CboPeriodo.TabIndex = 9
        Me.CboPeriodo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Periodo actual:"
        Me.Label2.Visible = False
        '
        'FormMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 272)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboAnno)
        Me.Controls.Add(Me.SSpBarraEstado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema MEDICA - Inversiones Rafael  (Versión 1.0.0)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SSpBarraEstado.ResumeLayout(False)
        Me.SSpBarraEstado.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SSpBarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents SSServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSNameDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSReport As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SSfecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemPersona As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemMLine1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemConstante As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemMLine2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemRegColegiado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemEstabEmpresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemTipoDocu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemTipoProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemCajaNumeracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemMLine3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemConceptoCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemALine1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemAtenderSolicitud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemAfiliacionFMorto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemImpuesto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemTCambio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemPrdContable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CboAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TSMnuItemSLine1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemSQLSunat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemSysConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSNroCaja As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProcesosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemPrcFactu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemALine2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemConfigParamServ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemPLine1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemPrcProgramaCoutaOrdinaria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeTarjetasCreditoPorEntidadFinancieraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemMLine4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemPLine2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnularComprobanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSMnuItemRptGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemRptBookVta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemRptCole As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificarUnErrorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemVentMinimizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemVentMaximizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemRptReImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSMnuItemRptSQLEstadoCuentaCole As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemRegistroFichaDeAtención As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnuItemCampana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
End Class
