using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            Debug.Log(getHealth().ToString());
        }
    }

    public void addHealth(int gain)
    {
        health += gain;
    }

    public int getHealth()
    {
        return health;
    }
}
