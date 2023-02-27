using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DanCon
{


    public class PlayerMovement : MonoBehaviour
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======
>>>>>>> Stashed changes

        public Sprite SamuraiPlaceholder_0, SamuraiPlaceholder_1, SamuraiPlaceholder_2, SamuraiPlaceholder_3;
>>>>>>> f5a88b8f82138dd490109fd0991ad7463f19acea

        // these allow us to decide which keys allow for movement in the inspector
        private KeyCode keyCode;

        Vector2 movementRun;
        [SerializeField] Animator samuraiAnim;
        [SerializeField] private float movementSpeed;
        [SerializeField] private Rigidbody2D theRB2D;
 



        private void Start()
        {
            theRB2D = GetComponent<Rigidbody2D>();
        }

        // allows player to move forward, if they hold down the key
        // if they let go of the key, they move back
        // player tag MAY not be necesary here, but might be relevant if we make changes in the future
        private void Update()
        {

            movementRun.x = Input.GetAxisRaw("Horizontal");

<<<<<<< HEAD
            samuraiAnim.SetFloat("Horizontal", movementRun.x);
            samuraiAnim.SetFloat("Speed", movementRun.sqrMagnitude);
=======
            {

>>>>>>> f5a88b8f82138dd490109fd0991ad7463f19acea

<<<<<<< Updated upstream
            {


                    if (Input.GetKeyDown(upAttack))
                    {   // animation plays when A is pressed - but won't play again
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_3;
                    }
=======
 
>>>>>>> Stashed changes

<<<<<<< HEAD
        }
        private void FixedUpdate()
        {
            theRB2D.MovePosition(theRB2D.position + movementRun * movementSpeed * Time.deltaTime);
=======
                    else if (Input.GetKeyDown(midAttack))
                    {
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_2;
                    }

                    else if (Input.GetKeyDown(downAttack))
                    {
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_1;
                    }

                    //timeBtwAtk = startTimeBtwAtk;

            }

            // controls for player 2

            if (gameObject.CompareTag("PlayerTwo"))
            {
                if (Input.GetKeyDown(stepLeft))
                {
                    theRB2D.velocity = new Vector2(-movementSpeed, theRB2D.velocity.y);
                }

                else if (Input.GetKeyUp(stepLeft))
                {
                    theRB2D.velocity = new Vector2(movementSpeed, theRB2D.velocity.y);
                }

            }

            if (gameObject.CompareTag("PlayerTwo"))

            {


                    if (Input.GetKeyDown(upAttack))
                    {   // animation plays when A is pressed - but won't play again
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_3;
                    }

                    else if (Input.GetKeyDown(midAttack))
                    {
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_2;
                    }

                    else if (Input.GetKeyDown(downAttack))
                    {
                        GetComponent<SpriteRenderer>().sprite = SamuraiPlaceholder_1;
                    }

                    //timeBtwAtk = startTimeBtwAtk;

               

            }
>>>>>>> f5a88b8f82138dd490109fd0991ad7463f19acea
        }

 

    }
}