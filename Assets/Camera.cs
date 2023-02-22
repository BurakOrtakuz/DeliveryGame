using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject thingsFallow;
    //Kamera ile arabayı hizzalama
    void LateUpdate()
    {
        transform.position = thingsFallow.transform.position + new Vector3(0,0,-10);
    }
}
