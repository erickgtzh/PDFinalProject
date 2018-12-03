using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFinalProject
{
    abstract class Validator
    {
        public abstract void setNext(Validator validator);
        public abstract Validator getNext();
        public abstract void startSimulation(int[] to_validate);
        public static String errors = "";
        public abstract String getErrorMessage();
    }
}
