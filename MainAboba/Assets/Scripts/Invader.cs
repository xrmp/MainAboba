using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;
    public float animationTime;

    private SpriteRenderer _spriteRenderer;
    private int _animationonFrame;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), this.animationTime, this.animationTime);
    }

    private void AnimateSprite()
    {
        _animationonFrame++;

        if (_animationonFrame >= animationSprites.Length) { _animationonFrame = 0; }

        _spriteRenderer.sprite = animationSprites[_animationonFrame];
    }
}
