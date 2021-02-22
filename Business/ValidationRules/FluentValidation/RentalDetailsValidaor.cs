using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalDetailsValidaor:AbstractValidator <RentalDetails>
    {

        //ctor tab + tab
        public RentalDetailsValidaor()
        {

        }
    }
}
