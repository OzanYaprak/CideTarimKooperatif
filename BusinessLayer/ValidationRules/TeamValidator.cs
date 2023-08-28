using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel ismi boş geçilemez");
            RuleFor(x => x.PersonTitle).NotEmpty().WithMessage("Personel ünvanı boş geçilemez");
            RuleFor(x => x.PersonImageURL).NotEmpty().WithMessage("Personel fotoğrafı boş geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Personel ismi min. 5 maks. 50 karakter arasında olmalıdır.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Personel ismi min. 5 maks. 50 karakter arasında olmalıdır.");
            RuleFor(x => x.PersonTitle).MaximumLength(50).WithMessage("Personel ünavı min. 3 maks. 50 karakter arasında olmalıdır.");
            RuleFor(x => x.PersonTitle).MinimumLength(3).WithMessage("Personel ünavı min. 3 maks. 50 karakter arasında olmalıdır.");
        }
    }
}