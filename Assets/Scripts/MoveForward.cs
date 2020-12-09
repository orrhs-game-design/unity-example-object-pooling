﻿using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}