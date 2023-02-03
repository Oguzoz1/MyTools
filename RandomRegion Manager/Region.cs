using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Region
{
    public Transform regionPos;
    public Vector3 SpawnLocation { private  set { spawnLocation = value; } get { return spawnLocation; } } private Vector3 spawnLocation;
    public float RangeX { private set { rangeX = value; } get { return rangeX; } } [SerializeField] private float rangeX;
    public float RangeZ { private set { rangeZ = value; } get { return rangeZ; } } [SerializeField] private float rangeZ;

    public Vector3 RandomVector(Vector3 position)
    {
        float x = Random.Range(position.x - RangeX, position.x + RangeX);
        float y = position.y;
        float z = Random.Range(position.z - RangeZ, position.z + RangeZ);

        Vector3 desired = new Vector3(x, y, z);
        return desired; 
    }
}
