using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [Header("Levels")]
    [SerializeField] private GameObject[] levels;
    [SerializeField] private int levelIndex;

    [SerializeField] private Transform levelParent;

    private void Awake()
    {
        LevelSpawn();
    }
    private void LevelSpawn()
    {
        if (levels[levelIndex] == null)
        {
            Debug.LogError("Level is not found");
        }
        else
        {
            GameObject levelObject = Instantiate(levels[levelIndex],Vector3.zero,Quaternion.identity,levelParent);
        }
    }
}
