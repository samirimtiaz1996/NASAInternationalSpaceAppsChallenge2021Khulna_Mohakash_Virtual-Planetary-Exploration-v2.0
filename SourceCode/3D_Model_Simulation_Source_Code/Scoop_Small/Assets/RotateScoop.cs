using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScoop : MonoBehaviour
{
    public float speed = 50f;
    public float refer;
    public GameObject scoop;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
                scoop.transform.Rotate(Vector3.left, speed * Time.deltaTime);
                refer=scoop.transform.rotation.eulerAngles.x;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            
                scoop.transform.Rotate(Vector3.right, speed * Time.deltaTime);
                refer = scoop.transform.rotation.eulerAngles.x;
            
        }
        

    }
    public void rotateScoop()
    {

        scoop.transform.Rotate(Vector3.right, 200 * Time.deltaTime);
        refer = scoop.transform.rotation.eulerAngles.x;
    }
}
