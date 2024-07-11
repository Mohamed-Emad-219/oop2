using System.ComponentModel;
using System;
using System.Reflection;

namespace oop2
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    
    enum Gender
    {
        Male,
        Female
    }

    class Employee
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }

        // Constructor
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

       
        public override string ToString()
        {
            return $"{Name} (ID: {ID}) - {SecurityLevel}, Salary: {Salary:C}, Gender: {Gender}, Hire Date: {HireDate.ToShortDateString()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            //Inheritance is a fundamental concept in (OOP).
            //It allows a class (the derived class or subclass)
            //to inherit properties and behavior from another class
            //(the base class or superclass).
            //When a class inherits from another class,
            //it implicitly contains all members(fields, properties, methods)
            //of the base class, except for constructors and static constructors.
            // we use : to inherit


            /*
             
             Common access modifiers in C#:
public: Members are accessible from any code.
private: Members are only accessible within the same class.
protected: Members are accessible within the same class and derived classes.
internal: Members are accessible within the same assembly (project).
protected internal: A combination of protected and internal.
Important Points:
Private members are not inherited by derived classes. They remain private to the base class.
Protected members are inherited and accessible within derived classes.
Public members are inherited and accessible everywhere.
If you omit an access modifier, the default is internal for classes and private for members.

             */
            #endregion

            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "John", SecurityLevel.DBA, 75000, new DateTime(2022, 5, 15), Gender.Male);
            EmpArr[1] = new Employee(2, "Alice", SecurityLevel.Guest, 50000, new DateTime(2021, 8, 10), Gender.Female);
            EmpArr[2] = new Employee(3, "Bob", SecurityLevel.Secretary, 60000, new DateTime(2023, 3, 20), Gender.Male);

             
            Array.Sort(EmpArr, (emp1, emp2) => emp1.HireDate.CompareTo(emp2.HireDate));

             
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

             
            int boxingCount = 0;
            int unboxingCount = 0;
            foreach (var emp in EmpArr)
            {
                if (emp is object)  
                    boxingCount++;
                if (emp != null)  
                    unboxingCount++;
            }

            Console.WriteLine($"Boxing operations: {boxingCount}");
            Console.WriteLine($"Unboxing operations: {unboxingCount}");
        }

    }
    }

