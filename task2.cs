// Task 2: Digital Ink Reservoir
// Concept: Simulate an ink reservoir in a digital pen where ink can be added or removed when writing.

//    Requirements
// Implement a InkReservoir class:
// Color (string)
// InkAmount (double, in milliliters)

// Overload + operator:
// Combine two ink reservoirs (if they have the same color).
// If colors differ, prevent merging.

// Overload - operator:
// Subtract ink from a reservoir (simulating ink usage).
// Prevent negative ink levels.

// Override ToString() to return reservoir details.

// using System.Formats.Asn1;

// class InkReservoir {
//     private string _color{get;}
//     private double _milliliters{get;}

//     public InkReservoir(string color, double milliliters) {
//         this._color = color;
//         this._milliliters = milliliters;
//     }


//     public static InkReservoir operator +(InkReservoir a,InkReservoir b) {

//         if (a._color != b._color) {
//             throw new ArgumentException("The colors are different");
//         }

//         else {
//             return new InkReservoir(a._color,a._milliliters + b._milliliters);
//         }
//     }

//     public static InkReservoir operator -(InkReservoir ink, double milliliters) {
//         if (milliliters < 0) {
//             throw new ArgumentException("The milliliter cannot be less than 0");
//         }

//         else if (milliliters > ink._milliliters) {
//             double overflow = milliliters - ink._milliliters;
//             overflow /= 0.5;
//             throw new ArgumentException($"There wasnt enough ink and it remained to write {overflow} letters");
//         }

//         else {
//             return new InkReservoir(ink._color,ink._milliliters - milliliters);
//         }
//     }

//     public override string ToString() {
//         return $"The color is {this._color} And remained {this._milliliters}";
//     }

//     public static double ConvertMilliliters(int letterscount) {
//         return (double)letterscount * 1.0;
//     }
// }

// class Program {
//     static void Main(string[] args) {

//         InkReservoir pen = new InkReservoir("Blue",50.0);
//         InkReservoir pen2 = new InkReservoir("Black",60.0);
//         InkReservoir pen3 = new InkReservoir("Red",55.0);
//         InkReservoir[] pens = new InkReservoir[3] {pen, pen2, pen3};
//         ProgramRun(pens);
//     }

//     public static void ProgramRun(InkReservoir[] ArrayOfPens) {
//         while (true) {
//             Console.WriteLine("Do you want write anything?\nEnter yes or no\n");
//             string? choice = Console.ReadLine();

//             if (string.Compare(choice,"Yes",true) == 0) {
//                 Console.Write($"Which color do you want?\nRed:{ArrayOfPens[2].ToString()}\nBlue:{ArrayOfPens[0].ToString()}\nBlack:{ArrayOfPens[1].ToString()}\n");
//                 string? color = Console.ReadLine();
//                 switch (color) {
//                     case "Blue":
//                     Console.WriteLine("Enter conversation");
//                     string? blueconveration = Console.ReadLine();
//                     ArrayOfPens[0] = ArrayOfPens[0] - (double)blueconveration.Length * 0.5;
//                     Console.WriteLine($"The pen overview {ArrayOfPens[0]}");
//                     break;

//                     case "Black":
//                     Console.WriteLine("Enter conversation");
//                     string? blackconveration = Console.ReadLine();
//                     ArrayOfPens[1] = ArrayOfPens[1] - (double)blackconveration.Length * 0.5;
//                     Console.WriteLine($"The pen overview {ArrayOfPens[1]}");
//                     break;

//                     case "Red":
//                     Console.WriteLine("Enter conversation");
//                     string? redconveration = Console.ReadLine();
//                     ArrayOfPens[2] = ArrayOfPens[2] - (double)redconveration.Length * 0.5;
//                     Console.WriteLine($"The pen overview {ArrayOfPens[2]}");
//                     break;

//                     default:
//                         Console.WriteLine("Enter invalid value");
//                         break;
//                 }
//             }

//             else if (string.Compare(choice,"No",true) == 0) {
//                 Console.WriteLine("Program is stopped");
//                 break;
//             }    

//             else
//             {
//                 Console.WriteLine("Enter Invalid value try again");
//             }
//         }
//     }
// }
