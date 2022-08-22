using System;

class Program {
  public static void Main (string[] args) {


      string name1;    
      int age1;
      string favclr1;

      Console.WriteLine("Ivan's info has been declared \n");

      string name2;    
      int age2;
      string favclr2;

      Console.WriteLine("Veer's info has been declared \n");


      name1 = "ivan";
      age1 = 15;
      favclr1 = "red";

      Console.WriteLine("Name is: "+name1+" \n age is: "+age1+"\n favorite color is "+ favclr1+"\n");

      name2 = "veer";
      age2 = 16;
      favclr2 = "green";

      Console.WriteLine("Name is: "+name2+" \n age is: "+age2+" \n favorite color is "+favclr2+"\n");


      name1 = "ivan";
      age1 = 21;
      favclr1 = "blue";
      

      name2 = "veer";
      age2 = 30;
      favclr2 = "black";

      
      Console.WriteLine("\n                                Time has now passed... variables have changed value...\n ");
      
      Console.WriteLine("Name is: "+name1+" \n age is: "+age1+  " \n favorite color is "+favclr1+"\n");
      
      Console.WriteLine("Name is: "+name2+" \n age is: "+age2+  " \n favorite color is "+favclr2+"\n");






  }
}