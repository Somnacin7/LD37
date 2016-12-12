using UnityEngine;
using System.Collections;

public class TileSprite : MonoBehaviour {

    public int textureSize = 32;
    public bool scaleHorizontally = true;
    public bool scaleVertically = true;

    void Start() {
        var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * PixelCamera.scale));
        var newHeight = !scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * PixelCamera.scale));

        transform.localScale = new Vector3(newWidth * textureSize, newHeight * textureSize, 1);

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);
    }
}
