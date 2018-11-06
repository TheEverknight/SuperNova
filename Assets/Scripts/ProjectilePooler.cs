using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePooler : MonoBehaviour {
    public GameObject projectile;
    public int NumberOfInstances;
    private GameObject ProjectilePool;

	// Use this for initialization
	void Start () {
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
        for (int i = 0; i < NumberOfInstances; i++)
        {
            GameObject _projectile = Instantiate(projectile, ProjectilePool.transform);
            _projectile.tag = "EnemyProjectile";
            
            
        }
    }
}
