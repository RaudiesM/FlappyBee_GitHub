using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BeePoints : MonoBehaviour
{
    public int Points { get; private set; }
    [SerializeField] private TextMeshProUGUI text;
    private BeeTrigger beeTrigger;
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
        if (beeTrigger.HitPoints)
        {
            Points++;
            beeAudio.PlayPointsClip();
            beeTrigger.ResetPointBool();
        }
    }

    private void UpdateText()
    {
        if(Points != lastPoints)
        {
            text.text = Points.ToString();
            lastPoints = Points;
        }
    }

    public void PandaBonusPoints(int bonus)
    {
            Points += bonus;
    }
}
