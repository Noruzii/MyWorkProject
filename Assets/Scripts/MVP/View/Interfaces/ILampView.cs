
using UnityEngine;

public interface ILampView
{
    Light lampLight { get; }

    void DisplayColor(Color color);

    void TurnOnLight(bool state);
}
