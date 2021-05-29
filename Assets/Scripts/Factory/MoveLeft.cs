using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveLeft : MoveBase
    {
        public MoveLeft(SpriteRenderer spriteRenderer, Rigidbody2D rigidbody, Animator animator) : base(spriteRenderer, rigidbody, animator)
        {
        }

        public bool Move(float speed)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rigidBody.velocity = new Vector2(-speed, _rigidBody.velocity.y);
                _animator.SetBool("isWalking", true);
                _spriteRenderer.flipX = true;
                return true;
            }

            return false;
        }
    }
}
