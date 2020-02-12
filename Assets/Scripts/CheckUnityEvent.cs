using UnityEngine;
using UnityEngine.Events;

public class CheckUnityEvent : CheckType
{
    // UnityEvent
    UnityEvent _unityEvents = new UnityEvent();

    private void Start()
    {
        _unityEvents.AddListener(ChecReceiver);
    }

    public override void RunTest(int cycles)
    {
        base.RunTest(cycles);

        SetStart();

        for (int i = 0; i < _cycles; i++)
        {
            _unityEvents.Invoke();
        }

        SetEnd();

        Print();
    }
}
