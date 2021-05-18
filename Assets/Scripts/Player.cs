using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        Speed = 10;
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        MoveFactory();
    }

    private void MoveFactory()
    {
        MoveRight();
        MoveLeft();
    }

    public void MoveRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            _rigidBody.velocity = new Vector2(Speed, _rigidBody.velocity.y);
    }
    public void MoveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            _rigidBody.velocity = new Vector2(-Speed, _rigidBody.velocity.y);
    }
}
