using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    //private float score;
    public int score;
    //every two minutes double the score 
    public float timer = 0f;
    public float interval = 4f;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            //score * coins 
            //Not multiply with the time 
            //game objects destroy, the score increased

            //score += 1 * Time.deltaTime;
            timer += Time.deltaTime;

            if (timer >= interval) {

                score *= 2;
                timer = 0f;
            }
            UpdateScore();
           
        }
    }

    void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
    
}
