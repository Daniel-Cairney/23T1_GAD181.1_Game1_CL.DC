
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanCon
{

    public class PlayerOneHp : MonoBehaviour
    {

        public Sprite[] healthBar;

        private int playerOneLife = 640;


        void HitPoints()
        {
            switch(playerOneLife)
            {
                case 620:
                    GetComponent<SpriteRenderer>().sprite = healthBar[2];
                    break;

                case 600:
                    GetComponent<SpriteRenderer>().sprite = healthBar[3];
                    break;

                case 580:
                    GetComponent <SpriteRenderer>().sprite = healthBar[4];
                    break;

                case 560: 
                    GetComponent<SpriteRenderer>().sprite = healthBar[5];
                    break;

                case 540:
                    GetComponent<SpriteRenderer>().sprite = healthBar[6];

                    break;

                case 520:
                    GetComponent<SpriteRenderer>().sprite = healthBar[7];

                    break;

                case 500:
                    GetComponent<SpriteRenderer>().sprite = healthBar[8];

                    break;

                case 480:
                    GetComponent<SpriteRenderer>().sprite = healthBar[9];

                    break;

                case 460:
                    GetComponent<SpriteRenderer>().sprite = healthBar[10];

                    break;

                case 440:
                    GetComponent<SpriteRenderer>().sprite = healthBar[11];

                    break;

                case 420:
                    GetComponent<SpriteRenderer>().sprite = healthBar[12];

                    break;

                case 400:
                    GetComponent<SpriteRenderer>().sprite = healthBar[13];
                    break;

                case 380:
                    GetComponent<SpriteRenderer>().sprite = healthBar[14];

                    break;

                case 360:
                    GetComponent<SpriteRenderer>().sprite = healthBar[15];

                    break;

                case 340:
                    GetComponent<SpriteRenderer>().sprite = healthBar[16];

                    break;

                case 320:
                    GetComponent<SpriteRenderer>().sprite = healthBar[17];

                    break;

                case 300:
                    GetComponent<SpriteRenderer>().sprite = healthBar[18];

                    break;

                case 280:
                    GetComponent<SpriteRenderer>().sprite = healthBar[19];

                    break;

                case 260:
                    GetComponent<SpriteRenderer>().sprite = healthBar[20];

                    break;

                case 240:
                    GetComponent<SpriteRenderer>().sprite = healthBar[21];
                    break;

                case 220:
                    GetComponent<SpriteRenderer>().sprite = healthBar[22];
                    break;

                case 200:
                    GetComponent<SpriteRenderer>().sprite = healthBar[23];

                    break;

                case 180:
                    GetComponent<SpriteRenderer>().sprite = healthBar[24];

                    break;

                case 160:
                    GetComponent<SpriteRenderer>().sprite = healthBar[25];

                    break;

                case 140:
                    GetComponent<SpriteRenderer>().sprite = healthBar[26];
                    break;

                case 120:
                    GetComponent<SpriteRenderer>().sprite = healthBar[27];

                    break;

                case 100:
                    GetComponent<SpriteRenderer>().sprite = healthBar[28];

                    break;

                case 80:
                    GetComponent<SpriteRenderer>().sprite = healthBar[29];

                    break;

                case 60:
                    GetComponent<SpriteRenderer>().sprite = healthBar[30];
                    break;

                case 40:
                    GetComponent<SpriteRenderer>().sprite = healthBar[31];

                    break;

                case 20:
                    GetComponent<SpriteRenderer>().sprite = healthBar[32];

                    break;

                case 0:
                    GetComponent<SpriteRenderer>().sprite = healthBar[32];

                    break;
                    
            }
        }
    }
}
