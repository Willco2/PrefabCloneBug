using Sandbox;

public sealed class PrefabDebug : Component
{

	[Property] public ModelRenderer ModelRenderer { get; set; }

	protected override void OnStart()
	{
		Log.Info($"{GameObject.Name} started with {ModelRenderer.GetHashCode()}");
	}
}
