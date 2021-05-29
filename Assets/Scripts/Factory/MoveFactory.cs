using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Factory
{
    public class MoveFactory
    {
        private Rigidbody2D _rigidBody;
        private Animator _animator;
        private float _timeAttack;
        private SpriteRenderer _spriteRenderer;
        private MoveJump _moveJump;
        private MoveSimpleAttack _moveSimpleAttack;
        private MoveSpecialAttack _moveSpecialAttack;

        public MoveFactory(MonoBehaviour behavior)
        {
            _rigidBody = behavior.GetComponent<Rigidbody2D>();
            _animator = behavior.GetComponent<Animator>();
            _spriteRenderer = behavior.GetComponent<SpriteRenderer>();
            _moveJump = new MoveJump(_spriteRenderer, _rigidBody, _animator);
            _moveSimpleAttack = new MoveSimpleAttack(_spriteRenderer, _rigidBody, _animator, _timeAttack);
            _moveSpecialAttack = new MoveSpecialAttack(_spriteRenderer, _rigidBody, _animator, _timeAttack);
        }

        public void CanJump()
        {
            _moveJump.CanJump();
        }

        public void Move(float speed, float jumpForce, float startTimeAttack, GameObject Energy, GameObject Point)
        {
            if (_moveSimpleAttack.Move(startTimeAttack))
                return;

            if (_moveSpecialAttack.Move(Energy, Point))
                return;

            if (_moveJump.Move(jumpForce))
                return;

            if (new MoveRight(_spriteRenderer, _rigidBody, _animator).Move(speed))
                return;

            if (new MoveLeft(_spriteRenderer, _rigidBody, _animator).Move(speed))
                return;

            Stop();
        }

        public void Hit(float jumpForce)
        {
            new MoveHit(_rigidBody).Move(jumpForce);
        }

        private void Stop()
        {
            _rigidBody.velocity = new Vector2(0, _rigidBody.velocity.y);
            _animator.SetBool("isWalking", false);
        }

    }
}