public class StructureMapConfiguration
{
	public static void Configure(
		IContainer container)
	{
		container.Configure(x =>
		{
			x.For<IService>().Use<Service>();
		});
	}
}