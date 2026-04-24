namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ParticleSystemRenderer : Renderer
{

	public int activeVertexStreamsCount
	{
		 get { } //Length: 51
	}

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ParticleSystemRenderSpace alignment
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool allowRoll
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float cameraVelocityScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool enableGPUInstancing
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 flip
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public float lengthScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float maxParticleSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Mesh mesh
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public int meshCount
	{
		 get { } //Length: 51
	}

	public float minParticleSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float normalDirection
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector3 pivot
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public ParticleSystemRenderMode renderMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float shadowBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float sortingFudge
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public ParticleSystemSortMode sortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Material trailMaterial
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float velocityScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public ParticleSystemRenderer() { }

	[Obsolete]
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	public void BakeTrailsMesh(Mesh mesh, bool useTransform = false) { }

	[Obsolete]
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete]
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	public int get_activeVertexStreamsCount() { }

	public ParticleSystemRenderSpace get_alignment() { }

	public bool get_allowRoll() { }

	public float get_cameraVelocityScale() { }

	public bool get_enableGPUInstancing() { }

	public Vector3 get_flip() { }

	private void get_flip_Injected(out Vector3 ret) { }

	public float get_lengthScale() { }

	public SpriteMaskInteraction get_maskInteraction() { }

	public float get_maxParticleSize() { }

	[FreeFunction]
	public Mesh get_mesh() { }

	public int get_meshCount() { }

	public float get_minParticleSize() { }

	public float get_normalDirection() { }

	public Vector3 get_pivot() { }

	private void get_pivot_Injected(out Vector3 ret) { }

	public ParticleSystemRenderMode get_renderMode() { }

	public float get_shadowBias() { }

	public float get_sortingFudge() { }

	public ParticleSystemSortMode get_sortMode() { }

	public Material get_trailMaterial() { }

	public float get_velocityScale() { }

	[FreeFunction]
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Obsolete]
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[FreeFunction]
	[RequiredByNativeCode]
	public int GetMeshes(out Mesh[] meshes) { }

	[Obsolete]
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete]
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	public void set_alignment(ParticleSystemRenderSpace value) { }

	public void set_allowRoll(bool value) { }

	public void set_cameraVelocityScale(float value) { }

	public void set_enableGPUInstancing(bool value) { }

	public void set_flip(Vector3 value) { }

	private void set_flip_Injected(ref Vector3 value) { }

	public void set_lengthScale(float value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	public void set_maxParticleSize(float value) { }

	[FreeFunction]
	public void set_mesh(Mesh value) { }

	public void set_minParticleSize(float value) { }

	public void set_normalDirection(float value) { }

	public void set_pivot(Vector3 value) { }

	private void set_pivot_Injected(ref Vector3 value) { }

	public void set_renderMode(ParticleSystemRenderMode value) { }

	public void set_shadowBias(float value) { }

	public void set_sortingFudge(float value) { }

	public void set_sortMode(ParticleSystemSortMode value) { }

	public void set_trailMaterial(Material value) { }

	public void set_velocityScale(float value) { }

	[FreeFunction]
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	public void SetMeshes(Mesh[] meshes) { }

	[FreeFunction]
	public void SetMeshes(Mesh[] meshes, int size) { }

}

