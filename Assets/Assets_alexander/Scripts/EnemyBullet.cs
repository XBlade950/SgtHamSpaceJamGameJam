using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 1;
    private Vector3 startPos;
    public float bulletDistance = 20f;
    [SerializeField]
    private int damage = 1;


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

        if (obj.tag != "enemy" || obj.tag != "enemyBullet" || obj.tag != "playerBullet" || obj.tag != "Boss")
        {
            Debug.Log("Hit something");
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
