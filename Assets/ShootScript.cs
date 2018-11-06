using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {
    private PlayerProjectilePooler PPP;
    private List<GameObject> projectiles;
    

    public Transform[] ProjectileSpawnPoints;
    

    void Start()
    {
        PPP = gameObject.GetComponent<PlayerProjectilePooler>();
   
    }
	
	// Update is called once per frame
	void Update () {
       
        ProcessInput();
	}

    void ProcessInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }


    void Shoot()
    {

        
        
       for(int i = 0; i < 2; i++)
        {
            GameObject TempProjectile1 = (GameObject)PPP.GetPooledProjectile();
            TempProjectile1.GetComponent<Projectile>().ResetLifetime();
            TempProjectile1.transform.position = ProjectileSpawnPoints[i].transform.position;
            TempProjectile1.transform.rotation = ProjectileSpawnPoints[i].transform.rotation;
            TempProjectile1.SetActive(true);
        }




        /*

        TempProjectile2.GetComponent<Projectile>().ResetLifetime();

        

        
        TempProjectile2.transform.position = ProjectileSpawnPoint2.transform.position;
        TempProjectile2.transform.rotation = ProjectileSpawnPoint2.transform.rotation;
        TempProjectile1.SetActive(true);
        TempProjectile2.SetActive(true);

       */ 

        Debug.Log("Shoot");

    }



}
