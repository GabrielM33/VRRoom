using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
   [SerializeField]
   private Transform _hourHand;
   [SerializeField]
   private Transform _minuteHand;
   [SerializeField]
   private Transform _secondHand;

   private int  _previousSeconds;
   private int _timeInSeconds;

   void Start()
   {
        ConvertTimeToSeconds();
   }

    // Update is called once per frame
    void Update()
    {
        ConvertTimeToSeconds();
        RotateClockHands();
    }

    private int ConvertTimeToSeconds()
    {
        int currentSeconds = DateTime.Now.Second;
        int currentMinute = DateTime.Now.Minute;
        int currentHour = DateTime.Now.Hour;

        if (currentHour >= 12)
        {
            currentHour -= 12;
        }

        _timeInSeconds = currentSeconds + (currentMinute * 60) + (currentHour * 60 * 60);

        return _timeInSeconds;
    }

    void RotateClockHands()
    {
        float secondhandPerSecond = 360f /60f;
        float minutehandPerSecond = 360f / (60f * 60f);
        float hourhandPerSecond = 360f / (60f * 60f * 12f);

        if (_timeInSeconds != _previousSeconds)
        {
            UnityEngine.Debug.Log(_timeInSeconds);
            _secondHand.localRotation = Quaternion.Euler(0, 0, _timeInSeconds * secondhandPerSecond);
            _minuteHand.localRotation = Quaternion.Euler(0, 0, _timeInSeconds * minutehandPerSecond);
            _hourHand.localRotation = Quaternion.Euler(0, 0, _timeInSeconds * hourhandPerSecond);
        }
        _previousSeconds = _timeInSeconds;
    }
}
