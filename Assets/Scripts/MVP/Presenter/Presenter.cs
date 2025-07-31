using UnityEngine;

public abstract class Presenter<T> : MonoBehaviour,IState
{
    [HideInInspector]
    public View view;
    
    [HideInInspector]
    public Model<T> model;


    public virtual void Awake()
    {
        view = GetComponent<View>();

        model = GetComponent<Model<T>>();

        view.OnClicked += OnClickedInView;
        model.OnChanged += OnChangedInModel;

        SetCalm();

    }

    void OnEnable()
    {
        SetState.Instance.OnCalm += SetCalm;
        SetState.Instance.OnSad += SetSad;
    }

    void OnDisable()
    {
        SetState.Instance.OnCalm -= SetCalm;
        SetState.Instance.OnSad -= SetSad;
    }

    public abstract void OnClickedInView();

    public abstract void OnChangedInModel(T t);

    public abstract void SetCalm();

    public abstract void SetSad();
}
