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
        List<Order> orders = new List<Order>();
        int[] array = new int[3];

        public int[] Array { get => array; set => array = value; }

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
            OrderGenerator generator = new OrderGenerator();
            int number_of_vegetables = 0;
            int number_of_sodas = 0;
            int number_of_bread = 0;

            array[0] = to_validate[2];
            array[1] = to_validate[3];
            array[2] = to_validate[4];
            
            orders = generator.getOrder();

            errors = "";
            foreach (var i in orders)
            {
                number_of_vegetables += i.products[0].quantity;
                number_of_sodas += i.products[1].quantity;
                number_of_bread += i.products[2].quantity;
            }

            int sum_prod = number_of_vegetables + number_of_sodas + number_of_bread;

            if (sum_prod > to_validate[1])
            {
                //Console.WriteLine("Handled by AvailabilityProductsValidator");
                errors = "We don't have capacity to manage this amount of products, sorry." + Environment.NewLine;
            }
            else if (next != null)
            {
                next.startSimulation(to_validate);
            }
        }

        public override string getErrorMessage()
        {
            return errors;
        }
    }
}
