using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using Proforma.Models;
using System.Security.Cryptography.X509Certificates;

namespace Proforma.Modules
{
    public class CustomMail
    {

        string nameAccount = "";
        string emailAccount = "";
        string passAcount = "";
        string hostAccount = "";
        int portAccount = 0;
        string destinatario = "";

        /// <summary>
        /// Envia correo con archivo adjunto
        /// </summary>
        /// <param name="idVendedor">Id de vendedor</param>
        /// <param name="idContacto">Id de contacto</param>
        /// <param name="asunto">Asunto</param>
        /// <param name="mensaje">Cuerpo del mensaje</param>
        /// <param name="rutaArchivo">Ruta del archivo</param>
        public void EnviarCorreo(decimal idVendedor, decimal idContacto, string asunto = "", string mensaje = "", string rutaArchivo = "")
        {
            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            Attachment attachment = null;

            using (BD_ERPEntities context = new BD_ERPEntities())
            {
                var vendedor = context.tblVendedores.Where(x => x.decIdVendedor == idVendedor).FirstOrDefault();
                if (vendedor != null)
                {
                    emailAccount = vendedor.strCorreo;
                    passAcount = SystemProtected.DesEncriptarCadena(Convert.ToString(vendedor.strContrasena));
                }

                var contacto = context.tblClientesContacto.Where(x => x.decIdContacto == idContacto).FirstOrDefault();
                if (contacto != null)
                {
                    destinatario = contacto.strCorreo;
                }

                var configuracion = context.tblConfiguracion.FirstOrDefault();
                if (configuracion != null)
                {
                    nameAccount = configuracion.strNombreEmpresa;
                    mailMessage.From = new MailAddress(emailAccount, nameAccount);
                    mailMessage.To.Add(destinatario);
                    mailMessage.Subject = asunto;
                    mailMessage.Body = mensaje;
                    hostAccount = configuracion.strHost;
                    portAccount = Convert.ToInt32(configuracion.intPort);
                    if (rutaArchivo.Length > 0)
                    {
                        attachment = new Attachment(rutaArchivo);
                        mailMessage.Attachments.Add(attachment);
                    }
                }

                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);

                smtpClient.Credentials = new NetworkCredential(emailAccount, passAcount);
                smtpClient.EnableSsl = true;
                smtpClient.Host = hostAccount;
                smtpClient.Port = portAccount;
                smtpClient.Send(mailMessage);

                attachment.Dispose();
                mailMessage.Attachments.Clear();
            }
        }

        private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
