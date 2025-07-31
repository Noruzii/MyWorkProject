using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class LampView : View, ILampView
{
    [SerializeField]
    private Light _lampLight;

    public Light lampLight
    {
        get
        {
            return _lampLight;
        }
    }
  
    public void DisplayColor(Color color)
    {
        if (lampLight != null)
        {
            lampLight.color = color;
        }
    }

    public void TurnOnLight(bool state)
    {
        lampLight.gameObject.SetActive(state);
    }
}
