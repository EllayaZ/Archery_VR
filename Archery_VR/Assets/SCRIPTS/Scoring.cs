using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshPro scoretext;
    public int score;

    public void Start()
    {
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoretext.text = "Score:"+ score.ToString();


    }

    public void AddScore(int Scoreincrease)
    {
        score += Scoreincrease;
        UpdateScore();

    }
        
}

