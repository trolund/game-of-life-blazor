using System;
using System.Diagnostics;

public class FPSCounter
{
    private readonly Stopwatch _stopwatch = new Stopwatch();
    private int _frameCount;
    private double _elapsedSeconds;

    public double CurrentFPS { get; private set; }

    public void Start()
    {
        _stopwatch.Start();
    }

    public void Update()
    {
        _frameCount++;
        _elapsedSeconds = _stopwatch.Elapsed.TotalSeconds;

        if (_elapsedSeconds >= 1.0)
        {
            CurrentFPS = _frameCount / _elapsedSeconds;
            _frameCount = 0;
            _stopwatch.Restart();
        }
    }
}