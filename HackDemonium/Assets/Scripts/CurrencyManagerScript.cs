using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManagerScript : MonoBehaviour
{
    public Text Currency;

    public Text Error;

    public Text noHouse;

    public Text noMasks;

    public Text noHands;

    private int CurrencyAmount = 1400;

    public void BuyMask(){
        
        CurrencyAmount -= 100;

        if (CurrencyAmount >= 0){
            Error.text = "";
            Currency.text = "Currency: " + CurrencyAmount.ToString();
            noMasks.text = "1";
        }
        else{
            Error.text = "Sorry, you do not have enough gold.";
            CurrencyAmount += 100;
        }
    }

    public void WashHands(){

        CurrencyAmount -= 300;

       if (CurrencyAmount >= 0){
           Error.text = "";
           Currency.text = "Currency: " + CurrencyAmount.ToString();
           noHands.text = "1";
        }
        else{
            Error.text = "Sorry, you do not have enough gold.";
            CurrencyAmount += 300;
        }
    }

    public void Sanitize(){

        CurrencyAmount -= 100;

        if (CurrencyAmount >= 0){
            Error.text = "";
            Currency.text = "Currency: " + CurrencyAmount.ToString();
        }
        else{
            Error.text = "Sorry, you do not have enough gold.";
            CurrencyAmount += 100;
        }
    }

    public void SocialDistance(){

        CurrencyAmount -= 600;

        if (CurrencyAmount >= 0){
            Error.text = "";
            Currency.text = "Currency: " + CurrencyAmount.ToString();
        }
        else{
            Error.text = "Sorry, you do not have enough gold.";
            CurrencyAmount += 600;
        }
    }

    public void StayHome(){

        CurrencyAmount -= 1000;

        if (CurrencyAmount >= 0){
            Currency.text = "Currency: " + CurrencyAmount.ToString();
            noHouse.text = "1";
        }
        else{
            Error.text = "Sorry, you do not have enough gold.";
            CurrencyAmount += 1000;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
