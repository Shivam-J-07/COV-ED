using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterMeasureManager : MonoBehaviour
{
    public Button mask;

    public Button house;

    public Button washHands;

    private int counter = 0;

    public static bool buttonActive = false;  
    
    public void makeMaskInactive(){
        mask.gameObject.SetActive(false);
    }

    public void makeHouseInactive(){
        house.gameObject.SetActive(false);
    }

    public void makeWashHandsInactive(){
        washHands.gameObject.SetActive(false);
    }

}
