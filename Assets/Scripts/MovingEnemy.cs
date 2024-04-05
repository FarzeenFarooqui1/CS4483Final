using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public float speed = 3f;
    public float height = 5f;


    private void Update()
    {
        /*
        if(transform.position.y >= maxY)
        {
            current_movement = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
        if(transform.position.y <= minY)
        {
            current_movement = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = current_movement;
        }
        */
        
        
        float y = Mathf.PingPong(Time.time * speed, 1) * 5 - 3;
        transform.position = new Vector3(transform.position.x, y, 0);
    }
}
