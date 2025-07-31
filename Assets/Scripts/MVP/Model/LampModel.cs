using UnityEngine;
using System;

public class LampModel : Model<Color>, ILampModel
{
    public Color lampColor { get; set; }

    public bool lampState { get; set; }
}
