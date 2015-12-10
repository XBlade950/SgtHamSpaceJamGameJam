using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
    [SerializeField]
    private int health;
    public GameObject player;
    public float speed;
    public float offset;
    public float startPos;
    public float shootInterval = .5f;
    public GameObject bullet;
    private bool start;

    // Use this for initialization
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Transform>();
        gameObject.GetComponent<Transform>();
        start = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Debug.Log("Boss Defeated");
            Debug.Log("Enemy Defeated");
            Vector3 dropPos = transform.position;
            Quaternion quat = transform.rotation;
            Instantiate((GameObject)Resources.Load("Winning Crystal"), dropPos, quat);
            Destroy(gameObject);
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, player.transform.position.y+4f, gameObject.transform.position.z);
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < startPos)
        {
            start = true;
        }


        if (start)
        {
            Vector3 desired_velocity = Vector3.Normalize(player.transform.position - gameObject.transform.position) * (speed * Time.deltaTime);




            if (Vector3.Distance(player.transform.position, gameObject.transform.position) > offset)
            {
                gameObject.transform.position += desired_velocity;
            }

            if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= offset)
            {
                gameObject.transform.position -= desired_velocity;
            }
            Vector3 point = player.transform.position;
            point.y = transform.position.y;
            transform.LookAt(point);
            shoot();
        }

    }

    public void takeDamage(int damage)
    {
        health -= damage;

    }

    public void shoot()
    {
        shootInterval -= Time.deltaTime;
        if (shootInterval <= 0)
        {
            Vector3 toInstantiate = gameObject.transform.position;
            toInstantiate.y -= 1.5f;
            Instantiate(bullet, toInstantiate + (transform.forward * 5f), transform.rotation);
            shootInterval = .5f;
        }
    }
}
