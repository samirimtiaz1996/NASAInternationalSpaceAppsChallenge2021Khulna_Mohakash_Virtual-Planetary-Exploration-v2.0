using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_enabler : MonoBehaviour
{
    public GameObject script;
    public Cinemachine.CinemachineFreeLook vcam;
    public float test;
    // Start is called before the first frame update
    void Start()
    {
        // test = script.GetComponent<Cinemachine.LensSettings>().FieldOfView;
        test = vcam.m_Lens.FieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = true;
        else if(Input.GetMouseButtonUp(0))
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = false;
        if (Input.mouseScrollDelta.y>0)
        {
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = true;

            vcam.m_Lens.FieldOfView-=50*Time.deltaTime;
            test = vcam.m_Lens.FieldOfView;
        }
        else if(Input.mouseScrollDelta.y == 0 && !Input.GetMouseButton(0))
        {
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = false;
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = true;
            vcam.m_Lens.FieldOfView += 50 * Time.deltaTime;
            test = vcam.m_Lens.FieldOfView;
        }
        else if (Input.mouseScrollDelta.y==0 && !Input.GetMouseButton(0))
        {
            script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = false;
        }


    }
    public void zoomIn()
    {
        script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = true;

        vcam.m_Lens.FieldOfView -= 70 * Time.deltaTime;
    }
    public void zoomOut()
    {
        script.GetComponent<Cinemachine.CinemachineFreeLook>().enabled = true;

        vcam.m_Lens.FieldOfView += 70 * Time.deltaTime;
    }
    
}
