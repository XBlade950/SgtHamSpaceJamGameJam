using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowShield : MonoBehaviour {

    public Text showShield;
    private GameObject player;
    private MyPlayerController shield;
    // Use this for initialization
    void Start()
    {
        showShield = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        shield = player.GetComponent<MyPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shield.canShield)
            showShield.text = "Shield Available";
        else
            showShield.text = "Shield Unavailable";
    }
}
