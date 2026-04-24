namespace Rewired;

public sealed class Mouse : ControllerWithAxes
{
	private static Guid snJCMfJECepeXcLoskJsCxvfgLLu; //Field offset: 0x0
	private TimerAbs iPQMEKnsGOhgkUzRMlOgtLPkVdVc; //Field offset: 0x158
	private Single[] IivPwSgWYjCeocMIiwddHcumVDcK; //Field offset: 0x160
	private Vector2 KqlcUABzJlwGsVQVlqTnzTxAENJF; //Field offset: 0x168
	private Vector2 UUobQKJMgrcPFbyCMLsEXuTcVGkJ; //Field offset: 0x170
	private int ZhsvwRIjYoFNruykUPppXoALaf; //Field offset: 0x178
	private readonly IUnifiedMouseSource vpevKeWdykXSHmPHPhxFSttJDJbC; //Field offset: 0x180

	public virtual Guid deviceInstanceGuid
	{
		 get { } //Length: 234
	}

	public Vector2 screenPosition
	{
		 get { } //Length: 212
	}

	public Vector2 screenPositionDelta
	{
		 get { } //Length: 291
	}

	public Vector2 screenPositionPrev
	{
		 get { } //Length: 212
	}

	internal Mouse(string unnamed_param_0, IUnifiedMouseSource unnamed_param_1) { }

	private Mouse(int unnamed_param_0, InputSource unnamed_param_1, string unnamed_param_2, string unnamed_param_3, int unnamed_param_4, int unnamed_param_5, HardwareControllerMap_Game unnamed_param_6, Extension unnamed_param_7, ControllerDataUpdater unnamed_param_8) { }

	public virtual Guid get_deviceInstanceGuid() { }

	public Vector2 get_screenPosition() { }

	public Vector2 get_screenPositionDelta() { }

	public Vector2 get_screenPositionPrev() { }

	internal virtual void GpGqGMzBGeWclQczaYnvQZtUlMsn(UpdateLoopType unnamed_param_0) { }

	protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId) { }

	private void nODERIkHVgmWICrPZkByLTUWItbb() { }

	internal virtual void TIWlPgfaGufdFBhysiChIRXnJxnP() { }

	internal virtual bool YXRwIanXzcjIXypKCJbDKGsxxLgP(bool unnamed_param_0) { }

}

