using UnityEngine;

namespace ScriptableEvents.Examples.Scripts
{
	public class ScriptableEventsLogger : MonoBehaviour
	{
		public void LogScriptableEvent() => Debug.Log("ScriptableEvent");

		public void LogGameObjectScriptableEvent(GameObject go) => Debug.Log($"GameObjectScriptableEvent: {go}");
	}
}