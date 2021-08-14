using System.Collections.Generic;
using ScriptableEvents.Listeners.Base;
using UnityEngine;

namespace ScriptableEvents.Events.Base
{
	public abstract class ScriptableEventBase<T> : ScriptableObject
	{
		List<ScriptableEventListenerBase<T>> Listeners { get; } = new List<ScriptableEventListenerBase<T>>();

		public void Invoke(T param)
		{
			for (int i = Listeners.Count - 1; i >= 0; i--) Listeners[i].OnEventInvoked(param);
		}

		public void AddListener(ScriptableEventListenerBase<T> listener) => Listeners.Add(listener);

		public void RemoveListener(ScriptableEventListenerBase<T> listener) => Listeners.Remove(listener);
	}
}