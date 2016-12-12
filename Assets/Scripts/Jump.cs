using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public float jumpForce = 0;
    public LayerMask ground;

    private InputHandler input;
    private bool jump;
    private Rigidbody2D rb2d;
    private float groundDist;

    void Awake() {
        input = GetComponent<InputHandler>();
        input.OnJumpDown += JumpDown;
        input.OnJumpUp += JumpUp;

        rb2d = GetComponent<Rigidbody2D>();
        groundDist = GetComponent<BoxCollider2D>().bounds.extents.y;
    }

    void FixedUpdate() {
        if (jump) {
            if (IsGrounded()) {
                var curVelocity = rb2d.velocity;
                rb2d.velocity = new Vector2(curVelocity.x, jumpForce);
                jump = false;
            }
        }
    }

    void JumpDown() {
        jump = true;
    }

    void JumpUp() {
        jump = false;
    }

    public bool IsGrounded() {
        return Physics2D.Raycast(transform.position, -Vector2.up, groundDist + 0.1f, ground);
    }
}
