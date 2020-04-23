using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTarget : MonoBehaviour
{
    public void OnDestroy()
    {
        FindObjectOfType<Scoring>().AddScore(2);
    }
}
