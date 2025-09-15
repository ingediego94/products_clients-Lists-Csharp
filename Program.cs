using System.Security.Cryptography;

namespace crudsazo;

public class Program
{
    // Products Class:
    public class Products
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    
    // Clients Class:
    public class Clients
    {
        public int Id { get; set; }
        public string NameC { get; set; }
        public int Age { get; set; }
        public Products product_x { get; set; }
    }
    
    // Main method:
    public static void Main(string[] args)
    {

        // Creacion de los 4 productos:
        var prod1 = new Products();
        prod1.Code = 11;
        prod1.Name = "Laptop";
        prod1.Price = 4680000.0;

        var prod2 = new Products { Code = 22, Name = "Celular", Price = 845000.2 };
        var prod3 = new Products { Code = 33, Name = "Libro", Price = 99100.1 };
        var prod4 = new Products { Code = 44, Name = "Audifonos", Price = 55650.8 };
        

            
        // Creacion de los 2 clientes:
        var client1 = new Clients { Id = 898, NameC = "Susana", Age = 22, product_x = prod2 };
        var client2 = new Clients { Id = 1999, NameC = "Sara", Age = 33, product_x = prod1};
        var client3 = new Clients { Id = 2000, NameC = "Fernanda", Age = 18, product_x = prod3};
        var client4 = new Clients { Id = 2100, NameC = "John", Age = 43, product_x = prod4};
        

        // // Lista de productos
        List<Clients> clientList = new List<Clients> {client1, client2, client3, client4 };
        
        
        // Impresion:
        foreach (var cliente_x in clientList)
        {
            Console.WriteLine($"Id cliente: {cliente_x.Id,5} --- Nombre: {cliente_x.NameC,7} --- Edad: {cliente_x.Age,4} --- Producto: {cliente_x.product_x.Name,10}");
        }



    }
}