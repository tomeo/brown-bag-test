public class ExampleService {
	private IPageService _pageService;
	private IContentRepository _repository;
	private ICategoryService _categoryService;

	public ExampleService(
		IPageService pageService,
		IContentRepository repository,
		ICategoryService categoryService) {
		_pageService = pageService;
		_repository = repository;
		_categoryService = categoryService;
	}

	public int CountPagesByCategory(string categoryName) {
		var category = _categoryService.Find(categoryName);
		if (category == null) return 0;
		
		return _repository.Get<PageData>
			(_pageService.GetStartPage())
			.Where(p => p.Category)
				.Contains(c => c.Id == category.Id)).Count();
	}
}