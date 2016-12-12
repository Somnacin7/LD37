using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float movementSpeed = 1f;

    private InputHandler input;
    private Rigidbody2D rb2d;

	void Awake() {
        input = GetComponent<InputHandler>();
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
        var curVelocity = rb2d.velocity;
        rb2d.velocity = new Vector2(movementSpeed * input.horizontalAxis, curVelocity.y);
	}
}
