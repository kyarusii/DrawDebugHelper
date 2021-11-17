using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example
{
    public class SceneExample : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            DrawDebug.Box(Vector3.zero, Vector3.one, Color.white, 1, 10f);
        }
    }
}
