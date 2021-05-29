using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveSpecialAttack : MoveBase
    {
        private float _timeAttack;

        public MoveSpecialAttack(SpriteRenderer spriteRenderer, Rigidbody2D rigidbody, Animator animator, float timeAttack) : base(spriteRenderer, rigidbody, animator)
        {
            _timeAttack = timeAttack;
        }

        public bool Move(GameObject energy, GameObject point)
        {
            if (_timeAttack <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    var bullet = UnityEngine.Object.Instantiate(energy);
                    bullet.transform.position = point.transform.position;
                    return true;
                }
            }
            else
            {
                _timeAttack -= Time.deltaTime;
                return true;
            }

            return false;
        }

    }
}
