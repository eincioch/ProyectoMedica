Public Module mdlConstante

    Public KeyItem As String = "K"
    Public KeyEscuela As String = "E"
    Public SubPeriodo As Long = 1056
    Public EstadoCursoMatriculado As Long = 1077
    Public Seccion As Long = 1093
    Public ModalidadEstudios As Long = 5001
    Public gConEstDocumento As Long = 1066
    Public gConTipoDocumento As Long = 1063
    Public gConUnidades As Long = 1004

    'Jerarquía de Módulos
    Public Const Mod_AdmisionMedica = "28"

    'Glosas 
    Public Const sGlosaCtaCteCorriente = "Programación Pago Ficha Atención"

    'Constante (1015)
    Enum TipoActividad
        nPerTipoAlumno = 3
        nPerTipoTerceros = 15
        nPerTipoCliente = 16
        nPerRelTipoEmpConvenio = 30
        nPerRelTipoMedico = 40
        nPerRelTipoLabExterno = 50
    End Enum

    'Constante (1001)
    Enum TipoMoneda
        nSoles = 1
        nDolar = 2
        nEuro = 3
    End Enum

    'Constante (1116)
    Enum EstadoFichaAtencion
        nPendientePago = 1
        nProgramado = 2
        nPagoRealizado = 3
        nTomaExamen = 4
        nFinalizado = 5
        nEntregado = 6
    End Enum

    'Interface
    Enum TipoAtencion
        Particular = 1001
        LabExterno = 1002
        Convenio = 1003
    End Enum

    'Tipo Docu (Interface nIntClase=7004 AND nIntTipo=1000)
    Enum TipoDocuVta
        Factura = 3001
        BoletaVta = 3003
        Ticket = 3012

    End Enum


End Module
