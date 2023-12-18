using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerActions;

    public int movementValue = 1;
    private void Awake()
    {
        playerActions = GetComponent<PlayerInput>();

        playerActions.enabled = true;
        
        playerActions.onActionTriggered += MovePlayer;
    }
    public void MovePlayer(InputAction.CallbackContext context)
    {

    }
}
