using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour

{ 
    public GameObject fireballprefab;
    public Transform attackPoint;

    //объект,отвечаший за проигрование звука
    public AudioSource audioSource;

    //звуковой файл, содержаюший звук урона
    public AudioClip damageSound;
    
    //здоровие игрока
    private int health = 10;

    //метод понижаюший здоровие
    public void TakeDamage(int damage){
         health -= damage;
         if(health > 0)
        {
          audioSource.PlayOneShot(damageSound);
        }
         else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

    
    
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


