namespace UnityEngine.Rendering;

public class MousePositionDebug
{
	private static MousePositionDebug s_Instance; //Field offset: 0x2C927B4

	public static MousePositionDebug instance
	{
		 get { } //Length: 231
	}

	private static MousePositionDebug() { }

	public MousePositionDebug() { }

	public void Build() { }

	public void Cleanup() { }

	public static MousePositionDebug get_instance() { }

	public Vector2 GetMouseClickPosition(float ScreenHeight) { }

	public Vector2 GetMousePosition(float ScreenHeight, bool sceneView) { }

}

