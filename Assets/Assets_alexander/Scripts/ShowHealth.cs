using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHealth : MonoBehaviour {

    public Text showHealth;
    public GameObject player;
    private Player health;
	// Use this for initialization
	void Start () {
        showHealth = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        showHealth.text = health.getHealth().ToString();
	}
}
