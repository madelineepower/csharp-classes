using System;
using System.Linq;
using System.Collections.Generic;

namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("Murphy LLC", DateTime.Now);
            Employee employee1 = new Employee("Madeline", "Mom", DateTime.Now);
            Employee employee2 = new Employee("Russell", "Dad", DateTime.Now);
            Employee employee3 = new Employee("Martha", "Aunt", DateTime.Now);

            company1.AddEmployee(employee1);
            company1.AddEmployee(employee2);
            company1.AddEmployee(employee3);

            company1.ListEmployees();

        }
    }
}


public class Company
{
     /*
        Some readonly properties
     */
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a property for holding a list of current employees
    public List<Employee> EmployeeList = new List<Employee>();

    // Create a method that allows external code to add an employee
    public void AddEmployee(Employee person) {
        EmployeeList.Add(person);
    }
    // Create a method that allows external code to remove an employee
    public void RemoveEmployee(Employee person) {
        EmployeeList.Remove(person);
    }
    
    /*
     Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

     The constructor will set the value of the public properties
    */
    public Company (string name, DateTime date) {
        this.Name = name;
        this.CreatedOn = date;
    }
    public void ListEmployees() {
        foreach (Employee person in EmployeeList) {
            Console.WriteLine($"{person.Name} started on {person.StartDate} as the {person.Title}");
        }
    }
}

public class Employee 
{
    public string Name {get;set;}
    public string Title {get;set;}
    public DateTime StartDate {get;set;}

    public Employee (string name, string title, DateTime date)
    {
        this.Name = name;
        this.Title = title;
        this.StartDate = date;
    }
}