using UnityEngine;

namespace AG2187
{
    public class FindingInPhysics : MonoBehaviour
    {
        private GameObject player;
        public GameObject enemy;
        private Renderer renderer;
        private void Start()
        {
            player = FindObjectOfType<PlayerMove>().gameObject;
            enemy = FindObjectOfType<EnemyController>().gameObject;
            renderer = enemy.GetComponent<Renderer>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject == player) 
            {
                enemy.SetActive(!enemy.activeSelf);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == player)
            {
                renderer.material.color = Color.blue;
            }
        }
    } 
}
