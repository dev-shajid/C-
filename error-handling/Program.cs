using System;

namespace ErrorHandling{
    class Driver{
        public static void Main(){
            Console.Clear();
            Again:
            try{
                int choice=0;
                while(choice!=3){
                    Console.WriteLine("Choose:");
                    Console.WriteLine("1. Add Shape");
                    Console.WriteLine("2. Calculate Section Area");
                    Console.WriteLine("3. Exit");
                    choice=Convert.ToInt32(Console.ReadLine());
                    if(choice==1){
                        Console.WriteLine("Choose:");
                        Console.WriteLine("1. Circle");
                        Console.WriteLine("2. Rectangle");
                        int choice2=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Give a section: ");
                        string section=Console.ReadLine();
                        if(choice2==1){
                            Console.WriteLine("Input the Radius: ");
                            double radius=Convert.ToDouble(Console.ReadLine());
                            Circle circle = new Circle(radius);
                            WHManager.AddShapeObject(section, circle);
                        }
                        else if(choice2==2){
                            Console.WriteLine("Input the Height: ");
                            double height=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input the Width: ");
                            double width=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input the 1st Angle: ");
                            double a1=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input the 2nd Angle: ");
                            double a2=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input the 3rd Angle: ");
                            double a3=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input the 4th Angle: ");
                            double a4=Convert.ToDouble(Console.ReadLine());
                            Rectangle rectangle = new Rectangle(height, width, a1, a2, a3, a4);
                            WHManager.AddShapeObject(section, rectangle);

                        }
                        else Console.WriteLine("Invalid Choice!");
                    }
                    else if(choice==2) WHManager.CalculateSectionArea();
                    else Console.WriteLine("Invalid Choice!");
                }
            }
            catch(Exception err){
                Console.WriteLine($"Error: {err.Message}");
                goto Again;
            }
        }
    }
}