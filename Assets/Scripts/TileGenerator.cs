using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TileGenerator : MonoBehaviour
{
    private WorldGenerator _world;

    [SerializeField] private GameObject boxPrefab;
    [SerializeField] private GameObject starPrefab;
    
    [SerializeField] private float generationWidth; //ширина от центра, в которой располагаются коробки
    [SerializeField] private float generationHeight; //высота от центра, в которой располагаются коробки
    [SerializeField, Range(1, 3)] private int maxBoxes; //максимальное количество коробок на тайле
    [SerializeField, Range(1, 3)] private int maxStars; // максимальное количество звезд на тайле

    [SerializeField] private bool doNotGenerate = false;
    
    void Start()
    {
        _world = transform.parent.GetComponent<WorldGenerator>();
        if(doNotGenerate) return; // doNotGenerate=true на первом тайле

        for (var i = 0; i < Random.Range(1, maxBoxes + 1); i++)
        {
            var pos = transform.position + new Vector3(Random.Range(-generationWidth / 2, generationWidth / 2),
                Random.Range(-generationHeight / 2, generationHeight / 2));
            Instantiate(boxPrefab, pos, Quaternion.identity, this.transform);
        }
        for (var i = 0; i < Random.Range(1, maxStars + 1); i++)
        {
            var pos = transform.position + new Vector3(Random.Range(-generationWidth / 2, generationWidth / 2),
                Random.Range(-generationHeight / 2, generationHeight / 2));
            Instantiate(starPrefab, pos, Quaternion.identity, this.transform);
        }
    }

    public void Next() => _world.Generate();
}
