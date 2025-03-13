using Assignment.Classes;

Human human = new Human();
human.Name = "John";
human.Age = 25;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = 75;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = 100;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = -1;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = 0;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = 18;
Console.WriteLine(human.ageCategory(human.Age));

human.Age = 35;
Console.WriteLine(human.ageCategory(human.Age));

Car car = new Car();
car.Age = 5;
Console.WriteLine(car.ageCategory(car.Age));

car.Age = 15;
Console.WriteLine(car.ageCategory(car.Age));

car.Age = 25;
Console.WriteLine(car.ageCategory(car.Age));

car.Age = 35;
Console.WriteLine(car.ageCategory(car.Age));

Intern intern = new Intern();
intern.Name = "Jane";
intern.Surname = "Doe";
intern.Job = "Intern";
intern.Department = "IT";
intern.Salary = 1000;
intern.Features(intern.Name, intern.Surname, intern.Job, intern.Department, intern.Salary);

Developer developer = new Developer();
developer.Name = "Jack";
developer.Surname = "Smith";
developer.Job = "Developer";
developer.Department = "IT";
developer.Salary = 5000;
developer.Features(developer.Name, developer.Surname, developer.Job, developer.Department, developer.Salary);

GeneralManager generalManager = new GeneralManager();
generalManager.Name = "Jill";
generalManager.Surname = "Brown";
generalManager.Job = "General Manager";
generalManager.Department = "Management";
generalManager.Salary = 10000;
generalManager.Features(generalManager.Name, generalManager.Surname, generalManager.Job, generalManager.Department, generalManager.Salary);

Manager manager = new Manager();
manager.Name = "James";
manager.Surname = "White";
manager.Job = "Manager";
manager.Department = "Management";
manager.Salary = 7000;
manager.Features(manager.Name, manager.Surname, manager.Job, manager.Department, manager.Salary);

double totalSalary = intern.Salary + developer.Salary + generalManager.Salary + manager.Salary;
Console.WriteLine("Total salary of the company: " + totalSalary + "£");
