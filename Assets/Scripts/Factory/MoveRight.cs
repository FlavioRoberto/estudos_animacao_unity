using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveRight : MoveBase
    {
        public MoveRight(SpriteRenderer spriteRenderer,
                        Rigidbody2D rigidbody,
                        Animator animator) : base(spriteRenderer, rigidbody, animator)
        { }

        public bool Move(float speed)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rigidBody.velocity = new Vector2(speed, _rigidBody.velocity.y);
                _animator.SetBool("isWalking", true);
                _spriteRenderer.flipX = false;
                return true;
            }

            return false;
        }
    }
}
