using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Sprite stayRightSprite;

    private void Update()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("run_right_anim_cfg"))
        {
            spriteRenderer.sprite = stayRightSprite;
        }
    }
}