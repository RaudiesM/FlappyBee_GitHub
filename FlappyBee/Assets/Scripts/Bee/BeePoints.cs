using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BeePoints : MonoBehaviour
{
    public TextMeshProUGUI text;
    private BeeTrigger beeTrigger;
    private float points;
    private BeeAudio beeAudio;

    private void Start()
    {
        beeTrigger = FindObjectOfType<BeeTrigger>();      
        beeAudio = FindObjectOfType<BeeAudio>();
    }

    private void Update()
    {
        if(beeTrigger.hitPoints)
        {
            points++;
            beeAudio.PlayPointsClip();
            text.text = points.ToString();
            beeTrigger.ResetPointBool();
        }
    }

}
