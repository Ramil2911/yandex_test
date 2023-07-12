using System;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private float tileWidth;

    public GameObject[] tiles = new GameObject[3];

    private void Start()
    {
        tiles[2] = Instantiate(tilePrefab, tiles[1].transform.transform.position + new Vector3(tileWidth, 0, 0),
            Quaternion.identity, this.transform);
    }

    public void Generate()
    {
        if(tiles[0] != null) Destroy(tiles[0]);
        tiles[0] = tiles[1];
        tiles[1] = tiles[2];
        tiles[2] = Instantiate(tilePrefab, tiles[1].transform.transform.position + new Vector3(tileWidth, 0, 0),
            Quaternion.identity, this.transform);
    }
}
