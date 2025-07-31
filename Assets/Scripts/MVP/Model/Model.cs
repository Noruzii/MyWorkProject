using System;
using UnityEngine;

public abstract class Model<T> : MonoBehaviour
{
    public event Action<T> OnChanged;

    private T _currentValue;

    public T CurrentValue
    {
        get { return _currentValue; }

        set
        {
            _currentValue = value;
        }
    }

    public void SetValue(T newValue)
    {
        CurrentValue = newValue;
        OnChanged.Invoke(_currentValue);

    }
}
