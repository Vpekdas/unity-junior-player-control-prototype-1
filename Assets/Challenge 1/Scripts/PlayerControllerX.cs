using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    private float _verticalInput;

    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(RotationSpeed * Time.deltaTime * _verticalInput * Vector3.right);
    }
}
