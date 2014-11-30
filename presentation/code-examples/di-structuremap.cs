public class StructureMapConfiguration {
	public static void Configure(IContainer container) {
		container.Configure(x =>
		{
			x.For<IService>().Use<Service>();
			x.For<IOtherService>().Use<OtherService>();
			x.For<IDifferentService>().Use<DifferentService>();
		});
	}
}