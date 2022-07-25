using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Modules.Core.Services.Contracts;

namespace WHT.Banking.Modules.Email.Sender.Sendgrid.Models
{
    public class EmailSender : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message, bool isHtml = false)
        {
            throw new NotImplementedException();
        }
    }
}
