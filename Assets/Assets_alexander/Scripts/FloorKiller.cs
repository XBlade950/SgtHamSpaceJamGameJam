using UnityEngine;
using System.Collections;

public class FloorKiller : MonoBehaviour {

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
            obj.GetComponent<Player>().takeDamage(100);
        }
    }
}
