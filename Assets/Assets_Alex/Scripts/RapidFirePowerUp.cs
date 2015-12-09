using UnityEngine;
using System.Collections;

public class RapidFirePowerUp : MonoBehaviour {
    
    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.gameObject;
        if(obj.tag == "Player")
        {
            obj.GetComponent<Player>().rapidFire();
        }
    }
}
