using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public bool IsFlying { get; private set; }
    public bool IsFalling { get; private set; }
    public bool gameStart { get; private set; }
    [SerializeField, Range(0, 100)] private float pushForce;
    private Vector3 flyingForce;
    private Rigidbody2D beeBody;
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
            IsFlying = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            IsFlying = false;
        }
    }

    private void CheckFall()
    {
        if (beeBody.velocity.y > 0)
        {
            IsFalling = true;
        }
        else
        {
            IsFalling = false;
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
        if (IsFlying)
        {
            beeBody.AddForce(flyingForce, ForceMode2D.Force);
        }
        
        beeAudio.Buzzing(IsFlying, transform.position.y);
    }
    
    #endregion
}
