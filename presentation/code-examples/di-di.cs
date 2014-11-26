public class ServiceUser {
	private IService _service;

	public ServiceUser(IService service) {
		_service = service;
	}

	public int SomeMethod(int p) {
		if (p == 0) {
			return _service.OtherMethod(p);
		}
		return _service.DifferentMethod(p);
	}
}