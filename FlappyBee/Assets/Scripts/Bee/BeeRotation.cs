using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeRotation : MonoBehaviour
{   
    private BeeMovement beeMovement;
    [SerializeField] private float beeRotationFactor;
    [SerializeField, Range(0, 0.3f)] private float maxRotation;

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
        if (beeMovement.IsFlying)
        {
            if (transform.rotation.z <= maxRotation)
            {
                transform.Rotate(new Vector3(0, 0, beeRotationFactor * Time.deltaTime));
            }
        }
        else
        {   
            if (transform.rotation.z >= -maxRotation)
            {
                transform.Rotate(new Vector3(0, 0, -beeRotationFactor * Time.deltaTime));
            }
        }
    }
}
