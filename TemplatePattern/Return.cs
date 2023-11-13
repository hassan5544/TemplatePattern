using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Return : Document
    {
        public override decimal TotalAmount { get { return Qty * UnitPrice * -1; } }

        public override void GetUserInput()
        {
            Return userInput = new Return();

            Console.WriteLine("This is a Return");
            Console.WriteLine("Input Qty");
            userInput.Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input UnitPrice");
            userInput.UnitPrice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Net Is" + userInput.TotalAmount.ToString());
        }
    }
}
