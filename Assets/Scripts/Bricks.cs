using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject brick;

	private void OnMouseDown() {
        Destroy(brick);
        Debug.Log("kubus berhasil dihancurkan!");
    }
}
