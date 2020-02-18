using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Employee : Person, IQuittable
    {
         
        public int ID { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        //public override void SayName()
        //{
        //    base.SayName();
        //    Console.WriteLine("ID: " + ID);
        //    Console.Read();
        //}

        //public static bool operator ==(Employee p, Employee a)
        //{
        //    bool equality = (p.ID == a.ID);
        //    return equality;
        //}
        //public static bool operator !=(Employee p, Employee a)
        //{
        //    bool equality = (p.ID != a.ID);
        //    return equality;
        //}
    }
}
