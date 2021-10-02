using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleRotation : MonoBehaviour
{

    public float speed = 50f;
    public GameObject handle;

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
            handle.transform.Rotate(Vector3.up, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            handle.transform.Rotate(Vector3.down, speed * Time.deltaTime);
    }
    public void rotateHandle()
    {
        handle.transform.Rotate(Vector3.up, 200 * Time.deltaTime);
    }
}
