using UnityEngine;

public class CarMovement : PlayerMovement //INHERITANCE from the playermovement script
{
    private float horsePower = 3f;
    private float carTurnSpeed = 20f;
    private Rigidbody playerRB;
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public override void ForwardMoves() //POLYMORPHISM changing the translate to addforce method.
    {
        playerRB.AddRelativeForce(Vector3.forward * verticalInput * horsePower, ForceMode.Impulse);    
    }
    public override void VerticalMoves() //POLYMORPHISM changing the translate to rotate
    {
        transform.Rotate(carTurnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
