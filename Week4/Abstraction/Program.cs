class Program
{
    static void Main(string[] args)
    {
        // Create a Project Manager object
        ProjectManager manager = new ProjectManager
        {
            EmployeeName = "Lumi",
            EmployeeSurname = "Parlayan",
            Department = "Management Department"
        };
        manager.DisplayEmployeeInfo();
        manager.PerformDuty();

        Console.WriteLine();

        // Create a Software Developer object
        SoftwareDeveloper developer = new SoftwareDeveloper
        {
            EmployeeName = "Ahmet",
            EmployeeSurname = "Avcı",
            Department = "Software Department"
        };
        developer.DisplayEmployeeInfo();
        developer.PerformDuty();
    }
}