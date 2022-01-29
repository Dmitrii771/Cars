using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Plane : Transport
    {
        public Plane(string mark, string model, string number)
            : base(mark, model, number) { }
        public override void Move()
        {
            Console.WriteLine("Самолет летит");
        }




    }
}
