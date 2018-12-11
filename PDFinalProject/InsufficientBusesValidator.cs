using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    class InsufficientBusesValidator : Validator
    {
        Boolean flag = true;
        private Validator next;
        List<Order> orders = new List<Order>();
        int[] array = new int[3];

        public int[] Array { get => array; set => array = value; }

        public void setArrayProduct(int p1, int p2, int p3)
        {
            array[0] = p1;
            array[1] = p2;
            array[2] = p3;
        }

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
            array[0] = to_validate[2];
            array[1] = to_validate[3];
            array[2] = to_validate[4];

            if (!getProducts())
            {
                //Console.WriteLine("Handled by InsufficientBusesValidator");
                errors = "";
            }
            else if (next != null)
            {
                next.startSimulation(to_validate);
            }

        }

        public Boolean getProducts()
        {
            OrderGenerator generator = new OrderGenerator();
            //Transportation transportation = new Transportation();
            //int[] array = transportation.getNumberOfBuses();

            orders = generator.getOrder();
            int number_of_vegetables = 0;
            int number_of_sodas = 0;
            int number_of_bread = 0;
            errors = "";
            foreach (var i in orders)
            {
                number_of_vegetables += i.products[0].quantity;
                number_of_sodas += i.products[1].quantity;
                number_of_bread += i.products[2].quantity;
            }

            if (number_of_vegetables > array[0] )
            {
                int subtract = number_of_vegetables - array[0];
                errors += "Invalid operation, " + subtract + " kg's of frozen vegetables are left over." + Environment.NewLine;
            }
            if (number_of_sodas > array[1])
            {
                int subtract = number_of_sodas - array[1];
                errors += "Invalid operation, " + subtract + " sodas are left over." + Environment.NewLine;
            }
            if (number_of_bread > array[2])
            {
                int subtract = number_of_bread - array[2];
                errors += "Invalid operation, " + subtract + " packs of bread are left over." + Environment.NewLine;
            }
            if (number_of_vegetables <= array[0] && number_of_sodas <= array[1] && number_of_bread <= array[2])
            {
                //errors = "Simulation has started.";
                errors = "";
                flag = false;
            }

            return flag;
        }

        public override string getErrorMessage()
        {
            return errors;
        }
    }
}
