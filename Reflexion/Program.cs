using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaTrieda tr = new MojaTrieda();


            Type t = tr.GetType();
            var prop = t.GetProperties();
            prop[0].SetValue(tr, 500);
            prop[1].SetValue(tr, "ajpj");
        }
    }

    public class MojaTrieda
    {
        public int MyProperty { get; set; }
        public string MyProperty2 { get; set; }
    }

}
