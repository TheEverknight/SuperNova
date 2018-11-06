using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectilePooler : MonoBehaviour {
    public GameObject projectile;
    public int NumberOfInstances;
    private GameObject ProjectilePool;
    private List<GameObject> projectiles;

	// Use this for initialization
	void Awake () {
        CreatePool();
        PopulatePool();
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreatePool()
    {
        ProjectilePool = new GameObject();
        ProjectilePool.transform.SetParent(transform);
        ProjectilePool.name = "ProjectilePool";
    }

    void PopulatePool()
    {
        projectiles = new List<GameObject>();
        for (int i = 0; i < NumberOfInstances; i++)
        {
            GameObject obj = (GameObject)Instantiate(projectile);
            obj.SetActive(false);
            obj.transform.SetParent(ProjectilePool.transform);
            projectiles.Add(obj);
        }
        PopulateArray();
    }

    void PopulateArray()
    {



           
        foreach(GameObject Pro in projectiles)
        {
            Pro.SetActive(false);
        }

    }

    public GameObject GetPooledProjectile()
    {
            //1
            for (int i = 0; i < projectiles.Count; i++)
            {
                //2
                if (!projectiles[i].activeInHierarchy)
                {
                    return projectiles[i];
                }
            }
            //3   
            return null;
        
    }
}
