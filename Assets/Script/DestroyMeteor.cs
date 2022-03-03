using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "Meteor")
        {
            Destroy(other.gameObject);
        }
    }
}
