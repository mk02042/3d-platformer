using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Destore(gameObject, 3);   
    }

    // Update is called once per frame
    void Update()
    {
       transform.position +=
       transform.foward *
       speed * Time.deltaTime;  
    }
    void ontriggerEnter(Collider other) {
        Destroy(gameObject);
        Enemy enemy = other,GetComponent<Enemy>();
        Destroy(enemy.gameObject);

    }


}
