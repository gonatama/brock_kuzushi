using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour
{
    float Speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
