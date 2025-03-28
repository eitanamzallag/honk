using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Vector2 _movement;
    private Rigidbody2D _rb;
    private Animator _animator;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.Set(InputManager.movement.x, InputManager.movement.y);
        _rb.velocity = _movement * _speed;

        if (InputManager.movement != Vector2.zero)
        {
            _animator.SetFloat("Horizontal", _movement.x);
            _animator.SetFloat("Vertical", _movement.y);
            _animator.SetFloat("LastHorizontal", InputManager.movement.x);
            _animator.SetFloat("LastVertical", InputManager.movement.y);
        }
        else
        {
            _animator.SetFloat("Horizontal", 0);
            _animator.SetFloat("Vertical", 0);
        }
    }
}
