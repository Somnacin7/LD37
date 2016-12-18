using UnityEngine;
using System.Collections;

public class FlipSprite : MonoBehaviour {

    // By default sprites should face right
    private InputHandler input;
    private SpriteRenderer spriteRenderer;

	void Awake() {
        input = GetComponent<InputHandler>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	void Update() {
	    if (input.horizontalAxis < 0 && !spriteRenderer.flipX) {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        } else if (input.horizontalAxis > 0 && spriteRenderer.flipX) {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }
}
