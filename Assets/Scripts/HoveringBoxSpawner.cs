using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

namespace AG2187
{
    public class HoveringBoxSpawner : MonoBehaviour
    {
        public int numberOfHoveringSphere;
        public int numberOfHoveringCube;
        public GameObject hoveringCube;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                InstantiateFromPrefabs();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                InstantiateHoveringObjects();
            }
        }
        //==================================Method 1 creat form prefabs======================
        private void InstantiateFromPrefabs()
        { 
            Vector3 spawnPoint = new Vector3(Random.Range(0,10.0f),3,Random.Range(0,10.0f));
            Instantiate(hoveringCube, spawnPoint, Quaternion.identity);
        }
        //==================================Method 2 creat gameobjects========================
        private void InstantiateHoveringObjects()
        {
            GameObject hoveringSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Vector3 spawnPoint = new Vector3(Random.Range(0, 10.0f), 3, Random.Range(0, 10.0f));
            hoveringSphere.AddComponent<HoveringIterm>();
            hoveringSphere.transform.position = spawnPoint;

        }

    } 

}
