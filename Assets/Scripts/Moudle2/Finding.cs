using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

namespace AG2187
{
    public class Finding : MonoBehaviour
    {
        [SerializeField] private GameObject findGameobjectByDrag;
        [SerializeField] private GameObject findGameobjectByName;
        [SerializeField] private GameObject findGameobjectByType;
        [SerializeField] private GameObject findGameobjectWithTag;
        [SerializeField] private GameObject findGameobjectByOrderChild;
        [SerializeField] private GameObject[] findGameobjectByComponentChild;

        private void Start()
        {
            findGameobjectByName = GameObject.Find("This is cube");

            findGameobjectByType = FindObjectOfType<CapsuleCollider>().gameObject;

            findGameobjectWithTag = GameObject.FindGameObjectWithTag("Cube");

            findGameobjectByOrderChild = transform.GetChild(2).gameObject;

            SphereCollider[] temp = GetComponentsInChildren<SphereCollider>();
            findGameobjectByComponentChild = new GameObject[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                {
                    findGameobjectByComponentChild[i] = temp[i].gameObject;
                }
            }
        }

    } 
}
