using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script creates a quick pause menu, simply create an empty in your UI and parent the pause menu to it, then setup the buttons pointing to the functions of this class

public class PauseMenu : MonoBehaviour {

    bool paused = false;
	
	

	// Checks whether to pause or unpause
	void Update () {
		if (Input.GetButtonDown("Pause"))
        {
            if (!paused)
            {
                Debug.Log("paused");
                Time.timeScale = 0f;
                paused = true;
                foreach (Transform child in transform)
                {
                    child.gameObject.SetActive(true);
                }
            }
            else
            {
                Time.timeScale = 1f;
                paused = false;
                foreach (Transform child in transform)
                {
                    child.gameObject.SetActive(false);
                }
            }
           
        }
	}
    
    public void Resume()//Call this function from an onClick to Resume your game from the pause menu
    {
        Time.timeScale = 1f;
        paused = false;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void Quit()//Call this function from an onClick to quit the game
    {
        Application.Quit();
    }
}
