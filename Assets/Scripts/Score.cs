using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject Win;
    

    public void ScoreStart()
    {
        score = score + 14;
        text.text = score.ToString();
        if (score == 10)
        {
            Win.SetActive(true);
        }

    }
}
