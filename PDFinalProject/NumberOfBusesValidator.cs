using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    class NumberOfBusesValidator : Validator
    {
        private Validator next;
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

            
            if (to_validate[0] > 5 || to_validate[0] == 0)
            {
                //Console.WriteLine("Handled by NumberOfBusesValidator");
                errors = "Please update the number of the buses. \n(Max = 1, Min = 5)" + Environment.NewLine;
            }
            else if(next != null)
            {
                next.startSimulation(to_validate);
            }

        }
        
        public override String getErrorMessage()
        {
            return errors;
        }

    }
}
