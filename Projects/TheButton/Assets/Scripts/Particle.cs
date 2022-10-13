using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem particle;

    public void PlayParticle()
    {
        if (particle.isPlaying)
        {
            particle.Stop();
        }
        else
        {
            particle.Play();
        }
    }
}
