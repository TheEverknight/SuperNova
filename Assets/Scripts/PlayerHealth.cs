using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : Health {

   new public void Kill()
    {

        //SceneManager.LoadScene(" ");

    }

    new public void Damage(int DamageAmount)
    {
       _currentHealth -= DamageAmount;
        //Debug.Log("Damage Player " + DamageAmount);

        //play a brief animation and make the player flash red to indicate that they have taken damage.
        //
    }
}
