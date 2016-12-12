using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

    public delegate void JumpDown();
    public event JumpDown OnJumpDown;
    public delegate void JumpUp();
    public event JumpUp OnJumpUp;
    private bool jump;

    public float horizontalAxis { get; set; }

    // Update is called once per frame
    void Update() {
        // Get Jump Input
        if (Input.GetAxis("Jump") > 0) {
            if (!jump) {
                if (OnJumpDown != null) {
                    OnJumpDown();
                }
                jump = true;
            }
        } else {
            OnJumpUp();
            jump = false;
        }

        // Get Horizontal Axis
        horizontalAxis = Input.GetAxis("Horizontal");
	}
}
