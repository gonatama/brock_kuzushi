using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour
{
    float Speed = 15.0f;
    //int up = 0;
    private Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        Debug.Log(ball);
        ball.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(ball.velocity.z) < 3f)
        {
            ball.velocity = new Vector3(ball.velocity.x, ball.velocity.y, ball.velocity.z * 3f);
        }

        if (Mathf.Abs(ball.velocity.x) < 3f)
        {
            ball.velocity = new Vector3(ball.velocity.x * 3f, ball.velocity.y, ball.velocity.z);
        }

    }
}
