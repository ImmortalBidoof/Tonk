using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathExplosion : MonoBehaviour
{
    ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }

    void Update()
    {
        
    }

    public void startExplosion()
    {
        ps.Play();
    }
}
