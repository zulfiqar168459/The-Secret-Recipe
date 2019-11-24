using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanger : MonoBehaviour
{
    public float RespawnDelay;
    public spongepop Maincharacter;

    void Start()
    {
        Maincharacter = FindObjectOfType<spongepop>();
    }

    void Update()
    {
        
    }

    public void Respawn() { 
        Maincharacter.gameObject.SetActive(false);
        Maincharacter.transform.position = Maincharacter.RespawenPoint;
        Maincharacter.gameObject.SetActive(true);

    }
}
