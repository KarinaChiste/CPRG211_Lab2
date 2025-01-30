using Lab2;

const string PATH = @"..\..\..\res\employees.txt";
const char sep = ':';

List<Employee> employees = new List<Employee>();
StreamReader streamReader = new StreamReader(PATH);
string line;
string[] fields;
string prefix;
string[] salaryId = ["0", "1", "2", "3", "4"];
string[] wageId = ["5", "6", "7"];
string[] partTimeId = ["8", "9"];

while(!streamReader.EndOfStream)
{
    line = streamReader.ReadLine();
    fields = line.Split(sep);
    //fields[0] = id
    //fields[7] - fields [8] = salary or time and wages
    Employee emp = null;
    prefix = fields[0].Substring(0,1);
    if (salaryId.Contains(prefix))
    {
        emp = new Salaried(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5], fields[6], Double.Parse(fields[7]));
    }
    else if (wageId.Contains(prefix)) 
    {
        emp = new Wages(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5], fields[6], Double.Parse(fields[7]), Double.Parse(fields[8]));
    }
    else if(partTimeId.Contains(prefix))
    {
        emp = new PartTime(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5], fields[6], Double.Parse(fields[7]), Double.Parse(fields[8]));
    }
    employees.Add(emp);
}

double totalPay = 0;
double highestWage = 0;
string highestWageName = null;
double lowestSalary = Double.MaxValue;
string lowestSalaryName = null;
double salariedEmployees = 0;
double partTimeEmployees = 0;
double wageEmployees = 0;

foreach(Employee emp in employees)
{
    //Console.WriteLine(emp);
    totalPay += emp.CalculatePay();
    
    if(emp.GetType() == typeof(Wages))
    {
        if (emp.CalculatePay() > highestWage)
        {
            highestWage = emp.CalculatePay();
            highestWageName = emp.Name;
        }
        wageEmployees++;
    }
    if (emp.GetType() == typeof(Salaried))
    {
        if (emp.CalculatePay() < lowestSalary)
        {
            lowestSalary = emp.CalculatePay();
            lowestSalaryName = emp.Name;
        }
        salariedEmployees++;
    }
    if (emp.GetType() == typeof(PartTime))
    {
        partTimeEmployees++;
    }

}

double averagePay = totalPay / employees.Count;
Console.WriteLine($"Average Pay: {averagePay.ToString("c")}");

Console.WriteLine($"{highestWageName} is the weekly top earning Wage Employee making {highestWage.ToString("c")}");
Console.WriteLine($"{lowestSalaryName} has the lowest salary at {lowestSalary.ToString("c")}");

Console.WriteLine($"Part Time Employee Percentage: {((int)(partTimeEmployees/ employees.Count * 100))}%");
Console.WriteLine($"Salaried Employee Percentage: {((int)(salariedEmployees / employees.Count *100))}%");
Console.WriteLine($"Wages Employee Percentage: {((int)(wageEmployees / employees.Count * 100))}%");