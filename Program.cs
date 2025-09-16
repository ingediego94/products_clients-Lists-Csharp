namespace crudsazo;

public class Program
{
    
    // class to products
    public class Products()
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
    }
    
    
    // class to clients
    public class Clients()
    {
        public int Id { get; set; }
        public string Name_C { get; set; }
        public int Age { get; set; }
        public bool Status_C { get; set; }
        public List<Products> ProductsList { get; set; } = new List<Products>();
    }
    
    
    
    // Main class
    public static void Main(string[] args)
    {
        // Option number 1:
        var prod1 = new Products();
        prod1.Code = 21321;
        prod1.Name = "Silla Gamer Pro";
        prod1.Price = 834999.12;
        prod1.Status = true;
        
        
        // Option number 2:
        var prod2 = new Products { Code = 54341, Name = "Monitor Gamer", Price = 663999.32, Status = true };
        var prod3 = new Products { Code = 2321, Name = "Mouse Gamer", Price = 89999.2, Status = false };
        var prod4 = new Products { Code = 5432, Name = "Mesa de juego", Price = 787874.3, Status = true };
        
        
        // Creación de clientes y sus respectivos productos
        var client1 = new Clients { Id = 11, Name_C = "Cristina Agudelo", Age = 43, Status_C = true};
        client1.ProductsList.Add(prod4);
        client1.ProductsList.Add(prod2);
        
        var client2 = new Clients { Id = 22, Name_C = "Diego Vallejo", Age = 31, Status_C = true};
        client2.ProductsList.Add(prod1);
        client2.ProductsList.Add(prod3);
        
        var client3 = new Clients { Id = 33, Name_C = "Edison Guachucal", Age = 23, Status_C = true};
        client3.ProductsList.Add(prod4);
        client3.ProductsList.Add(prod1);
        client3.ProductsList.Add(prod3);
        
        
        // Lista de productos:
        List<Clients> clientes = new List<Clients> { client1, client2, client3 };
        
        // Impresion con foreach
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"El cliente con ID: {cliente.Id}, nombre: {cliente.Name_C}, Edad: {cliente.Age}, Estado: {cliente.Status_C}");
            Console.WriteLine("   Productos comprados:");
            foreach (var producto in cliente.ProductsList)
            {
                Console.WriteLine($"      - {producto.Name} (${producto.Price})");
            }
        }
    }
    
    
}