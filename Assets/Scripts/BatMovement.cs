using UnityEngine;

public class BatMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _pulseStrength;
    [SerializeField] private float _pulseCooldown;
    [SerializeField] private float _targetGravityScale;
    [SerializeField] private SpriteRenderer _sr;

    private bool _isMoving;


    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = (new Vector2(h, v)).normalized;

        _isMoving = dir != Vector2.zero;

        _rb.gravityScale = _isMoving ? 0f : _targetGravityScale; 

        _rb.AddForce(dir * _speed);

        if (_isMoving)
        {
            _sr.flipX = dir.x == 1;
        }
    }

    private void Pulse()
    {
        if (!_isMoving)
        {
            _rb.AddForce(_pulseStrength * Vector2.up);
        }
    }
}
 