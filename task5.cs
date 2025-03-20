// Task 5:  Computed Property with String Formatting
// Task: Create a TimePeriod class with:
// A property TotalSeconds (int).
// A computed property FormattedTime that returns "HH:mm:ss" format.

class TimePeriod {

    private int _second;

    public int TotalSeconds {
        get { return _second; }

        set {
            if (value < 0) {
                throw new ArgumentOutOfRangeException("The second is negative");
            }
            else {
                _second = value;
            }
        }
    }

    public string FormattedTime {
        get { return Convert(_second); }
    }

    public string Convert(int seconds) {
        int hour = seconds / 3600;
        seconds%=3600;
        int minute = seconds / 60;
        seconds%=60;
        return $"{hour}:{minute}:{seconds}";
    }

}

class Program {
    static void Main(string[] args) {
        TimePeriod timePeriod = new TimePeriod();
        timePeriod.TotalSeconds = 3800;
        Console.WriteLine($"Formatted is {timePeriod.FormattedTime}");
    }
}

