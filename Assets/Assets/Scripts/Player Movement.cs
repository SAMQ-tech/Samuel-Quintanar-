using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private float horizontal;

    [SerializeField] private float runSpeed;
    [SerializeField] private float jumpForce;

    [SerializeField] private Animator anim;



    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(horizontal * runSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.0001f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (horizontal > 0) anim.SetBool("walkR", true);
        else anim.SetBool("walkR", false);
        if (horizontal < 0) anim.SetBool("walkL", true);
        else anim.SetBool("walkL", false);
    }
}



