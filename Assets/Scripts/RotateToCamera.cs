using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{

    public GameObject followObject;
    Vector3 NewLook;
    public void RotateToObject()
    {
        //gameObject.transform.LookAt(followObject.transform.position);
        NewLook = new Vector3(followObject.transform.position.x, 
                                                                gameObject.transform.position.y, 
                                                                                                followObject.transform.position.z);
        gameObject.transform.LookAt(NewLook);

    }
}
