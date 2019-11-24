using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private int score = 0;
    void Start() { }
    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        score += 5;
        Debug.Log("Your Score is " + score);
    }
}
