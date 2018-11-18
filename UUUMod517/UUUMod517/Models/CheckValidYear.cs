using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UUUMod517.Models
{
    public class CheckValidYear : ValidationAttribute
    {

        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne 1598,by corsi,peri,and rinuccini";
        }

        public override bool IsValid(object value)
        {
            int? year = (int?)value;
            if(year < 1598){
                return false;
            }
            else
            {
                return true;
            }
            //return base.IsValid(value);
        }
    }
}