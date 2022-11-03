using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField, Range(0, 0.1f)] private float scrollSpeed;
    private float imageOffset;
    private Material backgroundImage;

    private void Start()
    {
        backgroundImage = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        imageOffset += (scrollSpeed * Time.deltaTime);
        Vector2 offsetVector = new Vector2(imageOffset, 0);
        backgroundImage.SetTextureOffset("_MainTex", offsetVector);
    }
}
