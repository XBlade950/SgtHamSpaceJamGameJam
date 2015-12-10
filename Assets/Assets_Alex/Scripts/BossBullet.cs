using UnityEngine;
using System.Collections;

public class BossBullet : MonoBehaviour {

    public float speed = 1;
    private GameObject enemy;
    public float bulletDistance = 50f;
    public int damage = 10;
    private Vector3 startPos;


    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;

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


        if (obj.tag == "Player")
        {
            Debug.Log("Bullet hit Player");
            obj.GetComponent<Player>().takeDamage(damage);

        }

        if (obj.tag != "enemy" && obj.tag != "enemyBullet" && obj.tag != "playerBullet" && obj.tag != "Boss" && obj.name != "Boss" && obj.tag != "BossShield")
        {
            Debug.Log("Boss Hit"+obj.name);
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;

        if (obj.tag == "shield")
        {
            Destroy(gameObject);
        }
    }
}
