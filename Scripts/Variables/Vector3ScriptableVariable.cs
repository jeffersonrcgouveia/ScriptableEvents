using ScriptableEvents.Variables.Base;
using UnityEngine;
using static ScriptableEvents.Constants.ScriptableVariablesConstants;

namespace ScriptableEvents.Variables
{
	[CreateAssetMenu(menuName =  MenuName + Vector3Name, fileName = Vector3Name)]
	public class Vector3ScriptableVariable : ScriptableVariableBase<Vector3>
	{
	}
}