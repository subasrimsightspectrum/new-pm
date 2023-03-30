using Microsoft.AspNetCore.Mvc;  //Build Namespace

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        #region Default Constructor
        int a, b, c = 4; string d = "8"; string name = "";
        int x = 3; //int - dtatype , x- variable, 3 -value <data type> <variable name> = <value>;
      
        public ValuesController()
        {
            a = c; b = int.Parse(d);
            name = d;
        }
        #endregion
        #region Parameterized Constructor
        public ValuesController(int Id, string Name)
        {
            a = Id;
            d = Name;
        }
        #endregion
        #region Copy Constructor
        public ValuesController(ValuesController values)
        {
            a = values.a;
            d = values.d;
        }
        #endregion
        #region Static Constructor
        public class employee
        {
            static employee() // Static constructordeclaration
            {
                Console.WriteLine("The static constructor ");
            }
            public static void Salary()
            {
                Console.WriteLine();
                Console.WriteLine("The Salary method");
            }

        }
        #endregion
        public static void main()
        {
            ValuesController valuesController = new ValuesController();  /// Default Constructor
            Console.WriteLine(valuesController.a);
            Console.WriteLine(valuesController.b);
            Console.WriteLine(valuesController.name);

            ValuesController value = new ValuesController(23, "suba");   ///Parameterized Consrctor
            Console.WriteLine(value.a);
            Console.WriteLine(value.d);

            ValuesController value2 = new ValuesController(value);   ///Copy Consrctor
            Console.WriteLine(value2.a);
            Console.WriteLine(value2.d);

            Console.WriteLine("----------Static constrctor example by vithal wadje------------------");
            Console.WriteLine();
            employee.Salary();
            Console.ReadLine();
        }

    }
}

//namespace Test
//{
//    class Student
//    {
//        public int Id { get; set; }
//    }
//}