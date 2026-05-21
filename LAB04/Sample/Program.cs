using OOP_COLLECTIONS;
using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. Cоздать отдел с названием "IT"
        // =========================
        Department itDepartment = new Department("IT");


        // =========================
        // 2. Cоздать 2-х рабочих
        // =========================
        Worker worker1 = new Worker( "Ксения Ясюкевич", 115, 7);
        Worker worker2 = new Worker( "Милена Ахрем", 110, 9);


        // =========================
        // 3. Cоздать 2-х программистов
        // =========================
        Programmer programmer1 = new Programmer( "Анна Станевская", 800, "Mid" );
        Programmer programmer2 = new Programmer( "Анастасия Рогунович", 500, "Junior");

        // =========================
        // 4. Cоздать 1-го менеджера
        // =========================
        Manager manager1 = new Manager("Ульяна Шульгина", 800, 7);



        // =========================
        // 5. Добавить всех сотрудников в отдел
        // =========================
        itDepartment.AddEmployee(worker1);
        itDepartment.AddEmployee(worker2);
        itDepartment.AddEmployee(programmer1);
        itDepartment.AddEmployee(programmer2);
        itDepartment.AddEmployee(manager1);



        // =========================
        // 6. Вывести всех сотрудников отдела
        // =========================
        Console.WriteLine("=== Все сотрудники отдела ===");
        itDepartment.ShowAllEmployees();
        // =========================
        // 7. Найти сотрудников с Id 1, 3, 7 и вывести информацию о них
        // =========================
        Console.WriteLine("\n=== Тестируем поиск сотрудника ===");
        Employee emp1 = itDepartment.FindEmployeeById(1);
        Employee emp3 = itDepartment.FindEmployeeById(3);
        Employee emp7 = itDepartment.FindEmployeeById(7);
        Console.WriteLine("Employee с ID 1:");
        if (emp1 != null) emp1.DisplayInfo(); else Console.WriteLine("Не найден");

        Console.WriteLine("\nEmployee with ID 3:");
        if (emp3 != null) emp3.DisplayInfo(); else Console.WriteLine("Не найден");

        Console.WriteLine("\nEmployee with ID 7:");
        if (emp7 != null) emp7.DisplayInfo(); else Console.WriteLine("Не найден");
        // =========================
        // 8. Удалить сотрудника с Id = 2
        // =========================
        Console.WriteLine("\n=== Тестируем удаление сотрудника ===");
        bool removed = itDepartment.RemoveEmployeeById(2);
        Console.WriteLine(removed ? "Employee с ID 2 был удалён" : "Employee с ID 2 не найден");


        // =========================
        // 9. Вывести всех сотрудников отдела после удаления
        // =========================
        Console.WriteLine("\n=== После удаления ===");
        itDepartment.ShowAllEmployees();
        // =========================
        // 10. Вывести на экран сводную информацию об отделе
        // =========================
        Console.WriteLine("\n=== Статистика Отдела ===");
        itDepartment.GetDepartmentInfo();
    }
}