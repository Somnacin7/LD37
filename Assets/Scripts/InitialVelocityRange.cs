using UnityEngine;
using System.Collections;

public class InitialVelocityRange : MonoBehaviour {

    public Vector2 min = Vector2.zero;
    public Vector2 max = Vector2.zero;

    private Vector2 velocity;
    private Rigidbody2D rb2d;

	void Start() {
        rb2d = GetComponent<Rigidbody2D>();

        var x = Random.Range(min.x, max.x);
        var y = Random.Range(min.y, max.y);
        velocity = new Vector2(x, y);
	}

    void FixedUpdate() {
        rb2d.velocity = velocity;
    }
}
