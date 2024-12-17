using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{    
    /// Comment first: abracadabra  
    /// This change from you
    ///step Third jfvgfrhgvojrjvgr'jejvrepjvjr'j 
    /// dop
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMetod();
            creator.FactoryMetod();


            Console.ReadLine();
        }
    }
}
