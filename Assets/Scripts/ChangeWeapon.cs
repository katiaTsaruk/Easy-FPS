using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            WeaponChange();
        }
    }
    void WeaponChange()
    {
        weapon1.SetActive(!weapon1.activeSelf);
        weapon2.SetActive(!weapon2.activeSelf);
    }
}
