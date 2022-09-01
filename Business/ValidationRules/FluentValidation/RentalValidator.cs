using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş olamaz");

            RuleFor(p => p.ReturnDate).NotEmpty().WithMessage("Kiralama bitiş tarihi boş olamaz");
        }
    }
}
