using UnityEngine;
using System.Collections;


public class Camera : MonoBehaviour
{
    public GameObject ballsphere;

    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - ballsphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance + ballsphere.transform.position;
    }
}
