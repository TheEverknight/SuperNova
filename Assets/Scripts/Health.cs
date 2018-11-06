using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    // the public value is only used as a setter for the private value associated with the 
    //
    //
    public int health;
    [SerializeField] protected int _currentHealth;
    

	// Use this for initialization
	void Start () {
        _currentHealth = health;
        
	}

    //This will likely be triggered when the player clears a section, or collides with a health 
    //pickup, and will heal the player the amount passed by the object it collided with, or specified 
    //via event
    public void Heal(int HealAmount)
    {
        _currentHealth += HealAmount;

        Mathf.Clamp(_currentHealth, 0, 100);

       
    }

    //Much like the Heal Function this will happen mostly with collisions, with projectiles, or possibly a raycast
    //and will deal damage to the entity based on the amount passed by the object it collided with.
    public void Damage(int DamageAmount)
    {
        _currentHealth -= DamageAmount;
        
        //if the entity should be dead, run the function "Kill"
        if(_currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        //Play Animation, and or destroy the gameobject

        //temporarily we should destroy object that the script is attatched to.

        Destroy(this.gameObject);
    }


}
