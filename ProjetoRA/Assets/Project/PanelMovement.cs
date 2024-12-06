using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMovement : MonoBehaviour
{
    
    [SerializeField]
    Transform cameraTransform;
    [SerializeField]
    Vector3 offsetFromCamera;
    [SerializeField]
    float turnBufferInDegrees = 30f;
    [SerializeField]
    float turnSpeed = 0.03f;
    [SerializeField]
    bool lockPitch = false;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, cameraTransform.position.y, cameraTransform.position.z) + offsetFromCamera;

        Vector3 cameraEuler = cameraTransform.rotation.eulerAngles;

        cameraEuler.z = 0f;

        if(lockPitch){
            cameraEuler.x = 0f;
        }

        Quaternion targetQuat = Quaternion.Euler(cameraEuler);

        float angle = Quaternion.Angle(transform.rotation, targetQuat);

        if(angle > turnBufferInDegrees){
            transform.rotation = Quaternion.Lerp(transform.rotation, targetQuat, turnSpeed);
        }
    }
}
