using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cnpt_Firefly : scr_cnpt_Form_Abstract
{
    private int jumpsLeft = 2;
    //public scr_cnpt_Firefly(float jumpPower, float moveSpeed) : base(jumpPower, moveSpeed)
    //{
    //    _jumpPower = jumpPower;
    //    _moveSpeed = moveSpeed;
    //}

    public override void Jump(Rigidbody2D rb, float jumpPower, bool isGrounded)
    {
        if (isGrounded)
        {
            jumpsLeft = 1;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        else if (jumpsLeft > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpsLeft -= 1;
        }
    }
}