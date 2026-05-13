using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public GameObject orbPrefab;

    public Transform canvasParent;

    public GlitchController glitchController;

    public int orbCount = 3;

    public Vector2 minPosition;
    public Vector2 maxPosition;

    public void SpawnOrbs()
    {
        for (int i = 0; i < orbCount; i++)
        {
            GameObject orb =
                Instantiate(
                    orbPrefab,
                    canvasParent
                );

            RectTransform rect =
                orb.GetComponent<RectTransform>();

            rect.anchoredPosition =
                new Vector2(
                    Random.Range(minPosition.x, maxPosition.x),
                    Random.Range(minPosition.y, maxPosition.y)
                );

            OrbController controller =
                orb.GetComponent<OrbController>();

            controller.glitchController = glitchController;
        }
    }
}