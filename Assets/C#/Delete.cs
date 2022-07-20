using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public static bool SlimeOn = true;
    public static bool TreeOn = true;
    public static bool MantisOn = true;

    void Start()
    {
        //SlimeOn = true;
        //TreeOn = true;
    }

    public void desSlime()
    {
        SlimeOn = false;
    }
    public void desTree()
    {
        TreeOn= false;
    }
    public void desMantis()
    {
        MantisOn = false;
    }
}
