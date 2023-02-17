using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    public KeyCode key;
    public UnityEvent keyPressEvent;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            keyPressEvent.Invoke();
        }
    }
}

