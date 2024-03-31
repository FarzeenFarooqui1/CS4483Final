using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    bool isInvincible = false;
    public float invincibilityTime = 3.0f;
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

    public void SetInvincible()
    {
        isInvincible = true;

        CancelInvoke("SetDamageable"); //incase already invoked
        Invoke("SetDamageable", invincibilityTime);
    }

    void SetDamageable()
    {
        isInvincible = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpeedPowerUp")
        {
            boosting = true;
            playerSpeed = 20;
            Destroy(collision.gameObject);
        }
    }


}