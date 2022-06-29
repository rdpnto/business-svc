﻿using BusinessSvc.Domain.Entities;
using MediatR;

namespace BusinessSvc.Application.Tests.Commands.SendEmail
{
    public class SendEmailCommandTest : IRequest<SendEmailCommandResponseTest>
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}
