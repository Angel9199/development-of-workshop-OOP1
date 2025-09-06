using System.Globalization;

namespace P00._1._1Library;


public class Time
{
    // private fields
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    // Properties with validation 
    public int Hour
    {
        get => _hour;
        set
        {
            if (value < 0 || value > 23)
                throw new ArgumentOutOfRangeException(nameof(Hour), $"The hour: {value} is not valid.");
            _hour = value;
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(Minute), "The minute is not valid.");
            _minute = value;
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(Second), "The second is not valid.");
            _second = value;
        }
    }

    public int Millisecond
    {
        get => _millisecond;
        set
        {
            if (value < 0 || value > 999)
                throw new ArgumentOutOfRangeException(nameof(Millisecond), "The millisecond is not valid.");
            _millisecond = value;
        }
    }

    // Overloaded constructors 
    public Time() : this(0, 0, 0, 0) { }
    public Time(int hour) : this(hour, 0, 0, 0) { }
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }
    public Time(int hour, int minute, int second, int millisecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
    }

    // Methods 
    public override string ToString()
    {
        try
        {
            var date = new DateTime(1, 1, 1, Hour, Minute, Second).AddMilliseconds(Millisecond);
            return date.ToString("hh:mm:ss.fff tt", CultureInfo.InvariantCulture);
        }
        catch
        {
            return "Invalid Time";
        }
    }

    public long ToMilliseconds() =>
        Hour * 3600000L + Minute * 60000L + Second * 1000L + Millisecond;

    public long ToSeconds() =>
        Hour * 3600L + Minute * 60L + Second;

    public long ToMinutes() =>
        Hour * 60L + Minute;

    public Time Add(Time other)
    {
        long totalMs = this.ToMilliseconds() + other.ToMilliseconds();

        long ms = totalMs % 1000;
        long totalSec = totalMs / 1000;
        long sec = totalSec % 60;
        long totalMin = totalSec / 60;
        long min = totalMin % 60;
        long hr = (totalMin / 60) % 24;

        return new Time((int)hr, (int)min, (int)sec, (int)ms);
    }

    public bool IsOtherDay(Time other)
    {
        long totalMinutes = this.ToMinutes() + other.ToMinutes();
        return totalMinutes >= 1440; // 24 * 60
    }
}


