using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipascript : MonoBehaviour
{
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(-3.07f, 1.85f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
