using UnityEngine;

public class PlayerController : Singleton<MonoBehaviour>
{
    public PlayerState playerState;

    private void Update()
    {
        switch (playerState)
        {
            case PlayerState.None:
                break;
            case PlayerState.Playing:
                break;
            case PlayerState.Pause:
                break;
            case PlayerState.Fail:
                break;
            case PlayerState.Win:
                break;
        }
    }
}
