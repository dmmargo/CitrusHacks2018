using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float speed = 20.0f;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }

        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }
        else if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }
        else
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                      Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }
    }

}
