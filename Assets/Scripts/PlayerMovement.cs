using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;

    [SerializeField] private float gravity;
    [SerializeField] private float jumpStrength;

    [SerializeField] private Transform trail;

    private bool _isSoftJumping;

    void FixedUpdate()
    {
        speedY += gravity;
        if (_isSoftJumping) speedY += jumpStrength;
        
        trail.position += new Vector3(0, speedY);
        transform.position += new Vector3(speedX,0);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        _isSoftJumping = context.phase switch
        {
            InputActionPhase.Started => true,
            InputActionPhase.Canceled => false,
            _ => _isSoftJumping
        };
    }
}
