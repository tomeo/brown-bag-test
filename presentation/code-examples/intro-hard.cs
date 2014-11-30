public int CountPagesByCategory(string categoryName) {
	var repo = ServiceLocator
		.Current.GetInstance<IContentRepository>();

	var category = Category.Find(categoryName);
	if (category == null) return 0;

	return repo.Get<PageData>(PageReference.StartPage)
		.Where(p => p.Category
			.Contains(c => c.Id == category.Id)).Count();
}