using System.Collections;
using UnityEngine;

public class Collision : MonoBehaviour {

     void OnCollisionEnter(Collision col) {
        
        if(col.gameObject.name == "Object")
        {
            Destroy(col.gameObject);
        }
    }
}
