using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeManager : MonoBehaviour {
    // cubeの座標が y < 100以下になったら呼ばれる
    public static UnityEvent OnCubeHell = new UnityEvent();
}
