using UnityEngine;

public class NPCController : MonoBehaviour
{
    public int heal = 100;
    public int speed = 100;
    public Vector3 nemPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nemPosition = transform.position;
        nemPosition.z -= speed * Time.deltaTime;
        transform.position= nemPosition;
    }
}
