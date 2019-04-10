using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKeyDown(KeyCode.Q) && position.x > -3)
        {
            position.x -= 3;
        }

        if (Input.GetKeyDown(KeyCode.D) && position.x < 3)
        {
            position.x += 3;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Base baseComponent = GetComponent<Base>();
            baseComponent.speed += 5;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Base baseComponent = GetComponent<Base>();
            baseComponent.speed -= 5;
        }

        transform.position = position;
    }
}
