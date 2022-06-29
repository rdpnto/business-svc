﻿using BusinessSvc.Domain.Entities;
using System.Collections.Generic;

namespace BusinessSvc.Application.Commands.SendEmail
{
    public class SendEmailCommandResponse
    {
        public bool EmailSent { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
