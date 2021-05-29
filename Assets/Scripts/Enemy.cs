using Enums;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == ETags.PLAYER)
        {
            _animator.SetTrigger("hit");
            Destroy(this.gameObject, 2);
        }
    }
}
