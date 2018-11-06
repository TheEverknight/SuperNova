using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject LevelPool;
    private GameObject[] LevelPrefabs;
    private GameObject choice;

    void Start()
    {
      LevelPrefabs = GameObject.FindGameObjectsWithTag("Level");
       
        foreach(GameObject level in LevelPrefabs)
        {
            level.SetActive(false);
        }

        Generate();
    }

    public void Generate()
    {
       choice = Choose();
        Spawn(choice);
    }

    GameObject Choose()
    {
        GameObject _choice; 
        if(LevelPrefabs.Length >= 1)
        {
            _choice = LevelPrefabs[Random.Range(0, LevelPrefabs.Length - 1)];
        }
        else
        {
            _choice = null;
        }

        return _choice;
    }

    void Spawn(GameObject LevelChoice)
    {
        if (LevelChoice.activeInHierarchy == true)
        {
            Generate();

        }
        else
        {

            

            LevelChoice.transform.position = this.transform.position;
            LevelChoice.SetActive(true);
        }
    }
}
