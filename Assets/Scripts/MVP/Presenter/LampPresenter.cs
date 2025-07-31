using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class LampPresenter : Presenter<Color>
{
    private ILampView lampView;
    private ILampModel lampModel;

    private AudioSource audioSource;
    public override void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        lampModel = GetComponent<ILampModel>();
        lampView = GetComponent<ILampView>();
        lampModel.lampState = transform.GetChild(0).gameObject.activeInHierarchy;
        base.Awake();
    }

    public override void OnClickedInView()
    {
        model.SetValue(model.CurrentValue);
    }

    public override void OnChangedInModel(Color color)
    {
        lampView.DisplayColor(color);
        lampView.TurnOnLight(lampModel.lampState = !lampModel.lampState);
        audioSource.Play();
    }

    public override void SetCalm()
    {
        model.CurrentValue = Color.white;
        transform.GetChild(0).gameObject.SetActive(false);
        lampModel.lampState = false;
    }

    public override void SetSad()
    {
        model.CurrentValue = Color.red;
        transform.GetChild(0).gameObject.SetActive(false);
        lampModel.lampState = false;
    }
}
