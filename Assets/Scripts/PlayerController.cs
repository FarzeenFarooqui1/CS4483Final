using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public ScoreManager collectedCount;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public Sprite redWhite;
    public Sprite redGreen;
    public Sprite redPurple;
    public Sprite blueWhite;
    public Sprite blueGreen;
    public Sprite bluePurple;
    public Sprite greenWhite;
    public Sprite greenGreen;
    public Sprite greenPurple;
    public Sprite purpleWhite;
    public Sprite purpleGreen;
    public Sprite purplePurple;
    public SpriteRenderer character;

    public bool isInvincible = false;

    [SerializeField] private float invincibilityDurationSeconds;

    private float _speedBoostDuration;
    private bool boosting;

    public GameObject mainSprite;
    public GameObject InvincibleSprite;
    public GameObject SpeedSprite;

    public GameObject InvincibleText;
    public GameObject SpeedText;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
       




        if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = redWhite;

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = blueWhite;

        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = greenWhite;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = purpleWhite;
        }



        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = redGreen;
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = blueGreen;
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = greenGreen;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = purpleGreen;
        }


        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = redPurple;
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = bluePurple;
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = greenPurple;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = purplePurple;

        }

    }
    // Update is called once per frame
    void Update()
    {
        if(isInvincible == true)
        {
            mainSprite.SetActive(false);
            InvincibleSprite.SetActive(true);
            InvincibleText.SetActive(true);
        }
        else
        {
            mainSprite.SetActive(true);
            InvincibleSprite.SetActive(false);
            InvincibleText.SetActive(false);
        }
        float directionY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(directionY * playerSpeed, rb.velocity.y);
        float directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * playerSpeed, rb.velocity.x);

        if (boosting)
        {
            mainSprite.SetActive(false);
            SpeedSprite.SetActive(true);
            SpeedText.SetActive(true);
            _speedBoostDuration += Time.deltaTime;
            if (_speedBoostDuration >= 3)
            {
                playerSpeed = 12;
                _speedBoostDuration = 0;
                boosting = false;
                mainSprite.SetActive(true);
                SpeedSprite.SetActive(false);
                SpeedText.SetActive(false);
            }
        }
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
        if (isInvincible == true)
        {
            Physics2D.IgnoreLayerCollision(7, 8, true);
            yield return new WaitForSeconds(invincibilityDurationSeconds);
            isInvincible = false;
            Debug.Log("Player is no longer invincible!");
        }

        Physics2D.IgnoreLayerCollision(7, 8, false);

    }
    //   void FixedUpdate()
    //{
    //  rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            collectedCount.score++;
        }
        if (other.tag == "SpeedPowerUp")
        {
            boosting = true;
            playerSpeed = 20;
            Destroy(other.gameObject);
        }

        if (other.tag == "InvincibilityPowerUp")
        {
            Debug.Log("Player turned invincible!");
            MethodThatTriggersInvulnerability();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Enemy")
        {
            if(isInvincible == false)
            {
                SpeedText.SetActive(false);
                Destroy(this.gameObject);
            }
       
        }
    }
}