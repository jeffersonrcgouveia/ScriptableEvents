using ScriptableEvents.Events.Base;
using UnityEngine;
using static ScriptableEvents.Constants.ScriptableEventConstants;

namespace ScriptableEvents.Events
{
	[CreateAssetMenu(menuName =  MenuName + GameObjectName, fileName = GameObjectName)]
	public class GameObjectScriptableEvent : ScriptableEventBase<GameObject>
	{
	}
}