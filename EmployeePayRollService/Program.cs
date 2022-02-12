using EmployeePayRollService;

namespace EmployeePayrollADO.Net
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository repository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            repository.DataBaseConnection(); // UC1 Ensuring the database connection using the sql connection string
            repository.GetAllEmployeeData(); //UC2

            AddRecordInput();//UC2 add Record

            repository.UpdateBasicPay("Risa", 3000000);//UC3 update BasicPay where name is Terisa table 

            repository.UpdatedSalaryFromDatabase("Terisa"); //UC4

            repository.EmployeesFromForDateRange("2020-01-15"); //UC5

            repository.FindGroupedByGenderRecord("F");//UC6

            repository.InsertIntoMultipleTablesWithTransactions(); //UC7

            repository.RetrieveEmployeeDetailsFromMultipleTables();//UC8

            Console.ReadLine();
        }
        public static void AddRecordInput()
        {
            try
            {
                EmployeeRepository repository = new EmployeeRepository();//Creating a object of EmployeeRepository class.

                EmployeeModel model = new EmployeeModel();// Adding Employee To Database
                DateTime now = DateTime.Now;
                model.EmployeeId = 4;
                model.EmployeeName = "Risa";
                model.PhoneNumber = "1234567891";
                model.Address = "Mumbai";
                model.Department = "HR";
                model.Gender = "F";
                model.BasicPay = 20000;
                model.Deductions = 2000;
                model.TaxablePay = 100;
                model.Tax = 200;
                model.NetPay = 1800;
                model.StartDate = now;
                model.City = "Mumbai";
                model.Country = "IN";

                repository.AddEmployee(model);  //call AddEmployee method and pass model values       
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}