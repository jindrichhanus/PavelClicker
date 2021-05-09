using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AchievementScreen : MonoBehaviour
{
    public GameObject Achi1;
    public GameObject Achi2;
    public GameObject Achi3;
    public GameObject Achi4;
    public GameObject Achi5;


    public void AchiScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadAchievements() 
    {
        
        if(MakeIQ.Achievement1Finished == true)
        {
            Achi1.SetActive(true);
        }
        else
        {
            Achi1.SetActive(false);
        }
        
        if(MakeIQ.Achievement2Finished == true)
        {
            Achi2.SetActive(true);
        }
        else
        {
            Achi2.SetActive(false);
        }
        
        if(MakeIQ.Achievement1Finished == true)
        {
            Achi3.SetActive(true);
        }
        else
        {
            Achi3.SetActive(false);
        }
        
        if(MakeIQ.Achievement4Finished == true)
        {
            Achi4.SetActive(true);
        }
        else
        {
            Achi4.SetActive(false);
        }
        
        if(MakeIQ.Achievement5Finished == true)
        {
            Achi5.SetActive(true);
        }
        else
        {
            Achi5.SetActive(false);
        }







    }


    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }






}
