namespace UnityEngine;

[NativeType]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SpriteRenderer : Renderer
{

	public float adaptiveModeThreshold
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Color color
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public SpriteDrawMode drawMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool flipX
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool flipY
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	internal bool shouldSupportTiling
	{
		[NativeMethod]
		internal get { } //Length: 51
	}

	public Vector2 size
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	public Sprite sprite
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public SpriteSortPoint spriteSortPoint
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public SpriteTileMode tileMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public SpriteRenderer() { }

	public float get_adaptiveModeThreshold() { }

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	public SpriteDrawMode get_drawMode() { }

	public bool get_flipX() { }

	public bool get_flipY() { }

	public SpriteMaskInteraction get_maskInteraction() { }

	[NativeMethod]
	internal bool get_shouldSupportTiling() { }

	public Vector2 get_size() { }

	private void get_size_Injected(out Vector2 ret) { }

	public Sprite get_sprite() { }

	public SpriteSortPoint get_spriteSortPoint() { }

	public SpriteTileMode get_tileMode() { }

	internal Bounds GetSpriteBounds() { }

	[NativeMethod]
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	private void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret) { }

	public void set_adaptiveModeThreshold(float value) { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

	public void set_drawMode(SpriteDrawMode value) { }

	public void set_flipX(bool value) { }

	public void set_flipY(bool value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	public void set_size(Vector2 value) { }

	private void set_size_Injected(ref Vector2 value) { }

	public void set_sprite(Sprite value) { }

	public void set_spriteSortPoint(SpriteSortPoint value) { }

	public void set_tileMode(SpriteTileMode value) { }

}

