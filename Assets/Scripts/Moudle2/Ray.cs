using UnityEditor.UI;
using UnityEngine;

namespace AG2187
{
	public class Ray : MonoBehaviour
	{
		private LayerMask mask;

        private void Start()
        {
            mask = LayerMask.GetMask("Player");
        }

        private void Update()
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1f, Color.green);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,1f, mask))
            {
                Debug.Log("Hit the Player");
            }
        }
    } 
}
