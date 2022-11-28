using Proforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proforma.Modules
{
    public static class DataExtentions
    {
        /// <summary>
        /// Evalua si el objeto es nulo y devuelve un valor
        /// </summary>
        /// <param name="expression">Valor del objeto</param>
        /// <param name="valueToReturn">Valor a retornar si el objeto es nulo</param>
        /// <returns></returns>
        public static object IsNull(this object expression, object valueToReturn)
        {
            object result = expression;
            
            if (expression == null)
            {
                result = valueToReturn;
            }
            else if (expression == DBNull.Value)
            {
                result = valueToReturn;
            }
            else if (expression.ToString().Length == 0)
            {
                result = valueToReturn;
            }
            return result;
        }

        /// <summary>
        /// Obtiene la fecha y hora del servidor
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetDateDB(this DateTime date)
        {
            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                var dateQuery = context.Database.SqlQuery<DateTime>("SELECT GETDATE()");
                var datetimeServer = dateQuery.AsEnumerable().FirstOrDefault();
                return datetimeServer;
            }
        }

        /// <summary>
        /// Convierte fecha con cero horas
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime StartDate(this DateTime date)
        {
            return DateTime.Parse(date.ToShortDateString());
        }

        /// <summary>
        /// Convierte fecha con ultima hora del dia
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime EndDate(this DateTime date)
        {
            return DateTime.Parse(date.ToString("dd/MM/yyyy 23:59:59"));
        }
    }
}
