using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanger : MonoBehaviour
{
    public float RespawnDelay;
    public spongepop Maincharacter;
    public int Coins=0;
    public Text Score;

    void Start()
    {
        //#6 to access maincharacter object type
        Maincharacter = FindObjectOfType<spongepop>();
        Score.text = "Score: " + Coins;
    }

    void Update()
    {
        
    }

    public void Respawn() {
        StartCoroutine("RespawnCoroutine");
    }

    //to delay only respawn. the coroutine will pause execution and automatically resume at the next frame
    public IEnumerator RespawnCoroutine()
    {
        Maincharacter.gameObject.SetActive(false);
        yield return new WaitForSeconds(RespawnDelay);
        Maincharacter.transform.position = Maincharacter.RespawenPoint;
        Maincharacter.gameObject.SetActive(true);
    }

    public void AddCoins(int NumCoins) {
        Coins += NumCoins;
        Score.text = "Score: " + Coins;

    }
}
