using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float pushForce;
    private Vector3 flyingForce;
    private Rigidbody2D beeBody;
    public bool isFlying { get; private set; }
    public bool isFalling { get; private set; }
    public bool gameStart { get; private set; }
    private BeeAudio beeAudio;


    private void Start()
    {
        beeBody = GetComponent<Rigidbody2D>();
        beeAudio = FindObjectOfType<BeeAudio>();
        flyingForce = new Vector2(0, pushForce);
    }

    
    private void Update()
    {
        CheckInput();
        CheckFall();
        CheckGameStart();
    }


    private void FixedUpdate()
    {
        HandleFlying();
    }

    #region Check-Methods
    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlying = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isFlying = false;
        }
    }

    private void CheckFall()
    {
        if (beeBody.velocity.y > 0)
        {
            isFalling = true;
        }
        else
        {
            isFalling = false;
        }
    }
    private void CheckGameStart()
    {
        if(Input.GetKeyDown(KeyCode.Space) && gameStart == false)
        {
            gameStart = true;
        }
    }

    #endregion

    #region Handle-Methods

    private void HandleFlying()
    {
        if (isFlying)
        {
            beeBody.AddForce(flyingForce, ForceMode2D.Force);
            //beeBody.velocity = flyingForce*Time.deltaTime*5;
            beeAudio.PlayBuzzClip();
        }
    }
    
    #endregion
}
