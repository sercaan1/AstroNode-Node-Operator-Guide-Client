using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.FluentValidators.CustomValidators
{
    public class UploadImageFileValidator : AbstractValidator<IFormFile>
    {
        public UploadImageFileValidator()
        {
            RuleFor(x => x.Length).LessThanOrEqualTo(1048576)
                .WithMessage("File cannot be larger than 1 mb.");

            RuleFor(x => x.ContentType).Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
                .WithMessage("File types are: jpeg, jpg and png.");
        }
    }
}
