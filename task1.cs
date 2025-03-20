// Task 1: Water Tank System
// Concept: Simulate water tanks where water can be transferred or consumed.
// Requirements
// Implement a WaterTank class:
// Capacity (double, liters)
// CurrentLevel (double, liters)
// Overload + operator: Combine two water tanks (capped at the capacity limit).
// Overload - operator: Consume water from the tank (cannot go below 0).
// Override ToString() to display tank levels.

// using System;
// using System.Reflection.Metadata.Ecma335;

// class WaterTank
// {
//     private double _capacity;
//     private double _currentLevel;

//     public WaterTank(double capacity, double currentLevel)
//     {
//         if (capacity <= 0)
//         {
//             Console.WriteLine("Invalid argument capacity cannot be less 0");
//             return;
//         }
//         else
//         {
//             this._capacity = capacity;
//         }

//         if (currentLevel < 0)
//         {
//             Console.WriteLine("current level cannot be less than 0");
//             return;
//         }    

//         else if (currentLevel > this._capacity)
//         {
//             double overflow = currentLevel - this._capacity;
//             Console.WriteLine($"current level cannot be bigger then capacity  and lose {overflow} liter");
//             this._currentLevel = this._capacity;
//             return;
//         }

//         else
//         {
//             this._currentLevel = currentLevel;
//         }

//     }

//     public double Capacity
//     {
//         get { return _capacity; }
//     }

//     public double Currentlevel
//     {
//         get { return _currentLevel; }
//         set {
//             if (value > _capacity) 
//             {
//                 double overflow = value - _capacity;
//                 Console.WriteLine($"The water tank is full and you lose some water {overflow} liter");
//                 _currentLevel = _capacity;
//                 return;
//             }
//             _currentLevel = value;
//         }
//     }


//     public static WaterTank operator +(WaterTank obj1, WaterTank obj2)
//     {
//         if (obj1._currentLevel + obj2._currentLevel > obj1._capacity)
//         {
//             return new (obj1._capacity, obj1._capacity);
//         }
//         return new (obj1._capacity, obj1._currentLevel + obj2._currentLevel);
//     }

//     public static WaterTank operator -(WaterTank obj1, double amount)
//     {
//         WaterTank tank3 = amount > obj1._currentLevel ?  new(obj1._capacity,0) :   new(obj1._capacity,obj1._currentLevel - amount);
//         return tank3;
//     }

//     public override string ToString()
//     {
//         return $"Capacity is {_capacity}\nCurrent level is {_currentLevel}";
//     }
// }



// class Program
// {
//     public static void Main()
//     {
//         WaterTank waterTank = new WaterTank(5.0, 4.0);
//         WaterTank waterTank2 = new WaterTank(7.0, 4.0);

//         WaterTank waterTank3 = waterTank + waterTank2;
//         Console.WriteLine($"The watertank overview\n{waterTank3.ToString()}");
//         waterTank3 = waterTank - 5.0;
//         Console.WriteLine($"The watertank overview\n{waterTank3.ToString()}");

//     }
// }