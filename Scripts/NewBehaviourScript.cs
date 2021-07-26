#if UNITY_EDITOR && UNITY_IOS
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
 
public class BuildPostProcessor
{
    [PostProcessBuild]
    public static void OnPostProcessBuild(BuildTarget target, string path)
    {
        if (target == BuildTarget.iOS)
        {
            string projPath = PBXProject.GetPBXProjectPath(path);
 
            PBXProject proj = new PBXProject();
            proj.ReadFromFile(projPath);
 
            string targetGUID = proj.GetUnityFrameworkTargetGuid();
            proj.AddBuildProperty(targetGUID, "SWIFT_VERSION", "5.1");
 
            proj.WriteToFile(projPath);
        }
    }
}
#endif
