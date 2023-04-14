using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreTracker : MonoBehaviour
{
    //change to text mesh pro
    //https://www.youtube.com/watch?v=-U29sx9x3Zk


    public TextMesh scoreLabel;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusScore()
    {
        score += 1;
        scoreLabel.text = "FEATHERS: " + score.ToString();

        Debug.Log("FEATHERS: " + score);
    }

    public void MinusScore()
    {
        score -= 1;
        scoreLabel.text = "FEATHERS: " + score.ToString();

        Debug.Log("FEATHERS: " + score);
    }
}
