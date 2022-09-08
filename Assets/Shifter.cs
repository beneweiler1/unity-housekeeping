using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifter : MonoBehaviour
{
  [SerializeField] private Vector3 _space;
    int frames = 0;
    // Update is called once per frame
    int speed = 1;
    void Update()
    {
        if(frames >= 500){
            speed = -1 * speed;
            _space.y = speed;
            frames = 0;
        }
        frames += 1;
        transform.Translate(_space * Time.deltaTime);
    }
}
