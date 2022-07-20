using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_Count : MonoBehaviour
{
    public static int skillcount;
    public static int maxcount;
    public Text Skillc;

    void Start()
    {
        maxcount = 1;
        skillcount = maxcount; 
    }

    void Update()
    {
        Skillc.text = "스킬 카운트 " + skillcount + "/" + maxcount;
    }
}
