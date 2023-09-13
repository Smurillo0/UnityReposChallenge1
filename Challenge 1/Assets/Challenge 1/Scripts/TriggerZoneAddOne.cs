
/*
    * Sarahi Murillo
    * TriggerZoneAddOne.cs
    * Challenge 1 
    * this script allows us to check for collisions with trigger zones placed on the plane and inccremnet by 1 each time a target is hit. 
    
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddOne : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }

    }
}
