using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else { Destroy(gameObject); }
    }

    public static void ForceRecreate()
    {
        if (_instance != null)
        {
            Destroy(_instance.gameObject);
            _instance = null;
        }

        GameObject prefab = Resources.Load<GameObject>(typeof(T).Name);
        if (prefab != null)
        {
            GameObject newInstance = Instantiate(prefab);
            newInstance.name = typeof(T).Name;
        }
        else
        {
            Debug.LogError("prefab not found in Resources.");
        }
    }

}