using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private InputActionReference _moveInputAction;
    [SerializeField] private InputActionReference _jumpInputAction;
    private MyInputActions _inputActions;

    private void Awake()
    {
        _inputActions = new MyInputActions();
    }

    private Vector2 _moveInput;

    private void OnEnable()
    {
        // started
        // performed
        // canceled
        // Invoke C Sharp Events
        //_playerInput.actions["Move"].performed += OnMove;
        //_playerInput.actions["Move"].canceled += OnMoveStop;

        //_inputActions.Enable();
        //_inputActions.Player.Move.performed += OnMove;
        //_inputActions.Player.Move.canceled -= OnMoveStop;

        _moveInputAction.action.Enable();
        _moveInputAction.action.performed += OnMove;
    }

    public void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>();

        Debug.Log(_moveInput);
    }

    // Invoke Unity Events
    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();

        Debug.Log(_moveInput);
    }
    public void OnMoveStop(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();

        Debug.Log(_moveInput);
    }


    public void OnJump()
    {
        Debug.Log("OnJump");
    }
}
