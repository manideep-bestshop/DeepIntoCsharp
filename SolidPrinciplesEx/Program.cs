using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesEx
{
    // Single Responsibility Principle
    // Each class should have only one responsibility.

    // Interface for payroll calculation strategy
    public interface IPayrollCalculator
    {
        decimal CalculatePay(Employee employee);
    }

    // Employee class
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    // PayrollCalculator class responsible for calculating pay
    public class PayrollCalculator : IPayrollCalculator
    {
        public decimal CalculatePay(Employee employee)
        {
            // Simulated payroll calculation logic
            // For simplicity, just return the salary
            return employee.Salary;
        }
    }

    // EmployeeRepository class responsible for storing employee data
    public class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }
    }

    // PayrollProcessor class responsible for processing payroll
    public class PayrollProcessor
    {
        private IPayrollCalculator payrollCalculator;

        public PayrollProcessor(IPayrollCalculator calculator)
        {
            payrollCalculator = calculator;
        }

        public void ProcessPayroll(EmployeeRepository repository)
        {
            foreach (var employee in repository.GetAllEmployees())
            {
                decimal pay = payrollCalculator.CalculatePay(employee);
                Console.WriteLine($"Employee {employee.Name} - Pay: {pay}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employee repository
            var repository = new EmployeeRepository();
            repository.AddEmployee(new Employee { Name = "John", Salary = 5000 });
            repository.AddEmployee(new Employee { Name = "Alice", Salary = 6000 });

            // Create payroll calculator
            var calculator = new PayrollCalculator();

            // Create payroll processor
            var payrollProcessor = new PayrollProcessor(calculator);

            // Process payroll
            payrollProcessor.ProcessPayroll(repository);
        }
    }
}
