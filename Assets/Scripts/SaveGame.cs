using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{


    public GameObject SaveButton;
    

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedIQ", MakeIQ.IQ);
        PlayerPrefs.SetInt("SavedHappiness", MakeIQ.Happiness);
        PlayerPrefs.SetInt("SavedPavels", MakeIQ.numberOfPavels);
        PlayerPrefs.SetInt("SavedPavlos", MakeIQ.numberOfPavlos);
        PlayerPrefs.SetInt("SavedKnowledge", MakeIQ.IQperClick);
        PlayerPrefs.SetInt("SavedPejvlValue", MakeIQ.pejvlValue);
        PlayerPrefs.SetInt("SavedPavloValue", MakeIQ.pavloValue);
        PlayerPrefs.SetInt("SavedIQperS", MakeIQ.IQperS);
        PlayerPrefs.SetInt("SavedIQperS2", MakeIQ.IQperS2);

        PlayerPrefs.SetInt("SavedKnowledgeValue", MakeIQ.IQperClickValue);
    }


}
