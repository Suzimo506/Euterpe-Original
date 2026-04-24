namespace Assets.Scripts.UI.Effects;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BgEffect : MonoBehaviour
{
	public string fadeInAnimName; //Field offset: 0x18
	public string fadeOutAnimName; //Field offset: 0x20
	private Animator m_Animator; //Field offset: 0x28

	public BgEffect() { }

	private void Awake() { }

	public void FadeIn() { }

	public void FadeOut() { }

}

