namespace practice2_srp.entities;

public class Person
{
     public Person(string name, int age, string direction, string email)
     {
          Name = name;
          Age = age;
          Direction = direction;
          Email = email;
     }

     private string Name { get; set; } 
     private int Age { get; set; }
     private string Direction { get; set; } 
     private string Email { get; set; } 

     public void PrintData()
     {
          Console.WriteLine($"Nombre: {Name}");
          Console.WriteLine($"Age: {Age}");
          Console.WriteLine($"Direction: {Direction}");
          Console.WriteLine($"Email: {Email}");
     }
}