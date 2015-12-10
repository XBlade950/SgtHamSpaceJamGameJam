using UnityEngine;
using System.Collections;

public class WinningCrystal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
            Destroy(gameObject);
        }
    }
}
