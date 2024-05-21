using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GridCell : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool walkable;

    private void Start()
    {
        OnValidate();
    }

    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = walkable ? Color.white : Color.black;
    }
}