using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{

    [SerializeField] private Animation highAttack;
    [SerializeField] private Animation lowAttack;
    [SerializeField] private Animation midAttack;

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            highAttack.Play("High Attack");
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            lowAttack.Play("Low Attack");
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            midAttack.Play("Mid Attack");
        }
    }
}
