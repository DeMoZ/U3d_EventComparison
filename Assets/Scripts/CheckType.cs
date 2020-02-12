using System;
using UnityEngine;

public class CheckType //: MonoBehaviour
{
    public int _cycles { get; set; }

    public DateTime _timeStart { get; set; }
    public DateTime _timeEnd { get; set; }

    protected void SetStart()
    {
        _timeStart = DateTime.Now;
    }

    protected void SetEnd()
    {
        _timeEnd = DateTime.Now;
    }

    protected void Print()
    {
        MonoBehaviour.print($"      time {_timeEnd - _timeStart} ;      {_timeStart} - {_timeEnd};      {this}");
    }

    public virtual void RunTest(int cycles)
    {
        _cycles = cycles;
    }

    protected void ChecReceiver() { }
}
