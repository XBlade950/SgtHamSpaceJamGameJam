using UnityEngine;
using System.Collections;

public class HeavyAmmo : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;
        if(obj.tag == "Player")
        {
            obj.GetComponent<Player>().addOneShot();
            Destroy(gameObject);
        }
    }
}
