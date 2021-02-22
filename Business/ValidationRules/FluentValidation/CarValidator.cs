using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator <Car>
    {

        //ctor tab + tab

        public CarValidator()
        {

            RuleFor(c=> c.DailyPrice).GreaterThanOrEqualTo(7500);
            RuleFor(c => c.Id).NotEmpty();
            

        }

        
    }
}
