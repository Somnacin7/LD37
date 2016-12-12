using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public float jumpForce = 0;

    private InputHandler input;
    private bool jump;
    private Rigidbody2D rb2d;

    void Awake() {
        input = GetComponent<InputHandler>();
        input.OnJumpDown += SetJump;

        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate() {
        if (jump) {
            var curVelocity = rb2d.velocity;
            rb2d.velocity = new Vector2(curVelocity.x, jumpForce);
            jump = false;
        }
    }

    void SetJump() {
        jump = true;
    }
}
