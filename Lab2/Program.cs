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
        emp = new Wages(fields[0], fields[1], fields[2], fields[3], long.Parse(fields[4]), fields[5], fields[6], Double.Parse(fields[7]), Double.Parse(fields[8]));
    }
    employees.Add(emp);
}


foreach(Employee emp in employees)
{
    Console.WriteLine(emp);
}
