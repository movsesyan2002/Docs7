// Task 4:  Property with Validation and Default Value
// Task: Create a Product class that contains:
// A Price property that:
// Cannot be negative.
// If set to a negative value, defaults to 0.
// A Stock property that:
// Cannot be negative.
// If set to a negative value, defaults to 10.

// class Product {
//     private decimal _price;
//     private int _stock;

//     public decimal Price {
//         get { return _price; }

//         set {

//             if (value < 0) {
//                 throw new ArgumentException("Price cannot be negative");
//             }

//             else {
//                 _price = value;
//             }

//         }
//     }

//     public int Stock {
//         get { return _stock; }
//         set {
//             if (value < 0) {
//                 _stock = 10;                
//             }
//             else
//             {
//                 _stock = value;
//             }
//         }
//     }
// }

// class Program {
//     public static void Main(string[] args) {
//         Product product = new Product();
//         product.Price = 6.000m;
//         product.Stock = 15;
//         Console.WriteLine($"Product price is {product.Price} and Stock is {product.Stock}");
//         product.Price = -1;
//     }
// }