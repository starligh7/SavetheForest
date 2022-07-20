using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkButton : MonoBehaviour
{
    public GameObject atk1;
    public GameObject atk2;
    public GameObject atk3;
    public GameObject atk4;

    public static float a1;
    public static float a2;
    public static float a3;
    public static float a4;

    public void atkb1()
    {
        if(Skill_Count.skillcount > 0)
        {
            a1++;
            Skill_Count.skillcount--;
        }
    }
    public void atkb2()
    {
        if (Skill_Count.skillcount > 0)
        {
            a2++;
            Skill_Count.skillcount--;
        }
    }
    public void atkb3()
    {
        if (Skill_Count.skillcount > 0)
        {
            a3++;
            Skill_Count.skillcount--;
        }
    }
    public void atkb4()
    {
        if (Skill_Count.skillcount > 0)
        {
            a4++;
            Skill_Count.skillcount--;
        }
    }

}
