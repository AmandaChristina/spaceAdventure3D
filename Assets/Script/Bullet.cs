using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 newPos = Vector3.forward * speed * Time.deltaTime;
        transform.position += newPos ;

        Destroy(gameObject, 10f);
    }

    //Lembrando que precisamos de que um dos objetos tenha Rigidbody
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Meteor")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
