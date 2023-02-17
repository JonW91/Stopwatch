namespace Stopwatch;

public class Stopwatch
{
    #region Fields

    // Fields

    private DateTime _start;
    private DateTime _stop;
    private bool _isRunning;

    #endregion

    #region Constructor

    public Stopwatch()
    {
        _start = DateTime.MinValue;
        _stop = DateTime.MinValue;
        _isRunning = false;
    }

    #endregion

    #region Methods

    // Methods

    public void Start()
    {
        if (_isRunning == false)
        {
            _start = DateTime.Now;
            _isRunning = true;
        }
        else
        {
            try
            {
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"The stopwatch has already been started. {e}");
            }
        }
    }


    public void Stop()
    {
        if (_isRunning == true)
        {
            _stop = DateTime.Now;
            _isRunning = false;
        }
        else
        {
            try
            {
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"The stopwatch has already been stopped. {e}");
            }
        }
    }

    public void TimeSpan()
    {
        var duration = _stop - _start;
        Console.WriteLine($"Congratulations, there was {duration} between starting and stopping the stopwatch.");
    }

    #endregion
}