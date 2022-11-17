using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullWithHoney : MonoBehaviour
{
    [SerializeField] Animator animator;

   


    private void OnParticleCollision(GameObject other)
    {
        if (animator.GetBool("honeyed") == false)
        {
            StartCoroutine(EatHoney());       
        }
    }


    private IEnumerator EatHoney()
    {
        animator.SetBool("honeyed", true);
        Debug.Log("Panda gefüttert");
        yield return new WaitForSeconds(1);
        animator.SetBool("honeyed", false);
    }
}
