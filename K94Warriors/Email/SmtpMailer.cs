﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

namespace K94Warriors.Email
{
    /// <summary>
    /// Emails messages over SMTP.
    /// </summary>
    public class SmtpMailer
    {
        /// <summary>
        /// Send an e-mail message.
        /// </summary>
        /// <param name="from">The from email address.</param>
        /// <param name="to">The to email address.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <exception cref="System.ArgumentException">thrown when any parameter is null, empty, or white space.</exception>
        public void Send(string from, string to, string subject, string body)
        {
            // Sanitize
            if (string.IsNullOrWhiteSpace(from))
            {
                throw new ArgumentException("cannot be null, empty, or white space", "from");
            }
            if (string.IsNullOrWhiteSpace(to))
            {
                throw new ArgumentException("cannot be null, empty, or white space", "from");
            }
            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentException("cannot be null, empty, or white space", "from");
            }
            if (string.IsNullOrWhiteSpace(body))
            {
                throw new ArgumentException("cannot be null, empty, or white space", "from");
            }

            // Create the mail message
            using (var mailMessage = new MailMessage(from, to, subject, body))
            {
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                // New up the SMTP client
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Send(mailMessage);
                }
            }
        }
    }
}