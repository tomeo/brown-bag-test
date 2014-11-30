[Test]
public void ShouldReturnZeroWhenNoPagesWithCategory() {
	// Arrange
	var currentCategory = Substitute.For<Category>();
	_categoryService.Find(Arg.Any<int>).Returns(category);
	var startPage = Substitute.For<PageData>();
	_pageService.GetStartPage().Returns(startPage);
	_repository.Get<PageData>(Arg.Any<ContentReference>)
		.Returns(Enumerable.Empty<PageData>());

	// Act
	var result = _target.CountPagesByCategory(1);

	// Assert
	Assert.AreEqual(0, result);
	_categoryService.Recieved(1).Find(Arg.Any<int>);
	_pageService.Recieved(1).GetStartPage();
	_repository.Recieved(1)
		.Get<PageData>(Arg.Any<ContentReference>);
}