using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballprefab;
    public Transform attackPoint;

    //здоровие игрока
    private int health = 10;

    //метод понижаюший здоровие
    public void TakeDamage(int damage){
        health -= damage;
        print("здоровие игрока:" + health);
    
    
    }

    
    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
           Instantiate(fireballprefab,
     attackPoint.
     position, attackPoint.
     rotation); 

      }
    }
}


