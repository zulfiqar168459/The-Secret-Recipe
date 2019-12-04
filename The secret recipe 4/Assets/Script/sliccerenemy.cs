using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliccerenemy : MonoBehaviour
{
    public float Speed;
    public bool MoveRight;
    public int Damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRight) { 
            transform.Translate(2 * Time.deltaTime * Speed, 0,0);
            transform.localScale = new Vector2(2.9f,3.1f);
        }
        else {
            transform.Translate(-2 * Time.deltaTime * Speed, 0,0);
            transform.localScale = new Vector2(-2.9f, 3.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //enable that with your function name and set damage into unity by 5
        //if (other.tag == "Player") { FindObjectOfType<spongepop>().TakeDamage(Damage); }

            if (other.gameObject.CompareTag("Turn") || other.gameObject.CompareTag("Player")) { 

            if (MoveRight==true) { MoveRight = false; } 
            else { MoveRight = true; } }
    }
}
