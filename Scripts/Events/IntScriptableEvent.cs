using ScriptableEvents.Events.Base;
using UnityEngine;
using static ScriptableEvents.Constants.ScriptableEventConstants;

namespace ScriptableEvents.Events
{
	[CreateAssetMenu(menuName =  MenuName + IntName, fileName = IntName)]
	public class IntScriptableEvent : ScriptableEventBase<int>
	{
	}
}