using Assembly_CSharp.Assets.Scripts.Factory;
using Enums;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Energy;
    public GameObject Point;
    public float Speed = 10;
    public float JumpForce = 2;
    public float StartTimeAttack = 3;
    private MoveFactory _moveFactory;

    void Start()
    {
        _moveFactory = new MoveFactory(this);
    }

    private void FixedUpdate()
    {
        _moveFactory.Move(Speed, JumpForce, StartTimeAttack, Energy, Point);
    }

    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.layer == (int)ELayer.GROUND)
            _moveFactory.CanJump();

        if (colision.gameObject.tag == ETags.ENEMY)
            _moveFactory.Hit(JumpForce);
    }
}
