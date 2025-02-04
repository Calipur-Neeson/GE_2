using UnityEngine;

namespace AG2187
{
    public class HoveringIterm : MonoBehaviour
    {
        private Rigidbody rigidbody;
        private Transform itemHoldPoint;
        public float hoveringDistance = 2.0f;
        public float addForce = 20.0f;

        void Start()
        {
            rigidbody = gameObject.AddComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            itemHoldPoint = GetComponent<Transform>();
            AddHoveringForce(addForce);
        }

        private void Update()
        {
            if (itemHoldPoint.position.y <= hoveringDistance)
            {
                AddHoveringForce(addForce);
            }
        }
        public void AddHoveringForce(float force)
        {
            rigidbody.AddForce(0, force, 0);
        }
    } 
}
