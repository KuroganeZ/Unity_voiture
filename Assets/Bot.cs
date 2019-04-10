using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Boost", 2.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Boost()
    {
        
        Base baseComponent = GetComponent<Base>();
        baseComponent.speed += 5;
    }
}
