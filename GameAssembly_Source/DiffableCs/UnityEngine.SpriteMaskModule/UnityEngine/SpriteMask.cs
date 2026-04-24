namespace UnityEngine;

[NativeType]
[RejectDragAndDropMaterial]
public sealed class SpriteMask : Renderer
{

	public float alphaCutoff
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int backSortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int backSortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int frontSortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int frontSortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool isCustomRangeActive
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
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

	public SpriteMask() { }

	public float get_alphaCutoff() { }

	public int get_backSortingLayerID() { }

	public int get_backSortingOrder() { }

	public int get_frontSortingLayerID() { }

	public int get_frontSortingOrder() { }

	[NativeMethod]
	public bool get_isCustomRangeActive() { }

	public Sprite get_sprite() { }

	public SpriteSortPoint get_spriteSortPoint() { }

	internal Bounds GetSpriteBounds() { }

	private void GetSpriteBounds_Injected(out Bounds ret) { }

	public void set_alphaCutoff(float value) { }

	public void set_backSortingLayerID(int value) { }

	public void set_backSortingOrder(int value) { }

	public void set_frontSortingLayerID(int value) { }

	public void set_frontSortingOrder(int value) { }

	[NativeMethod]
	public void set_isCustomRangeActive(bool value) { }

	public void set_sprite(Sprite value) { }

	public void set_spriteSortPoint(SpriteSortPoint value) { }

}

