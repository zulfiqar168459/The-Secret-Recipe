using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    public Sprite Magic;
    public Sprite CircleMagic;
    private SpriteRenderer CheckPointRender;
    public bool CheckPointReached;

    void Start()
    {
        CheckPointRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {  CheckPointRender.sprite = CircleMagic; CheckPointReached = true; }
    }
}
