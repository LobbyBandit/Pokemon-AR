using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{

    GameObject followObject;
    Vector3 NewLook;

    private void Start()
    {
        followObject = GameObject.Find("AR Camera");
    }

    public void RotateToObject()
    {
        //gameObject.transform.LookAt(followObject.transform.position);
        NewLook = new Vector3(followObject.transform.position.x, 
                                                                gameObject.transform.position.y, 
                                                                                                followObject.transform.position.z);
        gameObject.transform.LookAt(NewLook);

    }

    public void ResetRotation()
    {

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

    }

    public void doExitGame()
    {
        Application.Quit();
    }

}
