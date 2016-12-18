using UnityEngine;
using System.Collections;

public class PlayerAnimatorController : MonoBehaviour {

    private Animator animator;
    private InputHandler input;

	void Awake() {
        animator = GetComponent<Animator>();
        input = GetComponent<InputHandler>();
	}
	
	// Update is called once per frame
	void Update() {
	    if (Mathf.Abs(input.horizontalAxis) > 0) {
            animator.SetBool("idle", false);
        } else {
            animator.SetBool("idle", true);
        }
    }
}
