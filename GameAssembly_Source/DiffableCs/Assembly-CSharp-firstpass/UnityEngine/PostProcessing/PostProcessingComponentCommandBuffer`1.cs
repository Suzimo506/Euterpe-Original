namespace UnityEngine.PostProcessing;

public abstract class PostProcessingComponentCommandBuffer : PostProcessingComponent<T>
{

	protected PostProcessingComponentCommandBuffer`1() { }

	public abstract CameraEvent GetCameraEvent() { }

	public abstract string GetName() { }

	public abstract void PopulateCommandBuffer(CommandBuffer cb) { }

}

