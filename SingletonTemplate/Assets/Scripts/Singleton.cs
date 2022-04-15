using UnityEngine;

public class Singleton<T> : MonoBehaviour where  T : MonoBehaviour
{
    private static object _lock = new Object();
    public static T _instance;

    public T Instance
    {
        get
        {
            lock (_lock)
            {
                if (Instance == null)
                {
                    _instance = FindObjectOfType(typeof(T)) as T;  
                }
                return _instance;
            }
        }
    }
}
