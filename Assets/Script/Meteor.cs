using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Meteor : MonoBehaviour
{
    public float speed, speedRot, period, magnitude;
    float cont;
    int lado;
    public int dado;
    Vector3 newX;

    void Start()
    {
        cont = period;
        dado = Random.Range(0, 2);
        if (dado == 0) lado = -1;
        else lado = 1;
    }
    void Update()
    {
        //Avançar Posição
        Vector3 newPos = Vector3.forward * Time.deltaTime * speed;
        transform.position += newPos;
        transform.position += newX;

        //Rotação
        Vector3 newRot = new Vector3(1, 1, 1) * Time.deltaTime * speedRot;
        transform.Rotate (newRot) ;
        SineMethod();


    }

    //Movimento de Sine
    void SineMethod()
    {
        cont += Time.deltaTime;

        for(int i = 0; cont > period; i++ ) {
            lado *= -1;
            newX = (Vector3.right * magnitude * Time.deltaTime) * lado;
            cont = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GlobalVariables.isLoadScene = true;
        }
    }
}
