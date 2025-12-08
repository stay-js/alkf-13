using FastEndpoints;
using GyogyfurdokLib;

namespace Gyogyfurdok.Validators
{
    public class BathValidator : Validator<Bath>
    {
        public BathValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Az azonosító kötelező (pozitív egész szám)")
                .GreaterThan(0).WithMessage("Az azonosító csak pozitív egész szám lehet");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("A fürdő név kötelező (min. 5 karakter, első karakter nagybetű)")
                .MinimumLength(5).WithMessage("A fürdő név túl rövid (min. 5 karakter)")
                .Must(x => !string.IsNullOrWhiteSpace(x) && char.IsUpper(x[0])).WithMessage("A fürdő csak nagybetűvel kezdődhet");

            RuleFor(x => x.City)
                .NotNull().WithMessage("A település kötelező (min. 2 karakter, első karakter nagybetű)")
                .MinimumLength(2).WithMessage("A település túl rövid (min. 2 karakter)")
                .Must(x => !string.IsNullOrWhiteSpace(x) && char.IsUpper(x[0])).WithMessage("A település csak nagybetűvel kezdődhet");

            string zipCodeError = "Az irányítószám csak négyjegyű pozitív egész szám lehet";
            RuleFor(x => x.ZipCode)
                .NotNull().WithMessage("Az irányítószám kötelező (négyjegyű pozitív egész szám)")
                .GreaterThanOrEqualTo(1000).WithMessage(zipCodeError)
                .LessThanOrEqualTo(9999).WithMessage(zipCodeError);

            RuleFor(x => x.County).NotEmpty().WithMessage("A megye kötelező");
        }
    }
}
