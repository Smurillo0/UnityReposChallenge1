using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouLose : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < 80 && player.transform.position.y > -51)
        {
            ScoreManager.gameOver = true;

        }
    }
}
