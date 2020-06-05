using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private BoxCollider2D bCol2d;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        bCol2d = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    }
}
