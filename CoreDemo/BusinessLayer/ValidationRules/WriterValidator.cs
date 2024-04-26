using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator: AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar kısmı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ad Soyad 2 karakterden az olamaz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad soyad maksimum 50 karakter olabilir");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
			RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf bulundurmalı");
			RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harf bulundurmalı");
			RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifre en az bir sayı bulundurmalı");
		}
    }
}
