using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spongepop : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpSpeed = 5f;
    private float Movement = 0f;
    private Rigidbody2D rigidBody;
    //#2
    public Transform GroundCheckPoint;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    private bool Grounded;
    //3
    private Animator playerAnimation;

    //4
    public Vector3 RespawenPoint;
    public levelmanger GameLevelManger;    


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
        RespawenPoint = transform.position;
        GameLevelManger = FindObjectOfType<levelmanger>();
    }

    void Update()
    {

        //Movement #1
        Movement = Input.GetAxis("Horizontal");
        if (Movement > 0)
        {
            rigidBody.velocity = new Vector2(Movement * Speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(1.520293f, 1.913541f);
        }//**
        else if (Movement < 0)
        {
            rigidBody.velocity = new Vector2(Movement * Speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(-1.520293f, 1.913541f);
        }//**
        else { rigidBody.velocity = new Vector2(0, rigidBody.velocity.y); }

        //jump #2
        Grounded = Physics2D.OverlapCircle(GroundCheckPoint.position, GroundCheckRadius, GroundLayer);
        if (Input.GetButtonDown("Jump") && Grounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, JumpSpeed);
        }

        //Animation #3
        playerAnimation.SetFloat("Speed", Mathf.Abs(rigidBody.velocity.x));
        playerAnimation.SetBool("OnGround", Grounded);

        //Kick1 #4
        if (Input.GetButtonDown("Fire1")){playerAnimation.SetTrigger("Kick1");}
        
        //Kick2 #5
        if (Input.GetButtonDown("Fire2")) { playerAnimation.SetTrigger("Kick2"); }
       
        //SuperPower1 #6
        if (Input.GetButtonDown("Fire3")) { playerAnimation.SetTrigger("SuperPower1"); }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FallDetector") { GameLevelManger.Respawn(); }
        if (other.tag == "Checkpont") { RespawenPoint = other.transform.position; }
    }
}
   

