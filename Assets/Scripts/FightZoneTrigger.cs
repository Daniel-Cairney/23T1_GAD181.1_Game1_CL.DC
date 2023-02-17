using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FightZoneTrigger : MonoBehaviour
{

    public UnityEvent OnEnterTrigger;
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _collider.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        // I'm just making sure that the trigger is activtaing - It Is!


        Debug.Log("TRIGGER button TEST"); // here to test that the Trigger is firing

        OnEnterTrigger.Invoke();
    }

    private void Update()
    {
        if (_collider == false)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
