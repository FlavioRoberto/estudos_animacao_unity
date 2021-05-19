using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10;
    public float JumpForce = 2;
    private MoveFactory _moveFactory;
    private AttackFactory _attackFactory;

    void Start()
    {
        _moveFactory = new MoveFactory(this);
        _attackFactory = new AttackFactory(this);
    }

    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.layer == (int)ELayer.GROUND)
            _moveFactory.CanJump();
    }

    private void FixedUpdate()
    {
        _moveFactory.Move(Speed, JumpForce);
        _attackFactory.Attack();
    }
}
