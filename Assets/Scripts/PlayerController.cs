using StarterKit.Base;
using UnityEngine;

public class PlayerController : BaseObject
{
    [SerializeField] private float playerMoveSpeed = 5f;
    [SerializeField] private float jumpX;
    [SerializeField] private float jumpY = 5f;
    [SerializeField] private bool isGrounded;
    private float _dirX;

    private Rigidbody2D _myRigidbody2D;
    // private Vector2 _position;

    public override void BaseObjectStart()
    {
        _myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public override void BaseObjectUpdate()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        _dirX = Input.GetAxis("Horizontal") * playerMoveSpeed * Time.deltaTime;
        // _position = new Vector2(transform.position.x, transform.position.y);
        transform.position = new Vector2(transform.position.x + _dirX, transform.position.y);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
            _myRigidbody2D.AddForce(new Vector2(jumpX, jumpY), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isGrounded = false;
    }
}