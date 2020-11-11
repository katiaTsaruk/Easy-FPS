using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public ShowingMessage showingMessage;
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
            Debug.DrawRay(CameraRay.origin,CameraRay.direction);
            if (hit.transform.tag == "Enemy_0")
                showingMessage.CreateLogTextFromType("you hit " + hit.transform.tag, textType.level_0);
            else if (hit.transform.tag == "Enemy_1")
                showingMessage.CreateLogTextFromType("you hit " + hit.transform.tag, textType.level_1);
            else if (hit.transform.tag == "Enemy_2")
                showingMessage.CreateLogTextFromType("you hit "+hit.transform.tag, textType.level_2);
        }
    }
}
