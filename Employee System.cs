Employee System


namespace Employee_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // موظف بمرتب صحيح

            Empolyee e1 = new Empolyee("Abdo",5000);
            Console.WriteLine("Employee 1");
            Console.WriteLine("Name   : " + e1.Name);
            Console.WriteLine("Salary : " + e1.Salary);
            Console.WriteLine("----------------");
            // موظف بمرتب أقل من الحد الأدنى

            Empolyee e2 = new Empolyee("Ali", 1500);
            Console.WriteLine("Employee 2");
            Console.WriteLine("Name   : " + e2.Name);
            Console.WriteLine("Salary : " + e2.Salary);


        }
    }
    public class Empolyee
    {
        public string Name { get; set; }
        private double _salary;
        // Full Property (المرتب + Validation)
        public double Salary
        {
            get
            {
                 return this._salary; 


            }
            set
            {
               
                if (_salary < 3000)
                {
                    _salary = 3000;
                }
                else
                {
                    _salary = value;
                }
             
            }
        }
        // Constructor

        public Empolyee(string name ,double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

    }
   
}