using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFinalProject
{
    class ValidatorDirector : Validator
    {
        private Validator next;
        private static String error_message = "";

        public static string Error_message { get => error_message; set => error_message = value; }

        public override Validator getNext()
        {
            return next;
        }

        public override void setNext(Validator validator)
        {
            next = validator;
        }

        public override void startSimulation(int[] to_validate)
        {
            NumberOfBusesValidator numberOfBusesValidator = new NumberOfBusesValidator();
            AvailabilityProductsValidator availabilityProductsValidator = new AvailabilityProductsValidator();
            InsufficientBusesValidator insufficientBusesValidator = new InsufficientBusesValidator();

            numberOfBusesValidator.setNext(availabilityProductsValidator);

            
            availabilityProductsValidator.setNext(insufficientBusesValidator);

            
            numberOfBusesValidator.startSimulation(to_validate);

            setErrorMessage(numberOfBusesValidator.getErrorMessage());
        }

        public override String getErrorMessage()
        {
            return Error_message;
        }

        public void setErrorMessage(String _error_message)
        {
            Error_message = _error_message;
        }
    }
}
