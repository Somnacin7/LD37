﻿using UnityEngine;
using System.Collections;

public class PixelCamera : MonoBehaviour {

    public static float pixelsToUnits = 1f;
    public static float scale = 1;

    // Gameboy Resolution
    public Vector2 nativeResolution = new Vector2(240, 160);

    void Awake() {
        var camera = GetComponent<Camera>();

        if (camera.orthographic) {
            scale = Screen.width / nativeResolution.x;
            pixelsToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
    }
}
