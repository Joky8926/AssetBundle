using System.Collections;
using System.Collections.Generic;

public class JList : IEnumerable {
	private List<string> lst = new List<string>();
	private int uCurrIndex = -1;
	string[] m_Days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };

	public System.Collections.IEnumerator GetEnumerator()
	{
		for (uCurrIndex = 0; uCurrIndex < lst.Count; uCurrIndex++)
		{
			yield return lst[uCurrIndex];
		}
	}

	public void Add(string value) {
		lst.Add(value);
	}

	public void Remove(string value) {
		lst.Remove(value);
		uCurrIndex--;
	}

	public void RemoveAt(int uIndex) {
		lst.RemoveAt(uIndex);
	}

	public void Dispose() {
		
	}
}
