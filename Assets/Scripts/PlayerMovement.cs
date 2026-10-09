using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementAxis = new Vector2(0.0f, 0.0f);
        movementAxis.x = Input.GetAxisRaw("Horizontal");
        movementAxis.y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(0.0f, 0.0f);

        direction.x += (movementAxis.x * speed) * Time.deltaTime;
        direction.y += (movementAxis.y * speed) * Time.deltaTime;
        rb.AddForce(new Vector3(direction.x, 0.0f, direction.y));
    }
}
