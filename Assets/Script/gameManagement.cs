using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagement : MonoBehaviour
{
    public GameObject objMeteor;
    Vector3 spawnVector;
    float spawnX, spawnY, spawnZ, cont, contLoadScene;
    public float timeSpawn;

    void Start()
    {
        GlobalVariables.isLoadScene = false;
        GlobalVariables.score = 0f;
        cont = timeSpawn;
    }
    void Update()
    {
       MeteorCreate();

        if(GlobalVariables.isLoadScene == true) {

            contLoadScene += Time.deltaTime;
            if (contLoadScene > 2f)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
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
