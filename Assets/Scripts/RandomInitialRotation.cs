using UnityEngine;
using System.Collections;

public class RandomInitialRotation : MonoBehaviour {

    public float minVelocity = 0;
    public float maxVelocity = 0;

    private Rigidbody2D rb2d;

	void Start() {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.angularVelocity = Random.Range(minVelocity, maxVelocity);
	}   
}
