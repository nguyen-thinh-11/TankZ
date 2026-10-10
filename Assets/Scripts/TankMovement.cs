using UnityEngine;
using UnityEngine.InputSystem;

public class MoveMovement: MonoBehaviour
{
    public Animator animator;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpeed = 100f;
    Rigidbody rb;


    void Reset() { animator = GetComponentInChildren<Animator>(); }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();
        Rotate();

        animator.SetFloat("Move", moveSpeed);
        animator.SetFloat("Turn", rotateSpeed);
    }

    private void Move()
    {
        float moveInput = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            moveInput = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            moveInput = -1f;
        }

        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        float rotateInput = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            rotateInput = -1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            rotateInput = 1f;
        }

        transform.Rotate(Vector3.up * rotateInput * rotateSpeed * Time.deltaTime);
    }
}