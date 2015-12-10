using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowOHKO : MonoBehaviour {

    private Text showBullets;
    private GameObject player;
    private Player oneShots;
    // Use this for initialization
    void Start()
    {
        showBullets = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        oneShots = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        showBullets.text = oneShots.getOneShots().ToString();
    }
}
