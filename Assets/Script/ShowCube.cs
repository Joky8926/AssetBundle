using UnityEngine;
using System.Collections;

public class ShowCube : MonoBehaviour {

	void Start() {
		CreateABPre();
//		LoadABM();
	}

	private void CreateABPre() {
		string sPath = "Assets/StreamingAssets/cube1";
		AssetBundle ab = AssetBundle.LoadFromFile(sPath);
		string sPath0 = "Assets/StreamingAssets/mt1";
		AssetBundle.LoadFromFile(sPath0);
		GameObject goPre = ab.LoadAsset<GameObject>("Cube1");
		GameObject go = GameObject.Instantiate(goPre);
		ab.Unload(true);
//		Resources.UnloadAsset(goPre);
//		GameObject go2 = GameObject.Instantiate(goPre);
		go.transform.parent = this.transform;
	}

	private void LoadABM() {
		string sPath = "Assets/StreamingAssets/StreamingAssets";
		AssetBundle ab = AssetBundle.LoadFromFile(sPath);
		AssetBundleManifest abm = ab.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
		string[] cubedepends = abm.GetAllDependencies("cube1");
		Debug.Log(cubedepends[0]);
	}

	private void CreateLocalPre() {
		GameObject goPre = Resources.Load<GameObject>("Cube2");
		GameObject go = GameObject.Instantiate(goPre);
		go.transform.parent = this.transform;
	}
}
