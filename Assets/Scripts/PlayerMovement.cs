using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Speed = 3f;
    private float TurnSpeed = 1f;
    public float horizontalInput {get; private set; } //ENCAPSULATION for movement of different player types
    public float verticalInput {get; private set; } //ENCAPSULATION for movement of different player types
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        VerticalMoves();
        ForwardMoves();
    }
    public virtual void VerticalMoves() 
    {
        transform.Rotate(TurnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
    public virtual void ForwardMoves()
    {
        transform.Translate(Speed * Time.deltaTime * Vector3.forward * verticalInput);
    }
    public virtual void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.name == "Sphere type 1(Clone)"){Menu.Instance.greyScore += 1;}
        if (other.gameObject.name == "Sphere type 2(Clone)"){Menu.Instance.goldScore += 1;}
        if (other.gameObject.name == "Sphere type 3(Clone)"){Menu.Instance.greenScore += 1;}
        Destroy(other.gameObject);
    }
}
