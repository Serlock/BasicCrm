﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.Utilities
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors[0].ToString());
            }
        }
    }
}
