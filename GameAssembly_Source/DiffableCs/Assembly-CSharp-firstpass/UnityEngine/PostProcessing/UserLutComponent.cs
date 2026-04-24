namespace UnityEngine.PostProcessing;

public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
{
	private static class Uniforms
	{
		internal static readonly int _UserLut; //Field offset: 0x0
		internal static readonly int _UserLut_Params; //Field offset: 0x4

		private static Uniforms() { }

	}


	public virtual bool active
	{
		 get { } //Length: 324
	}

	public UserLutComponent() { }

	public virtual bool get_active() { }

	public void OnGUI() { }

	public virtual void Prepare(Material uberMaterial) { }

}

