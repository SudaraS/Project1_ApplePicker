using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCollectables : MonoBehaviour, ICollectables
{
   
    public bool IsCollectable()
    {
        return false;
    }
}
