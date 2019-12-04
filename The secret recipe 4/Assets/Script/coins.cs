using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private levelmanger GamelevelManger;
    public int CoinValue;
    void Start() {
        GamelevelManger = FindObjectOfType<levelmanger>(); }
    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            GamelevelManger.AddCoins(CoinValue);
            Destroy(gameObject); }
        
    }
}
