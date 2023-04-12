using emreekiz.Models;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emreekiz.Views.Personel
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.PersonelAd).NotEmpty().WithMessage("İsim Boş Geçilemez.");
            RuleFor(p => p.PersonelSoyad).NotEmpty().WithMessage("Soyad Boş Geçilemez.");
            RuleFor(p => p.AraçID).MinimumLength(3).WithMessage("En az 3 rakam girebilirsiniz.");
            RuleFor(p => p.AraçID).MaximumLength(3).WithMessage("En fazla 3 rakam girebilirsiniz.");
        }
        public void MyMethod()
        {
            // Burada yapılacak işlemler
            Console.WriteLine("MyMethod has been implemented.");
        }

        internal ValidationResult Validate(TB_Personel yenip)
        {
            throw new NotImplementedException();
        }
    }
    
}