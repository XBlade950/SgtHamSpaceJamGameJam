using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

    public float speed = 1;
    private Vector3 startPos;
    public float bulletDistance = 50f;
    public int damage = 20;


	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward*speed;

        //deletes if bullet is very far away(off screen)
        Vector3 diff = transform.position - startPos;
        if (diff.magnitude > bulletDistance)
        {
            Debug.Log("Too far");
            Destroy(gameObject);
        }

	}

    void OnCollisionEnter(Collision col)
    {
        GameObject obj = col.gameObject;
        
        Debug.Log("Bullet hit something");
        if (obj.tag == "enemy"){
            obj.GetComponent<Enemy>().takeDamage(damage);
        }
        if (obj.tag == "Boss")
        {
            obj.GetComponent<Boss>().takeDamage(damage);
        }
        if (obj.tag != "Player" || obj.tag != "enemyBullet" || obj.tag != "playerBullet")
        {
            Destroy(gameObject);
        }
    }

    
}
