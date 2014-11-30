public class Adder {
	public int Add(int a, int b) {
		return a + b;
	}
}

[TestFixture]
public class AddTests {
	private Adder _target;

	[SetUp]
	public void Init() {
		_target = new Adder();
	}

	[Test]
	public void ShouldReturnTheSumOfParameters(){
		Assert.AreEqual(7, _target.Add(3, 4));
		Assert.AreEqual(1, _target.Add(12, -11));
		Assert.AreEqual(1000, _target.Add(501, 499));
	}
}