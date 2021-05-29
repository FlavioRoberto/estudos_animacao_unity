using System;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal class MoveHit
    {
        private Rigidbody2D _rigidBody;

        public MoveHit(Rigidbody2D rigidbody)
        {
            _rigidBody = rigidbody;
        }

        public void Move(float jumpForce)
        {
            _rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
