using ScriptableEvents.Events.Base;
using UnityEngine;
using static ScriptableEvents.Constants.ScriptableEventConstants;

namespace ScriptableEvents.Events
{
	[CreateAssetMenu(menuName =  MenuName + StringName, fileName = StringName)]
	public class StringScriptableEvent : ScriptableEventBase<string>
	{
	}
}