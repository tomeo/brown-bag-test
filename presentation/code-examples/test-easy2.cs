[TestCase(3, 4, 7)]
[TestCase(12, -11, 1)]
[TestCase(1000, 501, 499)]
public void ShouldReturnTheSumOfParameters(
	int a,
	int b,
	int expected) {
	Assert.AreEqual(expected, _target.Add(a, b));
}