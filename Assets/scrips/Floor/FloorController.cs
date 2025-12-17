using Unity.VisualScripting;
using UnityEngine;

public class FloorController : MonoBehaviour
{
   [SerializeField] float speed;
   [SerializeField] GameObject targetFloor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RestarFloor")
        {
            transform.position = new Vector3(0, 0, targetFloor.transform.position.z + 30);
        }
    }
}
