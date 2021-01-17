using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void toInstructions(){
		SceneManager.LoadScene("Instructions Scene");
	}

    public void toStore(){
		SceneManager.LoadScene("Store Scene");
	}

	public void toLogin(){
		SceneManager.LoadScene("Login Screen");
	}

	public void toGame(){
		SceneManager.LoadScene("GamePlay");
	}
}
