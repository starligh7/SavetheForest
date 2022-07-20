using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move_Boss : MonoBehaviour
{
    public GameObject PlayerTransform;
    public Transform Cam;
    void LateUpdate()
    {
        Cam.position = new Vector3(PlayerTransform.transform.position.x, PlayerTransform.transform.position.y+7, -10);
    }
}
