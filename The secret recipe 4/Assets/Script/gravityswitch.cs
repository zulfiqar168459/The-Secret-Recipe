using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityswitch : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool Top;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) { rb.gravityScale *= -1; }
        Rotation();
    }

    void Rotation()
    {
        if (!Top)
        {
            transform.eulerAngles = new Vector3(0,0,180f);
        }

        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        Top = !Top;

    }
}
