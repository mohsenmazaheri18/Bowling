using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PinScore : MonoBehaviour
{
    public Score score1;
    public Image image;

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Floor"))
        {
           
        Debug.Log("khord");
        score1.ScoreStart();
        image.color = Color.green;
          

        }
    }
}
