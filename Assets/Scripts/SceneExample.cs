using UnityEngine;

namespace Example
{
    public class SceneExample : MonoBehaviour
    {
        public GameObject p1;
        public GameObject p2;
        public GameObject p3;
        public GameObject p4;

        // Start is called before the first frame update
        private void Start()
        {
            var startPos = p1.transform.position;
            var endPos = p2.transform.position;
            
            DrawDebug.Line(startPos, endPos, Color.white, 1f, 10f);
            DrawDebug.Line(p3.transform.position, p4.transform.position, Color.red, 1f, 10f);
        }
    }
}
