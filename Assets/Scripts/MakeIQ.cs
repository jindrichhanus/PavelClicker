using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeIQ : MonoBehaviour
{
    // Pejvl
    public  GameObject fakeButton;
    public  GameObject fakeText;
    public  GameObject realButton;
    public  GameObject realText;
    public static int pejvlValue = 100;
    public GameObject pejvlStats;
    public static int numberOfPavels;
    public static int IQperS;
    
    // Pavlo
    public GameObject fakeButton2;
    public GameObject fakeText2;
    public GameObject realButton2;
    public GameObject realText2;
    public static int pavloValue = 1000;
    public GameObject pavloStats;
    public static int numberOfPavlos;
    public static int IQperS2;
    public AudioSource playSound;
    
    // IQperClick
    public GameObject fakeButton3;
    public GameObject fakeText3;
    public GameObject realButton3;
    public GameObject realText3;
    public static int IQperClickValue = 5;
    public GameObject IQperClickStats;
    public static int numberOfIQperClick = 1;
    public static int IQperClick = 1;
    
    // Paula
    public GameObject fakeButton4;
    public GameObject fakeText4;
    public GameObject realButton4;
    public GameObject realText4;
    public static int paulaValue = 2000;
    public GameObject PaulaStats;
    public static int numberOfPaulas = 0;
    public static int IQperS3 = 0;


    public GameObject textBox;
    public GameObject IQDisplay;
    public GameObject HPDisplay;
    public GameObject statusBox;
    static public int Happiness = 0;
    static public int IQ = 0;
    static public int lastCheckedIQ = 0;
    static public int IQ20 = 0;
    public GameObject Achievement1;
    public static bool Achievement1Finished = false;
    public GameObject Achievement2;
    public static bool Achievement2Finished = false;
    public GameObject Achievement3;
    public static bool Achievement3Finished = false;
    public GameObject Achievement4;
    public static bool Achievement4Finished = false;
    public GameObject Achievement5;
    public static bool Achievement5Finished = false;

    


    float TimeInterval;
    public void Click()
    {
        IQ += IQperClick;
        UpdateUI();
        int bum = Random.Range(1, 100000);
        int genChance = Random.Range(1, 200);
        if(genChance == 1)
        {
            Disaster();
        }
        if(genChance == 100)
        {
            Happiness += 5;
            IQ += 500;
            LuckyEvent();
            
        }
        if(bum == 69420)
        {
            Bum();
        }
    }

    public void UpdateUI()
    {
        
        if (IQ != lastCheckedIQ && IQ20 < IQ / 50)
        {

            Happiness += 1;
            
            statusBox.GetComponent<Text>().text = "You got 1 happiness";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            lastCheckedIQ = IQ;
            IQ20 = (IQ / 50);
        }
        
        // Achievementy
        if (IQ >= 10000)
        {
            if (Achievement1Finished == false)
            {
                
                
                    Achievement1Finished = true;
                    Achievement1.GetComponent<Animation>().Play("Achievement1");
                
               

            }
            else
            {
                Achievement1Finished = true;
            }


        }
       
        if (IQ >= 100000)
        {
            if (Achievement2Finished == false)
            {


                Achievement2Finished = true;
                Achievement2.GetComponent<Animation>().Play("Achievement1");



            }
            else
            {
                Achievement2Finished = true;
            }


        }

        if (numberOfPavels >= 100)
        {
            if (Achievement3Finished == false)
            {


                Achievement3Finished = true;
                Achievement3.GetComponent<Animation>().Play("Achievement1");



            }
            else
            {
                Achievement3Finished = true;
            }
        }
        
        if (numberOfPavlos >= 100)
            {
                if (Achievement4Finished == false)
                {


                    Achievement4Finished = true;
                    Achievement4.GetComponent<Animation>().Play("Achievement1");



                }
                else
                {
                    Achievement4Finished = true;
                }
        }

        if (numberOfPaulas >= 100)
        {
                if (Achievement5Finished == false)
                {


                    Achievement5Finished = true;
                    Achievement5.GetComponent<Animation>().Play("Achievement1");



                }
                else
                {
                    Achievement5Finished = true;
                }


        }

        






                // Stats
                pejvlStats.GetComponent<Text>().text = "Pejvls: " + numberOfPavels + " at " + IQperS + " per second";
        fakeText.GetComponent<Text>().text = "Buy Pejvl -" + pejvlValue + "IQ";
        realText.GetComponent<Text>().text = "Buy Pejvl -" + pejvlValue + "IQ";

        pavloStats.GetComponent<Text>().text = "Pavlos: " + numberOfPavlos + " at " + IQperS2 + " per second";
        fakeText2.GetComponent<Text>().text = "Buy Pavlo -" + pavloValue + "IQ";
        realText2.GetComponent<Text>().text = "Buy Pavlo -" + pavloValue + "IQ";
        
        IQperClickStats.GetComponent<Text>().text = "Knowledge: " + IQperClick + " IQ per click";
        fakeText3.GetComponent<Text>().text = "Buy Knowledge -" + IQperClickValue + "Happiness";
        realText3.GetComponent<Text>().text = "Buy Knowledge -" + IQperClickValue + "Happiness";

        PaulaStats.GetComponent<Text>().text = "Paulas: " + numberOfPaulas + " at " + IQperS3 + " per second";
        fakeText4.GetComponent<Text>().text = "Buy Paula -" + paulaValue + "IQ";
        realText4.GetComponent<Text>().text = "Buy Paula -" + paulaValue + "IQ";

        // Buttons 




            if (IQ >= pejvlValue)
            {
                fakeButton.SetActive(false);
                realButton.SetActive(true);
            }
            else
            {
                realButton.SetActive(false);
                fakeButton.SetActive(true);
            }

            if (IQ >= pavloValue)
            {
                fakeButton2.SetActive(false);
                realButton2.SetActive(true);
            }
            else
            {
                realButton2.SetActive(false);
                fakeButton2.SetActive(true);
            }

            if (Happiness >= IQperClickValue)
            {
                fakeButton3.SetActive(false);
                realButton3.SetActive(true);
            }
            else
            {
                realButton3.SetActive(false);
                fakeButton3.SetActive(true);
            }
            
            if (IQ >= paulaValue)
            {
                fakeButton4.SetActive(false);
                realButton4.SetActive(true);
            }
            else
            {
                realButton4.SetActive(false);
                fakeButton4.SetActive(true);
            }


        
        IQDisplay.GetComponent<Text>().text = "IQ: " + IQ;
        HPDisplay.GetComponent<Text>().text = "Happiness: " + Happiness;

    }

    

    // Upgrades
    public void StartPejvl()
    {
        playSound.Play();

        IQ -= pejvlValue;
        pejvlValue *= Random.Range(2, 3);
        
        IQperS += 1;
        numberOfPavels += 1;
        UpdateUI();
        
    }
    public void StartPavlo()
    {
        playSound.Play();
        IQ -= pavloValue;
        pavloValue = Mathf.RoundToInt(pavloValue * 1.5f);
        IQperS2 += 10;
        

        numberOfPavlos += 1;
        UpdateUI();
    }
    
    public void StartPaula()
    {
        
        IQ -= paulaValue;
        paulaValue *= 3;
        IQperS3 += Random.Range(50, 200); 
        

        numberOfPaulas += 1;
        UpdateUI();
    }
    public void IQClick()
    {
        
              
        Happiness -= IQperClickValue;
        IQperClickValue *= 4;
        
        IQperClick += Random.Range(1, 10);

        numberOfIQperClick += 1;
        UpdateUI();
    }
        
    // Disasters-Random events
    public void Disaster()
    {
        
        int IQLoss = Mathf.RoundToInt(IQ * 0.25f);
        IQ -= IQLoss;
        statusBox.GetComponent<Text>().text = "You lost " + IQLoss + "IQ Because Pavel couldn't figure out how to solve mathematical problem";
        statusBox.GetComponent<Animation>().Play("StatusAnim");
        statusBox.SetActive(true);
    }

    public void LuckyEvent()
    {
        statusBox.GetComponent<Text>().text = "You got 5 happiness and 500IQ";
        statusBox.GetComponent<Animation>().Play("StatusAnim");
        statusBox.SetActive(true);
    }

    public void Bum()
    {
        int IQLoss = IQ / 2;
        IQ -= IQLoss;
        statusBox.GetComponent<Text>().text = "Pavel fell on his head and cant remember half of the things that happend ";
        statusBox.GetComponent<Animation>().Play("StatusAnim");
        statusBox.SetActive(true);
    }
    

    void LateUpdate()
    {
        
        TimeInterval += Time.deltaTime;
        if (TimeInterval >= 1)
        {
            TimeInterval = 0;
            //
            IQ += (IQperS + IQperS2 + IQperS3);
            
            UpdateUI();
        }
    }

}
