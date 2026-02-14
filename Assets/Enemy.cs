using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0;
    public Transform target;
    public int playtDamage = 2;

    void Update()
    {
        //bdbvjvvqvbdjqbvqjkq

        transform.position =
       Vector3.MoveTowards(transform.position,
       target.position, speed + Time.deltaTime);

        //jdghghjabdamnvb
        transform.LookAt(target.position);
    }

  
    
        
        
}
