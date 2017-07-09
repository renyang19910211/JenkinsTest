using UnityEditor;
class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = { "Assets/test.unity" };  //写上你要打包的场景         
        string path = "E:/123.apk";  //到时会在E盘生成名字为123的apk文件
        BuildPipeline.BuildPlayer(scenes, path, BuildTarget.Android, BuildOptions.None);
    }
}