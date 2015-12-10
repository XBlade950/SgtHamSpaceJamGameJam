using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void ExitTheGame()
    {
        //for real game time
        Application.Quit();

        //for unity editor
        //UnityEditor.EditorApplication.isPlaying = false;

	}
}
