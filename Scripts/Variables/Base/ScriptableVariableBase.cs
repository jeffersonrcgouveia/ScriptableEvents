using UnityEngine;

namespace ScriptableEvents.Variables.Base
{
	public abstract class ScriptableVariableBase<T> : ScriptableObject
	{
		[field: SerializeField] public T Data { get; set; }
	}
}