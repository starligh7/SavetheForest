using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Sound : MonoBehaviour
{
    public AudioSource Dragon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dragon.Play();
    }
}
