using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    [SerializeField]
    private float lifeTime;
    private float startTime;
	// Use this for initialization
	void Start () {
        startTime = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

   
}
