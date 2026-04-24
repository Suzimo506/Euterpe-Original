namespace UnityEngine.PostProcessing;

public abstract class PostProcessingComponentBase
{
	public PostProcessingContext context; //Field offset: 0x10

	public abstract bool active
	{
		 get { } //Length: 0
	}

	protected PostProcessingComponentBase() { }

	public abstract bool get_active() { }

	public override DepthTextureMode GetCameraFlags() { }

	public abstract PostProcessingModel GetModel() { }

	public override void OnDisable() { }

	public override void OnEnable() { }

}

