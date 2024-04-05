using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    public Material material;
    public Color[] colours;
    private int currentColourIndex = 0;
    private int targetColourIndex = 1;
    private float targetPoint;
    public float time;
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        ColourLerp();
        
    }

    void ColourLerp()
    {
        targetPoint += Time.deltaTime / time;
        material.color = Color.Lerp(colours[currentColourIndex], colours[targetColourIndex], targetPoint);

        if (targetPoint >= 1f)
        {
            targetPoint = 0f;
            currentColourIndex = targetColourIndex;
            targetColourIndex++;
            if (targetColourIndex == colours.Length)
            {
                targetColourIndex = 0;
            }
        }
    }
}
