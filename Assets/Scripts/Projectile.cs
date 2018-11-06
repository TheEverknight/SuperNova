using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public float Lifetime;
    private float _lifetime;
    private Transform Parent;
    

    

    void OnEnable()
    {
        _lifetime = Lifetime;
        Parent = transform.parent;
    }

    // Update is called once per frame
	void Update () {
        Move();

    }

    public void ResetLifetime()
    {
        this._lifetime = Lifetime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {

            other.GetComponent<Health>().Damage(10);

        }
    }

    void Move()
    {
        if (_lifetime > 0)
        {
            if(transform.parent != null)
            {
                transform.SetParent(null);
            }

            transform.Translate(Vector3.right * speed);
            _lifetime -= Time.deltaTime;
        }
        else if (_lifetime <= 0)
        {
            Disable();
        }

    }

    void Disable()
    {
        //this.enabled = false;
        transform.SetParent(Parent);
        gameObject.SetActive(false);
        transform.localPosition = Vector3.zero;
    }

   
}
