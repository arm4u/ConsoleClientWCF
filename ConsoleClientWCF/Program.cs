using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.MyServiceClient client = new ServiceReference1.MyServiceClient();
            ServiceReference1.Res res = client.MyFunc(new ServiceReference1.Req { Id = 6 });

            Console.WriteLine(res.ID + " - " + res.Name + " - " + res.Birthdate);

            Console.Read();
        }
    }
}
