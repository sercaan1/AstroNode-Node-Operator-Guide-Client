using Common.Models.FluentValidators.CustomValidators;
using Common.Models.ViewModels.Nodes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.FluentValidators.NodeValidators
{
    public class CreateNodeValidator : AbstractValidator<NodeCreateViewModel>
    {
        public CreateNodeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field is required.")
                .MaximumLength(256).WithMessage("Maximum allowed character count is 256.");

            RuleFor(x => x.ImageFile).SetValidator(new UploadImageFileValidator());

            RuleFor(x => x.StartDate).NotEmpty().WithMessage("This field is required.")
                .LessThan(x => x.EndDate).WithMessage("Start date cannot be later than end date.")
                .Must(BeAValidDate).WithMessage("Start date cannot be that old-timer.");

            RuleFor(x => x.EndDate).NotEmpty().WithMessage("This field is required.")
                .GreaterThan(x => x.StartDate).WithMessage("End date cannot be older than start date.");

            RuleFor(x => x.Review.Rate).NotEmpty().WithMessage("This field is required.")
                .LessThan(6).WithMessage("Rate cannot be more than 5.")
                .GreaterThan(-1).WithMessage("Rate cannot be less than 0.");

            RuleFor(x => x.Review.Difficulty).NotEmpty().WithMessage("This field is required.")
                .LessThan(6).WithMessage("Rate cannot be more than 5.")
                .GreaterThan(-1).WithMessage("Rate cannot be less than 0.");

            RuleFor(x => x.SocialMedia.TwitterLink).Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).When(x => !string.IsNullOrEmpty(x.SocialMedia.TwitterLink)).WithMessage("This field should be a valid http link");

            RuleFor(x => x.SocialMedia.DiscordLink).Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).When(x => !string.IsNullOrEmpty(x.SocialMedia.DiscordLink)).WithMessage("This field should be a valid http link");

            RuleFor(x => x.SocialMedia.TelegramLink).Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).When(x => !string.IsNullOrEmpty(x.SocialMedia.TelegramLink)).WithMessage("This field should be a valid http link");

            RuleFor(x => x.SocialMedia.WebPageLink).Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).When(x => !string.IsNullOrEmpty(x.SocialMedia.WebPageLink)).WithMessage("This field should be a valid http link");
        }

        private bool BeAValidDate(DateTime date)
        {
            if (date.Year < DateTime.Now.Year - 1)
            {
                return false;
            }
            return true;
        }
    }
}
