using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Ray CameraRay = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(CameraRay, out RaycastHit hit))
        {
            Debug.Log(hit.collider.gameObject.GetType());
        }
    }
}
