using System.Collections;
using System.Collections.Generic;
using Assets.sripts.Interfaces;
using UnityEngine;

public class PlayerController : MonoBehaviour, IBlockable
{
    public float moveSpeed = 5f;
    private Animator animator;
    private Rigidbody2D rb;

    private bool block;

    public void Block()
    {
        block = true;
        rb.velocity = Vector3.zero;
    }

    public void Unblock()
    {
        block = false;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Если персонаж заблокирован.
        if (block) return;

        // Перемещение персонажа
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal * moveSpeed, moveVertical * moveSpeed);
        rb.AddForce(movement, ForceMode2D.Impulse);

        rb.velocity /= 3;

        if(moveHorizontal > 0 && moveVertical == 0)
        {
            animator.Play("run_right_anim_cfg");
        }
        if (moveHorizontal < 0 && moveVertical == 0)
        {
            animator.Play("run_left_anim_cfg");
        }
        if (moveVertical > 0 && moveHorizontal == 0) 
        {
            animator.Play("run_up_anim_cfg");
        }
        if(moveVertical < 0 && moveHorizontal == 0)
        {
            animator.Play("move");
        }
        if (moveVertical == 0 && moveHorizontal == 0)
        {
            animator.Play("Menu player");
        }
        if (moveVertical < 0)
        {
            if (moveHorizontal > 0)
            {
                animator.Play("Menu player");
            }
        }
        
    }
}