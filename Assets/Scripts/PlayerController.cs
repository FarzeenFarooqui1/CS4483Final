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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
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

    void setDamageable()
    {
        isInvincible = true;
    }

}