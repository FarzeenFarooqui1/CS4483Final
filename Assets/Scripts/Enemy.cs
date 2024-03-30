using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control enemy speed
    public float minXSpeed = 2f; // Minimum speed for horizontal movement
    public float maxXSpeed = 5f; // Maximum speed for horizontal movement
    private Rigidbody2D rb;
    private bool movingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Randomize initial horizontal speed
        speed = Random.Range(minXSpeed, maxXSpeed);
    }

    void Update()
    {
        // Move the enemy horizontally
        Vector2 movement = movingRight ? Vector2.right : Vector2.left;
        rb.velocity = movement * speed;

        // Change direction if reaching boundaries
        if (transform.position.x >= maxXSpeed && movingRight)
        {
            movingRight = false;
        }
        else if (transform.position.x <= minXSpeed && !movingRight)
        {
            movingRight = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
