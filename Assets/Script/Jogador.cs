using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public GameObject objBullet;
    public GameObject objSpawn;
    float posX, posY, posMaxX, posMaxY;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objBullet, objSpawn.transform.position, objSpawn.transform.rotation);
        }

        posX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        posY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 newPos = new Vector3(posX, posY, 0);
        Vector3 atualPos = transform.position += newPos;

        posMaxX = Mathf.Clamp(atualPos.x, -5f, 5f);
        posMaxY = Mathf.Clamp(atualPos.y, -1.5f, 3.5f);

        transform.position = new Vector3(posMaxX, posMaxY, atualPos.z);
        //transform.Translate(posX, 0, posY);
    }

    //void OnCollissionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Meteor")
    //    {
    //        Destroy(other.gameObject);
    //        Destroy(this.gameObject);
    //    }
    //}
}
