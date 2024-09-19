using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour, ICollectables
{
  

    public bool IsCollectable()
    {
        return true;
    }
}
