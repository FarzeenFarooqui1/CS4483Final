using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    private Renderer backgroundRenderer;
    private float textureUnitSizeX;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
        textureUnitSizeX = backgroundRenderer.material.mainTexture.width / transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate movement
        float offsetX = Time.deltaTime * backgroundSpeed;
        float newPositionX = backgroundRenderer.material.mainTextureOffset.x + offsetX;

        // Apply looping effect
        if (Mathf.Abs(newPositionX) >= textureUnitSizeX)
        {
            newPositionX -= textureUnitSizeX * Mathf.Sign(offsetX);
        }

        // Apply new position
        backgroundRenderer.material.mainTextureOffset = new Vector2(newPositionX, 0);
    }
}
