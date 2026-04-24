namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[NativeType]
	internal struct Burst
	{
		private float m_Time; //Field offset: 0x0
		private MinMaxCurve m_Count; //Field offset: 0x8
		private int m_RepeatCount; //Field offset: 0x28
		private float m_RepeatInterval; //Field offset: 0x2C
		private float m_InvProbability; //Field offset: 0x30

		public MinMaxCurve count
		{
			 get { } //Length: 19
			 set { } //Length: 26
		}

		public MinMaxCurve get_count() { }

		public void set_count(MinMaxCurve value) { }

	}

	internal struct CollisionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CollisionModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ColorBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public MinMaxGradient color
		{
			 set { } //Length: 66
		}

		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

		public void set_color(MinMaxGradient value) { }

		private static void set_color_Injected(ref ColorOverLifetimeModule _unity_self, ref MinMaxGradient value) { }

	}

	internal struct CustomDataModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CustomDataModule(ParticleSystem particleSystem) { }

	}

	internal struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			 get { } //Length: 51
			 set { } //Length: 66
		}

		public MinMaxCurve rateOverTime
		{
			 set { } //Length: 66
		}

		public float rateOverTimeMultiplier
		{
			 get { } //Length: 51
		}

		internal EmissionModule(ParticleSystem particleSystem) { }

		public bool get_enabled() { }

		private static bool get_enabled_Injected(ref EmissionModule _unity_self) { }

		public float get_rateOverTimeMultiplier() { }

		private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self) { }

		public Burst GetBurst(int index) { }

		private static void GetBurst_Injected(ref EmissionModule _unity_self, int index, out Burst ret) { }

		public void set_enabled(bool value) { }

		private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) { }

		public void set_rateOverTime(MinMaxCurve value) { }

		private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) { }

		public void SetBurst(int index, Burst burst) { }

		private static void SetBurst_Injected(ref EmissionModule _unity_self, int index, ref Burst burst) { }

	}

	internal struct EmitParams
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private Particle m_Particle; //Field offset: 0x0
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_PositionSet; //Field offset: 0x84
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_VelocitySet; //Field offset: 0x85
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_RotationSet; //Field offset: 0x87
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_StartSizeSet; //Field offset: 0x89
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_StartColorSet; //Field offset: 0x8A
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	internal struct ExternalForcesModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ExternalForcesModule(ParticleSystem particleSystem) { }

	}

	internal struct ForceOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ForceOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct InheritVelocityModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal InheritVelocityModule(ParticleSystem particleSystem) { }

	}

	internal struct LightsModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LightsModule(ParticleSystem particleSystem) { }

	}

	internal struct LimitVelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float duration
		{
			 get { } //Length: 51
		}

		public float gravityModifierMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public bool loop
		{
			 get { } //Length: 51
			 set { } //Length: 66
		}

		public int maxParticles
		{
			 get { } //Length: 51
			 set { } //Length: 64
		}

		public bool playOnAwake
		{
			 get { } //Length: 51
			 set { } //Length: 66
		}

		public ParticleSystemScalingMode scalingMode
		{
			 get { } //Length: 51
			 set { } //Length: 64
		}

		public ParticleSystemSimulationSpace simulationSpace
		{
			 get { } //Length: 51
			 set { } //Length: 64
		}

		public float simulationSpeed
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public MinMaxGradient startColor
		{
			 get { } //Length: 89
			 set { } //Length: 66
		}

		public float startDelayMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public MinMaxCurve startLifetime
		{
			 get { } //Length: 79
		}

		public float startLifetimeMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float startRotationMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public float startRotationXMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public float startRotationYMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public float startRotationZMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public MinMaxCurve startSize
		{
			 set { } //Length: 66
		}

		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float startSizeMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		public float startSpeedMultiplier
		{
			 get { } //Length: 51
			 set { } //Length: 67
		}

		internal MainModule(ParticleSystem particleSystem) { }

		public float get_duration() { }

		private static float get_duration_Injected(ref MainModule _unity_self) { }

		public float get_gravityModifierMultiplier() { }

		private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self) { }

		public bool get_loop() { }

		private static bool get_loop_Injected(ref MainModule _unity_self) { }

		public int get_maxParticles() { }

		private static int get_maxParticles_Injected(ref MainModule _unity_self) { }

		public bool get_playOnAwake() { }

		private static bool get_playOnAwake_Injected(ref MainModule _unity_self) { }

		public ParticleSystemScalingMode get_scalingMode() { }

		private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) { }

		public ParticleSystemSimulationSpace get_simulationSpace() { }

		private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) { }

		public float get_simulationSpeed() { }

		private static float get_simulationSpeed_Injected(ref MainModule _unity_self) { }

		public MinMaxGradient get_startColor() { }

		private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) { }

		public float get_startDelayMultiplier() { }

		private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self) { }

		public MinMaxCurve get_startLifetime() { }

		private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		public float get_startLifetimeMultiplier() { }

		private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationMultiplier() { }

		private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationXMultiplier() { }

		private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationYMultiplier() { }

		private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationZMultiplier() { }

		private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startSizeMultiplier() { }

		private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startSpeedMultiplier() { }

		private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self) { }

		public void set_gravityModifierMultiplier(float value) { }

		private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_loop(bool value) { }

		private static void set_loop_Injected(ref MainModule _unity_self, bool value) { }

		public void set_maxParticles(int value) { }

		private static void set_maxParticles_Injected(ref MainModule _unity_self, int value) { }

		public void set_playOnAwake(bool value) { }

		private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value) { }

		public void set_scalingMode(ParticleSystemScalingMode value) { }

		private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value) { }

		public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

		private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value) { }

		public void set_simulationSpeed(float value) { }

		private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value) { }

		public void set_startColor(MinMaxGradient value) { }

		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) { }

		public void set_startDelayMultiplier(float value) { }

		private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startLifetimeMultiplier(float value) { }

		private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startRotationMultiplier(float value) { }

		private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startRotationXMultiplier(float value) { }

		private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startRotationYMultiplier(float value) { }

		private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startRotationZMultiplier(float value) { }

		private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startSize(MinMaxCurve value) { }

		private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

		public void set_startSizeMultiplier(float value) { }

		private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startSpeedMultiplier(float value) { }

		private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value) { }

	}

	[NativeType]
	internal struct MinMaxCurve
	{
		[SerializeField]
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private float m_CurveMultiplier; //Field offset: 0x4
		[SerializeField]
		private AnimationCurve m_CurveMin; //Field offset: 0x8
		[SerializeField]
		private AnimationCurve m_CurveMax; //Field offset: 0x10
		[SerializeField]
		private float m_ConstantMin; //Field offset: 0x18
		[SerializeField]
		private float m_ConstantMax; //Field offset: 0x1C

		public float constant
		{
			 get { } //Length: 8
			 set { } //Length: 6
		}

		public float constantMax
		{
			 get { } //Length: 8
		}

		public float constantMin
		{
			 get { } //Length: 8
		}

		public AnimationCurve curve
		{
			 get { } //Length: 7
		}

		public AnimationCurve curveMax
		{
			 get { } //Length: 7
		}

		public AnimationCurve curveMin
		{
			 get { } //Length: 7
		}

		public ParticleSystemCurveMode mode
		{
			 get { } //Length: 5
		}

		public MinMaxCurve(float constant) { }

		public float get_constant() { }

		public float get_constantMax() { }

		public float get_constantMin() { }

		public AnimationCurve get_curve() { }

		public AnimationCurve get_curveMax() { }

		public AnimationCurve get_curveMin() { }

		public ParticleSystemCurveMode get_mode() { }

		public static MinMaxCurve op_Implicit(float constant) { }

		public void set_constant(float value) { }

	}

	[NativeType]
	internal struct MinMaxGradient
	{
		[SerializeField]
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private Gradient m_GradientMin; //Field offset: 0x8
		[SerializeField]
		private Gradient m_GradientMax; //Field offset: 0x10
		[SerializeField]
		private Color m_ColorMin; //Field offset: 0x18
		[SerializeField]
		private Color m_ColorMax; //Field offset: 0x28

		public Color color
		{
			 get { } //Length: 11
		}

		public MinMaxGradient(Color color) { }

		public MinMaxGradient(Gradient gradient) { }

		public Color get_color() { }

		public static MinMaxGradient op_Implicit(Color color) { }

		public static MinMaxGradient op_Implicit(Gradient gradient) { }

	}

	internal struct NoiseModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal NoiseModule(ParticleSystem particleSystem) { }

	}

	[RequiredByNativeCode]
	internal struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private uint m_ParentRandomSeed; //Field offset: 0x68
		private float m_Lifetime; //Field offset: 0x6C
		private float m_StartLifetime; //Field offset: 0x70
		private int m_MeshIndex; //Field offset: 0x74
		private float m_EmitAccumulator0; //Field offset: 0x78
		private float m_EmitAccumulator1; //Field offset: 0x7C
		private uint m_Flags; //Field offset: 0x80

		public Vector3 angularVelocity3D
		{
			 set { } //Length: 149
		}

		[Obsolete]
		public float lifetime
		{
			 set { } //Length: 6
		}

		public Vector3 position
		{
			 get { } //Length: 18
			 set { } //Length: 15
		}

		public uint randomSeed
		{
			 set { } //Length: 4
		}

		public float remainingLifetime
		{
			 get { } //Length: 8
			 set { } //Length: 6
		}

		public Vector3 rotation3D
		{
			 set { } //Length: 149
		}

		public Color32 startColor
		{
			 set { } //Length: 4
		}

		public float startLifetime
		{
			 set { } //Length: 6
		}

		public float startSize
		{
			 set { } //Length: 65
		}

		public Vector3 velocity
		{
			 get { } //Length: 19
			 set { } //Length: 16
		}

		public Vector3 get_position() { }

		public float get_remainingLifetime() { }

		public Vector3 get_velocity() { }

		public void set_angularVelocity3D(Vector3 value) { }

		public void set_lifetime(float value) { }

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_remainingLifetime(float value) { }

		public void set_rotation3D(Vector3 value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}

	internal struct PlaybackState
	{
		public struct Collision
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Emission
		{
			public float m_ParticleSpacing; //Field offset: 0x0
			public float m_ToEmitAccumulator; //Field offset: 0x4
			public Seed m_Random; //Field offset: 0x8

		}

		public struct Force
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Initial
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Lights
		{
			public Seed m_Random; //Field offset: 0x0
			public float m_ParticleEmissionCounter; //Field offset: 0x10

		}

		public struct Noise
		{
			public float m_ScrollOffset; //Field offset: 0x0

		}

		public struct Seed
		{
			public uint x; //Field offset: 0x0
			public uint y; //Field offset: 0x4
			public uint z; //Field offset: 0x8
			public uint w; //Field offset: 0xC

		}

		public struct Seed4
		{
			public Seed x; //Field offset: 0x0
			public Seed y; //Field offset: 0x10
			public Seed z; //Field offset: 0x20
			public Seed w; //Field offset: 0x30

		}

		public struct Shape
		{
			public Seed4 m_Random; //Field offset: 0x0
			public float m_RadiusTimer; //Field offset: 0x40
			public float m_RadiusTimerPrev; //Field offset: 0x44
			public float m_ArcTimer; //Field offset: 0x48
			public float m_ArcTimerPrev; //Field offset: 0x4C
			public float m_MeshSpawnTimer; //Field offset: 0x50
			public float m_MeshSpawnTimerPrev; //Field offset: 0x54
			public int m_OrderedMeshVertexIndex; //Field offset: 0x58

		}

		public struct Trail
		{
			public float m_Timer; //Field offset: 0x0

		}

		internal float m_AccumulatedDt; //Field offset: 0x0
		internal float m_StartDelay; //Field offset: 0x4
		internal float m_PlaybackTime; //Field offset: 0x8
		internal int m_RingBufferIndex; //Field offset: 0xC
		internal Emission m_Emission; //Field offset: 0x10
		internal Initial m_Initial; //Field offset: 0x28
		internal Shape m_Shape; //Field offset: 0x68
		internal Force m_Force; //Field offset: 0xC4
		internal Collision m_Collision; //Field offset: 0x104
		internal Noise m_Noise; //Field offset: 0x144
		internal Lights m_Lights; //Field offset: 0x148
		internal Trail m_Trail; //Field offset: 0x15C

	}

	internal struct RotationBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct RotationOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ShapeModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct SubEmittersModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SubEmittersModule(ParticleSystem particleSystem) { }

	}

	internal struct TextureSheetAnimationModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TextureSheetAnimationModule(ParticleSystem particleSystem) { }

	}

	internal struct TrailModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TrailModule(ParticleSystem particleSystem) { }

	}

	[NativeType]
	internal struct Trails
	{
		internal List<Vector4> positions; //Field offset: 0x0
		internal List<Int32> frontPositions; //Field offset: 0x8
		internal List<Int32> backPositions; //Field offset: 0x10
		internal List<Int32> positionCounts; //Field offset: 0x18
		internal int maxTrailCount; //Field offset: 0x20
		internal int maxPositionsPerTrailCount; //Field offset: 0x24

	}

	internal struct TriggerModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TriggerModule(ParticleSystem particleSystem) { }

	}

	internal struct VelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float zMultiplier
		{
			 set { } //Length: 67
		}

		internal VelocityOverLifetimeModule(ParticleSystem particleSystem) { }

		public void set_zMultiplier(float value) { }

		private static void set_zMultiplier_Injected(ref VelocityOverLifetimeModule _unity_self, float value) { }

	}


	[Obsolete]
	public bool automaticCullingEnabled
	{
		 get { } //Length: 51
	}

	public CollisionModule collision
	{
		 get { } //Length: 32
	}

	public ColorBySpeedModule colorBySpeed
	{
		 get { } //Length: 32
	}

	public ColorOverLifetimeModule colorOverLifetime
	{
		 get { } //Length: 32
	}

	public CustomDataModule customData
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public float duration
	{
		 get { } //Length: 75
	}

	public EmissionModule emission
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public float emissionRate
	{
		 get { } //Length: 75
		 set { } //Length: 207
	}

	[Obsolete]
	public bool enableEmission
	{
		 get { } //Length: 75
		 set { } //Length: 84
	}

	public ExternalForcesModule externalForces
	{
		 get { } //Length: 32
	}

	public ForceOverLifetimeModule forceOverLifetime
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public float gravityModifier
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	public InheritVelocityModule inheritVelocity
	{
		 get { } //Length: 32
	}

	public bool isEmitting
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public bool isPaused
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public bool isPlaying
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public bool isStopped
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public LightsModule lights
	{
		 get { } //Length: 32
	}

	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public bool loop
	{
		 get { } //Length: 75
		 set { } //Length: 84
	}

	public MainModule main
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public int maxParticles
	{
		 get { } //Length: 75
		 set { } //Length: 82
	}

	public NoiseModule noise
	{
		 get { } //Length: 32
	}

	public int particleCount
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	[Obsolete]
	public float playbackSpeed
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	[Obsolete]
	public bool playOnAwake
	{
		 get { } //Length: 75
		 set { } //Length: 84
	}

	public bool proceduralSimulationSupported
	{
		 get { } //Length: 51
	}

	public uint randomSeed
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 64
	}

	public RotationBySpeedModule rotationBySpeed
	{
		 get { } //Length: 32
	}

	public RotationOverLifetimeModule rotationOverLifetime
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public ParticleSystemScalingMode scalingMode
	{
		 get { } //Length: 75
		 set { } //Length: 82
	}

	public ShapeModule shape
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public ParticleSystemSimulationSpace simulationSpace
	{
		 get { } //Length: 75
		 set { } //Length: 82
	}

	public SizeBySpeedModule sizeBySpeed
	{
		 get { } //Length: 32
	}

	public SizeOverLifetimeModule sizeOverLifetime
	{
		 get { } //Length: 32
	}

	[Obsolete]
	public Color startColor
	{
		 get { } //Length: 125
		 set { } //Length: 226
	}

	[Obsolete]
	public float startDelay
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	[Obsolete]
	public float startLifetime
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	[Obsolete]
	public float startRotation
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	[Obsolete]
	public Vector3 startRotation3D
	{
		 get { } //Length: 314
		 set { } //Length: 197
	}

	[Obsolete]
	public float startSize
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	[Obsolete]
	public float startSpeed
	{
		 get { } //Length: 75
		 set { } //Length: 91
	}

	public SubEmittersModule subEmitters
	{
		 get { } //Length: 32
	}

	public TextureSheetAnimationModule textureSheetAnimation
	{
		 get { } //Length: 32
	}

	public float time
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 67
	}

	public TrailModule trails
	{
		 get { } //Length: 32
	}

	public TriggerModule trigger
	{
		 get { } //Length: 32
	}

	public bool useAutoRandomSeed
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 66
	}

	public VelocityOverLifetimeModule velocityOverLifetime
	{
		 get { } //Length: 32
	}

	public ParticleSystem() { }

	[FreeFunction]
	public void Clear(bool withChildren) { }

	public void Clear() { }

	[ThreadSafe]
	internal static void CopyManagedJobData(Void* systemPtr, out NativeParticleData particleData) { }

	[RequiredByNativeCode]
	public void Emit(int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void Emit(EmitParams emitParams, int count) { }

	[Obsolete]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete]
	public void Emit(Particle particle) { }

	private void Emit_Injected(ref EmitParams emitParams, int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void Emit_Internal(int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void EmitOld_Internal(ref Particle particle) { }

	public bool get_automaticCullingEnabled() { }

	public CollisionModule get_collision() { }

	public ColorBySpeedModule get_colorBySpeed() { }

	public ColorOverLifetimeModule get_colorOverLifetime() { }

	public CustomDataModule get_customData() { }

	public float get_duration() { }

	public EmissionModule get_emission() { }

	public float get_emissionRate() { }

	public bool get_enableEmission() { }

	public ExternalForcesModule get_externalForces() { }

	public ForceOverLifetimeModule get_forceOverLifetime() { }

	public float get_gravityModifier() { }

	public InheritVelocityModule get_inheritVelocity() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_isEmitting() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_isPaused() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_isPlaying() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_isStopped() { }

	public LightsModule get_lights() { }

	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	public bool get_loop() { }

	public MainModule get_main() { }

	public int get_maxParticles() { }

	public NoiseModule get_noise() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_particleCount() { }

	public float get_playbackSpeed() { }

	public bool get_playOnAwake() { }

	public bool get_proceduralSimulationSupported() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public uint get_randomSeed() { }

	public RotationBySpeedModule get_rotationBySpeed() { }

	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	public ParticleSystemScalingMode get_scalingMode() { }

	public ShapeModule get_shape() { }

	public ParticleSystemSimulationSpace get_simulationSpace() { }

	public SizeBySpeedModule get_sizeBySpeed() { }

	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	public Color get_startColor() { }

	public float get_startDelay() { }

	public float get_startLifetime() { }

	public float get_startRotation() { }

	public Vector3 get_startRotation3D() { }

	public float get_startSize() { }

	public float get_startSpeed() { }

	public SubEmittersModule get_subEmitters() { }

	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float get_time() { }

	public TrailModule get_trails() { }

	public TriggerModule get_trigger() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_useAutoRandomSeed() { }

	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	[FreeFunction]
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	internal Void* GetManagedJobData() { }

	internal JobHandle GetManagedJobHandle() { }

	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	[FreeFunction]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) { }

	[FreeFunction]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	[FreeFunction]
	internal Vector3 GetParticleCurrentSize3D(ref Particle particle) { }

	private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret) { }

	[FreeFunction]
	internal int GetParticleMeshIndex(ref Particle particle) { }

	public int GetParticles(out Particle[] particles, int size) { }

	[FreeFunction]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	public int GetParticles(out Particle[] particles) { }

	public int GetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public int GetParticles(out NativeArray<Particle> particles, int size) { }

	public int GetParticles(out NativeArray<Particle> particles) { }

	[FreeFunction]
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	public PlaybackState GetPlaybackState() { }

	private void GetPlaybackState_Injected(out PlaybackState ret) { }

	[FreeFunction]
	private void GetTrailDataInternal(ref Trails trailData) { }

	public Trails GetTrails() { }

	[FreeFunction]
	public bool IsAlive(bool withChildren) { }

	public bool IsAlive() { }

	[FreeFunction]
	public void Pause(bool withChildren) { }

	public void Pause() { }

	[FreeFunction]
	public void Play(bool withChildren) { }

	public void Play() { }

	[FreeFunction]
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunction]
	internal static JobHandle ScheduleManagedJob(ref JobScheduleParameters parameters, Void* additionalData) { }

	private static void ScheduleManagedJob_Injected(ref JobScheduleParameters parameters, Void* additionalData, out JobHandle ret) { }

	public void set_emissionRate(float value) { }

	public void set_enableEmission(bool value) { }

	public void set_gravityModifier(float value) { }

	public void set_loop(bool value) { }

	public void set_maxParticles(int value) { }

	public void set_playbackSpeed(float value) { }

	public void set_playOnAwake(bool value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_randomSeed(uint value) { }

	public void set_scalingMode(ParticleSystemScalingMode value) { }

	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	public void set_startColor(Color value) { }

	public void set_startDelay(float value) { }

	public void set_startLifetime(float value) { }

	public void set_startRotation(float value) { }

	public void set_startRotation3D(Vector3 value) { }

	public void set_startSize(float value) { }

	public void set_startSpeed(float value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_time(float value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunction]
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	internal void SetManagedJobHandle(JobHandle handle) { }

	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	[FreeFunction]
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	public void SetParticles(out NativeArray<Particle> particles, int size) { }

	public void SetParticles(out Particle[] particles) { }

	[FreeFunction]
	public void SetParticles(out Particle[] particles, int size, int offset) { }

	public void SetParticles(out Particle[] particles, int size) { }

	public void SetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public void SetParticles(out NativeArray<Particle> particles) { }

	[FreeFunction]
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	public void SetPlaybackState(PlaybackState playbackState) { }

	private void SetPlaybackState_Injected(ref PlaybackState playbackState) { }

	[FreeFunction]
	public void SetTrails(Trails trailData) { }

	private void SetTrails_Injected(ref Trails trailData) { }

	public void Simulate(float t) { }

	public void Simulate(float t, bool withChildren) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	[FreeFunction]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Stop() { }

	[FreeFunction]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop(bool withChildren) { }

	[FreeFunction]
	public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) { }

	public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) { }

	public void TriggerSubEmitter(int subEmitterIndex) { }

	[FreeFunction]
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) { }

	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle) { }

}

