using UnityEngine;

public class PersonMovement : PlayerMovement //INHERITANCE from the playermovement script
{
    private float totalSpeed;
    private float runSpeed = 5.0f;
    private float strafeSpeed = 3f;
    private float sprintSpeed = 1.5f;
    private Rigidbody playerRB;
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public override void VerticalMoves() //POLYMORPHISM changing the y movement to x movement.
    {
        transform.Translate(strafeSpeed * Vector3.right * horizontalInput * Time.deltaTime);
    }
    public override void ForwardMoves() //POLYMORPHISM changing the z movement amount.
    {
        Sprinting();
        transform.Translate(totalSpeed * Time.deltaTime * Vector3.forward * verticalInput);
    }
    private void Sprinting() //ABSTRACTION sprinting for car does not make sense, but for a person it does.
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            totalSpeed = runSpeed * sprintSpeed;
        }
        else
        {
            totalSpeed = runSpeed;
        }
    }
}
