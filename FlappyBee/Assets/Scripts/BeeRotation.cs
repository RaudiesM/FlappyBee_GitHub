using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeRotation : MonoBehaviour
{
    private BeeMovement beeMovement;
    [SerializeField] private float beeRotationFactor;

    private void Start()
    {
        beeMovement = FindObjectOfType<BeeMovement>();
    }

    private void Update()
    {
       HandleRotation();       
    }

    private void HandleRotation()
    {
        if (beeMovement.isFlying == false)
        {
            if (transform.rotation.z >= -0.5663706f)
            {
                transform.Rotate(new Vector3(0, 0, -beeRotationFactor * Time.deltaTime));
            }
        }
        else
        {
            if (transform.rotation.z <= 0.5663706f)
            {
                transform.Rotate(new Vector3(0, 0, beeRotationFactor * Time.deltaTime));
            }
        }

    }

}
