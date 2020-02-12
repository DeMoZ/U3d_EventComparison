using UnityEngine;

public class CheckEventDelegate : CheckType
{
    // Event-Delegate
    delegate void DelegateContainer();
    event DelegateContainer EventContainerOne;

    void Start()
    {
        EventContainerOne += ChecReceiver;
    }

    public override void RunTest(int cycles)
    {
        base.RunTest(cycles);

        SetStart();

        for (int i = 0; i < _cycles; i++)
        {
            EventContainerOne?.Invoke();
        }

        SetEnd();

        Print();
    }
}
