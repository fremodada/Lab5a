using System;

/**** Define Employee class  ****/

class Employee {

// Define fields
private string firstname;
private string lastname;
private string id;
private int age;
private string address;
private string title;
private double yearlysalary;
private string employmentstatus;


// Define properties
public string FirstName
{get;set;}

public string LastName
  {get;set;}

public int Age
{
  get { return age;}
  set 
  {
    if (value >= 18) // Employee age check.  Age must be > 18
    {
      age = value;
    }  
    else
      {
      //Default age to 18
      age = 18;
      }
    }       
}

public double YearlySalary
{
  get{return yearlysalary;}
  set
  {
    // Minimum salary must be $1000
    if (value < 1000)
    yearlysalary = 1000;
    else
    yearlysalary = value;
  }
}
public string ID
  {get;set;}

public string EmploymentStatus
  {get;set;}


// Define default constructor
public Employee()
{
  FirstName = "Unknown";
  LastName ="Unknown";
  ID = "Unknown";
  Age = 0;
  EmploymentStatus = "active";
  }

// Define constructor with parameters
public Employee(string firstname, string lastname, string id, int age, double yearlysalary)
{
  FirstName = firstname;
  LastName = lastname;
  ID = id;
  Age = age; 
  EmploymentStatus = "active";
  YearlySalary = yearlysalary;
}

// Define method: Intro
public void Intro()
{
  Console.WriteLine(" ");
  Console.WriteLine ("EMPLOYEE RECORD:");
  Console.WriteLine ("---------------");
  Console.WriteLine("First Name: " + FirstName);
  Console.WriteLine("Last Name: " + LastName);
  Console.WriteLine("ID: " + ID);
  Console.WriteLine("Age: " + Age);
  Console.WriteLine("Yearly Salary: $" + YearlySalary);
  Console.WriteLine(" ");
}

// Define method: IncreaseSalary
public double IncreaseSalary(double percent)
{
  double salaryincrease = yearlysalary + (percent / 100) * yearlysalary;
  if (percent < 0)
  {
    Console.WriteLine("Invalid Input - negative percent increase not allowed.  Yearly Salary not updated.");
  }
  else 
  {
    Console.WriteLine("Yearly salary updated to $" + salaryincrease);
  }
  return salaryincrease;
}

// Define method: RemoveEmployee
public void RemoveEmployee()
{
  if (EmploymentStatus == "active")
  {
    // Set employee status to inactive
    EmploymentStatus = "inactive";
    Console.WriteLine("Employee removed.");
  }
  else
  {
    Console.WriteLine("Employee already inactive." );
  }
}


}  /***** End of Employee class *****/