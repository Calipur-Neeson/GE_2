using System;
using UnityEngine;

namespace AG2187
{
    public class PlayerMove : MonoBehaviour
    {
        private float moveSpeed = 8f;
        private float health = 100f;
        private void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float MoveZ = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(moveX,0,MoveZ)*moveSpeed * Time.deltaTime;
            transform.Translate(moveDirection);
            
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log($"Current Health: {health}");
        }
    }

}