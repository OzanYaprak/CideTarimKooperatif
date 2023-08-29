using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.AnnouncementTitle).NotEmpty().WithMessage("Duyuru başlığı girilmelidir");
            RuleFor(x=>x.AnnouncementDescription).NotEmpty().WithMessage("Duyuru açıklaması girilmelidir");
        }
    }
}