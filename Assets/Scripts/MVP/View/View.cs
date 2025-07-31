using System;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class View : MonoBehaviour
{
    public event Action OnClicked;

    [HideInInspector]
    public Camera mainCamera;

    public GameInput gameInput;

    void Awake()
    {
        mainCamera = Camera.main;
        gameInput = new GameInput();
    }

    public void HandleClickOrTap(InputAction.CallbackContext context)
    {
        Vector2 pointerPosition = Input.mousePosition;
        Ray ray = mainCamera.ScreenPointToRay(pointerPosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                OnClicked.Invoke();
            }
        }
    }

    void OnEnable()
    {
        gameInput.Enable();

        gameInput.GamePlay.ClickOrTap.performed += HandleClickOrTap;
    }

    void OnDisable()
    {
        gameInput.Disable();

        gameInput.GamePlay.ClickOrTap.performed -= HandleClickOrTap;
    }
}
