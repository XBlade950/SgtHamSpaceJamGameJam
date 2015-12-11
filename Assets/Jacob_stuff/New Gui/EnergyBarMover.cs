using UnityEngine;
using System.Collections;

public class EnergyBarMover : MonoBehaviour {

    public RectTransform bar;
    private GameObject player;
    private MyPlayerController energy;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        energy = player.GetComponent<MyPlayerController>();
        //bar.sizeDelta = new Vector2(100, 10);



    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (bar.sizeDelta.x < 100)
        {
            Debug.Log(bar.sizeDelta.x);
            bar.sizeDelta = new Vector2((Time.time - energy.getShieldTimer()) * 10, 10);
            if (bar.sizeDelta.x > 99)
            {
                bar.sizeDelta = new Vector2(100, 10);
                Debug.Log(bar.sizeDelta.x);
            }
        }

        if (Input.GetKeyDown("e") && bar.sizeDelta.x == 100)
        {
            bar.sizeDelta = new Vector2(0, 10);
        }        

	}
}
