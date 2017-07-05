using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class EditorCreateAB : EditorWindow {

	[MenuItem("CreateAB/CreateMacAB")]
	public static void CreateAssetBundleByMac() {
		string sPath = "Assets/StreamingAssets";
		BuildPipeline.BuildAssetBundles(sPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneOSXUniversal);
	}
}
