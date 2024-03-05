using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CricketBat") && collision.gameObject.CompareTag("CricketBall"))
        {
            // Play audio from the CricketBall
            AudioSource audioSource = collision.gameObject.GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}