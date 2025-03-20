// Task 6: Read-Only Indexer for Contact List
// Task: Create a ContactArray class that:
// Stores contacts as Person objects.
// Allows searching contacts by ID or Name using two separate indexers.
// Returns null if no contact is found.


// class Person {
//     public string name;
//     public int id;

//     public Person(string name, int id) {
//         this.name = name;
//         this.id = id;
//     }

//     public override string ToString()
//     {
//         return $"Contact name is {this.name} Contact id is {this.id}";
//     }
// }

// class ContactArray {
//     private Person[] contacts;
//     public static int count = 0;

//     public ContactArray(int consize) {
//         this.contacts = new Person[consize];
//     }

//     public void Addcontact(string name, int id) {
//         if (count < contacts.Length) {
//             contacts[count++] = new Person(name, id);
//         }
        
//     }

//     public Person this[int index] {
//         get {
//            for (int i = 0; i < count; i++) {
//                 if (contacts[i].id == index) {
//                     return contacts[i];
//                 }
//            }
//            return null;
//         }
//     }

//     public Person this[string name] {
//         get {
//             for (int i = 0; i < count; i++) {
//                 if (contacts[i].name == name) {
//                     return contacts[i];
//                 }
//             }
//             return null;
//         }
//     }
// }

// class Program {

//     static void Main(string[] args) {
//         ContactArray contacts = new ContactArray(5);
//         contacts.Addcontact("Arame",1);
//         contacts.Addcontact("Tigran",2);
//         contacts.Addcontact("Gag",3);

//         Person obj = contacts["Arame"];
//         Console.WriteLine(obj.ToString());
//     }
// }