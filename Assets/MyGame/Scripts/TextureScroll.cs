using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public float scrollSpeed;
    public bool scroll = true;
    Material backgroundMaterial;
    public float time= 0f;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    private void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, time);
            backgroundMaterial.mainTextureOffset = offset;
        }
    }
}
