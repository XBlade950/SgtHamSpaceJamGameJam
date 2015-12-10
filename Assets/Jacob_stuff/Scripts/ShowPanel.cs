using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour {

    public Text won;
    public GameObject PausePanel;
    public GameObject WinLosePanel;
    private bool paused;
    private GameObject player;
    private Player health;
    public bool win = false;


	// Use this for initialization
	void Start () {
        paused = false;

        PausePanel.SetActive(false);
        WinLosePanel.SetActive(false);
        
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<Player>();

	}
	
	// Update is called once per frame
	void Update () {


        if (health.getHealth() <= 0)
        {
            won.text = "You Lose";
            WinLosePanel.SetActive(true);
        }

        if (win)
        {
            WinLosePanel.SetActive(true);
        }

           

        if (Input.GetKeyDown("escape"))
        {
            paused = !paused;
            if (paused)
                Time.timeScale = 0f;
            else
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1f;
            }

        }
	}

    void OnGUI()
    {
        if (paused)
            PausePanel.SetActive(true);
    }

}
