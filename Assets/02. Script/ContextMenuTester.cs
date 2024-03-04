using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ContextMenuTester : MonoBehaviour
{
    [ContextMenu("ContextMenuTest")]
    public void Test()
    {
        Debug.Log("Context Menu Test");
    }
}
