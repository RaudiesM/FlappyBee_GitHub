using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private BeeMovement beeMovement;
    private void Start()
    {
        beeMovement = FindObjectOfType<BeeMovement>();
    }
    private void Update()
    {
        if (beeMovement.isFlying)
        {
            animator.SetBool("isFlying", true);
        }
        else
        {
            animator.SetBool("isFlying", false);
        }
    }
}
