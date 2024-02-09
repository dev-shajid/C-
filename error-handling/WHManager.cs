using System;

namespace ErrorHandling{
    static class WHManager{
        static Dictionary<string, List<Shape>> lists = new Dictionary<string, List<Shape>>();
        public static void AddShapeObject(string section, Shape shape){
            try{
                if (!shape.IsValid()) throw new ArgumentException("Not a valid Shape!");
                if (lists.ContainsKey(section)) lists[section].Add(shape);
                else lists.Add(section, new List<Shape> { shape });
                Console.WriteLine("Successfully Added Shape!\n");
            }
            catch (ArgumentException err) {
                Console.WriteLine($"Error: {err.Message}");
            }
        }

        public static void CalculateSectionArea(){
            Console.WriteLine("\nTotal Sections: " + lists.Count);
            Console.WriteLine("-------------------");
            foreach (var section in lists){
                double area = 0;
                foreach (Shape shape in section.Value) area+=shape.CalculateArea();
                Console.WriteLine($"Section: {section.Key} -- Total Area: {area}");
            }
            Console.WriteLine();
        }
    }
}