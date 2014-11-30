public int CountPagesByCategory(int categoryId){
	var repo = ServiceLocator
		.Current.GetInstance<IContentRepository>();

	var category = Category.Find(categoryId);
	
	return repo.Get<PageData>(PageReference.StartPage)
		.Where(p => p.Category
			.Contains(c => c.Id == category.Id)).Count();
}