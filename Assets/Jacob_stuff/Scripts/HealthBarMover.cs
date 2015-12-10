using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarMover : MonoBehaviour {

	
    private GameObject player;
    private Player health;
    
    // Use this for initialization
    void Start()
    { 
        
        player = GameObject.FindGameObjectWithTag("Player");
        health = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
