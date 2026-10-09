using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float _speed = 15.0f;
    private Rigidbody _rb;

    void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    void Update() {
        Vector2 movementAxis = new Vector2(0.0f, 0.0f);
        movementAxis.x = Input.GetAxisRaw("Horizontal");
        movementAxis.y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(0.0f, 0.0f);

        direction.x += (movementAxis.x * _speed) * Time.deltaTime;
        direction.y += (movementAxis.y * _speed) * Time.deltaTime;
        _rb.AddForce(new Vector3(direction.x, 0.0f, direction.y));
    }
}
