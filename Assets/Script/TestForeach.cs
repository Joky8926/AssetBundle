using UnityEngine;
using System.Collections.Generic;

public class TestForeach : MonoBehaviour {
	private JList lstStr;
	private List<string> orcList;

	void Start() {
		InitList();
		DoRemove();
		OutputList();
//		Other();
	}

	private void Other() {
		orcList = new List<string>();
		orcList.Add("aaa");
		orcList.Add("bbb");
		orcList.Add("bbb");
		orcList.Add("ccc");
		orcList.Add("ddd");
		foreach (string str in orcList) {
			if (str == "bbb") {
				orcList.Add(str);
			}
		}
		for (int i = 0; i < orcList.Count; i++) {
			if (orcList[i] == "bbb") {
				orcList.Remove(orcList[i]);
				i--;
			}
		}
		for (int i = 0; i < orcList.Count; i++) {
			Debug.Log(orcList[i]);
		}
	}

	private void InitList() {
		lstStr = new JList();
		lstStr.Add("aaa");
		lstStr.Add("bbb");
		lstStr.Add("bbb");
		lstStr.Add("ccc");
		lstStr.Add("ddd");
	}

	private void DoRemove() {
		foreach (string str in lstStr) {
			if (str == "bbb") {
				lstStr.Remove(str);
			}
		}
	}

	private void OutputList() {
		foreach (string str in lstStr) {
			Debug.Log(str);
		}
	}
}
