using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class CreateReviewValidator:AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator()
        {
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyiniz!");
            RuleFor(x=>x.CustomerName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız!");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Lütfen Puan Değerini Boş Geçmeyiniz");
            RuleFor(x => x.Comment).MinimumLength(20).WithMessage("Lütfen Yorum Kısmına En Az 20 Karakter Veri Girişi Yapınız!");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen Yorum Kısmına En fazla 500 Karakter Veri Girişi Yapınız!");
        }
    }
}
