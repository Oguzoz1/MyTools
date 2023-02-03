using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRegionManager : MonoBehaviour
{
    public Region[] regions;
    public void SpawnGameObjectRandom(GameObject obj)
    {
        Region x = regions[Random.Range(0, regions.Length)];

        x.SpawnLocation = x.RandomVector(x.regionPos.position);
        obj.transform.position = x.SpawnLocation;
    }

    public Vector3 RandomPosition()
    {
        Region x = regions[Random.Range(0, regions.Length)];
        return x.RandomVector(x.regionPos.Position);
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < regions.Length; i++)
        {
            DrawArea(regions[i]);
        }
    }

    void DrawArea(Region region)
    {
        Gizmos.color = Color.red;
        Vector3 position = region.regionPos.position;

        Vector3 nxtonz = new Vector3(position.x - region.RangeX, position.y, position.z - region.RangeZ);
        Vector3 tox = new Vector3(position.x - region.RangeX, position.y, position.z + region.RangeZ);
        Gizmos.DrawLine(nxtonz, tox);

        Vector3 pxtopz = new Vector3(position.x + region.RangeX, position.y, position.z + region.RangeZ);
        Gizmos.DrawLine(tox, pxtopz);

        Vector3 tonz = new Vector3(position.x + region.RangeX, position.y, position.z - region.RangeZ);
        Gizmos.DrawLine(pxtopz, tonz);
        Gizmos.DrawLine(tonz, nxtonz);
    }

}
