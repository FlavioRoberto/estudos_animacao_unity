using UnityEngine;

public class Energy : MonoBehaviour
{
    public AudioClip AudioShoot;
    public float Speed;
    private Player _player;
    private Vector2 _direction;

    void Start()
    {
        DefineDirection();
    }

    void Update()
    {
        Audio.current.Play(AudioShoot);
        transform.Translate(_direction * Time.deltaTime * Speed);
        Destroy(gameObject, 2f);
    }

    private void DefineDirection()
    {
        _player = GameObject.FindObjectOfType<Player>();

        var flipX = _player.GetComponent<SpriteRenderer>().flipX;

        if (flipX)
            _direction = Vector2.left;
        else
            _direction = Vector2.right;
    }
}
