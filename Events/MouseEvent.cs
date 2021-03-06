
namespace Poncho.Events
{
	/// <summary>
	/// MouseEvents are dispatched when the user interacts with a DisplayObject using the mouse.
	/// </summary>
	public class MouseEvent : Event
	{
		#region CONSTANTS
		public const string CLICK			= "MouseEvent.click";
		public const string RIGHT_CLICK		= "MouseEvent.right_click";
		public const string MIDDLE_CLICK	= "MouseEvent.middle_click";
		public const string MOUSE_OVER		= "MouseEvent.mouse_over";
		public const string MOUSE_OUT		= "MouseEvent.mouse_out";
		public const string MOUSE_DOWN		= "MouseEvent.mouse_down";
		public const string MOUSE_UP		= "MouseEvent.mouse_up";
		public const string RIGHT_DOWN		= "MouseEvent.right_down";
		public const string RIGHT_UP		= "MouseEvent.right_up";
		public const string MIDDLE_DOWN		= "MouseEvent.middle_down";
		public const string MIDDLE_UP		= "MouseEvent.middle_up";
		public const string MOUSE_WHEEL		= "MouseEvent.mouse_wheel";
		#endregion

		#region GETTERS & SETTERS
		// --------------------------------------------------------------
		public int delta { get; private set; }
		public EventDispatcher relatedObject { get; private set; }
		#endregion

		#region MEMBERS
		// --------------------------------------------------------------
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="relatedObject"></param>
		/// <param name="delta"></param>
		public MouseEvent(string type, EventDispatcher relatedObject=null, int delta=0) : base(type)
		{
			this.relatedObject = relatedObject;
			this.delta = delta;
		}
		
		#endregion
	}
}
