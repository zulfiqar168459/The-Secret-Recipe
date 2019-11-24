using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Player;
    public float offset;
    public float SmoothCamera;
    private Vector3 PlayerPosition;
        void Start()
    {
        
    }

    void Update()
    {
        PlayerPosition = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
        if (Player.transform.localScale.x > 0f) {
            PlayerPosition = new Vector3(Player.transform.position.x + offset, transform.position.y, transform.position.z); }
        else { PlayerPosition = new Vector3(Player.transform.position.x - offset, transform.position.y, transform.position.z); }

        transform.position = Vector3.Lerp(transform.position,PlayerPosition, SmoothCamera * Time.deltaTime);
    }
}
