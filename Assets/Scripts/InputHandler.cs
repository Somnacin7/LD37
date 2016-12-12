using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

    public delegate void JumpDown();
    public event JumpDown OnJumpDown; 
    private bool jump;

    public float horizontalAxis;

	// Use this for initialization
	void Start() {
	    
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Jump") > 0) {
            if (!jump) {
                if (OnJumpDown != null) {
                    OnJumpDown();
                }
                jump = true;
            }
        } else {
            jump = false;
        }
	}
}
