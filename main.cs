using System;


class Program {
  public static double DetermineHypotenuse(double side1, double side2)  {
    
    double hypotenuse = Math.Sqrt((side1 * side1) +(side2 * side2));
    return hypotenuse; 
  }




    public static void Main (string[] args) {
     Console.WriteLine("Enter side1." );
    double side1a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter side2.");
    double side2a = Convert.ToDouble(Console.ReadLine());
    
  double hypotenuseoftriangle  = 0;

  hypotenuseoftriangle = DetermineHypotenuse(side1a,side2a);
  


  Console.WriteLine("Hypotenuese of the triangle is " + hypotenuseoftriangle);
}
}