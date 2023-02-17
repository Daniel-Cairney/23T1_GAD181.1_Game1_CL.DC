using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace DanCon
{

    public class SceneLoader : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("FightScene");
        }

        public void Settings()
        {
            SceneManager.LoadScene("Settings");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
        
        public void BackToMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
   
        public void TutorialMenu()
        {
            SceneManager.LoadScene("Tutorial");
        } 
        
        public void TutorialSecondPage()
        {
            SceneManager.LoadScene("Tutorial2");
        }

    
    }

}