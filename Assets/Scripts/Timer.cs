using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int ints;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ints = ints - 1;
      
       
        text.text = ints.ToString();
        if (ints == 0)
        {
            SceneManager.LoadScene("Demo Mobile");
        }
    }
}
