using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WebApplication1.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    // Web attribute
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {

        public int DoAddValues(AddValues addValues)
        {
            return addValues.value1 + addValues.value2;
        }

        public string DoWork()
        {
            return "Hello World";
        }

        public int DoFib(int n)
        {
            return fib(n);
        }

        public int DoSquare(int value)
        {
            return value*value;
        }
        
        public int fib(int n)
        {
            if (n<2)
            {
                return 1;
            } else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int value1 { get; set; }
        [DataMember]
        public int value2 { get; set; }

        public AddValues()
        {
            value1 = 0;
            value1 = 0;

        }
    }
}
