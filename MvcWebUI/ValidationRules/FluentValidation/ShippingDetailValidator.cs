using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad girilmelidir");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyad girilmelidir");
            RuleFor(s => s.Address).NotEmpty().WithMessage("Adres girilmelidir"); ;
            RuleFor(s => s.City).NotEmpty().WithMessage("Şehir girilmelidir");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email girilmelidir");




        }

       
    }
}
