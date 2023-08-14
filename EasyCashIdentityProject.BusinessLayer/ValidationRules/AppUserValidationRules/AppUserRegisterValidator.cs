using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(n => n.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(s => s.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(e => e.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(c => c.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");


            RuleFor(n => n.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriş yapınız.");
            RuleFor(n => n.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriş yapınız.");

            RuleFor(s => s.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriş yapınız.");
            RuleFor(s => s.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriş yapınız.");

            RuleFor(u => u.UserName).Equal(e=>e.Email).WithMessage("Kullanıcı adı ile email aynı olmak zorundadır.");

            RuleFor(e => e.Email).EmailAddress().WithMessage("Lütfen geçerli bir e-mail adresi giriniz.");

            RuleFor(p => p.Password).Length(8, 8).WithMessage("Şifre tam olarak 8 karakter uzunluğunda olmalıdır.")
                                    .Must(ContainLowercase)
                                    .WithMessage("Şifre en az bir küçük harf içermelidir.")
                                    .Must(ContainUppercase)
                                    .WithMessage("Şifre en az bir büyük harf içermelidir.")
                                    .Must(ContainDigit)
                                    .WithMessage("Şifre en az bir rakam içermelidir.")
                                    .Must(ContainSpecialCharacter)
                                    .WithMessage("Şifre en az bir özel karakter içermelidir.");

            RuleFor(c => c.ConfirmPassword).Equal(p => p.Password).WithMessage("Şifre tekrarı ile şifre aynı olmak zorundadır.Lütfen tekrar deneyiniz.");

        }
        private bool ContainLowercase(string password)
        {
            return password.Any(char.IsLower);
        }

        private bool ContainUppercase(string password)
        {
            return password.Any(char.IsUpper);
        }

        private bool ContainDigit(string password)
        {
            return password.Any(char.IsDigit);
        }

        private bool ContainSpecialCharacter(string password)
        {
            return password.Any(c => !char.IsLetterOrDigit(c));
        }
    }

   
}
