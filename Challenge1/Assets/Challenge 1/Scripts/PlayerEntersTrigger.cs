using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntersTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }

    }
}
