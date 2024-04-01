using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;

    private Rigidbody2D rb;
    private Vector2 playerDirection;

    public bool isInvincible = false;

    [SerializeField] private float invincibilityDurationSeconds;

    private float _speedBoostDuration;
    private bool boosting;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _speedBoostDuration = 3.0f;
        boosting = false;
    }
    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;


        if (boosting)
        {
            _speedBoostDuration += Time.deltaTime;
            if(_speedBoostDuration >= 3)
            {
                playerSpeed = 12;
                _speedBoostDuration = 0;
                boosting = false;
            }
        }


    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    void MethodThatTriggersInvulnerability()
    {
        if (!isInvincible)
        {
            StartCoroutine(BecomeTemporarilyInvincible());
        }
    }
    private IEnumerator BecomeTemporarilyInvincible()
    {
        isInvincible = true;
        if(isInvincible == true)
        {
            Physics2D.IgnoreLayerCollision(7, 8, true);
            yield return new WaitForSeconds(invincibilityDurationSeconds);
            isInvincible = false;
            Debug.Log("Player is no longer invincible!");
        }

        Physics2D.IgnoreLayerCollision(7, 8, false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpeedPowerUp")
        {
            boosting = true;
            playerSpeed = 20;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "InvincibilityPowerUp")
        {
            Debug.Log("Player turned invincible!");
            MethodThatTriggersInvulnerability();
            Destroy(collision.gameObject);
        }
    }


}