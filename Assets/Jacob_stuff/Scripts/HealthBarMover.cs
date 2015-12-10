using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarMover : MonoBehaviour {

    public RectTransform bar;
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
        bar.sizeDelta = new Vector2(health.getHealth(), 10);
    }
}
