using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Dependency Injection
            /*
            User user = new User();
            user.Print();
            Console.ReadKey();
            */

            //Extension Method

            //string a =null;
            //a.ExtMethod();
            //Console.Read();

            //Anonymous type

            //var x = new { color = "Black", Height = 20 };
            //Console.WriteLine("{0}+{1}", x.color, x.Height);
            //Console.Read();

            //Out Param
            //string name;
            //int keyValue;
            //bool boolValue;
            //A obj = new A();
            //obj.OutParamMethod(out keyValue, out name, out boolValue);

            //Console.WriteLine("1:{0}, 2:{1}, 3:{2}", name, keyValue, boolValue);
            //Console.Read();


            //A obj = new A();
            //obj.OutParamMethod(out int keyValue, out string name, out bool boolValue);
            //Console.WriteLine("1:{0}, 2:{1}, 3:{2}", name, keyValue, boolValue);
            //Console.Read();


            //ref Param
            //string name = "chnage";
            //int keyValue = 10;
            //bool boolValue = false;
            //A obj = new A();
            //obj.RefParamMethod(ref keyValue, ref name, ref boolValue);
            //Console.WriteLine("1:{0}, 2:{1}, 3:{2}", name, keyValue, boolValue);
            //Console.Read();

            A.StaticMethod();
            Console.Read();
        }

    }
    class User
    {
        private IService _service;
        public User()
        {
            this._service = new Service();
        }
        public void Print()
        {
            _service.Print();
        }
    }

    class Service : IService
    {
        public void Print()
        {
            Console.WriteLine("From Service");
        }
    }
    public interface IService
    {
        void Print();
    }

}
