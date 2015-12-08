using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 1;
    private GameObject enemy;
    public float bulletDistance = 20f;
    public int damage = 1;


    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;

        //deletes if bullet is very far away(off screen)
        Vector3 diff = transform.position - enemy.transform.position;
        if (diff.magnitude > bulletDistance)
            Destroy(gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject obj = col.gameObject;

        
        if (obj.tag == "Player")
        {
            Debug.Log("Bullet hit Player");
            obj.GetComponent<Player>().takeDamage(damage);
            
        }
        if (obj.tag != "enemy")
        {
            Destroy(gameObject);
        }
    }


}
