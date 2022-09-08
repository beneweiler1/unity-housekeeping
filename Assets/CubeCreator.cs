using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    public int x = 0;
    [SerializeField] private Vector3 _rotation;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0,0,0.5f);
    }
}
