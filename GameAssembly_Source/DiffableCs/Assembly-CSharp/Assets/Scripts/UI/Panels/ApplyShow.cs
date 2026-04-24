namespace Assets.Scripts.UI.Panels;

public class ApplyShow
{
	public string animApply; //Field offset: 0x10
	public string animNoApply; //Field offset: 0x18
	public GameObject applyShowObject; //Field offset: 0x20
	public Animator m_Anim; //Field offset: 0x28
	private Coroutine m_OutPlayCoroutine; //Field offset: 0x30

	public ApplyShow() { }

	[CompilerGenerated]
	private void <PlayApply>b__6_0() { }

	private bool IsAnimiatorFinish() { }

	public void PlayApply(bool apply) { }

	private void PlayFadeIn() { }

	private void PlayFadeOut() { }

}

