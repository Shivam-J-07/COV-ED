using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Score;

    public Button left;

    public Button middle;

    public Button right;

    public Text Question;

    private int ScoreAmount;

    int counter = 0;

    public void IncreaseScore(){

        ScoreAmount = ScoreAmount + 200;
        
        Score.text = ScoreAmount.ToString();
    }

    public void disableMiddleButton(){

        counter = counter + 1;

        middle.interactable = false
    }

    public void disableRightButton(){

        counter = counter + 1;

        right.interactable = false;
    }

    public void disableLeftButton(){

        counter = counter + 1;

        left.interactable = false;
    }

    public void resetButton(){

        if (counter == 1){
            Question.text = "What comes after Tuesday?";

            right.interactable = true;
            
            middle.GetComponentInChildren<Text>().text = "Monday";

            left.GetComponentInChildren<Text>().text = "Wednesday";

            right.GetComponentInChildren<Text>().text = "Friday";
        }

        else if(counter == 2){
            Question.text = "What comes after Tuesday?";
        }

    }

    void start(){
        
    }

    void update(){


    }

}
