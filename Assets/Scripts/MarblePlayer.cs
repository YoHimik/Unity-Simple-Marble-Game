using UnityEngine;

public class MarblePlayer : MonoBehaviour
{
    private const float speed = 0.06f;
    private const float jumpSpeed = 2f;

    private float horizontal;
    private float vertical;
    private float jump;

    private const float lowerPoint = 0f;

    private new Rigidbody rigidbody;

    private Vector3 xvector3;
    private Vector3 zvector3;
    private Vector3 yvector3;
    public Vector3 checkpoint;

    private bool isGrounded;

    void Start()
    {
        isGrounded = false;
        rigidbody = GetComponent<Rigidbody>();
        xvector3 = new Vector3(1, 0, 0);
        zvector3 = new Vector3(0, 0, 1);
        yvector3 = new Vector3(0, 1, 0);
        checkpoint = new Vector3(0, 1, 0);
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        isGrounded = false;
    }

    void Update()
    {
        if (transform.position.y < lowerPoint)
            Death();
    }

    void FixedUpdate()
    {
        Controls();
    }

    void Controls()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");
        rigidbody.AddForce(xvector3 * horizontal * speed / Time.deltaTime, ForceMode.Impulse);
        rigidbody.AddForce(zvector3 * vertical * speed / Time.deltaTime, ForceMode.Impulse);
        if (isGrounded)
        {
            rigidbody.AddForce(yvector3 * jump * jumpSpeed / Time.deltaTime, ForceMode.Impulse);
        }            
    }

    public void Death()
    {
        transform.position = checkpoint;
        rigidbody.velocity = yvector3;
    }
}