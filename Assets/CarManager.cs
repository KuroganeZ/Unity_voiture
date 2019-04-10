using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnvalues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public float startWait;
    public bool stop;

    public int randEnemy;

    private float xPos;

    public Player Player;
    
  
    

    
     // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitCarManager());
    }


    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        if (Player.transform.position.z >= 100)
        {
            foreach (Transform transformEnfant in transform)
            {
                Vector3 positionEnfant = transformEnfant.position;
                positionEnfant.z -= 100;
                transformEnfant.position = positionEnfant;

            }
        }       
    }
    
    IEnumerator waitCarManager()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, 3);

            xPos = Random.Range(-3, 3);

            if (xPos < -1)
                xPos = -3;
            else if (xPos > 1)
                xPos = 3;
            else
                xPos = 0;
            
            Vector3 spawnPosition = new Vector3(xPos,1, 1);

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0),
                gameObject.transform.rotation, transform);
            
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
