// Task 4:  Student Grades
// Task: Create a Students class that stores grades:
// Implement an indexer where:
// The key is a subject name.
// The value is a grade.
// If the subject doesn’t exist, return -1.
// Use only arrays.


using System.Security.Cryptography.X509Certificates;

class Student {
    private string[] subjects;
    private int[] grade;

    private static int _count = 0;

    public Student(int capacity){
        subjects = new string[capacity];
        grade = new int[capacity];
    }

    public int this[string name] {
        
        get{
            for (int i = 0; i < _count; i++)
            {
                if (subjects[i] == name)
                {
                    return grade[i];
                }
            }
            return -1;
        }

        set {

            for (int i = 0; i < _count; ++i) {
                if (subjects[i] == name) {
                    grade[i] = value;
                    return;
                }
            }

            if (_count < subjects.Length ) {
                subjects[_count] = name;
                grade[_count] = value;
                _count++;
            }
        }    
    }
}

class Program {
    static void Main() {
        Student student = new Student(3);
        student["Math"] = 10;
        student["Geographic"] = 9;

        Console.WriteLine($"The student Math grades is {student["Math"]}");
    }
}
