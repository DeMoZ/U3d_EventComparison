using System;
using UnityEngine;

public class CheckAction : CheckType
{
    // Action
    Action _actions = delegate { };

    void Start()
    {
        _actions += ChecReceiver;
    }

    public override void RunTest(int cycles)
    {
        base.RunTest(cycles);

        SetStart();

        for (int i = 0; i < _cycles; i++)
        {
            _actions.Invoke();
        }

        SetEnd();

        Print();
    }
}
