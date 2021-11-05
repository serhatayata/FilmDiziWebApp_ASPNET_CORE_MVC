using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.Infrastructure
{
    public class MustBeTrueAttribute:Attribute,IModelValidator
    {
        public bool IsRequired => true;
        public string ErrorMessage { get; set; } = "You have to accept the terms.";
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var value = context.Model as bool?;
            if (!value.HasValue || value.Value == false)
            {
                return new List<ModelValidationResult> { new ModelValidationResult("", ErrorMessage) };
            }
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
    }
}
