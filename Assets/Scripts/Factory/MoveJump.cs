using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveJump : MoveBase
    {
        public bool canJump = false;

        public MoveJump(SpriteRenderer spriteRenderer, Rigidbody2D rigidbody, Animator animator) : base(spriteRenderer, rigidbody, animator)
        {
        }

        public void CanJump()
        {
            if (canJump)
                return;

            _animator.SetBool("isJumping", false);
            canJump = true;
        }

        public bool Move(float force)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump)
            {
                _rigidBody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
                canJump = false;
                _animator.SetBool("isJumping", true);
                return true;
            }

            return false;
        }

    }
}
