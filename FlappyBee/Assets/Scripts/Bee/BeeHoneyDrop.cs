using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHoneyDrop : MonoBehaviour
{
    [SerializeField] private ParticleSystem honeyParticles;
    [SerializeField] private float honeyDropVelocity;
    private Rigidbody2D beeBody;

    private void Start()
    {
        beeBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ParticleDrop();
    }

    private void ParticleDrop()
    {
        var emission = honeyParticles.emission;
        if (beeBody.velocity.y < honeyDropVelocity)
        {
            emission.enabled = true;
        }
        else
        {
            emission.enabled = false;
        }
    }
}
