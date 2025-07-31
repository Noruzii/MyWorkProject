using UnityEngine;

public class BabyPresenter : Presenter<AudioClip>
{
    public AudioClip sad;
    public AudioClip happy;

    private IBabyView babyView;

    public override void Awake()
    {
        babyView = GetComponent<IBabyView>();
        base.Awake();
    }
    public override void OnChangedInModel(AudioClip t)
    {
        babyView.PlayAudio(t);
    }

    public override void OnClickedInView()
    {
        model.SetValue(model.CurrentValue);
    }

    public override void SetCalm()
    {
        model.CurrentValue = happy;
    }

    public override void SetSad()
    {
        model.CurrentValue = sad;
    }
}
