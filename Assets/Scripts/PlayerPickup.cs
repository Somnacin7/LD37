using UnityEngine;
using System.Collections;

public class PlayerPickup : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col) {
        var go = col.gameObject;
        Destroy(go);
    }
}
