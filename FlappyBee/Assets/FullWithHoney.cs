using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullWithHoney : MonoBehaviour
{
    [SerializeField] Animator pandaAnimator;
    [SerializeField] private int pandaBonus;
    private int honeyCounter;
    private BeePoints beePoints;
    BeeAudio beeAudio;

    private void Start()
    {
        beePoints = FindObjectOfType<BeePoints>();
        beeAudio = FindObjectOfType<BeeAudio>();
    }

    private void OnParticleCollision(GameObject other)
    {
        honeyCounter++;
    }


    private void Update()
    {
        
        //Debug.Log(honeyCounter);
        if(honeyCounter >= 7)
        {
            if (pandaAnimator.GetBool("honeyed") == false)
            {
                StartCoroutine(EatHoney());
            }
        }
    }

    private IEnumerator EatHoney()
    {
        pandaAnimator.SetBool("honeyed", true);
        Debug.Log("Panda gefüttert");
        beeAudio.PlaySchleckClip();
        yield return new WaitForSeconds(1);
        beePoints.PandaBonusPoints(pandaBonus);
        pandaAnimator.SetBool("honeyed", false);
        honeyCounter = 0;
    }
}
