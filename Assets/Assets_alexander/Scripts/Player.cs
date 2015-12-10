using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private int health;
    private int OneShots = 4;
    private GameObject shield;
    //private bool canShield = true;
    [SerializeField]
    //private float shieldCoolDown = 10f;

	// Use this for initialization
	void Start () {
        health = 100;
        shield = (GameObject)Resources.Load("Shield");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            if (health <= 0)
                health = 0;
            Debug.Log(getHealth().ToString());
        }
    }

    public void addHealth(int gain)
    {
        health += gain;
        if (health >= 100)
        {
            health = 100;
        }
    }

    public int getHealth()
    {
        return health;
    }

    public void addOneShot()
    {
        OneShots++;
    }

    public void OneShot()
    {
        OneShots--;
    }

    public int getOneShots()
    {
        return OneShots;
    }

    public void deployShield()
    {
        
        Vector3 spawn = transform.position;
        Instantiate(shield, spawn, transform.rotation);
            
        startCooldown();
        
    }

    private void startCooldown()
    {
        

    }

    public void rapidFire()
    {

    }
}
