using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Level")
        {
            collider.gameObject.SetActive(false);
            collider.transform.localPosition = Vector3.zero;
        }
    }
}
