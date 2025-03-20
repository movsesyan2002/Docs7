// Task 3: Property with Lazy Initialization and Read-Only Constraint
// Task: Create a Person class with the following:
// FirstName and LastName as auto-properties.
// A read-only property FullName that is computed only once when accessed for the first time (lazy initialization).
// Ensure FullName is stored internally and does not change if FirstName or LastName are modified.

// class Person {

//     public string firstName { get; set;}
//     public string lastName { get; set;}
//     private string _fullname;
//     private bool _iscomplete = false;

//     public Person(string FirstName,string LastName) {
//         this.firstName = FirstName;
//         this.lastName = LastName;
//     }

//     public string FullName { 
//         get{
//             if (this._iscomplete == false)
//             {
//                 _iscomplete = true;
//                 _fullname = $"{this.firstName} {this.lastName}";
//             }
//             return this._fullname;
//         }
//     }

// }

// class Program {
//     static void Main(string[] args) {
//         Person person = new Person("Dav", "Movsesyan");
//         Console.WriteLine($"{person.FullName}");
//         person.firstName = "Narek";
//         Console.WriteLine($"{person.firstName} {person.lastName}");
//         Console.WriteLine($"{person.FullName}");

//     }
// }

