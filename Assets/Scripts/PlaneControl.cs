using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public float movementSpeed = 10.0f; //movement speed of Player
    public int inverse = 1; //Determine Inverse Controls 
    public float rotationSpeed = 50.0f;    //Rotation Speed of Player  

    public float MaxX;
    public float MinX;
    public float MinY;
    public float MaxY;

    private float _MovementSpeed;
    private float Accel;
    AudioSource _hit;   //Audio Source for Hit sound

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        _MovementSpeed = movementSpeed;
        _hit = GetComponent<AudioSource>();
     
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        Move();
        LimitSpace();

    }

    ///<summary>
    ///Collision Detection for Player
    ///</summary>
    ///<param name=”collision”>The collision object the player has collided with</param>
    public void OnTriggerEnter(Collider collision)
    {
       
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, -1 * vertical, 0);
        Vector3 finalDirection = new Vector3(horizontal, -1 * vertical, 2.5f);

        //make the ship accelerate over time
        //_MovementSpeed = 
        transform.position += direction * movementSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection), Mathf.Deg2Rad * rotationSpeed);

    }
    void LimitSpace()
    {
        if (transform.position.x > MaxX)
        {
            transform.position = new Vector3(MaxX, transform.position.y, transform.position.z);
        } 
        if (transform.position.x < MinX)
        {
            transform.position = new Vector3(MinX, transform.position.y, transform.position.z);
        }
        if (transform.position.y > MaxY)
        {

            transform.position = new Vector3(transform.position.x, MaxY, transform.position.z);
        }
        if (transform.position.y < MinY)
        {
            transform.position = new Vector3(transform.position.x, MinY, transform.position.z);
        }


    }

}