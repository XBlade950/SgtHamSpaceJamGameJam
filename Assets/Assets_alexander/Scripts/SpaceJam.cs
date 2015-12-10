using UnityEngine;
using System.Collections;

public class SpaceJam : MonoBehaviour {

    AudioSource spaceJam;
    private bool playing = false;
	// Use this for initialization
	void Start () {
	    spaceJam = gameObject.GetComponent<AudioSource>();
        //audio.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;

        if (obj.tag == "Player" && !playing){
            spaceJam.Play();
            playing = true;
        }
    }
}
