using System;
using UnityEngine;

public class NewClockScript : MonoBehaviour
{
    [SerializeField] private Transform _hourHand;
    [SerializeField] private Transform _minuteHand;
    [SerializeField] private Transform _secondHand;
    public float yRotation = 90f; 
    public float zRotation = 90f;

    private void Start()
    {
        UpdateClockHands();
    }

    private void Update()
    {
        UpdateClockHands();
    }

    private void UpdateClockHands()
    {
        DateTime currentTime = DateTime.Now;

        float secondHandRotation = (currentTime.Second / 60f) * 360f;
        float minuteHandRotation = ((currentTime.Minute + currentTime.Second / 60f) / 60f) * 360f;
        float hourHandRotation = ((currentTime.Hour % 12 + currentTime.Minute / 60f) / 12f) * 360f;

        _secondHand.localRotation = Quaternion.Euler(-secondHandRotation, yRotation, zRotation);
        _minuteHand.localRotation = Quaternion.Euler(-minuteHandRotation, yRotation, zRotation);
        _hourHand.localRotation = Quaternion.Euler(-hourHandRotation, yRotation, zRotation);
    }
}
