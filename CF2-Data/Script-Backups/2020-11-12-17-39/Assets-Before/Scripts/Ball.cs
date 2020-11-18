using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;
    private bool thrown = false;
    public float horizontalSpeed;
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
            float zAxis = Input.GetAxis("Horizontal");
            Vector3 position = transform.position;
            position.z += zAxis * horizontalSpeed;
            transform.position = position;
        }
        if (!thrown&&Input.GetKeyDown(KeyCode.Space))
        {
            thrown = true;
            rig.isKinematic = false;
            rig.velocity = new Vector3(-speed, 0,0 );
        }
    }
}
