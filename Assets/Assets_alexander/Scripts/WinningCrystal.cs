using UnityEngine;
using System.Collections;

public class WinningCrystal : MonoBehaviour {

    public bool win = false;
    private ShowPanel menu;
    
	// Use this for initialization
	void Start () {
        menu = GameObject.Find("GUI").GetComponent<ShowPanel>();
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
            Destroy(gameObject);
        }
    }
}
