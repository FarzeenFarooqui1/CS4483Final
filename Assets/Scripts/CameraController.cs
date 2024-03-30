using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        // Calculate the target position for the camera to follow the player horizontally
        Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);

        // Move the camera towards the target position smoothly
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }
}
