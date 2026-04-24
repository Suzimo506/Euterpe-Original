namespace Rewired.Data.Mapping;

public sealed class ControllerMap_Editor
{
	[CompilerGenerated]
	private sealed class fxCdiKXfFrCOoovtWJIiwZwDCPtk : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private ActionElementMap QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public ControllerMap_Editor SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

		private override ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current
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
		public fxCdiKXfFrCOoovtWJIiwZwDCPtk(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

		[DebuggerHidden]
		private override ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public int id; //Field offset: 0x10
	public int categoryId; //Field offset: 0x14
	public int layoutId; //Field offset: 0x18
	public string name; //Field offset: 0x20
	public string hardwareGuidString; //Field offset: 0x28
	public int customControllerUid; //Field offset: 0x30
	public List<ActionElementMap> actionElementMaps; //Field offset: 0x38

	public IEnumerable<ActionElementMap> ActionElementMaps
	{
		 get { } //Length: 131
	}

	public Guid hardwareGuid
	{
		 get { } //Length: 113
	}

	public ControllerMap_Editor() { }

	public void AddActionElementMap() { }

	public ControllerMap_Editor Clone() { }

	public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap) { }

	public void CreateElementsFromHardwareMap(CustomController_Editor customController) { }

	public void DeleteActionElementMap(int index) { }

	internal JoystickMap duiJtzvLVfQecVjkXEWsnninPjSU(Func<Int32, Boolean> unnamed_param_0, HardwareControllerMapIdentifier unnamed_param_1, HardwareJoystickMap unnamed_param_2, bool unnamed_param_3) { }

	public void DuplicateActionElementMap(int index) { }

	public IEnumerable<ActionElementMap> get_ActionElementMaps() { }

	public Guid get_hardwareGuid() { }

	public ActionElementMap GetActionElementMap(int index) { }

	public void InsertActionElementMap(int index) { }

	private void iVVPPybMdubVXFKfJlvcdRobDfggB(Func<Int32, Boolean> unnamed_param_0, InputSource unnamed_param_1, CustomControllerMap unnamed_param_2, CustomController_Editor unnamed_param_3) { }

	internal KeyboardMap iZKHbmzNWnfIJMkhacRYZUmxFrZU(Func<Int32, Boolean> unnamed_param_0) { }

	private ActionElementMap MvHsrfABouHWalPpUkdbLAkxUxkl() { }

	internal ControllerTemplateMap qPqDnlGfIxWdkhgFsdEFiTgguHiRA() { }

	public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow) { }

	private void tkaMTBUDnMomUpaVEQnsBmwrOrDF(Func<Int32, Boolean> unnamed_param_0, ControllerMap unnamed_param_1, HardwareControllerMapIdentifier unnamed_param_2, HardwareJoystickMap unnamed_param_3, bool unnamed_param_4) { }

	internal CustomControllerMap ZnLLxoBIixZQPPaXzepbZHmtckEL(Func<Int32, Boolean> unnamed_param_0, CustomController_Editor unnamed_param_1) { }

	internal MouseMap zyKjHmcmUtCeOmJceSJZQlsalRHt(Func<Int32, Boolean> unnamed_param_0) { }

}

