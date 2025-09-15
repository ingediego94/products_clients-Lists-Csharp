using System.Runtime.Intrinsics.Arm;

namespace crudsazo;

public class Product
{
    


    
    
    
    
    
    
    
    
    public static void Menu()
    {
        int option = 0; 
        
        while (option != 5)
        {
            Console.WriteLine("Welcome EXITO'S inventory:");
            Console.WriteLine("Chose the option that you want: ");
            Console.WriteLine("1) Watch products. \n2) Add a new product \n3) Update a product. \n4) Delete a product. \n5) Exit.");
        
        
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
            }
            else
            {
                switch (option)
                {
                    case 1:
                        //WatchProducts();
                        Console.WriteLine("Option 1");
                        break;
                    
                    case 2:
                        // AddProducts();
                        Console.WriteLine("Option 2");
                        break;
                }
            }
        }
        
    }
    
}