using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class CompanyValidatior : AbstractValidator<Company>
    {
        public CompanyValidatior()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Şirket adı boş bırakılamaz");
            RuleFor(x => x.TaxAdministration).NotEmpty().WithMessage("Vergi dairesi boş bırakılamaz");
            RuleFor(x => x.TaxNumber).NotEmpty().WithMessage("Vergi numarası boş bırakılamaz");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Adres boş bırakılamaz");

        }
    }
}
