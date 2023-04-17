using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickForMovement : JoystickHandler
{
    [SerializeField] private CharacterMovement _characterMovement;

    private void Update()
    {
        if(_inputVector.x != 0 || _inputVector.y != 0)
        {
            _characterMovement.MoveCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
            _characterMovement.RotateCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));        
        }
    }   
}
