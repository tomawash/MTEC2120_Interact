using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreTracker : MonoBehaviour
{

    //public TextMesh scoreLabel;
    public TextMeshPro scoreText;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 5;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "FEATHERS: " + score.ToString();
    }



    /*
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
    */
}
