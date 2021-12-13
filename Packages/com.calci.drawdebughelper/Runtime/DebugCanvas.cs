using System;
using UnityEngine;

namespace Calci.DDH
{
	public class DebugCanvas : MonoBehaviour
	{
		#region Accessor

		public static DebugCanvas PublicGet() => Get();
		private static DebugCanvas inst;
		internal static DebugCanvas Get()
		{
#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				throw new Exception("Cannot use DrawDebug in EditMode. Use Gizmo and Handles instead DrawDebug");
			}
#endif
			if (inst == null)
			{
				inst = new GameObject("DrawDebugCanvas").AddComponent<DebugCanvas>();
				inst.Init();
			}

			return inst;
		}

		private void OnDestroy()
		{
			inst = default;
		}

		#endregion

		private Canvas canvas = default;

		private void Init()
		{
			canvas = gameObject.AddComponent<Canvas>();
			canvas.renderMode = RenderMode.ScreenSpaceOverlay;
			canvas.sortingOrder = 9999;
		}

		public LineDrawer CreateLineDrawer()
		{
			var obj = new GameObject("LineDrawer");
			
			obj.transform.SetParent(this.transform);
			obj.AddComponent<CanvasRenderer>();
			
			var rect = obj.AddComponent<RectTransform>();
			var lineDrawer = obj.AddComponent<LineDrawer>();
			
			rect.anchorMin = Vector2.zero;
			rect.anchorMax = Vector2.one;
			rect.offsetMin = Vector2.zero;
			rect.offsetMax = Vector2.zero;

			return lineDrawer;
		}
	}
}