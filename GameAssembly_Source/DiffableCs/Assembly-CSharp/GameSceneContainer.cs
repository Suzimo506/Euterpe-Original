//Type is in global namespace

public class GameSceneContainer : SingletonMonoBehaviour<GameSceneContainer>
{
	public Camera mainCamera; //Field offset: 0x18
	public GameObject girlLayer; //Field offset: 0x20
	public GameObject bossLayer; //Field offset: 0x28
	public GameObject elfinLayer; //Field offset: 0x30
	public DialogMasterControl dialogMaster; //Field offset: 0x38
	public SpriteRenderer sprLightness; //Field offset: 0x40

	public GameSceneContainer() { }

}

