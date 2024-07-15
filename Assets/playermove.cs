using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Life lifeScript;

    void Start()
    {
        Application.targetFrameRate = 60;
        lifeScript = GetComponent<Life>();
    }

    void Update()
    {
        if (lifeScript != null && lifeScript.IsGameOver)
        {
            return; //Stop Playaer Move
        }

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.1f;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * 0.1f;
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0f, 3.0f, 0f);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0f, -3.0f, 0f);
        }
    }
}