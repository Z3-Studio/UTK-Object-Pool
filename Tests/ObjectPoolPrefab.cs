using UnityEngine; 
using Z3.ObjectPooling;
using Z3.UIBuilder.Core;

namespace Z3.Demo
{
    public class ObjectPoolPrefab : MonoBehaviour
    {
        [Button]
        public void ReturnComponent()
        {
            ObjectPool.ReturnToPool(this);
        }

        [Button]
        public void ReturnTransform()
        {
            ObjectPool.ReturnToPool(transform);
        }
    }

}