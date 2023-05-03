using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPopadanie : MonoBehaviour
{
    public ParticleSystem effect;
    void Update()
    {
        effect.Play();
        Destroy(gameObject, 1.5f);
    }
}
