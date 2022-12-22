using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proforma.Modules
{
    public static class PublicVar
    {
        //Variables publicas
        public static string gstrUsername = "";
        public static string gstrPassword = "";
        public static decimal gdecIdUser = 0;
        public static decimal gdecIdRol = 0;
        public static int gintContadorInactivo = 0;
        public static string gstrFormatFechaDesde = "dd/MM/yyyy 00:00:00";
        public static string gstrFormatFechaHasta = "dd/MM/yyyy 23:59:59";
        public static string gstrFormatFecha = "dd/MM/yyyy";

        //Produccion
        public static string gstrServername = "192.168.1.4";
        public static string gstrServerdomain = "";
        public static string gstrServeruser = "Administrador";
        public static string gstrServerpassword = "2016Eagle2016";
        public static string gstrServerArchivos = "\\\\192.168.1.4\\Imagenes\\";

        //Desarrollo
        //public static string gstrServername = "localhost";
        //public static string gstrServerdomain = "";
        //public static string gstrServeruser = "rcastillo";
        //public static string gstrServerpassword = "R0b3rt$18102%";
        //public static string gstrServerArchivos = "\\\\localhost\\Imagenes\\";

        //Mensajes del sistema
        public const string gstrTitleInfo = "Información";
        public const string gstrTitleWarning = "Advertencia";
        public const string gstrTitleError = "Error";
        public const string gstrDeleteDataMsg = "Se eliminará el registro. Haga clic en Aceptar, de lo contrario haga clic en Cancelar.";
        public const string gstrSaveDataMsg = "Los datos fueron guardados correctamente, haga clic en Aceptar.";
        public const string gstrNoChangesMsg = "No se han realizado cambios";
        public const string gstrUpdateCompletedMsg = "El sistema se ha actualizado y se procedera a reiniciar para que hagan efecto los cambios";
        public const string gstrUpdateExistMsg = "Existe una nueva actualización, haga clic en el icono del sistema para actualizarlo";
        public const string gstrUpdateWaitMsg = "Haga clic en Aceptar y espere que el sistema se actualice";
        public const string gstrInactiveTimeMsg = "Por seguridad el sistema se reiniciará debido a que ha estado 60 minutos inactivo";

        //Mensajes de validaciones
        public const string gstrCampoRequeridoMsg = "Campo Obligatorio";
        public const string gstrCamposRequeridosMsg = "Por favor llene los campos requeridos.";
        public const string gstrErrorLlaveForaneaMsg = "No se puede eliminar el registro seleccionado porque tiene referencias a otros registros en el sistema.";
        public const string gstrFechaIniMayorFechaFinMsg = "La fecha inicial no puede ser mayor que la fecha final";

        //Inicio de sesion
        public const string gstrUserPassIncorrectMsg = "El Usuario y/o Contraseña son incorrectos. Verifique sus datos de autenticación e intente nuevamente.";
        public const string gstrUserInactiveMsg = "El Usuario no está activo. Contacte con el Administrador.";

        //Tasa de Cambio del día
        public const string gstrTasaNoExistMsg = "La tasa de hoy no ha sido grabada, por favor introdúzcala al Sistema.";
        public const string gstrTasaEnRegistrosMsg = "Ya existen registros con la tasa cambiaria del día de hoy, por lo tanto no se puede modificar.";

        //Catalogo de usuarios
        public const string gstrUpdateAdministratorMsg = "Solo existe un usuario administrador, no puede realizar la acción";

        //Catalogo de productos
        public const string gstrPrecioInvalidoMSg = "El precio no puede ser menor al costo.";

        //Cotizaciones
        public const string gstrTasaCambioFaltanteMsg = "No existe tasa de cambio del día, por lo tanto no se puede crear una cotización.";
        public const string gstrExistenciaInsuficienteMsg = "La cantidad digitada es mayor a la existencia del producto.";
        public const string gstrClienteInvalidoMsg = "Debe seleccionar un cliente antes de agregar un producto a la cotización.";
        public const string gstrCotizacionSinDetalleMsg = "Está a punto de guardar una cotización sin detalle. Haga clic en Aceptar, de lo contrario haga clic en Cancelar.";
        public const string gstrAprobacionMsg = "Se aprobará la cotización. Haga clic en Aceptar, de lo contrario haga clic en Cancelar.";
        public const string gstrAnulacionMsg = "Se anulará la cotización. Haga clic en Aceptar, de lo contrario haga clic en Cancelar.";
        public const string gstrPersonalizarCorreoMsg = "Abrir Menú de Personalización de correo a enviar. Haga clic en Sí, de lo contrario haga clic en No.";

        //Reportes
        public const string gstrPrintPreviewTitle = "Vista previa del documento";
    }

    public static class TipoOperacion
    {
        public const string Creacion = "Creación";
        public const string Modificacion = "Modificación";
        public const string Eliminacion = "Eliminación";
        public const string Aprobacion = "Aprobación";
        public const string Anulacion = "Anulación";
        public const string Impresion = "Impresión";
        public const string Exportacion = "Exportación";
        public const string CorreoCotizacion = "Enviar Cotización";
    }
}
