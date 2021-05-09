using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public int savedIQ;
    public int savedHappiness;
    public int savedPavels;
    public int savedPavelValue;
    public int savedPavlos;
    public int savedPavloValue;
    public int savedKnowledge;
    public int savedKnowledgeValue;
    public int savedIQperS;
    public int savedIQperS2;

    void Start()
    {


        if (MainMenu.isLoading == true)
            {
                savedIQ = PlayerPrefs.GetInt("SavedIQ");
                MakeIQ.IQ = savedIQ;

                savedHappiness = PlayerPrefs.GetInt("SavedHappiness");
                MakeIQ.Happiness = savedHappiness;

                savedPavels = PlayerPrefs.GetInt("SavedPavels");
                MakeIQ.numberOfPavels = savedPavels;

                savedPavelValue = PlayerPrefs.GetInt("SavedPejvlValue");
                MakeIQ.pejvlValue = savedPavels;

                savedPavlos = PlayerPrefs.GetInt("SavedPavlos");
                MakeIQ.numberOfPavlos = savedPavlos;

                savedPavloValue = PlayerPrefs.GetInt("SavedPavloValue");
                MakeIQ.pavloValue = savedPavloValue;

                savedKnowledge = PlayerPrefs.GetInt("SavedKnowledge");
                MakeIQ.IQperClick = savedKnowledge;

                savedKnowledgeValue = PlayerPrefs.GetInt("SavedKnowledgeValue");
                MakeIQ.IQperClickValue = savedKnowledgeValue;
            
                savedIQperS = PlayerPrefs.GetInt("SavedIQperS");
                MakeIQ.IQperS = savedIQperS;
            
                savedIQperS2 = PlayerPrefs.GetInt("SavedIQperS2");
                MakeIQ.IQperS2 = savedIQperS2;








            }
        
    }


    



}
