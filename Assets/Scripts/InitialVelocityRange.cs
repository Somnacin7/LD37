using UnityEngine;
using System.Collections;

public class InitialVelocityRange : MonoBehaviour {

    public Vector2 min = Vector2.zero;
    public Vector2 max = Vector2.zero;

    private Rigidbody2D rb2d;

	void Start() {
        rb2d = GetComponent<Rigidbody2D>();

        var x = Random.Range(min.x, max.x);
        var y = Random.Range(min.y, max.y);
        rb2d.velocity = new Vector2(x, y);
	}
}
