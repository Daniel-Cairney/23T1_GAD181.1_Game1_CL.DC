using DanCon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCSTrigger : MonoBehaviour
{

    private Collider2D _collider;

    public void TurnOnScript()
    {
        if (gameObject.CompareTag("PlayerOne") && gameObject.CompareTag("PlayerTwo"))
        {
            AttackScript myScript = _collider.gameObject.GetComponent<AttackScript>();
            myScript.enabled = true;
        }
    }


    public void TurnOffScript()
    {
        if (gameObject.CompareTag("PlayerOne") && gameObject.CompareTag("PlayerTwo"))
        {
            AttackScript myScript = _collider.gameObject.GetComponent<AttackScript>();
            myScript.enabled = false;
        }
    }
        

}
