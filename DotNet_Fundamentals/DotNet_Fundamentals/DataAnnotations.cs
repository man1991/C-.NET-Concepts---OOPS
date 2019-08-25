using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    class DataAnnotations
    {
        static void Main(string[] args)
        {
            //Step 1: Create object which needs to be implemented
            Customer1 obj = new Customer1();

            //Due to Validation, [Required( ErrorMessage = "Name is Compulsory")]
            //obj.CustomerName = "";//False. Name is Compulsory

            //obj.CustomerName = "aaaaaaaaaaaaassss";//True

            //Due to Validation, [StringLength(20)]:  
            //obj.CustomerName = "aaaaaaaasaadefaaaassss"; False. The field CustomerName must be a string with a maximum length of 20.

            //Due to Validation, [RegularExpression(@"^[A-Z]{1,20}$")]:  
            obj.CustomerName = "AAABBBDDDDDDDDJJJJKWQ"; //False. The field CustomerName must match the regular expression '^[A-Z]{1,20}$'.

            //Step 2
            var context = new ValidationContext(obj, null, null);

            //Step 3
            var result = new List<ValidationResult>();//to get list of error messages and pass it to the TryValidateObject
            bool IsValid = Validator.TryValidateObject(obj, 
                                                        context,
                                                        result,
                                                        true);
            Console.WriteLine(IsValid);
            foreach(var x in result)
            {
                Console.WriteLine(x.ErrorMessage);
            }
            Console.Read();
        }
    }
    public class Customer1
    {
        private string _CustomerName;

        [Required( ErrorMessage = "Name is Compulsory")] // to customize error message if you don't want to throw default from ValidationResult
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]{1,20}$")]
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                _CustomerName = value;
            }
        }
    }
}
