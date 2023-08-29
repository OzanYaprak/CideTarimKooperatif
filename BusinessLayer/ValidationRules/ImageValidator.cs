using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.ImageTitle).NotEmpty().WithMessage("Görsel başlığı boş geçilemez");
            RuleFor(x => x.ImageDescription).NotEmpty().WithMessage("Görsel açıklaması boş geçilemez");
            RuleFor(x => x.ImageURl).NotEmpty().WithMessage("Görsel yolu boş geçilemez");
            RuleFor(x => x.ImageTitle).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.ImageTitle).MinimumLength(8).WithMessage("Lütfen en az 8 karakter veri girişi yapınız");
            RuleFor(x => x.ImageDescription).MaximumLength(50).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.ImageDescription).MinimumLength(20).WithMessage("Lütfen en az 8 karakter veri girişi yapınız");
        }
    }
}