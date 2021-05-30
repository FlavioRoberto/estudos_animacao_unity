using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveSpecialAttack : MoveBase
    {
        private float _timeAttack;
        private AudioClip _audioAttack;

        public MoveSpecialAttack(SpriteRenderer spriteRenderer,
                                 Rigidbody2D rigidbody,
                                 Animator animator,
                                 float timeAttack,
                                 AudioClip audioAttack) : base(spriteRenderer, rigidbody, animator)
        {
            _timeAttack = timeAttack;
            _audioAttack = audioAttack;
        }

        public bool Move(GameObject energy, GameObject point)
        {
            if (_timeAttack <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    var bullet = UnityEngine.Object.Instantiate(energy);
                    bullet.transform.position = point.transform.position;
                    Audio.current.Play(_audioAttack);
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
