using UnityEngine;

public class CarMovement : PlayerMovement //INHERITANCE from the playermovement script
{
    private float horsePower = 1f;
    private float carTurnSpeed = 20f;
    [SerializeField] private float currentGear = 1; //Serialized to verify changing gears works
    private Rigidbody playerRB;
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public override void ForwardMoves() //POLYMORPHISM changing the translate to addforce method.
    {
        if (Input.GetKeyDown(KeyCode.E) && currentGear < 5)
        {
            ShiftUP();
        }
        if (Input.GetKeyDown(KeyCode.Q) && currentGear > 0)
        {
            ShiftDOWN();
        }
        playerRB.AddRelativeForce(Vector3.forward * currentGear * verticalInput * horsePower, ForceMode.Impulse);    
    }
    public override void VerticalMoves() //POLYMORPHISM changing the translate to rotate
    {
        transform.Rotate(carTurnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
    private void ShiftUP() //ABSTRACTION shifting gears for a person makes no sense
    {
        currentGear += 1;
    }
    private void ShiftDOWN()
    {
        currentGear -= 1;
    }
}
