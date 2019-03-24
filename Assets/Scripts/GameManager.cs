using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
     
    void Start()
    {
        CreateDestinationPoint();
    }

    private void CreateDestinationPoint()
    {
        GameObject DestinationPoint = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
        DestinationPoint.transform.position = new Vector3(0, 0, GPS.instance.gameObject.transform.position.z+4);
    
    }
}
