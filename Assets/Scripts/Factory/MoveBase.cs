using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    internal abstract class MoveBase
    {
        protected SpriteRenderer _spriteRenderer;
        protected Rigidbody2D _rigidBody;
        protected Animator _animator;

        protected MoveBase(SpriteRenderer spriteRenderer,
                           Rigidbody2D rigidbody,
                           Animator animator)
        {
            _spriteRenderer = spriteRenderer;
            _rigidBody = rigidbody;
            _animator = animator;
        }
        
    }
}
