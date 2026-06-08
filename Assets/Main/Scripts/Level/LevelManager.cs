using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    GameObject MainCanvas;

    PlayerCore Core;
    
    private void OnEnable()
    {
        Core = FindAnyObjectByType<PlayerCore>();
        EventBus.OnPlayerDie += RestartLevel;
        EventBus.OnFinish += Victory;
    }
    private void OnDisable()
    {
        EventBus.OnPlayerDie -= RestartLevel;
        EventBus.OnFinish -= Victory;
    }
    void RestartLevel(PlayerCore core)
    {
        core.ResetPlayer();
    }

    public void ForceRestartLevel()
    {
        Core.ResetPlayer();
        MainCanvas.SetActive(false);

    }


    public void Exit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }
    void Victory()
    {
        MainCanvas.SetActive(true);
        
    }
}
