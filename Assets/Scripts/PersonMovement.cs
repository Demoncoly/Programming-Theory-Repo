using UnityEngine;

public class PersonMovement : PlayerMovement //INHERITANCE from the playermovement script
{
    private float runSpeed = 1.0f;
    private float strafeSpeed = 3f;
    private Rigidbody playerRB;
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public override void VerticalMoves() //POLYMORPHISM changing the y movement to z movement
    {
        transform.Translate(strafeSpeed * Vector3.right * horizontalInput * Time.deltaTime);
    }
    public override void ForwardMoves()
    {
        transform.Translate(runSpeed * Time.deltaTime * Vector3.forward * verticalInput);
    }
}
