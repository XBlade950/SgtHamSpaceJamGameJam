using UnityEngine;
using System.Collections;

public class WinningCrystal : MonoBehaviour {

    public bool win = false;
    private ShowPanel menu;
    private GameObject player;
    
	// Use this for initialization
	void Start () {
        menu = GameObject.Find("GUI").GetComponent<ShowPanel>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;
        if (obj.tag == "Player")
        {
            Debug.Log("YOU WIN BITCH");
            menu.win = true;
            player.GetComponent<PlayerController>().enabled = false;
            Destroy(gameObject);
        }
    }
}
