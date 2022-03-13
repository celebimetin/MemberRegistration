using FluentValidation;
using MemberRegistration.Entities.Concrete;
using System;

namespace MemberRegistration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();
            RuleFor(m => m.DateOfBirth).NotEmpty().LessThan(DateTime.Now);
            RuleFor(m => m.Email).NotEmpty().EmailAddress();
            RuleFor(m => m.TcNo).NotEmpty().Length(11);
        }
    }
}