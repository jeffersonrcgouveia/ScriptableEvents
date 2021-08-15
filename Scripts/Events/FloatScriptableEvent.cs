using ScriptableEvents.Events.Base;
using UnityEngine;
using static ScriptableEvents.Constants.ScriptableEventConstants;

namespace ScriptableEvents.Events
{
	[CreateAssetMenu(menuName =  MenuName + FloatName, fileName = FloatName)]
	public class FloatScriptableEvent : ScriptableEventBase<float>
	{
	}
}