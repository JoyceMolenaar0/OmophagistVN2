using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSCR : MonoBehaviour
{
   public void Play() 
    {
        SceneManager.LoadScene("(2)Cutscene");
    }

    public void GoToTesting() 
    {
        SceneManager.LoadScene("(3)TestingLoading");
    }

    
    public void Prologue()
    {
        SceneManager.LoadScene("Dialogue");
    }








    //Scene: BadEnding
    public void GoToBadEnding2()
    {
        SceneManager.LoadScene("BadEnding2");
    }

    public void GoToBadEnding3()
    {
        SceneManager.LoadScene("BadEnding3");
    }



    public void Quit()
    {
        Application.Quit();
        
    }

   
}
