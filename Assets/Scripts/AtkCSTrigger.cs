using DanCon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCSTrigger : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (gameObject.CompareTag("PlayerOne") && gameObject.CompareTag("PlayerTwo"))
        {
            AttackScript myScript = collider.gameObject.GetComponent<AttackScript>();
            myScript.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (gameObject.CompareTag("PlayerOne") && gameObject.CompareTag("PlayerTwo"))
        {
            AttackScript myScript = collider.gameObject.GetComponent<AttackScript>();
            myScript.enabled = false;
        }
    }
}
