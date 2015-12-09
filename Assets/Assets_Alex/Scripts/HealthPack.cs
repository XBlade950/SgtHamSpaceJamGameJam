using UnityEngine;
using System.Collections;

public class HealthPack : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;
        if (obj.tag == "Player")
        {
            obj.GetComponent<Player>().addHealth(15);
            Destroy(gameObject);
        }
    }
}
