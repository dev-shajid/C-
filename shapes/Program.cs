using System;
namespace GeometricWareHouse{ 
    class Program {
        public List<Shape> shapes = new List<Shape>();
        public int total_circle=0, total_rectangle=0, total_cube=0, total_triangle=0;
        public double total_area=0, total_circle_area=0, total_rectangle_area=0, total_cube_area=0, total_triangle_area=0;

        public void AddShapes(Program NewShape)
        {
            while(true){
                NewShape.ShowSecondaryMenu();
                int choose2 = Convert.ToInt32(Console.ReadLine());
                if(choose2==1) NewShape.AddCircle();
                else if(choose2==2) NewShape.AddRectangle();
                else if(choose2==3) NewShape.AddCube();
                else if(choose2==4) NewShape.AddTriangle();
                else if(choose2==5) break;
                else Console.WriteLine("Invalid Key!");
                Console.WriteLine("");
            }
        }

        public void AddCircle()
        {
            Console.WriteLine("Enter the Radius of a circle");
            double inputRadius = Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(inputRadius);
            total_circle++; total_area+=c.Area(); total_circle_area+=c.Area();
            shapes.Add(c);
        }

        public void AddRectangle()
        {
            Console.WriteLine("Enter the Height of the Rectangle");
            double inputHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width of the Rectangle");
            double inputWidth = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle(inputHeight, inputWidth);
            total_rectangle++; total_area+=r.Area(); total_rectangle_area+=r.Area();
            shapes.Add(r);
        }

        public void AddCube()
        {
            Console.WriteLine("Enter the Dimension of the Cube");
            double inputDimentsion = Convert.ToDouble(Console.ReadLine());
            Cube c = new Cube(inputDimentsion);
            total_cube++; total_area+=c.Area(); total_cube_area+=c.Area();
            shapes.Add(c);
        }
        
        public void AddTriangle()
        {
            Console.WriteLine("Enter the Side_1 for the Triangle");
            double input_side_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Side_1 for the Triangle");
            double input_side_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Side_1 for the Triangle");
            double input_side_c = Convert.ToDouble(Console.ReadLine());
            Triangle t = new Triangle(input_side_a, input_side_b, input_side_c);
            total_triangle++; total_area+=t.Area(); total_triangle_area+=t.Area();
            shapes.Add(t);
        }

        public void ShowLists(){
            Console.WriteLine($"\nID\tType\t\tDimension\tArea\tPerimeter");
            Console.WriteLine($"=============================================================");
            int i=0;
            foreach(Shape shape in shapes){
                i++;
                if(shape is Circle circle) Console.WriteLine($"{i}\tCircle\t\t{circle.Radius}\t\t{circle.Area():N2}\t{circle.Perimeter():N2}");
                else if(shape is Rectangle rectangle) Console.WriteLine($"{i}\tRectangle\t{rectangle.Height}*{rectangle.Width}\t\t{rectangle.Area():N2}\t{rectangle.Perimeter():N2}");
                else if(shape is Cube cube) Console.WriteLine($"{i}\tCube\t\t{cube.Height}\t\t{cube.Area():N2}\t{cube.Perimeter():N2}");
                else if(shape is Triangle triangle) Console.WriteLine($"{i}\tTriangle\t{triangle.Side_B}*{triangle.Side_A}*{triangle.Side_C}\t\t{triangle.Area():N2}\t{triangle.Perimeter():N2}");
            }
            Console.WriteLine();
        }

        public void ShowStatistics(){
            double percent_circle_area = total_area>0?(total_circle_area/total_area)*100 : 0;
            double percent_rectangle_area = total_area>0?(total_rectangle_area/total_area)*100 : 0;
            double percent_cube_area = total_area>0?(total_cube_area/total_area)*100 : 0;
            double percent_triangle_area = total_area>0?(total_triangle_area/total_area)*100 : 0;

            Console.WriteLine($"Total Number Shape: {shapes.Count()}");
            Console.WriteLine($"Total Number of Circle: {total_circle}");
            Console.WriteLine($"Total Number of Rectangle: {total_rectangle}");
            Console.WriteLine($"Total Number of Cube: {total_cube}");
            Console.WriteLine($"Total Number of Triangle: {total_triangle}");
            Console.WriteLine($"Total Area: {total_area:N2} sq. Unit");
            Console.WriteLine($"Total Area of Circle: {total_circle_area:N2} sq. Unit & Percentage: {percent_circle_area:N2}% ");
            Console.WriteLine($"Total Area of Reactangle: {total_rectangle_area:N2} sq. Unit & Percentage: {percent_rectangle_area:N2}% ");
            Console.WriteLine($"Total Area of Cube: {total_cube_area:N2} sq. Unit & Percentage: {percent_cube_area:N2}% ");
            Console.WriteLine($"Total Area of Triangle: {total_triangle_area:N2} sq. Unit & Percentage: {percent_triangle_area:N2}%\n");
        }

        public void ShowPrimaryMenu(){
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Add Shapes");
            Console.WriteLine("2. Show Lists");
            Console.WriteLine("3. Show Statistics");
            Console.WriteLine("4. Exit");
        }

        public void ShowSecondaryMenu(){
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Add Circle");
            Console.WriteLine("2. Add Rectangle");
            Console.WriteLine("3. Add Cube");
            Console.WriteLine("4. Add Triangle");
            Console.WriteLine("5. Exit");
        }
        
        static void Main() {
            Console.Clear();
            Program NewShape = new Program();
            while(true){
                NewShape.ShowPrimaryMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if(choose==1) NewShape.AddShapes(NewShape);
                else if(choose==2) NewShape.ShowLists();
                else if(choose==3) NewShape.ShowStatistics();
                else if(choose==4) break;
                else Console.WriteLine("Invalid Key!");
            } 
        }
    }
}

