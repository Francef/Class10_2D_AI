using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private float matchCamXMovement = 0f;
    [SerializeField] private float matchCamYMovement = 0f;
    [SerializeField] private Vector2 offset; // allows us to offset our position relative to cam

    
    void LateUpdate()
    {
        transform.position = new Vector2(cam.position.x * matchCamXMovement, cam.position.y * matchCamYMovement) + offset;
    }
}
