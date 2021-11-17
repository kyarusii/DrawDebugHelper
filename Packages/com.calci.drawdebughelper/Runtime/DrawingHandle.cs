using UnityEngine;

namespace Calci.DDH
{
	/// <summary>
	/// 그리기 취소를 위한 핸들
	/// </summary>
	public class DrawingHandle
	{
		private static long s_GlobalId;
		
		public long Id { get; }
		public bool IsDrawing { get; protected set; }
		public float StartTime { get; protected set; }

		public DrawingHandle() : this(s_GlobalId)
		{
			s_GlobalId++;
		}

		private DrawingHandle(long id)
		{
			this.Id = id;
			this.IsDrawing = true;
			this.StartTime = Time.time;
		}
		
		public void Abort()
		{
			IsDrawing = false;
			
			Drawer.Get().Abort(this);
		}
	}
}