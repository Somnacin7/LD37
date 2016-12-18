using UnityEngine;
using System.Collections;

public class DestroyOffscreen : MonoBehaviour {

    public float offset = 16f;
    public delegate void DestroySelf();
    public event DestroySelf OnDestroy;

    private bool offscreen;
    private float offscreenX = 0;
    private float offscreenY = 0;
    private Rigidbody2D rb2d;

    void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

	// Use this for initialization
	void Start() {
        offscreenX = (Screen.width / PixelCamera.pixelsToUnits) / 2 + offset;
        offscreenY = (Screen.height / PixelCamera.pixelsToUnits) / 2 + offset;
    }
	
	// Update is called once per frame
	void Update() {
        var pos = transform.position;
        var dir = rb2d.velocity;

        if (Mathf.Abs(pos.x) > offscreenX) {
            if (dir.x < 0 && pos.x < -offscreenX) {
                offscreen = true;
            } else if (dir.x > 0 && pos.x > offscreenX) {
                offscreen = true;
            }
        } else if (Mathf.Abs(pos.y) > offscreenY) {
            if (dir.y < 0 && pos.y < -offscreenY) {
                offscreen = true;
            } else if (dir.y > 0 && pos.y > offscreenY) {
                offscreen = true;
            }
        } else {
            offscreen = false;
        }

        if (offscreen) {
            OnOutOfBounds();
        }
    }

    public void OnOutOfBounds() {
        offscreen = false;
        GameObjectUtil.Destroy(gameObject);

        if (OnDestroy != null) {
            OnDestroy();
        }
    }
}
