// Task 5:  Multi-Parameter Indexer for 3D Space
// Task: Create a Grid3D class that:
// Stores values in a 3D space (x, y, z coordinates).
// Uses an indexer with three integer parameters.
// Throws an error if any index is out of bounds.


// class Grid3D {
//     private int[,,] grid;

//     public Grid3D(int x, int y, int z) {
//         grid  = new int[x, y, z];
//     }

//     public int this[int x, int y, int z] {
//         get {
//             if ((x < 0 || x > grid.GetLength(0)) || (y < 0 || y > grid.GetLength(1)) || (z < 0 || z > grid.GetLength(2))){
//                 throw new ArgumentException("You Enter invalid getting index"); 
//             }
//             return grid[x, y, z];
//         }

//         set {
//             if ((x < 0 || x > grid.GetLength(0)) || (y < 0 || y > grid.GetLength(1)) || (z < 0 || z > grid.GetLength(2))){
//                 throw new ArgumentException("You Enter invalid setting index");
//             }

//             grid[x, y, z] = value;
//         }
//     }
// }

// class Program {
//     static void Main() {
//         Grid3D grid = new Grid3D(3, 3, 3);
//         grid[1,2,1 ] = 3;
//         Console.WriteLine($"The value of this grid[1,2,1] is {grid[1,2,1]}");
//     }
// }
