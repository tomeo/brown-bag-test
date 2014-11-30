[TestFixture]
public class CountPagesByCategoryTests {
	private ExampleService _target;
	private IPageService _pageService;
	private IContentRepository _repository;
	private ICategoryService _categoryService;

	[SetUp]
	public void Init() {
		_pageService = Substitute.For<IPageService>();
		_repository = Substitute.For<IContentRepository>();
		_categoryService = Substitute.For<ICategoryService>();
		_target = new ExampleService(
			_pageService,
			_repository,
			_categoryService);
	}

	// Tests
}