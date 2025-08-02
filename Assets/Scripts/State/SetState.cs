using UnityEngine;
using System;
public class SetState : MonoBehaviour
{
    public static SetState Instance { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public Light DirectionalLight;

    public event Action OnCalm;
    public event Action OnSad;

    private Color calmColor;
    private Color sadColor;

    void Start()
    {
        ColorUtility.TryParseHtmlString("#FFAF7C", out calmColor);
        ColorUtility.TryParseHtmlString("#590000", out sadColor);
        print("SetStaet");
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
