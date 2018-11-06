using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamageOnTouch : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ship")
        {
            if (other.gameObject.GetComponent<PlayerHealth>())
            {
                Debug.Log(" hit Player");
                other.gameObject.GetComponent<PlayerHealth>().Damage(5);
            }
        }

        
    }
}
