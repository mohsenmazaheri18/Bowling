using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSwipe : MonoBehaviour
{

    Vector2 startpos, endpos, direction;
    float TouchTimeStart, TouchTimeFinish, TimeInternal;

    [SerializeField]
    float ThrowForceInXandY = 1f;

    [SerializeField]
    float ThrowForceInZ = 50f;

    public Respwn res;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            TouchTimeStart = Time.time;
            startpos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            TouchTimeFinish = Time.time;

            TimeInternal = TouchTimeFinish - TouchTimeStart;

            endpos = Input.GetTouch(0).position;

            direction = startpos - endpos;

            rb.isKinematic = false;
            rb.AddForce(-direction.x * ThrowForceInXandY, -direction.y, ThrowForceInZ / TimeInternal);

            Destroy(gameObject, 3f);
            res.rad();
        }
    }
}
