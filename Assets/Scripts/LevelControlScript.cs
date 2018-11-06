using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlScript : MonoBehaviour {
    //Temporary, this will need to be changed to a private and get a 
    //reference from the Scriptable Object "GameManager"
    public float GameSpeed;
    private Spawner _spawner;
    private float MySpeed;
    private bool Spawned;
	// Use this for initialization
	void OnEnable () {
        //Get Game Speed	
        Spawned = false;
        _spawner = GameObject.Find("PrefabSpawnPoint1").GetComponent<Spawner>();
        MySpeed = GameSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Vector3.back) * MySpeed);
	}
    
    void OnTriggerEnter(Collider collider)
    {
        if (!Spawned)
        {
            if (collider.gameObject.tag == "Player")
            {
                _spawner.Generate();
                Spawned = true;
            }
        }
    }
}
