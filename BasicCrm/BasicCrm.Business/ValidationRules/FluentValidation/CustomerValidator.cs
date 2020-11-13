using FluentValidation;
using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Can't be Empty!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("SurName Can't be Empty!");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age Can't be Empty!");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Gender Can't be Empty!");
            RuleFor(x => x.Job).NotEmpty().WithMessage("Job Can't be Empty!");
            RuleFor(x => x.City).NotEmpty().WithMessage("City Can't be Empty!");

            RuleFor(x => x.Age).GreaterThanOrEqualTo((byte)0).LessThanOrEqualTo((byte)255);

            RuleFor(x => x.Gender).Must(MOrF).WithMessage("Gender Must be M or F!");
        }

        private bool MOrF(char arg)
        {
            if (arg == 'M' || arg == 'F')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
