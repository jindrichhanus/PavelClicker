using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsUI : MonoBehaviour
{
    public static bool toggle = false;
    public  GameObject ButtonsUpgrades;
    public  GameObject Menu;
    public  GameObject SaveButton;
    public  GameObject ShrekButton;
    

    
    
        
    
    public void Toggle()
    {
        toggle = !toggle;
        if (toggle)
        {
            ButtonsUpgrades.SetActive(true);
            
        }
        else
        {
            ButtonsUpgrades.SetActive(false);
        }
    }

    public void ToggleMenu()
    {
        toggle = !toggle;
        if (toggle)
        {
            Menu.SetActive(true);

        }
        else
        {
            Menu.SetActive(false);
        }
    }

    public void Resume()
    {
        if (toggle)
        {
            Menu.SetActive(false);

        }
    }

    
    public void Shrek()
    {
        
        
            ShrekButton.SetActive(true);

        
        
    
    }


}


