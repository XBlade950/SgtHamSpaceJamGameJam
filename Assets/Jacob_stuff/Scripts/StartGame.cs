using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
    

    [SerializeField]
    private string sceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    public void StartButtonClicked()
    {
        Application.LoadLevel(sceneName);
    }
}
