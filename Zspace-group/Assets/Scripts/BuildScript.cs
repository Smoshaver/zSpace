using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void BuildExecutable()
    {
        string[] scenes = { "Assets/Scenes/MainScene.unity" };  // Update with your actual scenes
        string buildPath = "C:\Users\smosh\Desktop\built example/Zspace-group.exe";  // Change path and executable name as needed

        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);

        Debug.Log("Build Completed Successfully!");
    }
}
