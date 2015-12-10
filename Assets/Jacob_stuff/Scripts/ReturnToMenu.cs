using UnityEngine;
using System.Collections;

public class ReturnToMenu : MonoBehaviour {

    

    // Update is called once per frame
    public void MenuButtonClicked()
    {
        Application.LoadLevel("Start");
    }
}
