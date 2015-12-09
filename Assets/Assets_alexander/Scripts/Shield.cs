using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    [SerializeField]
    private float lifeTime = 5f;
    private float startTime;
    private float time;
	// Use this for initialization
	void Start () {
        startTime = Time.deltaTime;
        time = lifeTime;
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Destroy(gameObject);
        }
	}

   
}
