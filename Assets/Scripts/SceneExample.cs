using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example
{
    public class SceneExample : MonoBehaviour
    {
        public GameObject p1;
        public GameObject p2;
        
        // Start is called before the first frame update
        private void Start()
        {
            DrawDebug.Line(p1.transform.position, p2.transform.position, Color.red, 1f, 10f);
        }
    }
}
