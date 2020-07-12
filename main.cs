using System;

class MainClass {
  public static void Main (string[] args) {
  
  // Test Case #1: Initiate new Employee using default constructor
  Employee employee1 = new Employee();
  employee1.Intro();

  // Test Case #2:  Initiate new Employee using constructor and parameters
  Employee employee2 = new Employee("Robert","Downey","12321",12, 0);
  employee2.Intro();

  
  // Test Case #3:  Initiate new Employee using constructor and parameters, then try negative salary increase adn then try to remove the employee.
  Employee employee3 = new Employee("John","Smith","S0089",38, 50000);
  employee3.Intro();
  employee3.IncreaseSalary(-2.2); 
  employee3.RemoveEmployee();
  
  // Test Case #4:  Initiate new Employee using constructor and parameters, then try positive salary increase adn then try to remove the employee twice.
  Employee employee4 = new Employee("Maria","Lambert","S0100",26, 80000);
  employee4.Intro();
  employee4.IncreaseSalary(7); 
  employee4.RemoveEmployee();
  employee4.RemoveEmployee();
  
  }
}