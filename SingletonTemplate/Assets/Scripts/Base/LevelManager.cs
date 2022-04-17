using UnityEngine;

public class LevelManager : Singleton<LevelManager>
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
        levelIndex = PlayerPrefs.GetInt(StringData.PLAYER);
        
        if (levels[levelIndex] == null)
        {
            Debug.LogError("Level is not found");
        }
        else
        {
            GameObject levelObject = Instantiate(levels[levelIndex],Vector3.zero,Quaternion.identity,levelParent);
        }
    }
    public void NextLevel() => PlayerPrefs.SetInt(StringData.PLAYER,levelIndex + 1);
    public void RestartLevel() => PlayerPrefs.SetInt(StringData.PLAYER,levelIndex);
}
