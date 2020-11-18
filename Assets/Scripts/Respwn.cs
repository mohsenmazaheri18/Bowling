using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respwn : MonoBehaviour
{
    public GameObject ball;
    public GameObject Win;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void rad()
    {
        StartCoroutine(reza());

    }

    IEnumerator reza()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(ball, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        Win.SetActive(true);
    }

    public void nextt()
    {
        SceneManager.LoadScene("Demo");
    }
    public void exit()
    {
        Application.Quit();
    }
}

