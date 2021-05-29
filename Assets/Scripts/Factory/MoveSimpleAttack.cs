using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveSimpleAttack : MoveBase
    {
        private float _timeAttack;

        public MoveSimpleAttack(SpriteRenderer spriteRenderer, Rigidbody2D rigidbody, Animator animator, float timeAttack) : base(spriteRenderer, rigidbody, animator)
        {
            _timeAttack = timeAttack;
        }

        public bool Move(float StartTimeAttack)
        {
            if (_timeAttack <= 0)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    _animator.SetBool("isAttacking", true);
                    _timeAttack = StartTimeAttack;
                    return true;
                }
            }
            else
            {
                _timeAttack -= Time.deltaTime;
                return true;
            }

            _animator.SetBool("isAttacking", false);
            return false;

        }

    }
}
