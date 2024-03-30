using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvinciblePowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GameObject player = other.gameObject;
            Player playerScript = player.GetComponent<Player>();

            Destroy(gameObject);
            playerScript.SetInvincible();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(NoDamage());
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    IEnumerator NoDamage()
    {
        yield return new WaitForSeconds(5);
        //Destroy(gameObject);

    }
}
