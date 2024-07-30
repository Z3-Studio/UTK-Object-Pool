using UnityEngine;
using Z3.ObjectPooling;
using Z3.UIBuilder.Core;

namespace Z3.Demo
{

    /// <summary>
    /// Note to developers: Please describe what this MonoBehaviour does.
    /// </summary>
    public class ObjectPoolTest : MonoBehaviour 
    {
        public Transform prefabT;
        public ObjectPoolPrefab prefab;

        public Transform parent;

        [Button]
        public void InstantiateComponent()
        {
            ObjectPool.SpawnPooledObject(prefab, parent);
        }

        [Button]
        public void InstantiateTransform()
        {
            ObjectPool.SpawnPooledObject(prefabT, parent);
        }
    }

}