using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BeePoints : MonoBehaviour
{
    public TextMeshProUGUI text;
    private BeeTrigger beeTrigger;
    public float points { get; private set; }
    private float lastPoints;
    private BeeAudio beeAudio;

    private void Start()
    {
        beeTrigger = FindObjectOfType<BeeTrigger>();      
        beeAudio = FindObjectOfType<BeeAudio>();
    }

    private void Update()
    {
        UpdatePoints();
        UpdateText();
    }
    private void UpdatePoints()
    {
        if (beeTrigger.hitPoints)
        {
            points++;
            beeAudio.PlayPointsClip();
            beeTrigger.ResetPointBool();
        }
    }
    private void UpdateText()
    {
        if(points != lastPoints)
        {
            text.text = points.ToString();
            lastPoints = points;
        }
    }

    public void PandaBonusPoints(float bonus)
    {
            points += bonus;
    }

}
