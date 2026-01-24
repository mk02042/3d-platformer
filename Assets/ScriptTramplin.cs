using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTramplin : MonoBehaviour
{
    public float jumpFactor = 2;

    void OnTriggerEnter(Collider other)

    {
        //фнаф
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;

    }

    void OnTriggerExit(Collider other)
    {
        //Мышаня
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;

    
    }
}
