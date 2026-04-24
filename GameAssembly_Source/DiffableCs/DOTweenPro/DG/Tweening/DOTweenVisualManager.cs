namespace DG.Tweening;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DOTweenVisualManager : MonoBehaviour
{
	public VisualManagerPreset preset; //Field offset: 0x18
	public OnEnableBehaviour onEnableBehaviour; //Field offset: 0x1C
	public OnDisableBehaviour onDisableBehaviour; //Field offset: 0x20
	private bool _requiresRestartFromSpawnPoint; //Field offset: 0x24
	private ABSAnimationComponent _animComponent; //Field offset: 0x28

	public DOTweenVisualManager() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

}

