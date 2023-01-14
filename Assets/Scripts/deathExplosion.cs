using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathExplosion : MonoBehaviour
{
    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startExplosion()
    {
        ps.Play();
    }
}
