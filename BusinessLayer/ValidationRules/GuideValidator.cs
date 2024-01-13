using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Lütfen Rehber adını giriniz");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Lütfen Rehber açıklamasını giriniz");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Lütfen Rehber görselini giriniz");
            RuleFor(x=>x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz");            
        }
    }
}
