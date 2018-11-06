using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPooler : MonoBehaviour {
    //this determines what prefabs can possibly "spawn in the level
    public GameObject[] LevelPrefabs;
    private GameObject[] Levels;

    public int NumOfInstances;
   

    void Awake()
    {
        
        foreach (GameObject Level in LevelPrefabs)
        {
            for(int i = 0; i < NumOfInstances; i++)
            {
                    GameObject instance = Instantiate(Level, transform);
                                
                    

            }
            
        }
       
    }
    
}
