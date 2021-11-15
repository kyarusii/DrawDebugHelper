using System.Diagnostics;
using UnityEngine;
using Calci.DDH;

/// <summary>
/// Shipping 단계에서는 코드를 꼭 제거할 것!
/// </summary>
public static class DrawDebug
{
	private const string SYMBOL = "DRAW_DEBUG";

	#region Wireframes

	[Conditional(SYMBOL)]
	public static void Line(Vector3 startPos, Vector3 endPos, Color color,
		float thickness = 1.0f, float lifeTime = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Box(Vector3 center, Vector3 extent, Color color,
		float thickness = 1.0f, float lifeTime = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Circle(Vector3 center, Vector3 normal, float radius, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Disc(Vector3 center, Vector3 normal, float innerRadius, float outerRadius, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Sphere(Vector3 center, float radius, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Cylinder(Vector3 center, Vector3 normal, float radius, float height, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Cone(Vector3 pivot, Vector3 normal, float radius, float height, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void AltCone(Vector3 pivot, Vector3 normal, float bottomRadius, float topRadius, float height,
		Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Pyramid(Vector3 pivot, Vector3 normal, int segment, float sideLength, float height, Color color,
		float thickness = 1.0f, float lifeTime = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void AltPyramid(Vector3 pivot, Vector3 normal, int segment, float bottomSideLength,
		float topSideLength, float height, Color color,
		float thickness = 1.0f, float lifeTime = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Capsule(Vector3 center, float radius, float height, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Frustum(Vector3 eye, Vector3 target, Vector2 nearClip, Vector3 farClip, Color color,
		float thickness = 1.0f, float lifeTIme = -1.0f) { }

	[Conditional(SYMBOL)]
	public static void Mesh(Vector3 center, Quaternion rotation, Vector3 scale, Mesh mesh, Color color,
		float thickness = 1.0f, float lifeTime = -1.0f) { }

	#endregion

	#region Filled

	/// <summary>
	/// 지정된 위치에 채워진 박스를 그립니다.
	/// </summary>
	/// <param name="center"></param>
	/// <param name="extent"></param>
	/// <param name="color"></param>
	/// <param name="lifeTIme"></param>
	[Conditional(SYMBOL)]
	public static void SolidBox(Vector3 center, Vector3 extent, Color color,
		float lifeTIme = -1.0f) { }

	#endregion

	#region Misc

	/// <summary>
	/// 지정된 위치에 텍스트를 그립니다.
	/// </summary>
	/// <param name="center"></param>
	/// <param name="text"></param>
	/// <param name="size"></param>
	/// <param name="color"></param>
	/// <param name="lifeTIme"></param>
	[Conditional(SYMBOL)]
	public static void Text(Vector3 center, string text, float size, Color color,
		float lifeTIme = -1.0f) { }

	/// <summary>
	/// 지정된 트랜스폼의 로컬 기즈모를 그립니다.
	/// </summary>
	/// <param name="transform"></param>
	/// <param name="color"></param>
	/// <param name="lifeTIme"></param>
	[Conditional(SYMBOL)]
	public static void LocalGizmo(Transform transform, Color color,
		float lifeTIme = -1.0f) { }

	/// <summary>
	/// 지정된 위치에서 월드 좌표계를 그립니다.
	/// </summary>
	/// <param name="position"></param>
	/// <param name="size"></param>
	/// <param name="color"></param>
	/// <param name="lifeTIme"></param>
	[Conditional(SYMBOL)]
	public static void Coordinate(Vector3 position, Vector3 size, Color color,
		float lifeTIme = -1.0f)
	{
	}

	#endregion
}