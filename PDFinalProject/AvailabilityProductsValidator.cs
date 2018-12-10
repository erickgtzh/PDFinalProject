using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    class AvailabilityProductsValidator : Validator
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
            
            
            if (to_validate[1] > 1455)
            {
                //Console.WriteLine("Handled by AvailabilityProductsValidator");
                errors = "We don't have capacity to manage this amount of products, sorry." + Environment.NewLine;
                //next = null;
            }
            else if (next != null)
            {
                next.startSimulation(to_validate);
                //to_Ret = "Simulation has started.";
            }
        }

        public override string getErrorMessage()
        {
            return errors;
        }
    }
}
