using ScriptableEvents.Events.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Listeners.Base
{
	public abstract class ScriptableEventListenerBase<T> : MonoBehaviour
	{
		[field: SerializeField] ScriptableEventBase<T> Event { get; set; }

		[field: SerializeField, Space] UnityEvent<T> Response { get; set; }

		void OnEnable() => Event.AddListener(this);

		void OnDisable() => Event.RemoveListener(this);

		public void OnEventInvoked(T param) => Response.Invoke(param);
	}
}