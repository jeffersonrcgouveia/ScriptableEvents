using ScriptableEvents.Events;
using UnityEngine;

namespace ScriptableEvents.Examples.Scripts
{
    public class GameObjectCreator : MonoBehaviour
    {
        [SerializeField] ScriptableEvent onLoad;

        [SerializeField] GameObjectScriptableEvent onCreateGameObject;

        void Awake()
        {
            onLoad.Invoke();
            CreateGameObject();
        }

        void CreateGameObject()
        {
            GameObject go = new GameObject("NewGameObject");
            onCreateGameObject.Invoke(go);
        }
    }
}
