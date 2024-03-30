using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{

    public float increase = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            Player playerScript = player.GetComponent<Player>();

            if (playerScript)
            {
                playerScript.moveSpeed += increase;
                Destroy(GameObject);
            }
        }
    }

        

    
}
