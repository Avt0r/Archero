using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    [Header("Movement stats")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    [Header("Handling")]
    private float _currentAttractionCharacter = 0;
    [SerializeField] private float _graviteForce = 20;

    [Header("Components")]
    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void MoveCharacter(Vector3 moveDirection)
    {
        moveDirection = moveDirection * _moveSpeed;
        moveDirection.y = _currentAttractionCharacter;
        _characterController.Move(moveDirection * Time.deltaTime);
    }

    public void RotateCharacter(Vector3 moveDirection) 
    {
        transform.rotation = Quaternion.LookRotation(moveDirection);
    }

    private void GravityHandling()
    {
        if(!_characterController.isGrounded)
        {
            _currentAttractionCharacter -= _graviteForce * Time.deltaTime;
        }
        else
        {
            _currentAttractionCharacter = 0;
        }
    }
}
