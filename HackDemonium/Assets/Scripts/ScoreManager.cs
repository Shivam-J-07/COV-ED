using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Score;

    public Text Currency;
    public Button left;

    public Button middle;

    public Button right;

    public Text Question;

    public Text arrow;

    private int ScoreAmount;

    int counter = 0;

    public void IncreaseScore(){

        ScoreAmount = ScoreAmount + 700;
        
        Score.text = ScoreAmount.ToString();
        Currency.text = ScoreAmount.ToString();
    }

    public void disableMiddleButton(){

        counter = counter + 1;

        middle.interactable = false;

        if (counter == 3){
            arrow.text = "→";
        }
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

            left.interactable = true;

            right.interactable = true;

            middle.interactable = true;

            middle.GetComponentInChildren<Text>().text = "Monday";

            left.GetComponentInChildren<Text>().text = "Wednesday";

            right.GetComponentInChildren<Text>().text = "Friday";
        }

        else if (counter == 2){
            Question.text = "Identify the pair of words that are homophones.";

            left.interactable = true;

            right.interactable = true;
            
            middle.interactable = true;

            middle.GetComponentInChildren<Text>().text = "Hear and Here";

            left.GetComponentInChildren<Text>().text = "Book and Look";

            right.GetComponentInChildren<Text>().text = "Beak and Week";
        }

    }

    void start(){
        
    }

    void update(){


    }

}
