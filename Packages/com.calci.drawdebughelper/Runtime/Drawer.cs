using System;
using System.Collections.Generic;
using UnityEngine;

namespace Calci.DDH
{
	internal sealed class Drawer : MonoBehaviour
	{
		#region Accessor

		private static Drawer inst;
		internal static Drawer Get()
		{
#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				throw new Exception("Cannot use DrawDebug in EditMode. Use Gizmo and Handles instead DrawDebug");
			}
#endif
			if (inst == null)
			{
				inst = new GameObject("DrawDebug").AddComponent<Drawer>();
				inst.Init();
			}

			return inst;
		}

		private void OnDestroy()
		{
			inst = default;
		}

		#endregion

		private readonly Dictionary<long, DrawingHandle> handles = new Dictionary<long, DrawingHandle>();
		private readonly Dictionary<DrawingHandle, DrawingContext> contextMap =
			new Dictionary<DrawingHandle, DrawingContext>();

		private ComputeBuffer positionBuffer;
		private ComputeBuffer argsBuffer;

		private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };
		private Material wireframeMaterial;

		private void Init()
		{
			// argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
			wireframeMaterial = new Material(Shader.Find("Standard"));
		}

		#region DrawCalls

		internal void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float thickness, float lifeTime)
		{
			var handle = new DrawingHandle();
		}

		internal void DrawBox(Vector3 center, Vector3 extent,
			Color color,
			float thickness, float lifeTime)
		{
			Mesh mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
			var handle = new DrawingHandle();

			var context = new DrawingContext()
			{
				mesh = mesh, 
				position = center,
				duration = lifeTime,
			};
			
			handles.Add(handle.Id, handle);
			contextMap.Add(handle, context);
		}
		
		#endregion

		public void Abort(DrawingHandle handle)
		{
		}

		private void Update()
		{
			foreach (DrawingHandle handle in handles.Values)
			{
				var context = contextMap[handle];
				if (handle.IsDrawing)
				{
					if (Time.time - handle.StartTime >= context.duration)
					{
						handle.Abort();
						continue;
					}
					
					// add draw queue
					// temp draw
					// Graphics.DrawMeshInstancedIndirect(context.mesh, 0, new Material(Shader.Find("Hidden/SceneViewWireframe")), new Bounds(context.position, Vector3.one* 3f), );
					Graphics.DrawMesh(context.mesh, Vector3.zero, Quaternion.identity, wireframeMaterial, 0);
				}
			}
			
			// draw here
			// Graphics.DrawMeshInstancedIndirect();
			
		}
	}

	internal enum EPrimitiveType
	{
		Box,
	}

	internal class DrawingContext
	{
		public Mesh mesh;
		public Vector3 position;
		public float duration;
	}
}