using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 _startForce;
    private Rigidbody2D _rb;
    [SerializeField] private GameObject _nextBall;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(_startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if (_nextBall != null)
        {
            GameObject b1 = Instantiate(_nextBall, _rb.position, Quaternion.identity) as GameObject;
            GameObject b2 = Instantiate(_nextBall, _rb.position, Quaternion.identity) as GameObject;
            b1.GetComponent<Ball>()._startForce = new Vector2(_rb.velocity.x, _rb.velocity.y);
            b2.GetComponent<Ball>()._startForce = new Vector2(-_rb.velocity.x, _rb.velocity.y);
        }
        Destroy(gameObject);
    }
}
