using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;


    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }


}
