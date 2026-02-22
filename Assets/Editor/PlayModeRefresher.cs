using UnityEditor;

[InitializeOnLoad]
public static class PlayModeRefresher
{
    static PlayModeRefresher()
    {
        // This runs every time the Editor's state changes (like clicking Play)
        EditorApplication.playModeStateChanged += OnPlayModeChanged;
    }

    private static void OnPlayModeChanged(PlayModeStateChange state)
    {
        // Only trigger when we are EXITING Edit Mode (entering Play Mode)
        if (state == PlayModeStateChange.ExitingEditMode)
        {
            // Force Unity to scan for script changes and compile
            AssetDatabase.Refresh();
        }
    }
}