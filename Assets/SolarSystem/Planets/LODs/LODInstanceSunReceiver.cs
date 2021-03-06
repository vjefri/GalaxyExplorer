﻿// Copyright Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

public class LODInstanceSunReceiver : MonoBehaviour
{
    public Transform Sun;

    private MeshRenderer currentRenderer;

    private void Awake()
    {
        currentRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Sun && currentRenderer)
        {
            currentRenderer.sharedMaterial.SetVector("_SunPosition", Sun.position);
        }
    }
}
