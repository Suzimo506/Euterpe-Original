namespace UnityEngine.InputSystem;

[Extension]
public static class InputActionRebindingExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ReadOnlyArray<InputBinding> bindings; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_1
	{
		public int firstPartIndex; //Field offset: 0x10
		public String[] partStrings; //Field offset: 0x18
		public int partCount; //Field offset: 0x20
		public <>c__DisplayClass8_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass8_1() { }

		internal string <GetBindingDisplayString>b__0(string fragment) { }

	}

	public class DeferBindingResolutionWrapper : IDisposable
	{

		public DeferBindingResolutionWrapper() { }

		public void Acquire() { }

		public override void Dispose() { }

	}

	internal sealed class RebindingOperation : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass32_0
		{
			public string group; //Field offset: 0x10

			public <>c__DisplayClass32_0() { }

			internal bool <WithTargetBinding>b__0(InputControlScheme x) { }

		}

		[Flags]
		private enum Flags
		{
			Started = 1,
			Completed = 2,
			Canceled = 4,
			OnEventHooked = 8,
			OnAfterUpdateHooked = 16,
			DontIgnoreNoisyControls = 64,
			DontGeneralizePathOfSelectedControl = 128,
			AddNewBinding = 256,
			SuppressMatchingEvents = 512,
		}

		public const float kDefaultMagnitudeThreshold = 0.2; //Field offset: 0x0
		private InputAction m_ActionToRebind; //Field offset: 0x10
		private Nullable<InputBinding> m_BindingMask; //Field offset: 0x18
		private Type m_ControlType; //Field offset: 0x78
		private InternedString m_ExpectedLayout; //Field offset: 0x80
		private int m_IncludePathCount; //Field offset: 0x90
		private String[] m_IncludePaths; //Field offset: 0x98
		private int m_ExcludePathCount; //Field offset: 0xA0
		private String[] m_ExcludePaths; //Field offset: 0xA8
		private int m_TargetBindingIndex; //Field offset: 0xB0
		private string m_BindingGroupForNewBinding; //Field offset: 0xB8
		private string m_CancelBinding; //Field offset: 0xC0
		private float m_MagnitudeThreshold; //Field offset: 0xC8
		private Single[] m_Scores; //Field offset: 0xD0
		private Single[] m_Magnitudes; //Field offset: 0xD8
		private double m_LastMatchTime; //Field offset: 0xE0
		private double m_StartTime; //Field offset: 0xE8
		private float m_Timeout; //Field offset: 0xF0
		private float m_WaitSecondsAfterMatch; //Field offset: 0xF4
		private InputControlList<InputControl> m_Candidates; //Field offset: 0xF8
		private Action<RebindingOperation> m_OnComplete; //Field offset: 0x118
		private Action<RebindingOperation> m_OnCancel; //Field offset: 0x120
		private Action<RebindingOperation> m_OnPotentialMatch; //Field offset: 0x128
		private Func<InputControl, String> m_OnGeneratePath; //Field offset: 0x130
		private Func<InputControl, InputEventPtr, Single> m_OnComputeScore; //Field offset: 0x138
		private Action<RebindingOperation, String> m_OnApplyBinding; //Field offset: 0x140
		private Action<InputEventPtr, InputDevice> m_OnEventDelegate; //Field offset: 0x148
		private Action m_OnAfterUpdateDelegate; //Field offset: 0x150
		private Cache m_LayoutCache; //Field offset: 0x158
		private StringBuilder m_PathBuilder; //Field offset: 0x160
		private Flags m_Flags; //Field offset: 0x168
		private Dictionary<InputControl, Single> m_StartingActuations; //Field offset: 0x170

		public InputAction action
		{
			 get { } //Length: 5
		}

		public Nullable<InputBinding> bindingMask
		{
			 get { } //Length: 51
		}

		public bool canceled
		{
			 get { } //Length: 11
		}

		public InputControlList<InputControl> candidates
		{
			 get { } //Length: 25
		}

		public bool completed
		{
			 get { } //Length: 11
		}

		public string expectedControlType
		{
			 get { } //Length: 33
		}

		public ReadOnlyArray<Single> magnitudes
		{
			 get { } //Length: 100
		}

		public ReadOnlyArray<Single> scores
		{
			 get { } //Length: 100
		}

		public InputControl selectedControl
		{
			 get { } //Length: 75
		}

		public bool started
		{
			 get { } //Length: 10
		}

		public double startTime
		{
			 get { } //Length: 9
		}

		public float timeout
		{
			 get { } //Length: 9
		}

		public RebindingOperation() { }

		public void AddCandidate(InputControl control, float score, float magnitude = -1) { }

		public void Cancel() { }

		public void Complete() { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		private string GeneratePathForControl(InputControl control) { }

		public InputAction get_action() { }

		public Nullable<InputBinding> get_bindingMask() { }

		public bool get_canceled() { }

		public InputControlList<InputControl> get_candidates() { }

		public bool get_completed() { }

		public string get_expectedControlType() { }

		public ReadOnlyArray<Single> get_magnitudes() { }

		public ReadOnlyArray<Single> get_scores() { }

		public InputControl get_selectedControl() { }

		public bool get_started() { }

		public double get_startTime() { }

		public float get_timeout() { }

		private static bool HavePathMatch(InputControl control, String[] paths, int pathCount) { }

		private void HookOnAfterUpdate() { }

		private void HookOnEvent() { }

		private void OnAfterUpdate() { }

		public RebindingOperation OnApplyBinding(Action<RebindingOperation, String> callback) { }

		private void OnCancel() { }

		public RebindingOperation OnCancel(Action<RebindingOperation> callback) { }

		private void OnComplete() { }

		public RebindingOperation OnComplete(Action<RebindingOperation> callback) { }

		public RebindingOperation OnComputeScore(Func<InputControl, InputEventPtr, Single> callback) { }

		private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

		public RebindingOperation OnGeneratePath(Func<InputControl, String> callback) { }

		public RebindingOperation OnMatchWaitForAnother(float seconds) { }

		public RebindingOperation OnPotentialMatch(Action<RebindingOperation> callback) { }

		public void RemoveCandidate(InputControl control) { }

		public RebindingOperation Reset() { }

		private void ResetAfterMatchCompleted() { }

		private void SortCandidatesByScore() { }

		public RebindingOperation Start() { }

		private void ThrowIfRebindInProgress() { }

		private void UnhookOnAfterUpdate() { }

		private void UnhookOnEvent() { }

		public RebindingOperation WithAction(InputAction action) { }

		public RebindingOperation WithBindingGroup(string group) { }

		public RebindingOperation WithBindingMask(Nullable<InputBinding> bindingMask) { }

		public RebindingOperation WithCancelingThrough(string binding) { }

		public RebindingOperation WithCancelingThrough(InputControl control) { }

		public RebindingOperation WithControlsExcluding(string path) { }

		public RebindingOperation WithControlsHavingToMatchPath(string path) { }

		public RebindingOperation WithExpectedControlType() { }

		public RebindingOperation WithExpectedControlType(Type type) { }

		public RebindingOperation WithExpectedControlType(string layoutName) { }

		public RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude) { }

		public RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true) { }

		public RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }

		public RebindingOperation WithoutIgnoringNoisyControls() { }

		public RebindingOperation WithRebindAddingNewBinding(string group = null) { }

		public RebindingOperation WithTargetBinding(int bindingIndex) { }

		public RebindingOperation WithTimeout(float timeInSeconds) { }

	}

	private static DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; //Field offset: 0x685AD

	[Extension]
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, List<BindingOverrideJson> list, InputAction action = null) { }

	[Extension]
	public static void ApplyBindingOverride(InputAction action, string newPath, string group = null, string path = null) { }

	[Extension]
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	[Extension]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	[Extension]
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	[Extension]
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	[Extension]
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	[Extension]
	public static void ApplyBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Extension]
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	[Extension]
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	internal static DeferBindingResolutionWrapper DeferBindingResolution() { }

	[Extension]
	public static string GetBindingDisplayString(InputAction action, DisplayStringOptions options = 0, string group = null) { }

	[Extension]
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, DisplayStringOptions options = 0) { }

	[Extension]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, DisplayStringOptions options = 0) { }

	[Extension]
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, DisplayStringOptions options = 0) { }

	[Extension]
	public static Nullable<InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	[Extension]
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	[Extension]
	public static int GetBindingIndex(InputAction action, string group = null, string path = null) { }

	[Extension]
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	[Extension]
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	[Extension]
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting = true) { }

	[Extension]
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting = true) { }

	[Extension]
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	[Extension]
	public static RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex = -1) { }

	[Extension]
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	[Extension]
	public static void RemoveAllBindingOverrides(InputAction action) { }

	[Extension]
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	[Extension]
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	[Extension]
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	[Extension]
	public static void RemoveBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Extension]
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	[Extension]
	public static string SaveBindingOverridesAsJson(InputAction action) { }

}

