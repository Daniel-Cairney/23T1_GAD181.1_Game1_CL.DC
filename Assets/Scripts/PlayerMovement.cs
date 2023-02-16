using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DanCon
{


    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;

        private Rigidbody2D theRB2D;
     
        // these allow us to decide which keys allow for movement in the inspector

        [SerializeField] private KeyCode stepRight;
        [SerializeField] private KeyCode stepLeft;
        [SerializeField] private KeyCode upAttack;
        [SerializeField] private KeyCode midAttack;
        [SerializeField] private KeyCode downAttack;

        private void Start()
        {
            theRB2D = GetComponent<Rigidbody2D>();
        }

        // allows player to move forward, if they hold down the key
        // if they let go of the key, they move back
        // player tag MAY not be necesary here, but might be relevant if we make changes in the future
        private void Update()
         {
            if (gameObject.CompareTag("PlayerOne"))
            {
                
                if (Input.GetKeyDown(stepRight))
                {
                    theRB2D.velocity = new Vector2(movementSpeed, theRB2D.velocity.y);
                }
                else if (Input.GetKeyUp(stepRight))
                {
                    theRB2D.velocity = new Vector2(-movementSpeed, theRB2D.velocity.y);
                }
            }


            if (gameObject.CompareTag("PlayerTwo"))
            {
                if (Input.GetKeyDown(stepLeft))
                {
                    theRB2D.velocity = new Vector2(-movementSpeed, theRB2D.velocity.y);
                }

                else if (Input.GetKeyUp(stepRight))
                {
                    theRB2D.velocity = new Vector2(movementSpeed, theRB2D.velocity.y);
                }

            }
        }

 
    }
}