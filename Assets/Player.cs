using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //здоровие игрока
    private ind health = 10;

    //метод понижаюший здоровие
    public void TakeDamage(ind damage){
        health -= damage;
        print("здоровие игрока:" + health);
    
    
    }

    
    // Update is called once per frame
    void Update()
    {
      if (Ioput.GetMouseButtonDown(0))
      {
           Instant1ate(fireballprefab,
     attackPoint,
     position, attackpoint.
     rotation); 

      }
    }
}


