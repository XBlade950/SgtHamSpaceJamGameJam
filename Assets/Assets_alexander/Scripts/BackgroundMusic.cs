using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

    AudioSource bgm;
    private bool playing = true;
	// Use this for initialization
	void Start () {
        bgm = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;

        if (obj.tag == "Player" && playing)
        {
            bgm.Stop();
            playing = false;
        }
    }
}
