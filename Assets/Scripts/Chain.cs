using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    public static bool IsActive;
    [SerializeField] private Transform _player;

    private void Start()
    {
        IsActive = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            IsActive = true;
        }
        if (IsActive)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.fixedDeltaTime * _speed;
            if (transform.localScale.y > 1f) IsActive = false;//short fix
        }
        else
        {
            transform.position = _player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }

}
