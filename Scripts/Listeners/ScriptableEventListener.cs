using ScriptableEvents.Events;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Listeners
{
	public class ScriptableEventListener : MonoBehaviour
	{
		[field: SerializeField] ScriptableEvent Event { get; set; }

		[field: SerializeField, Space] UnityEvent Response { get; set; }

		void OnEnable() => Event.AddListener(this);

		void OnDisable() => Event.RemoveListener(this);

		public void OnEventInvoked(object param = default) => Response.Invoke();
	}
}