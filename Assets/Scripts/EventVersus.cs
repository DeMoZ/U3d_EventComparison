using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventVersus : MonoBehaviour
{
    [SerializeField] private int _cycles = 100000000;

    //[EnumFlags]
    [SerializeField] private WhatTest _whatTest;

    private CheckAction _checkAction = new CheckAction();
    private CheckEventDelegate _checkEventDelegate = new CheckEventDelegate();
    private CheckUnityEvent _checkUnityEvent = new CheckUnityEvent();

    [System.Flags]
    enum WhatTest
    {
        // none=0,
        TestActions,
        TestUnityEvents,
        TestEventDelegate,  // for multiselection here should be number 4  (but switch will not work)

        all
    }
    /*
      // Decimal      // Binary
        none = 0,       // 00000000
        mainMenu = 1,   // 00000001
        preLevel = 2,   // 00000010
        level = 4,      // 00000100
        postLevel = 8,  // 00001000
        gameOver = 16,  // 00010000
        all = 0xFFFFFFF // 11111111111111111111111111111111
     */

    public void RunTest()
    {
        switch (_whatTest)
        {
            case WhatTest.TestActions:
                _checkAction.RunTest(_cycles);
                break;

            case WhatTest.TestUnityEvents:
                _checkUnityEvent.RunTest(_cycles);
                break;

            case WhatTest.TestEventDelegate:
                _checkEventDelegate.RunTest(_cycles);
                break;

            case WhatTest.all:
                _checkAction.RunTest(_cycles);
                _checkUnityEvent.RunTest(_cycles);
                _checkEventDelegate.RunTest(_cycles);
                break;
        }
    }
}