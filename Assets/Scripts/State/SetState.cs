using UnityEngine;
using System;
public class SetState : Singleton<SetState>
{
    public Light DirectionalLight;

    public event Action OnCalm;
    public event Action OnSad;

    private Color calmColor;
    private Color sadColor;

    void Start()
    {
        ColorUtility.TryParseHtmlString("#FFAF7C", out calmColor);
        ColorUtility.TryParseHtmlString("#590000", out sadColor);
        
        CalmEmotion();
    }

    public void SadEmotion()
    {
        OnSad.Invoke();
        DirectionalLight.color = sadColor;
    }

    public void CalmEmotion()
    {
        OnCalm.Invoke();
        DirectionalLight.color = calmColor;
    }
}
