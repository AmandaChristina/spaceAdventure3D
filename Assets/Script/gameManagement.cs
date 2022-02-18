using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagement : MonoBehaviour
{
    float spawnX, spawnY, spawnZ, cont;
    public float timeSpawn;
    public GameObject objMeteor;
    Vector3 spawnVector;

    void Start()
    {
        cont = timeSpawn;
    }
    void Update()
    {
       MeteorCreate();
       Destroy(objMeteor.gameObject, 20f);
    }

    void MeteorCreate()
    {
        cont -= Time.deltaTime;

        for (int i = 0; cont < 0f; i++) { 
            spawnX = Random.Range(-15, 15);
            spawnY = Random.Range(-7, 7);
            spawnVector = new Vector3(spawnX, spawnY, 100f);
            Instantiate(objMeteor, spawnVector, objMeteor.transform.rotation);
            cont = timeSpawn;
        }
    }
}
