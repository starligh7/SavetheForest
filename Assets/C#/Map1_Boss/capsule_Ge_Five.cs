using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_Ge_Five : MonoBehaviour
{
    public GameObject Capsule;
    public Transform Player;
    float span = 0.2f;
    float delta = 0;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Capsule);
            go.transform.position = new Vector3(Player.position.x, 21.5f, 0);
        }
    }
}
