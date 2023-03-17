using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

/// <summary>
/// Exemplo de envio de email C#
/// Lembre de ativar o POP https://mail.google.com/mail/#settings/fwdandpop
/// Lembre de ativar o acesso menos seguro https://myaccount.google.com/lesssecureapps (se não for usar TLS)
/// </summary>

namespace BuffetManagement.Negócio
{
    public class Contato
    {
        public void Envio(string assunto, string mensagem)
        {
            // Configure as credenciais do remetente do e-mail
            string remetente = "0000886005@senaimgaluno.com.br";
            string destinatario = "0000791018@senaimgaluno.com.br";
            string senha = "carol98924899";

            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 10000;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(remetente, senha);

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(remetente);
            mailMessage.To.Add(destinatario);
            mailMessage.Subject = assunto;
            mailMessage.Body = mensagem;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}