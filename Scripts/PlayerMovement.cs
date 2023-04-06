using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float sidewaysForce;
    public float speed;

    public bool isGrounded = true;
    public bool jumpPill = true;

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void MoveBackward()
    {
        transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    public void MoveUp()
    {
        if (isGrounded && jumpPill)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpPill = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
