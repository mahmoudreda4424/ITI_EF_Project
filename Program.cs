using Microsoft.EntityFrameworkCore;
using Project_WithCodeFirst.Models;

namespace Project_WithCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n╔════════════════════════════════════╗");
                Console.WriteLine("║        MENU - Choose Option       ║");
                Console.WriteLine("╚════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" [1]  -> Add Employee");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" [2]  -> Add Department");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" [3]  -> Add Project");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" [4]  -> Edit Employee Data");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" [5]  -> Assign Employee To Department");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" [6]  -> Assign Employee to Project");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" [7]  -> Remove Employee from Project");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" [8]  -> Edit Department Data");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" [9]  -> Edit Project Data");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" [10] -> Delete Employee");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" [11] -> Delete Department");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" [12] -> Delete Project");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" [13] -> Display Employees");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" [14] -> Display Departments");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" [15] -> Display Projects");
                Console.ResetColor();

                Console.WriteLine(" [16] -> Exit");

                Console.Write("\nOption ... ");
                string opt = Console.ReadLine();



                switch (opt)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        AddEmployee();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        AddDepartment();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        AddProject();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        EditEmployee();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        AssignEmployeeToDepartment();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "6":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        AssignEmployeeToProject();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "7":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        RemoveEmployeeFromProject();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "8":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        EditDepartmentData();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "9":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        EditProjectData();
                        Console.ResetColor();
                        Console.Clear();
                        break;

                    case "10":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        DeleteEmployee();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "11":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        DeleteDepartment();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "12":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        DeleteProject();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "13":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        DisplayEmployees();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "14":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        DisplayDepartments();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "15":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        DisplayProjects();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "16":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }


            }
        }


      
        public static void AddDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department Name: ");
                string name = Console.ReadLine();

                var dept = new Department { Name = name };
                db.Departments.Add(dept);
                db.SaveChanges();

                Console.WriteLine("Department added successfully!");
            }
        }
        public static void AddEmployee() 
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

               

                var employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                db.Employees.Add(employee);
                db.SaveChanges();

                Console.WriteLine("Employee added successfully!");
            }
        }
        public static void AddProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Start Date (yyyy-mm-dd): ");
                DateTime start = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter End Date (yyyy-mm-dd): ");
                DateTime end = DateTime.Parse(Console.ReadLine());

                var project = new Project
                {
                    Name = name,
                    StartDate = start,
                    EndDate = end
                };

                db.Projects.Add(project);
                db.SaveChanges();

                Console.WriteLine("Project added successfully!");
            }
        }



        public static void EditEmployee()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID to edit: ");
                int id = int.Parse(Console.ReadLine());

                var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == id);

                if (emp != null)
                {
                    Console.WriteLine($"Current First Name: {emp.FirstName}");
                    Console.Write("New First Name : ");
                    string newFirstName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newFirstName))
                        emp.FirstName = newFirstName;

                    Console.WriteLine($"Current Last Name: {emp.LastName}");
                    Console.Write("New Last Name : ");
                    string newLastName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newLastName))
                        emp.LastName = newLastName;

                    db.SaveChanges();
                    Console.WriteLine("Employee name updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        public static void AssignEmployeeToDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Department ID to assign: ");
                int deptId = int.Parse(Console.ReadLine());

                var employee = db.Employees.Find(empId);
                var department = db.Departments.Find(deptId);

                if (employee == null)
                {
                    Console.WriteLine("Employee not found.");
                    return;
                }

                if (department == null)
                {
                    Console.WriteLine("Department not found.");
                    return;
                }

                employee.DepartmentId = deptId;
                db.SaveChanges();

                Console.WriteLine("Employee assigned to department successfully!");
            }
        }

        public static void RemoveEmployeeFromProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Project ID: ");
                int projId = int.Parse(Console.ReadLine());

                var emp = db.EmployeeProjects
                    .FirstOrDefault(ep => ep.EmployeeId == empId && ep.ProjectId == projId);

                if (emp != null)
                {
                    db.EmployeeProjects.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee removed from project.");
                }
                else
                {
                    Console.WriteLine("This employee is not assigned to the specified project.");
                }
            }
        }
        public static void EditDepartmentData()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department ID to edit: ");
                int deptId = int.Parse(Console.ReadLine());

                var department = db.Departments.FirstOrDefault(d => d.DepartmentId == deptId);
                if (department == null)
                {
                    Console.WriteLine("Department not found.");
                    return;
                }

                Console.WriteLine($"Current Name: {department.Name}");
                Console.Write("New Name : ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    department.Name = newName;
                    db.SaveChanges();
                    Console.WriteLine("Department updated successfully.");
                }
                else
                {
                    Console.WriteLine("No changes made.");
                }
            }
        }
        public static void EditProjectData()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project ID to edit: ");
                int projectId = int.Parse(Console.ReadLine());

                var project = db.Projects.FirstOrDefault(p => p.ProjectId == projectId);
                if (project == null)
                {
                    Console.WriteLine("Project not found.");
                    return;
                }

                Console.WriteLine($"Current Name: {project.Name}");
                Console.Write("New Name : ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                    project.Name = newName;

                Console.WriteLine($"Current Start Date: {project.StartDate:yyyy-MM-dd}");
                Console.Write("New Start Date (yyyy-MM-dd): ");
                string newStart = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newStart))
                    project.StartDate = DateTime.Parse(newStart);

                Console.WriteLine($"Current End Date: {project.EndDate?.ToString("yyyy-MM-dd") ?? "N/A"}");
                Console.Write("New End Date (yyyy-MM-dd): ");
                string newEnd = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEnd))
                    project.EndDate = DateTime.Parse(newEnd);

                db.SaveChanges();
                Console.WriteLine("Project updated successfully.");
            }
        }
        public static void AssignEmployeeToProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Enter Project ID: ");
                int projectId = int.Parse(Console.ReadLine());

                var employee = db.Employees.FirstOrDefault(e => e.EmployeeId == empId);
                var project = db.Projects.FirstOrDefault(p => p.ProjectId == projectId);

                if (employee != null && project != null)
                {

                    var empProject = new EmployeeProject
                    {
                        EmployeeId = empId,
                        ProjectId = projectId
                    };

                    db.EmployeeProjects.Add(empProject);
                    db.SaveChanges();

                    Console.WriteLine("Employee assigned to project successfully.");
                }
                else
                {
                    Console.WriteLine("Employee or Project not found.");
                }
            }
        }



        public static void DeleteDepartment()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Department ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var dept = db.Departments
                             .Include(d => d.Employees)
                             .FirstOrDefault(d => d.DepartmentId == id);

                if (dept != null)
                {
                    if (dept.Employees.Any())
                    {
                        Console.WriteLine("Can't delete department. It still has employees assigned.");
                    }
                    else
                    {
                        db.Departments.Remove(dept);
                        db.SaveChanges();
                        Console.WriteLine("Department deleted successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Department not found.");
                }
            }
        }
        public static void DeleteEmployee()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Employee ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var emp = db.Employees
                    .Include(e => e.EmployeeProjects)
                    .FirstOrDefault(e => e.EmployeeId == id);

                if (emp != null)
                {
                    emp.EmployeeProjects.Clear(); 
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        public static void DeleteProject()
        {
            using (var db = new CompanyDbContext())
            {
                Console.Write("Enter Project ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var proj = db.Projects
                             .Include(p => p.EmployeeProjects)
                             .FirstOrDefault(p => p.ProjectId == id);

                if (proj != null)
                {
                    proj.EmployeeProjects.Clear(); 
                    db.Projects.Remove(proj);
                    db.SaveChanges();
                    Console.WriteLine("Project deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Project not found.");
                }
            }
        }



        public static void DisplayDepartments()
        {
            using (var db = new CompanyDbContext())
            {
                var departments = db.Departments
                                    .Include(d => d.Employees)
                                    .ToList();

                foreach (var dept in departments)
                {
                    Console.WriteLine($"Department ID: {dept.DepartmentId}, Name: {dept.Name}");
                    Console.WriteLine("Employees:");

                    foreach (var emp in dept.Employees)
                    {
                        Console.WriteLine($"   - {emp.FirstName} {emp.LastName} (ID: {emp.EmployeeId})");
                    }

                    Console.WriteLine("----------------------------------------");
                }
            }
        }
        public static void DisplayEmployees()
        {
            using (var db = new CompanyDbContext())
            {
                var employees = db.Employees
                                  .Include(e => e.Department)
                                  .Include(e => e.EmployeeProjects)
                                  .ThenInclude(ep => ep.Project)
                                  .ToList();

                foreach (var emp in employees)
                {
                    Console.WriteLine($"Employee ID: {emp.EmployeeId}, Name: {emp.FirstName} {emp.LastName}");
                    Console.WriteLine($"Department: {(emp.Department != null ? emp.Department.Name : "None")}");

                    Console.WriteLine("Projects:");
                    foreach (var proj in emp.EmployeeProjects)
                    {
                        Console.WriteLine($"   - {proj.Project.Name}");
                    }

                    Console.WriteLine("----------------------------------------");
                }
            }
        }
        public static void DisplayProjects()
        {
            using (var db = new CompanyDbContext())
            {
                var projects = db.Projects
                                 .Include(p => p.EmployeeProjects)
                                 .ThenInclude(ep => ep.Employee)
                                 .ToList();

                foreach (var proj in projects)
                {
                    Console.WriteLine($"Project ID: {proj.ProjectId}, Name: {proj.Name}");
                    Console.WriteLine($"Duration: {proj.StartDate} to {proj.EndDate}");
                    Console.WriteLine("Assigned Employees:");

                    foreach (var emp in proj.EmployeeProjects)
                    {
                        Console.WriteLine($"   - {emp.Employee.FirstName} {emp.Employee.LastName} (ID: {emp.Employee.EmployeeId})");
                    }

                    Console.WriteLine("----------------------------------------");
                }
            }
        }

    }
}
