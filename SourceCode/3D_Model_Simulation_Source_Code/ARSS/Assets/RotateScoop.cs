using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScoop : MonoBehaviour
{
    public float speed = 50f;
    public float refer;
    public GameObject scoop;
    public int control=0;

    void Update()
    {
        if (control==1)
        {

            speed = 50f;
            scoop.transform.Rotate(Vector3.left, speed * Time.deltaTime);
                refer=scoop.transform.rotation.eulerAngles.x;
            
        }
        if (control==0)
        {

                speed = 0f; 
                scoop.transform.Rotate(Vector3.right, speed * Time.deltaTime);
                refer = scoop.transform.rotation.eulerAngles.x;
            
        }
        if (control == 2)
        {

            speed = 50f;
            scoop.transform.Rotate(Vector3.right, speed * Time.deltaTime);
            refer = scoop.transform.rotation.eulerAngles.x;

        }


    }
    public void rotateScoop()
    {
        control = 1;
        scoop.transform.Rotate(Vector3.left, 200 * Time.deltaTime);
        refer = scoop.transform.rotation.eulerAngles.x;
     
    }
    public void stoprotateScoop()
    {
        control = 0;
        scoop.transform.Rotate(Vector3.right, 200 * Time.deltaTime);
        refer = scoop.transform.rotation.eulerAngles.x;
   
    }
    public void reverserotateScoop()
    {
        control = 2;
        scoop.transform.Rotate(Vector3.right, 200 * Time.deltaTime);
        refer = scoop.transform.rotation.eulerAngles.x;
    }
}
