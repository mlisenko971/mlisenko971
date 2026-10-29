using UnityEngine;

public class _0xdac21b78 : MonoBehaviour
{
    public static _0xdac21b78 Instance;
    private void _0xaef4e4de()
    {
    }

    public bool IsOnlyWinGameEndEnabled;
    public bool IsStoryEnabled;
    public bool IsBestScoreEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xdac21b78>();
            DontDestroyOnLoad(this.gameObject);
            this._0xaea2bb3f();
        }
        else
        {
            this._0xaef4e4de();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelIncrementOnWin;
    public bool IsTutorialEnabled;
    private void _0xaea2bb3f()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTimerEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsCheckScoreEnabled;
}