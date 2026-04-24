namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[DisallowMultipleComponent]
public class CustomController : ComponentController
{
	internal class CreateCustomControllerSettings
	{
		[CustomObfuscation]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _createCustomController; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private int _customControllerSourceId; //Field offset: 0x14
		[CustomObfuscation]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private int _assignToPlayerId; //Field offset: 0x18
		[CustomObfuscation]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _destroyCustomController; //Field offset: 0x1C

		public int assignToPlayerId
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public bool createCustomController
		{
			 get { } //Length: 5
			 set { } //Length: 9
		}

		public int customControllerSourceId
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public bool destroyCustomController
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public CreateCustomControllerSettings() { }

		public int get_assignToPlayerId() { }

		public bool get_createCustomController() { }

		public int get_customControllerSourceId() { }

		public bool get_destroyCustomController() { }

		public void set_assignToPlayerId(int value) { }

		public void set_createCustomController(bool value) { }

		public void set_customControllerSourceId(int value) { }

		public void set_destroyCustomController(bool value) { }

	}

	private struct nvjBLrvPKGaMmcjKPzShHLQqAEeYA
	{
		public ElementType TIvrHqoiWzSMnQmlhLoWYtklcSSt; //Field offset: 0x0
		public int eiJKaYkvxFLIftJVaItGfmzGjCEj; //Field offset: 0x4
		public float zRUQZDXXBkLNTaHWFlnOtpiXDsdt; //Field offset: 0x8

		public nvjBLrvPKGaMmcjKPzShHLQqAEeYA(ElementType unnamed_param_0, int unnamed_param_1, float unnamed_param_2) { }

		public nvjBLrvPKGaMmcjKPzShHLQqAEeYA(ElementType unnamed_param_0, int unnamed_param_1, bool unnamed_param_2) { }

		public bool ROXggXPGgDwsqrqDcoIFMNYKOfzx(ElementType unnamed_param_0, int unnamed_param_1) { }

		public void vmZKjjjOHafEldlwytqWvQziOVnS(float unnamed_param_0) { }

		public void vmZKjjjOHafEldlwytqWvQziOVnS(bool unnamed_param_0) { }

	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InputManager_Base _rewiredInputManager; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerSelector _customControllerSelector; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CreateCustomControllerSettings _createCustomControllerSettings; //Field offset: 0x38
	private List<nvjBLrvPKGaMmcjKPzShHLQqAEeYA> zMvAzHHoAjFSywhfiwhuWcinBMsg; //Field offset: 0x40
	private int UQPrGkhynWgAzwIjmgxuSYyvNRkv; //Field offset: 0x48
	private Action WWUbulrDXFRhitDEbQcrIOWObGSIA; //Field offset: 0x50

	internal event Action InputSourceUpdateEvent
	{
		internal add { } //Length: 118
		internal remove { } //Length: 118
	}

	public CreateCustomControllerSettings createCustomControllerSettings
	{
		 get { } //Length: 5
	}

	public CustomControllerSelector customControllerSelector
	{
		 get { } //Length: 5
	}

	public InputManager_Base rewiredInputManager
	{
		 get { } //Length: 5
		 set { } //Length: 201
	}

	[CustomObfuscation]
	internal CustomController() { }

	internal void add_InputSourceUpdateEvent(Action value) { }

	private void aJgVaSJvQBCegulXyMPdcUWGhgGU(CustomController unnamed_param_0) { }

	private void bFqPSjgMcZsLyneowzCtCRGizZmE() { }

	public virtual void ClearControlValues() { }

	internal void ClearElementValue(CustomControllerElementSelector element) { }

	internal void ClearElementValue(CustomControllerElementTarget target) { }

	internal void ClearElementValue(CustomControllerElementTargetSet targetSet) { }

	internal bool ElementExists(CustomControllerElementSelector element) { }

	internal int ElementExists_Editor(CustomControllerElementSelector element) { }

	private bool fifpVcdHlegPCtMYCEajAfVsPTxr() { }

	public CreateCustomControllerSettings get_createCustomControllerSettings() { }

	public CustomControllerSelector get_customControllerSelector() { }

	public InputManager_Base get_rewiredInputManager() { }

	public CustomController GetCustomController() { }

	[CustomObfuscation]
	internal override bool GetUseCustomController() { }

	private void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	private void hPsysfiDkhQXqTLztVOXmLoMeknD() { }

	[CustomObfuscation]
	internal virtual void OnDestroy() { }

	[CustomObfuscation]
	internal virtual void OnDisable() { }

	[CustomObfuscation]
	internal virtual void OnEnable() { }

	internal virtual bool OnInitialize() { }

	internal virtual void OnSubscribeEvents() { }

	internal virtual void OnUnsubscribeEvents() { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	private void pjpozwnbJiEqLkcIabcUECnhlGuBA() { }

	internal void remove_InputSourceUpdateEvent(Action value) { }

	public void set_rewiredInputManager(InputManager_Base value) { }

	internal void SetAxisValue(CustomControllerElementSelector element, float value) { }

	internal void SetButtonValue(CustomControllerElementSelector element, bool value) { }

	[CustomObfuscation]
	internal override void SetUseCustomController(bool value) { }

	private CustomController TYJfsBJktSNSViqWcOuUgkZxNKoR(bool unnamed_param_0) { }

	internal bool ValidateElement(CustomControllerElementTarget target) { }

	internal bool ValidateElement(CustomControllerElementSelector element) { }

	internal bool ValidateElements(CustomControllerElementTargetSet targetSet) { }

}

