public class ExampleService {
	private IPageService _pageService;
	private IContentRepository _repository;
	private ICategoryService _categoryService;

	public PageService(
		IPageService pageService,
		IContentRepository repository,
		ICategoryService categoryService) {
		_pageService = pageService;
		_repository = repository;
		_categoryService = categoryService;
	}

	public int CountPagesByCategory(int categoryId) {
		var category = _categoryService.Find(categoryId);
		return _repository.Get<PageData>
			(_pageService.GetStartPage())
			.Where(p => p.Category)
				.Contains(c => c.Id == category.Id)).Count();
	}
}