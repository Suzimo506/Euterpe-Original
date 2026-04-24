namespace Rewired;

public struct PlayerSaveData
{
	[CompilerGenerated]
	private sealed class exuIgTydNKEXnOqMYGiXaLULTCyr : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMapSaveData>, IEnumerator<ControllerMapSaveData>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private ControllerMapSaveData QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public PlayerSaveData SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		public PlayerSaveData OWwWupUeuoKYlEdJfAeXIrdpYlUf; //Field offset: 0x50
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x78

		private override ControllerMapSaveData System.Collections.Generic.IEnumerator<Rewired.ControllerMapSaveData>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public exuIgTydNKEXnOqMYGiXaLULTCyr(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ControllerMapSaveData> System.Collections.Generic.IEnumerable<Rewired.ControllerMapSaveData>.GetEnumerator() { }

		[DebuggerHidden]
		private override ControllerMapSaveData System.Collections.Generic.IEnumerator<Rewired.ControllerMapSaveData>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private JoystickMapSaveData[] gpsZBQUksPpsDlbBhqLzbrndOFVt; //Field offset: 0x0
	private KeyboardMapSaveData[] KXAIOmyaNECtgTjXIOKGIdkhDzxM; //Field offset: 0x8
	private MouseMapSaveData[] gNBGdhDTgmmDIGmCGVrSOjiGjKRH; //Field offset: 0x10
	private CustomControllerMapSaveData[] skKpJnkFNflgykJeulREQVIkaLdF; //Field offset: 0x18
	private InputBehavior[] HYEzhOnhKOlzQGXiFyWIlZATbxFA; //Field offset: 0x20

	public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData
	{
		 get { } //Length: 151
	}

	public int customControllerMapCount
	{
		 get { } //Length: 14
	}

	public CustomControllerMapSaveData[] customControllerMapSaveData
	{
		 get { } //Length: 5
	}

	public int inputBehaviorCount
	{
		 get { } //Length: 14
	}

	public InputBehavior[] inputBehaviors
	{
		 get { } //Length: 5
	}

	public int joystickMapCount
	{
		 get { } //Length: 13
	}

	public JoystickMapSaveData[] joystickMapSaveData
	{
		 get { } //Length: 4
	}

	public int keyboardMapCount
	{
		 get { } //Length: 14
	}

	public KeyboardMapSaveData[] keyboardMapSaveData
	{
		 get { } //Length: 5
	}

	public int mouseMapCount
	{
		 get { } //Length: 14
	}

	public MouseMapSaveData[] mouseMapSaveData
	{
		 get { } //Length: 5
	}

	internal PlayerSaveData(JoystickMapSaveData[] unnamed_param_0, KeyboardMapSaveData[] unnamed_param_1, MouseMapSaveData[] unnamed_param_2, CustomControllerMapSaveData[] unnamed_param_3, IList<InputBehavior> unnamed_param_4) { }

	public IEnumerable<ControllerMapSaveData> get_AllControllerMapSaveData() { }

	public int get_customControllerMapCount() { }

	public CustomControllerMapSaveData[] get_customControllerMapSaveData() { }

	public int get_inputBehaviorCount() { }

	public InputBehavior[] get_inputBehaviors() { }

	public int get_joystickMapCount() { }

	public JoystickMapSaveData[] get_joystickMapSaveData() { }

	public int get_keyboardMapCount() { }

	public KeyboardMapSaveData[] get_keyboardMapSaveData() { }

	public int get_mouseMapCount() { }

	public MouseMapSaveData[] get_mouseMapSaveData() { }

}

