using Unity.FPS.Game;
using UnityEngine;

namespace AG2187
{
    public class DamageableShootingTarget : Damageable
    {

        public Renderer objectRenderer;
        public Color swapColor;
        public Color originalColor;
        public bool colorSwapped = false;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            objectRenderer = GetComponent<Renderer>();
            originalColor = objectRenderer.material.color;
            
        }

        // Update is called once per frame
        public override void InflictDamage(float damage, bool isExplosionDamage, GameObject damageSource)
        {
            base.InflictDamage(damage, isExplosionDamage, damageSource);
            SwapColor();
        }

        public void SwapColor()
        {
            if (!colorSwapped )
            {
                objectRenderer.material.color = swapColor;
            }
            else
            {
                objectRenderer.material.color = originalColor;
            }
            colorSwapped = !colorSwapped;
        }
    } 
}
