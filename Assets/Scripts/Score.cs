using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public  TextMeshProUGUI scoreText;
    public GameObject cristal;
    void Start()
    {
        score = 0;
    }

   
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            score++;
        }
    }
}
