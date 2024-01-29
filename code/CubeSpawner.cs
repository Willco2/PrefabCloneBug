using Sandbox;

public sealed class CubeSpawner : Component
{

	[Property] public GameObject CubePrefab { get; set; }

	protected override void OnEnabled()
	{
		var red = CubePrefab.Clone( new Vector3( 100, 0, 25 ) ).Components.Get<ModelRenderer>();
		var blue = CubePrefab.Clone( new Vector3( -100, 0, 25 ) ).Components.Get<ModelRenderer>();

		Log.Info( $"{red.GameObject.Name} cloned with {red.GetHashCode()}" );
		Log.Info( $"{blue.GameObject.Name} cloned with {blue.GetHashCode()}" );

		red.Tint = Color.Red;
		blue.Tint = Color.Blue;
	}

}
