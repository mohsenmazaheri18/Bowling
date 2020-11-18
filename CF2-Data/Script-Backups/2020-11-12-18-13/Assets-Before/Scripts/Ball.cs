﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;
    private bool thrown = false;
    public float horizontalSpeed=2f;

    public GameObject left;
    public GameObject right;
    public GameObject shoot;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BallMoveMent();
    }
    void BallMoveMent()
    {
        if (!thrown)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector3 position = transform.position;
                position.z -= 4f * horizontalSpeed*Time.deltaTime;
                transform.position = position;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 position = transform.position;
                position.z += 4f * horizontalSpeed*Time.deltaTime;
                transform.position = position;
            }
        }
        if (!thrown&&ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
        {
            thrown = true;
            rig.isKinematic = false;
            rig.velocity = new Vector3(-speed, 0,0 );
            left.SetActive(false);
            right.SetActive(false);
            shoot.SetActive(false);
        }
    }
}