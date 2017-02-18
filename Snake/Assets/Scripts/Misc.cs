using UnityEngine;
using System.Collections;

public class Misc : MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
