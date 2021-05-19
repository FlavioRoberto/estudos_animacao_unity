using UnityEngine;

public class MoveFactory
{
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private bool _canJump;

    public MoveFactory(MonoBehaviour behavior)
    {
        _rigidBody = behavior.GetComponent<Rigidbody2D>();
        _animator = behavior.GetComponent<Animator>();
        _spriteRenderer = behavior.GetComponent<SpriteRenderer>();

    }

    public void CanJump()
    {
        if (_canJump)
            return;

        _animator.SetBool("isJumping", false);
        _canJump = true;
    }

    public void Move(float speed, float jumpForce)
    {
        if (Jump(jumpForce))
            return;

        if (MoveRight(speed))
            return;

        if (MoveLeft(speed))
            return;

        Stop();
    }

    private bool MoveRight(float speed)
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

    private bool MoveLeft(float speed)
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

    private bool Jump(float force)
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canJump)
        {
            _rigidBody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            _canJump = false;
            _animator.SetBool("isJumping", true);
            return true;
        }

        return false;
    }

    private void Stop()
    {
        _rigidBody.velocity = new Vector2(0, _rigidBody.velocity.y);
        _animator.SetBool("isWalking", false);
    }

}
