using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    private GameObject ball; 
    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = (GameObject)Resources.Load("Prefab/Ball");

        //Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Rが押されました。");
            GameObject ball = GameObject.Find("Ball(Clone)");
            Debug.Log(ball);
            if (ball == null)
            {
                GameObject obj = (GameObject)Resources.Load("Prefab/Ball");

                Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            }
            else
            {
                Debug.Log("ボールがゲーム内に存在しています。");

            }
        }
    }
}
