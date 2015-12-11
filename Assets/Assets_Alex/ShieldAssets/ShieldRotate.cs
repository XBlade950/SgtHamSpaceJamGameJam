using UnityEngine;
using System.Collections;

public class ShieldRotate : MonoBehaviour {
    GameObject center;
    public float speed = 30f;

    void Start()
    {
        center = GameObject.Find("Boss");
    }

    void Update()
    {
        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
        transform.position = new Vector3(center.transform.position.x, center.transform.position.y, center.transform.position.z);
    }
}
