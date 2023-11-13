using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Document
    {
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual decimal TotalAmount { get { return Qty * UnitPrice; } }

        public virtual void GetUserInput()
        {
            Document userInput = new Document();
            Console.WriteLine("Input Qty");
            userInput.Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input UnitPrice");
            userInput.UnitPrice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Net Is" + userInput.TotalAmount.ToString());
        }

    }
}
