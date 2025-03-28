using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 movement;

    private PlayerInput _playerInput;
    private InputAction _moveAction;


    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];
    }

    // Update is called once per frame
    void Update()
    {
        movement = _moveAction.ReadValue<Vector2>();
    }
}
