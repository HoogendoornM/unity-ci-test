using System;
using System.Linq;
using MadLevelManager;
using UnityEditor;

public class BuildMyGame
{

    public static void BuildAndroid()
    {
        Build(BuildTarget.Android);
    }

    public static void BuildOSX()
    {
        Build(BuildTarget.StandaloneOSXIntel64);
    }

    public static void BuildWindows()
    {
        Build(BuildTarget.StandaloneWindows);
    }

    public static void Build(BuildTarget target)
    {
        var scenes = MadLevel.activeConfiguration.ScenesInOrder();
        var levels = from s in scenes select s.scenePath;
        BuildPipeline.BuildPlayer(levels.ToArray(), Environment.GetCommandLineArgs().Last(), target,
            BuildOptions.None);
    }
}