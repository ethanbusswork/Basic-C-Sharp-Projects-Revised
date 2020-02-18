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
    }
}
