using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public float backgroundSpeed;

    public Camera material;
    public Color[] colours;
    private int currentColourIndex = 0;
    private int targetColourIndex = 1;
    private float targetPoint;
    public float time;

    void Update()
    {
        ColourLerp();
    }
    void ColourLerp()
    {
        targetPoint += Time.deltaTime / time;
        material.backgroundColor = Color.Lerp(colours[currentColourIndex], colours[targetColourIndex], targetPoint);

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
